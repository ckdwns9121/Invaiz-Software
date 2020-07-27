using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invaiz_Studio.Util
{
    public class MainRender
    {

     
        private MainForm mn;

        public void initUI()
        {
            try
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
            catch(Exception ex)
            {
                return;
            }
        }

        public void updateUI()
        {
            try
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

                for (int group = 0; group < 4; group++)
                {
                    groups[group].GroupName = mn.Payloads[group].groupName;
                    for (int index = 0; index < 4; index++)
                    {
                        float currentSize = (getFormNameLength(mn.Payloads[group].E_formName[index])) ? 10.0F : 12.5F;

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
            catch(Exception ex)
            {
                return;
            }
        }
        public bool getFormNameLength(string str)
        {
            try
            {
                return (str.Length > 10) ? true : false;
            }
            catch (Exception ex) {
                return false;
            }
        }

        public void settingUI(int group, int index, bool deviceCheck)
        {
            try
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


                    float currentSize = (getFormNameLength(mn.Payloads[group].E_formName[index])) ? 10.0F : 12.5F;
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
            catch(Exception ex)
            {
                return;
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
            string str = temp;
            int t = temp.IndexOf(" ");
            int l = temp.Length;

            str = (t != -1 && l > 5) ? str.Replace(" ", "") : temp;
            return str = (t != -1 && l > 5) ? str.Insert(t, Environment.NewLine) : temp;
        }

        private Image[] appImage = {
            Invaiz_Studio.Properties.Resources.iconwin,
            Invaiz_Studio.Properties.Resources.iconps,
            Invaiz_Studio.Properties.Resources.iconai,
            Invaiz_Studio.Properties.Resources.iconae,
            Invaiz_Studio.Properties.Resources.iconpr,
            Invaiz_Studio.Properties.Resources.iconlr,
            Invaiz_Studio.Properties.Resources.iconid
        };

        public void resetImage(string processName)
        {
            mn = MainForm.getInstance;
            switch (processName)
            {
                case "Window":
                    mn.appBox.AppIconImage = appImage[0];
                    break;
                case "Photoshop":
                    mn.appBox.AppIconImage = appImage[1];
                    break;
                case "Illustrator":
                    mn.appBox.AppIconImage = appImage[2];
                    break;
                case "AfterEffect":
                    mn.appBox.AppIconImage = appImage[3];
                    break;
                case "PremierePro":
                    mn.appBox.AppIconImage = appImage[4];
                    break;
                case "Lightroom":
                    mn.appBox.AppIconImage = appImage[5];
                    break;
                case "InDesign":
                    mn.appBox.AppIconImage = appImage[6];
                    break;
                case "ClipStudio":
                    mn.appBox.AppIconImage = null;
                    break;
                default:
                    mn.appBox.AppIconImage = appImage[0];
                    break;
            }
        }


        public void ProcessChangeReRender(string processName)
        {
            mn = MainForm.getInstance;
            if (processName.Equals("Window") && mn.windowCheck)
            {
                Console.WriteLine("윈도우고 체크 활성이니 리턴");
                return;
            }

            mn = MainForm.getInstance;
            mn.preset.savePreset(mn.PresetPath, mn.AppName, mn.PresetName);
            mn.AppName = processName;
            mn.startThread();
  
        }
    }
}
