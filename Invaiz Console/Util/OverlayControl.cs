using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Invaiz_Console.Util
{
    class OverlayControl
    {

        public System.Timers.Timer tm2; // 오버레이 타이머
        private MainForm mn;
        private View.GroupChangeOverlayForm groupOv = new View.GroupChangeOverlayForm();
        private View.PayloadOverlayForm payloadOv = new View.PayloadOverlayForm();
        
        public OverlayControl()
        {
            initTimer();
        }
        public void test()
        {
            Console.WriteLine("test");
        }
        private void initTimer()
        {
            tm2 = new System.Timers.Timer();
            tm2.Interval = 2000;
            tm2.Enabled = false;
            tm2.Elapsed += new ElapsedEventHandler(popupControl);
        }
        public void GroupOverlay(int number)
        {
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
            try
            {
                this.groupOv.Visible = false;
                this.payloadOv.Visible=false;
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}
