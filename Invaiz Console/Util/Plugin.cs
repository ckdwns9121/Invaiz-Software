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

namespace Invaiz_Console.Util
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
            // Console.WriteLine("플러그인 생성");
            //Extract("InvaizApp", cepFolderPath(), "Resources", "com.invaiz.extension.zip");
            //   ExtractZipByIO(cepFolderPath() + "\\com.invaiz.extension.zip", cepFolderPath());
            //    Console.WriteLine("플러그인 파일 생성완료");
            oc = new OverlayControl();

        }
      
        [DllImport("user32.dll")]
        static extern void keybd_event(byte vk, byte scan, int flags, int extrainfo);

        private const int KEYDOWN = 0x00;
        private const int KEYUP = 0x02;

        private const int CONTROLKEY= 162;
        private const int SHIFTKEY=160;
        private const int ALTKEY=164;


        private string keystring = "";
        protected void sendKeycode(int multi, int keycode, int group, int number, bool device)
        {

            switch (multi)
            {
                case 1: //단일키
                    singleKey(keycode);
                    break;
                case 2: //컨트롤
                    ctrlKey(keycode);
                    break;
                case 3: //컨트롤 쉬프트
                    ctrlShiftKey(keycode);
                    break;
                case 4: //알트
                    altKey(keycode);
                    break;
                case 5: // 쉬프트
                    shiftKey(keycode);
                    break;
                case 6://컨트롤 알트
                    ctrlAltKey(keycode);
                    break;
                case 7://컨트롤 쉬프트 알트
                    ctrlShiftAltKey(keycode);
                    break;
                case 8://쉬프트 알트
                    ShiftAltKey(keycode);
                    break;
                default:
                    break;
            }

            if (device)
            {
                oc.PayloadOverlay(true, group, number);
            }
            else
            {
                oc.PayloadOverlay(false, group, number);
            }
        }

        Util.ImportWinapi s = new Util.ImportWinapi();


        #region 키보드 데이터 전송
        private void ctrlKey(int keycode)
        {
            s.SendKeyDown(CONTROLKEY, true);
            s.Send(keycode, true);
            s.SendKeyUp(CONTROLKEY, true);

        }

        private void ShiftAltKey(int keycode)
        {
            s.SendKeyDown(SHIFTKEY, true);
            s.SendKeyDown(ALTKEY, true);
            s.Send(keycode, true);
            s.SendKeyUp(ALTKEY, true);
            s.SendKeyUp(SHIFTKEY, true);
        }

        private void ctrlShiftKey(int keycode)
        {

            s.SendKeyDown(CONTROLKEY, true);
            s.SendKeyDown(SHIFTKEY, true);
            s.Send(keycode, true);
            s.SendKeyUp(SHIFTKEY, true);
            s.SendKeyUp(CONTROLKEY, true);

        }

        private void ctrlAltKey(int keycode)
        {

            s.SendKeyDown(CONTROLKEY, true);
            s.SendKeyDown(ALTKEY, true);
            s.Send(keycode, true);
            s.SendKeyUp(ALTKEY, true);
            s.SendKeyUp(CONTROLKEY, true);
        }

        private void ctrlShiftAltKey(int keycode)
        {
            s.SendKeyDown(CONTROLKEY, true);
            s.SendKeyDown(SHIFTKEY, true);
            s.SendKeyDown(ALTKEY, true);
            s.Send(keycode, true);
            s.SendKeyUp(ALTKEY, true);
            s.SendKeyUp(SHIFTKEY, true);
            s.SendKeyUp(CONTROLKEY, true);
        }
        private void altKey(int keycode)
        {
            s.SendKeyDown(ALTKEY, true);
            s.Send(keycode, true);
            s.SendKeyUp(ALTKEY, true);
        }
        private void shiftKey(int keycode)
        { 
            s.SendKeyDown(SHIFTKEY, true);
            s.Send(keycode, true);
            s.SendKeyUp(SHIFTKEY, true);
        }

        private void singleKey(int keycode)
        {
            s.Send(keycode, false);
        }
        #endregion
        #region CEP 파일 생성
        protected string cepFolderPath()
        {
            string s = Environment.ExpandEnvironmentVariables("%ProgramFiles(x86)%");
            string path = Path.Combine(s, "Common Files", "Adobe", "CEP", "extensions");
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
            return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "InvaizApp", "Port", appName);
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
                    httpClient.Timeout = new TimeSpan(0, 0, 0, 5);
                    JsonObjectCollection userData = new JsonObjectCollection();
                    userData.Add(new JsonStringValue("messageType", messageType));
                    userData.Add(new JsonStringValue("actionType", actionType));
                    userData.Add(new JsonStringValue("typeKey", typeKey));
                    userData.Add(new JsonStringValue("request", payload));
                    Console.WriteLine("messageType " + messageType);
                    Console.WriteLine("actionType " + actionType);
                    Console.WriteLine("typeKey " + typeKey);
                    Console.WriteLine("request " + payload);

                    string script = userData.ToString();
                    var buffer = Encoding.UTF8.GetBytes(script);
                    var byteContent = new ByteArrayContent(buffer);
                    var response = await httpClient.PostAsync(serverUrl + portNumber, byteContent).ConfigureAwait(false);
                    string result = await response.Content.ReadAsStringAsync();

                    if (response.StatusCode == HttpStatusCode.OK)
                    {
                        Console.WriteLine("CEP Response " + result);
                        if (device)
                        {
                            oc.PayloadOverlay(true, group, number, result);
                        }
                        else
                        {
                            oc.PayloadOverlay(false, group, number, result);
                        }
                    }

                }
                catch (Exception e)
                {
                    if (device)
                    {
                        oc.PayloadOverlay(true, group, number);
                    }
                    else
                    {
                        oc.PayloadOverlay(false, group, number);
                    }
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
