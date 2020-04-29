using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invaiz_Console.Util
{
    public class Render
    {
        private MainForm mn;
        public void initUI()
        {
            mn = MainForm.getInstance;
            Component.DeviceGroup[] groups =
            {
                mn.deviceGroup1,mn.deviceGroup2,mn.deviceGroup3,mn.deviceGroup4
            };

            Component.DeviceButton[,] buttons =
            {
                {mn.deviceButton1,mn.deviceButton2,mn.deviceButton3,mn.deviceButton4},
                {mn.deviceButton5,mn.deviceButton6,mn.deviceButton7,mn.deviceButton8},
                {mn.deviceButton9,mn.deviceButton10,mn.deviceButton11,mn.deviceButton12},
                {mn.deviceButton13,mn.deviceButton14,mn.deviceButton15,mn.deviceButton16}
            };
            Component.DeviceEncoder[,] encoder =
             {
                {mn.deviceEncoder1,mn.deviceEncoder2,mn.deviceEncoder3,mn.deviceEncoder4},
                {mn.deviceEncoder5,mn.deviceEncoder6,mn.deviceEncoder7,mn.deviceEncoder8},
                {mn.deviceEncoder9,mn.deviceEncoder10,mn.deviceEncoder11,mn.deviceEncoder12},
                {mn.deviceEncoder13,mn.deviceEncoder14,mn.deviceEncoder15,mn.deviceEncoder16}
            };
            for (int i = 0; i < groups.Length; i++)
            {
                groups[i].init();
            }
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    buttons[i, j].init();
                    encoder[i, j].init();
                }
            }
        }

        public void updateUI()
        {
            mn = MainForm.getInstance;
            Component.DeviceGroup[] groups =
            {
                mn.deviceGroup1, mn.deviceGroup2,mn.deviceGroup3,mn.deviceGroup4
            };
            Component.DeviceButton[,] buttons =
             {
                {mn.deviceButton1,mn.deviceButton2,mn.deviceButton3,mn.deviceButton4},
                {mn.deviceButton5,mn.deviceButton6,mn.deviceButton7,mn.deviceButton8},
                {mn.deviceButton9,mn.deviceButton10,mn.deviceButton11,mn.deviceButton12},
                {mn.deviceButton13,mn.deviceButton14,mn.deviceButton15,mn.deviceButton16}
            };
            Component.DeviceEncoder[,] encoders =
             {
                {mn.deviceEncoder1,mn.deviceEncoder2,mn.deviceEncoder3,mn.deviceEncoder4},
                {mn.deviceEncoder5,mn.deviceEncoder6,mn.deviceEncoder7,mn.deviceEncoder8},
                {mn.deviceEncoder9,mn.deviceEncoder10,mn.deviceEncoder11,mn.deviceEncoder12},
                {mn.deviceEncoder13,mn.deviceEncoder14,mn.deviceEncoder15,mn.deviceEncoder16}
            };

            for(int group=0 ; group < 4; group++)
            {
                groups[group].GroupName = mn.Payloads[group].groupName;
                for(int index=0; index < 4; index++)
                {
                    float currentSize = (getFormNameLength(mn.Payloads[group].E_formName[index])) ? 8.0F : 12.5F;

                    encoders[group, index].form_name.Font = new System.Drawing.Font(encoders[group, index].form_name.Font.Name, currentSize,
                    encoders[group, index].form_name.Font.Style, encoders[group, index].form_name.Font.Unit);
                    encoders[group, index].FormName = newLineText(mn.Payloads[group].E_formName[index]);

                    buttons[group, index].FormName = newLineText(mn.Payloads[group].B_formName[index]);
                    buttons[group, index].SubName = mn.Payloads[group].B_subName[index];
                    encoders[group, index].LeftSubName = mn.Payloads[group].E_leftSubName[index];
                    encoders[group, index].RightSubName = mn.Payloads[group].E_rightSubName[index];
                }
            }
        }
        public bool getFormNameLength(string str)
        {
            return (str.Length > 10) ? true : false;
        }

        public void settingUI(int group, int index, bool deviceCheck)
        {
            mn = MainForm.getInstance;
            Component.DeviceButton[,] buttons =
             {
                {mn.deviceButton1,mn.deviceButton2,mn.deviceButton3,mn.deviceButton4},
                {mn.deviceButton5,mn.deviceButton6,mn.deviceButton7,mn.deviceButton8},
                {mn.deviceButton9,mn.deviceButton10,mn.deviceButton11,mn.deviceButton12},
                {mn.deviceButton13,mn.deviceButton14,mn.deviceButton15,mn.deviceButton16}
            };
            Component.DeviceEncoder[,] encoders =
             {
                {mn.deviceEncoder1,mn.deviceEncoder2,mn.deviceEncoder3,mn.deviceEncoder4},
                {mn.deviceEncoder5,mn.deviceEncoder6,mn.deviceEncoder7,mn.deviceEncoder8},
                {mn.deviceEncoder9,mn.deviceEncoder10,mn.deviceEncoder11,mn.deviceEncoder12},
                {mn.deviceEncoder13,mn.deviceEncoder14,mn.deviceEncoder15,mn.deviceEncoder16}
            };

            if (deviceCheck)
            {


                float currentSize = (getFormNameLength(mn.Payloads[group].E_formName[index])) ? 8.0F : 12.5F;
                encoders[group, index].form_name.Font = new System.Drawing.Font(encoders[group, index].form_name.Font.Name, currentSize,
                encoders[group, index].form_name.Font.Style, encoders[group, index].form_name.Font.Unit);
                encoders[group, index].FormName = newLineText(mn.Payloads[group].E_formName[index]);

                encoders[group, index].LeftSubName = mn.Payloads[group].E_leftSubName[index];
                encoders[group, index].RightSubName = mn.Payloads[group].E_rightSubName[index];

            }
            else
            {
                buttons[group, index].FormName = newLineText(mn.Payloads[group].B_formName[index]);
                buttons[group, index].SubName = mn.Payloads[group].B_subName[index];

            }
        }
        public void listValueInit()
        {
            mn = MainForm.getInstance;
            mn.customScrollbar1.Value = 0;
            mn.deviceList.AutoScrollPosition = new System.Drawing.Point(0, 0);

        }

        public void closeList()
        {
            mn = MainForm.getInstance;
            mn.presetList.Height = 0;
            mn.presetIsShow = false;
            mn.appList.Height = 0;
            mn.appListShow = false;

        }

        public string newLineText(string temp)
        {
            string str= temp;
            int t = temp.IndexOf(" ");
            int l =temp.Length;

            str = (t != -1 && l > 6) ? str.Replace(" ", "") : temp;
            return str = (t != -1 && l > 6) ? str.Insert(t, Environment.NewLine) : temp;
        }
    }
}
