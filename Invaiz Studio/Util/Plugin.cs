using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Json;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Invaiz_Studio.Util
{
    class Plugin
    {

        protected OverlayControl oc;

        public OverlayControl overlay
        {
            set { this.oc = value; }
            get { return this.oc; }
        }

        public Plugin()
        {
             Console.WriteLine("데이터 폴더경로 확인" + cepFolderPath2());
            //  Extract("InvaizApp", cepFolderPath(), "Resources", "com.invaiz.extension.zip");
            //ExtractZipByIO(cepFolderPath() + "\\com.invaiz.extension.zip", cepFolderPath());
            //  Console.WriteLine("플러그인 파일 생성완료");             
            oc = new OverlayControl();

        }
      
        [DllImport("user32.dll")]
        static extern void keybd_event(byte vk, byte scan, int flags, int extrainfo);

        private const int KEYDOWN = 0x00;
        private const int KEYUP = 0x02;

        private const int CONTROLKEY= 162;
        private const int SHIFTKEY=160;
        private const int ALTKEY=164;
        private const int LWIN = 91;



        protected void sendKeycode(int multi, int keycode, int group, int number, bool device)
        {
            bool extendCheck = isExtendKey(keycode);
            switch (multi)
            {
                case 1: //단일키
                    PressKey(keycode, extendCheck);
                    break;
                case 2: //컨트롤
                    PressCtrlKey(keycode, extendCheck);
                    break;
                case 3: //컨트롤 쉬프트
                    PressCtrlShiftKey(keycode, extendCheck);
                    break;
                case 4: //알트
                    PressAltKey(keycode, extendCheck);
                    break;
                case 5: // 쉬프트
                    PressShiftKey(keycode, extendCheck);
                    break;
                case 6://컨트롤 알트
                    PressCtrlAltKey(keycode, extendCheck);
                    break;
                case 7://컨트롤 쉬프트 알트
                    PressCtrlShiftKAltKey(keycode, extendCheck);
                    break;
                case 8://쉬프트 알트
                    PressShiftAltKey(keycode, extendCheck);
                    break;
                case 9:
                    MouseWheel(keycode ,true);
                    break;
                case 10:
                    MouseWheel(keycode, false);
                    break;
                default:
                    break;
            }
            (device ? new Action(() => oc.PayloadOverlay(true, group, number)) : () => oc.PayloadOverlay(false, group, number))();
        }

        private bool isExtendKey(int keycode)
        {
            bool check = false;
            switch (keycode)
            {
                case 33: //PU
                    check = true;
                    break;
                case 34: //PD
                    check = true;
                    break; 
                case 35: // END
                    check = true;
                    break;
                case 36: // HOME
                    check = true;
                    break;
                case 37: // LEFT
                    check = true;
                    break;
                case 38: // UP
                    check = true;
                    break;
                case 39: // RIGHT
                    check = true;
                    break;
                case 40: // DOWN
                    check = true;
                    break;
                case 45: //INSERT
                    check = true;
                    break;
                case 46: // DELETE
                    check = true;
                    break;
                default:
                    check = false;
                    break;
            }

            return check;
        }

        Util.ImportWinapi s = new Util.ImportWinapi();
         
        #region 키보드 데이터 전송
        private void PressCtrlKey(int keycode ,bool isExtend)
        {
            s.SendKeyDown(CONTROLKEY, false);
            s.Send(keycode, isExtend);
            s.SendKeyUp(CONTROLKEY, false);

        }
        private void PressShiftAltKey(int keycode, bool isExtend)
        {
            s.SendKeyDown(SHIFTKEY, false);
            s.SendKeyDown(ALTKEY, false);
            s.Send(keycode, isExtend);
            s.SendKeyUp(ALTKEY, false);
            s.SendKeyUp(SHIFTKEY, false);
        }

        private void PressCtrlShiftKey(int keycode, bool isExtend)
        {

            s.SendKeyDown(CONTROLKEY, false);
            s.SendKeyDown(SHIFTKEY, false);
            s.Send(keycode, isExtend);
            s.SendKeyUp(SHIFTKEY, false);
            s.SendKeyUp(CONTROLKEY, false);

        }

        private void PressCtrlAltKey(int keycode, bool isExtend)
        {

            s.SendKeyDown(CONTROLKEY, false);
            s.SendKeyDown(ALTKEY, false);
            s.Send(keycode, isExtend);
            s.SendKeyUp(ALTKEY, false);
            s.SendKeyUp(CONTROLKEY, false);
        }

        private void PressCtrlShiftKAltKey(int keycode, bool isExtend)
        {
            s.SendKeyDown(CONTROLKEY, false);
            s.SendKeyDown(SHIFTKEY, false);
            s.SendKeyDown(ALTKEY, false);
            s.Send(keycode, isExtend);
            s.SendKeyUp(ALTKEY, false);
            s.SendKeyUp(SHIFTKEY, false);
            s.SendKeyUp(CONTROLKEY, false);
        }
        private void PressAltKey(int keycode, bool isExtend)
        {
            s.SendKeyDown(ALTKEY, false);
            s.Send(keycode, isExtend);
            s.SendKeyUp(ALTKEY, false);
        }
        private void PressShiftKey(int keycode, bool isExtend)
        { 
            s.SendKeyDown(SHIFTKEY, false);
            s.Send(keycode, isExtend);
            s.SendKeyUp(SHIFTKEY, false);
        }
        private void PressKey(int keycode, bool isExtend)
        {
            s.Send(keycode, isExtend);
        }

        private void MouseWheel(int direction, bool check)
        {
            s.mouseWheel( direction *60 , check);
        }
        #endregion
        #region CEP 파일 생성
        protected string cepFolderPath()
        {
            string s = Environment.ExpandEnvironmentVariables("%ProgramFiles(x86)%");
            string path = Path.Combine(s, "Common Files", "Adobe", "CEP", "extensions");
            return path;
        }

        protected string cepFolderPath2()
        {
            string strFolder = Environment.GetFolderPath(System.Environment.SpecialFolder.LocalApplicationData);
            //string s = Environment.ExpandEnvironmentVariables("%ProgramFiles(x86)%");
            string path = Path.Combine(strFolder,"Invaiz Studio", "preset");
            return path;
        }


        private static void Extract(string nameSpace, string outDir, string internalFilePath, string resourceName)
        {
            Assembly assembly = Assembly.GetCallingAssembly();
            using (Stream s = assembly.GetManifestResourceStream(nameSpace + "." + (internalFilePath == "" ? "" : internalFilePath + ".") + resourceName))
            {
                using (BinaryReader r = new BinaryReader(s))
                {
                    using (FileStream fs = new FileStream(outDir + "\\" + resourceName, FileMode.OpenOrCreate))
                    {
                        using (BinaryWriter w = new BinaryWriter(fs))
                        {
                            w.Write(r.ReadBytes((int)s.Length));
                        }
                    }
                }
            }
        }

        protected static void ExtractZipByIO(string zipPath, string destinationPath)
        {
            try
            {
                if (!Directory.Exists(destinationPath))
                {
                    Directory.CreateDirectory(destinationPath);
                }
                using (ZipArchive zip = System.IO.Compression.ZipFile.OpenRead(zipPath))
                {
                    foreach (ZipArchiveEntry entry in zip.Entries)
                    {
                        var filepath = Path.Combine(destinationPath, entry.FullName);
                        var subDir = Path.GetDirectoryName(filepath);
                        if (!Directory.Exists(subDir))
                        {
                            Directory.CreateDirectory(subDir);
                        }
                        entry.ExtractToFile(filepath);
                    }
                }
            }
            catch (Exception ex)
            {
                return;
            }
        }
        #endregion
        #region CEP GET PORT
        protected string GetPluginDataDirectory(string appName)
        {
            return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Invaiz Studio", "Port", appName);
        }
        protected string getPortNumber(string appName)
        {
            string _cepServerPortFilePath = Path.Combine(this.GetPluginDataDirectory(appName), "cep_port.dll");
            string value = System.IO.File.ReadAllText(_cepServerPortFilePath);
            Console.WriteLine(value);
            return value;
        }
        #endregion
        #region CEP SEND 함수
        //비동기
        protected async Task sendCepScript(string messageType, string actionType, string typeKey, string payload, string appName, int group, int number, bool device)
        {

            using (HttpClient httpClient = new HttpClient())
            {
                try
                {
                    httpClient.Timeout = new TimeSpan(0, 0, 0, 5);
                    string serverUrl = "http://localhost:";
                    string portNumber = getPortNumber(appName);
                    Console.WriteLine("포트번호" + portNumber);
                    httpClient.Timeout = new TimeSpan(0, 0, 0, 5);
                    JsonObjectCollection userData = new JsonObjectCollection();
                    userData.Add(new JsonStringValue("messageType", messageType));
                    userData.Add(new JsonStringValue("actionType", actionType));
                    userData.Add(new JsonStringValue("typeKey", typeKey));
                    userData.Add(new JsonStringValue("payload", payload));

                    Console.WriteLine("messageType " + messageType);
                    Console.WriteLine("actionType " + actionType);
                    Console.WriteLine("typeKey " + typeKey);
                    Console.WriteLine("payload " + payload);

                    string script = userData.ToString();
                    var buffer = Encoding.UTF8.GetBytes(script);
                    var byteContent = new ByteArrayContent(buffer);
                    var response = await httpClient.PostAsync(serverUrl + portNumber, byteContent).ConfigureAwait(false);
                    string result = await response.Content.ReadAsStringAsync();

                    if (response.StatusCode == HttpStatusCode.OK)
                    {
                        Console.WriteLine("리턴값 나옴?" + result);
                        (device ? new Action(() => oc.PayloadOverlay(true, group, number,result)) : () => oc.PayloadOverlay(false, group, number,result))();
                    }

                }
                catch (Exception e)
                {
                    (device ? new Action(() => oc.PayloadOverlay(true, group, number)) : () => oc.PayloadOverlay(false, group, number))();
                    Console.WriteLine(e.Message);
                }

            }

        }

        protected void sendCepScript2(string messageType, string actionType, string typeKey, string payload, string appName, int group, int number, bool device)
        {
            try
            {
                string serverUrl = "http://localhost:";
                string portNumber = getPortNumber(appName);
                JsonObjectCollection userData = new JsonObjectCollection();
                userData.Add(new JsonStringValue("messageType", messageType));
                userData.Add(new JsonStringValue("actionType", actionType));
                userData.Add(new JsonStringValue("typeKey", typeKey));
                userData.Add(new JsonStringValue("request", payload));

                string postData = userData.ToString();
                HttpWebRequest req = (HttpWebRequest)WebRequest.Create(serverUrl + portNumber);
                byte[] sendData = Encoding.ASCII.GetBytes(postData);


                Console.WriteLine("messageType " + messageType);
                Console.WriteLine("actionType " + actionType);
                Console.WriteLine("typeKey " + typeKey);
                Console.WriteLine("request " + payload);

                req.Method = "POST";
                req.KeepAlive = true;


                using (Stream stream = req.GetRequestStream())
                {
                    stream.Write(sendData, 0, sendData.Length);
                    stream.Close();
                }

                HttpWebResponse webResponse = (HttpWebResponse)req.GetResponse();

                if (webResponse.StatusCode == HttpStatusCode.OK)
                {
                    Stream responseStream = webResponse.GetResponseStream();
                    StreamReader streamReader = new StreamReader(responseStream, Encoding.UTF8);
                    string strResult = streamReader.ReadToEnd();
                    Console.WriteLine("뭐냐?" + strResult);
             
                    webResponse.Close();
                    streamReader.Close();
                    responseStream.Close();

                    Console.WriteLine("CEP Response " + strResult);
                    if (device)
                    {
                        oc.PayloadOverlay(true, group, number, strResult);
                    }
                    else
                    {
                        oc.PayloadOverlay(false, group, number, strResult);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                if (device)
                {
                    oc.PayloadOverlay(true, group, number);
                }
                else
                {
                    oc.PayloadOverlay(false, group, number);
                }
            }
        }
        #endregion
    }
}
