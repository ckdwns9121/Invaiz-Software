using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Json;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Invaiz_Console.Util
{
    class PluginConnect :Plugin
    {

        public PluginConnect()
        {

        }

        private string excuteType;
        private string messageType;
        private string actionType;
        private string typeKey;
        private MainForm mn;
        private int keycode1;
        private int multi1;

        private int group, number;
        Util.ImportWinapi importWinapi = new ImportWinapi();

        /**
        * rotateExcuteType => 1.sendKey 2. sendScript
        * @ param Data.EncoderValue encoder . 실행 타입을 구별하고 실행 값을 뽑을 엔코더 객체
        * @ param int index . 돌리기 번호
        * @ param string direction 방향 타입
        * @ exception 예외사항
        */
        public void EncoderData(DeviceData.Payload payload, int group, int number, string direction, int s, string appName)
        {

            this.excuteType = payload.E_excuteType[number];

            if (this.excuteType.Equals("") || String.IsNullOrEmpty(this.excuteType))
            {
                nullOverlay(group, number, true);
                return;
            }
            this.messageType = payload.E_messageType[number];
            this.actionType = payload.E_actionType[number];
            this.typeKey = payload.E_typeKey[number];

            int dir = Int32.Parse(direction);
            int speed = s / 10;

            this.keycode1 = (dir == 2) ? payload.E_leftKeyCode[number] : payload.E_rightKeyCode[number];
            this.multi1 = (dir == 2) ? payload.E_leftisMulti[number] : payload.E_rightisMulti[number];
            speed = (dir == 2) ? (speed * -1) : (speed * 1);

            Type t = this.GetType();
            MethodInfo method = t.GetMethod(this.excuteType, BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);

            if (method != null)
            {
                method.Invoke(this, new object[] {
                    messageType, actionType, typeKey,speed.ToString(),
                    keycode1,multi1,appName,group,number,true
                }); ;
            }
        }

        /**
        * pressExcuteType => 1.sendKey 2. sendScript
        * @ param Data.EncoderValue encoder . 실행 타입을 구별하고 실행 값을 뽑을 엔코더 객체
        * @ exception 예외사항
        */

        public void ButtonData(DeviceData.Payload payload, int group, int number, string appName)
        {
            this.excuteType = payload.B_excuteType[number]; //sendKey, sendScript -> 함수이름.
            if (this.excuteType.Equals("") || String.IsNullOrEmpty(this.excuteType) ==true)
            {
                nullOverlay(group, number, false);
                return;
            }
            this.messageType = payload.B_messageType[number];
            this.actionType = payload.B_actionType[number];
            this.typeKey = payload.B_typeKey[number];
            this.keycode1 = payload.B_keyCode[number];
            this.multi1 = payload.B_isMulti[number];

            Type t = this.GetType();
            System.Reflection.MethodInfo method = t.GetMethod(this.excuteType, BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
            if (method != null)
            {
                method.Invoke(this, new object[] {
                    messageType, actionType, typeKey,null,
                    keycode1,multi1,appName,group,number,false
                });

            }
        }


        #region 나중에확인
        /**
        * pressExcuteType => 1.sendKey 2. sendScript
        * @ param Data.EncoderValue encoder . 실행 타입을 구별하고 실행 값을 뽑을 엔코더 객체 (비동기)
        * @ exception 예외사항 -
        */

        public void sendScript3(string messageType, string actionType, string typeKey, string payload, int rotateKeyCode, int rotateMulti)
        {
            using (HttpClient httpClient = new HttpClient())
            {

                //httpClient.Timeout = new TimeSpan(0, 0, 0, 5);

                string PORT_NUMBER = "";  //@ todo 프로세스 교체시 포트넘버 갱신.
                JsonObjectCollection userData = new JsonObjectCollection();
                userData.Add(new JsonStringValue("messageType", messageType));
                userData.Add(new JsonStringValue("actionType", actionType));
                userData.Add(new JsonStringValue("typeKey", typeKey));
                userData.Add(new JsonStringValue("payload", payload));

                Console.WriteLine("messageType " + messageType);
                Console.WriteLine("actionType " + actionType);
                Console.WriteLine("payload " + payload);

                string script = userData.ToString();

                try
                {
                    string result = httpClient.PostAsync("http://localhost:4000", (HttpContent)new StringContent(script)).Result.Content.ReadAsStringAsync().Result;
                    Console.WriteLine("CEP Response " + result);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        // 동기.
        public void sendScript2(string messageType, string actionType, string typeKey, string payload, int rotateKeyCode, int rotateMulti)
        {
            try
            {
                string url = "http://localhost:4000";
                JsonObjectCollection userData = new JsonObjectCollection();
                userData.Add(new JsonStringValue("messageType", messageType));
                userData.Add(new JsonStringValue("actionType", actionType));
                userData.Add(new JsonStringValue("typeKey", typeKey));
                userData.Add(new JsonStringValue("request", payload));

                string postData = userData.ToString();
                HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
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
                    string temp = strResult.ToString();
                    webResponse.Close();
                    streamReader.Close();
                    responseStream.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        #endregion

        protected void sendScript(string messageType, string actionType, string typeKey, string payload, int KeyCode, int Multi, string appName, int group, int number, bool device)
        {
            sendCepScript(messageType, actionType, typeKey, payload, appName, group, number, device);
        }
        protected void sendKey(string messageType, string actionType, string typeKey, string payload, int KeyCode, int Multi, string appName, int group, int number, bool device)
        {
            sendKeycode(Multi, KeyCode, group, number, device);
        }
        protected void nullOverlay(int group, int number, bool deviceCheck)
        {
            (deviceCheck ? new Action(() => oc.PayloadOverlay(true, group, number)) : () => oc.PayloadOverlay(false, group, number))();
        }
    }
}
 