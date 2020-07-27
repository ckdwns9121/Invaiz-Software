using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Invaiz_Studio.Util
{
    class OverlayControl
    {

        public System.Timers.Timer tm2; // 오버레이 타이머
        private MainForm mn;
        private View.GroupOverlayForm groupOv = new View.GroupOverlayForm();
        private View.PayloadOverlayForm payloadOv = new View.PayloadOverlayForm();
        
        public OverlayControl()
        {
            initTimer();
        }
        public void test()
        {
            Console.WriteLine("test");
        }
        public void closeOverlay()
        {
            Console.WriteLine("끄기");
            this.groupOv.Visible = false;
            this.payloadOv.Visible = false;
        }
        public void initTimer()
        {
            tm2 = new System.Timers.Timer();
            tm2.Interval = Properties.Settings.Default.OL_SECOND * 1000;
            tm2.Enabled = false;
            tm2.Elapsed += new ElapsedEventHandler(popupControl);
            Console.WriteLine(Properties.Settings.Default.OL_SECOND + "초 로 초기화");
        }
        public void GroupOverlay(int number)
        {
            if (!Properties.Settings.Default.OL_CHECK) return;

            mn = MainForm.getInstance;

            this.payloadOv.Visible = (this.payloadOv.Visible == true) ? false : false;

            Task.Factory.StartNew((Action)(() =>
            {
                this.groupOv.init(number);
           
                this.groupOv.Visible=true;
                this.groupOv.TopMost = true;
                if (!this.groupOv.Visible)
                    return;
                this.tm2.Enabled = false;
                this.tm2.Enabled = true;

            }));
        }


        public void PayloadOverlay(bool deviceCheck, int group , int number)
        {
            if (!Properties.Settings.Default.OL_CHECK) return;
            mn = MainForm.getInstance;

            this.groupOv.Visible = (this.groupOv.Visible == true) ? false : false;
            Task.Factory.StartNew((Action)(() =>
            {

                if (number != -1)
                {
                    this.payloadOv.init(deviceCheck, number,group);
                }
                else if(number== -1)
                {
                    this.payloadOv.init(group);
                }

                this.payloadOv.Visible = true;
                this.payloadOv.TopMost = true;

                if (!this.payloadOv.Visible)
                    return;
                this.tm2.Enabled = false;
                this.tm2.Enabled = true;

            }));
        }

        public void PayloadOverlay(bool deviceCheck, int group, int number,string str)
        {
            if (!Properties.Settings.Default.OL_CHECK) return;

            mn = MainForm.getInstance;

            if (str.Equals("succeeded") || str.Equals("failed") || str.Equals("CEP Responce") || str.Contains("Error") || str.Contains("NaN") || str.Contains("error") || str.Contains("undefined")) 
            {
                
                str = (deviceCheck) ? mn.Payloads[group].E_formName[number] : mn.Payloads[group].B_formName[number];
            }

            this.groupOv.Visible = (this.groupOv.Visible == true) ? false : false;


            Task.Factory.StartNew((Action)(() =>
            {

                this.payloadOv.init(deviceCheck,number,group,str);
                this.payloadOv.Visible = true;
                this.payloadOv.TopMost = true;

                if (!this.payloadOv.Visible)
                    return;
                this.tm2.Enabled = false;
                this.tm2.Enabled = true;

            }));
        }

        private void popupControl(object sender, EventArgs e)
        {
            if (!Properties.Settings.Default.OL_SHOW)
            {
                try
                {
                    this.groupOv.Visible = false;
                    this.payloadOv.Visible = false;
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
