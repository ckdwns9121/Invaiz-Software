using System;
using System.Threading;
using System.Xml;

namespace Invaiz_Console.Util
{
    public class Preset
    {
        private MainForm mn;
        public void getPresetFiles()
        {

            try
            {

                mn = MainForm.getInstance;
                string presetPath = mn.PresetPath + mn.AppName + @"\";

                //폴더 존재 유무 확인후 없을시 생성.
                System.IO.DirectoryInfo di = new System.IO.DirectoryInfo(presetPath);
                if (!di.Exists)
                {
                    di.Create();
                }
                bool fileExists = false;
                mn.presetList.list.Controls.Clear();
                //프로세스 폴더내에 있는 모든 프리셋 들고오기
                foreach (System.IO.FileInfo File in di.GetFiles())
                {
                    if (File.Extension.ToLower().CompareTo(".xml") == 0)
                    {
                        String FileNameOnly = File.Name.Substring(0, File.Name.Length - 4);
                        String FullFileName = File.FullName;
                        Component.PresetItem presetItems = new Component.PresetItem();
                        presetItems.PresetName = FileNameOnly;
                        mn.PresetName = FileNameOnly;
                        mn.presetList.list.Controls.Add(presetItems);
                        fileExists = true;
                        Console.WriteLine("프리셋 이름 : " + FileNameOnly);

                    }
                }

                if (!fileExists)
                {
                    mn.PresetName = "기본값";
                }
                else
                {
                    Console.WriteLine("세팅 시작");
                    this.settingPreset();
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
          
        }

        //가져온 프리셋 값을 데이터에 바인딩
        public void settingPreset()
        {
            try
            {
                mn = MainForm.getInstance;
                Thread.Sleep(100);
                DeviceData.Payload[] payloads = new DeviceData.Payload[4];
                for (int i = 0; i < 4; i++)
                {
                    payloads[i] = new DeviceData.Payload();
                }
                string presetPath = mn.PresetPath + mn.AppName + @"\" + mn.PresetName + ".xml";

                int groupIndex = 0;
                int encoderIndex = 0;
                int buttonIndex = 0;
                using (XmlReader reader = XmlReader.Create(presetPath))
                {
                    while (reader.Read())
                    {
                        // Only detect start elements.
                        if (reader.IsStartElement())
                        {
                            // Get element name and switch on it.
                            switch (reader.Name)
                            {
                                case "preset":
                                    string Name = reader["name"];
                                    break;
                                case "group":
                                    string gnum = reader["gnum"];
                                    string gname = reader["gname"];
                                    if (gnum != "")
                                    {
                                        groupIndex = Int32.Parse(gnum) - 1;
                                        payloads[groupIndex].groupName = gname; //그룹이름 세팅
                                    }
                                    break;

                                case "encoder":
                                    string encoder_number = reader["enum"];
                                    string encoder_excuteType = reader["excuteType"];
                                    string encoder_messageType = reader["messageType"];
                                    string encoder_actionType = reader["actionType"];
                                    string encoder_typeKey = reader["typeKey"];
                                    string encoder_formName = reader["formName"];
                                    string encoder_Left_Keycode = reader["Lkeycode"];
                                    string encoder_Right_Keycode = reader["Rkeycode"];
                                    string encoder_Left_Multi = reader["Lmulti"];
                                    string encoder_Right_Multi = reader["Rmulti"];
                                    string encoder_Left_SubName = reader["LsubName"];
                                    string encoder_Right_SubName = reader["RsubName"];

                                    if (encoder_messageType != "" && encoder_actionType != "")
                                    {
                                        encoderIndex = Int32.Parse(encoder_number) - 1;
                                        payloads[groupIndex].E_excuteType[encoderIndex] = encoder_excuteType;
                                        payloads[groupIndex].E_messageType[encoderIndex] = encoder_messageType;
                                        payloads[groupIndex].E_actionType[encoderIndex] = encoder_actionType;
                                        payloads[groupIndex].E_typeKey[encoderIndex] = encoder_typeKey;
                                        payloads[groupIndex].E_formName[encoderIndex] = encoder_formName;
                                    }
                                    else if (encoder_Left_Keycode != "" && encoder_Right_Keycode != "" && encoder_Left_Multi != "" && encoder_Right_Multi != "")
                                    {

                                        encoderIndex = Int32.Parse(encoder_number) - 1;
                                        int encoder_Lkeycode = Int32.Parse(encoder_Left_Keycode);
                                        int encoder_Lmulti = Int32.Parse(encoder_Left_Multi);
                                        int encoder_Rkeycode = Int32.Parse(encoder_Right_Keycode);
                                        int encoder_Rmulti = Int32.Parse(encoder_Right_Multi);

                                        payloads[groupIndex].E_excuteType[encoderIndex] = encoder_excuteType;
                                        payloads[groupIndex].E_formName[encoderIndex] = encoder_formName;
                                        payloads[groupIndex].E_leftKeyCode[encoderIndex] = encoder_Lkeycode;
                                        payloads[groupIndex].E_rightKeyCode[encoderIndex] = encoder_Rkeycode;
                                        payloads[groupIndex].E_leftisMulti[encoderIndex] = encoder_Lmulti;
                                        payloads[groupIndex].E_rightisMulti[encoderIndex] = encoder_Rmulti;
                                        payloads[groupIndex].E_leftSubName[encoderIndex] = encoder_Left_SubName;
                                        payloads[groupIndex].E_rightSubName[encoderIndex] = encoder_Right_SubName;

                                    }
                                    break;
                                case "button":
                                    string button_number = reader["bnum"];
                                    string button_excuteType = reader["excuteType"];
                                    string button_messageType = reader["messageType"];
                                    string button_actionType = reader["actionType"];
                                    string button_typeKey = reader["typeKey"];
                                    string button_formName = reader["formName"];
                                    string button_subName = reader["subName"];
                                    string button_keycode = reader["keycode"];
                                    string button_multi = reader["multi"];
                                    if (button_number != "")
                                    {
                                        buttonIndex = Int32.Parse(button_number) - 1;
                                        payloads[groupIndex].B_excuteType[buttonIndex] = button_excuteType;
                                        payloads[groupIndex].B_messageType[buttonIndex] = button_messageType;
                                        payloads[groupIndex].B_actionType[buttonIndex] = button_actionType;
                                        payloads[groupIndex].B_typeKey[buttonIndex] = button_typeKey;
                                        payloads[groupIndex].B_formName[buttonIndex] = button_formName;
                                        payloads[groupIndex].B_subName[buttonIndex] = button_subName;

                                        payloads[groupIndex].B_keyCode[buttonIndex] = Int32.Parse(button_keycode);
                                        payloads[groupIndex].B_isMulti[buttonIndex] = Int32.Parse(button_multi);
                                    }
                                    break;
                            }
                        }
                    }
                }
                mn.Payloads = payloads;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        //프리셋 저장
        public void savePreset(string path, string appName, string presetName )
        {
            mn = MainForm.getInstance;
            path += appName + @"\" + presetName +".xml";
            try
            {
                using (XmlWriter wr = XmlWriter.Create(path))
                {
                    wr.WriteStartDocument(); //</Photoshop>
                    wr.WriteStartElement(appName);
                    wr.WriteStartElement("preset"); //<preset name = "test">
                    wr.WriteAttributeString("name", presetName);  // attribute 쓰기
                    for (int groupIndex = 0; groupIndex < 4; groupIndex++)
                    {
                        string gnum = (groupIndex + 1).ToString();
                        wr.WriteStartElement("group");
                        wr.WriteAttributeString("gnum", gnum);
                        wr.WriteAttributeString("gname", mn.Payloads[groupIndex].groupName);

                        for (int encoderIndex = 0; encoderIndex < 4; encoderIndex++)
                        {
                            wr.WriteStartElement("encoder");
                            wr.WriteAttributeString("enum", (encoderIndex+1).ToString());
                            wr.WriteAttributeString("excuteType", mn.Payloads[groupIndex].E_excuteType[encoderIndex]);
                            wr.WriteAttributeString("messageType", mn.Payloads[groupIndex].E_messageType[encoderIndex]);
                            wr.WriteAttributeString("actionType", mn.Payloads[groupIndex].E_actionType[encoderIndex]);
                            wr.WriteAttributeString("typeKey", mn.Payloads[groupIndex].E_typeKey[encoderIndex]);
                            wr.WriteAttributeString("formName", mn.Payloads[groupIndex].E_formName[encoderIndex]);
                            wr.WriteAttributeString("LsubName", mn.Payloads[groupIndex].E_leftSubName[encoderIndex]);
                            wr.WriteAttributeString("RsubName", mn.Payloads[groupIndex].E_rightSubName[encoderIndex]);
                            wr.WriteAttributeString("Lkeycode", mn.Payloads[groupIndex].E_leftKeyCode[encoderIndex].ToString());
                            wr.WriteAttributeString("Rkeycode", mn.Payloads[groupIndex].E_rightKeyCode[encoderIndex].ToString());
                            wr.WriteAttributeString("Lmulti", mn.Payloads[groupIndex].E_leftisMulti[encoderIndex].ToString());
                            wr.WriteAttributeString("Rmulti", mn.Payloads[groupIndex].E_rightisMulti[encoderIndex].ToString());

                            wr.WriteEndElement(); //</encoder>
                        }
                        for (int button_Index = 0; button_Index < 4; button_Index++)
                        {
                            wr.WriteStartElement("button");
                            wr.WriteAttributeString("bnum", (button_Index + 1).ToString());
                            wr.WriteAttributeString("excuteType", mn.Payloads[groupIndex].B_excuteType[button_Index]);
                            wr.WriteAttributeString("messageType", mn.Payloads[groupIndex].B_messageType[button_Index]);
                            wr.WriteAttributeString("actionType", mn.Payloads[groupIndex].B_actionType[button_Index]);
                            wr.WriteAttributeString("typeKey", mn.Payloads[groupIndex].B_typeKey[button_Index]);
                            wr.WriteAttributeString("formName", mn.Payloads[groupIndex].B_formName[button_Index]);
                            wr.WriteAttributeString("subName", mn.Payloads[groupIndex].B_subName[button_Index]);
                            wr.WriteAttributeString("keycode", mn.Payloads[groupIndex].B_keyCode[button_Index].ToString());
                            wr.WriteAttributeString("multi", mn.Payloads[groupIndex].B_isMulti[button_Index].ToString());
         
                            wr.WriteEndElement(); //</button>
                        }
                        wr.WriteEndElement(); //</group>
                    }

                    wr.WriteEndElement(); //</preset>
                    wr.WriteEndDocument(); // </Photoshop>
                }
            }
            catch (Exception ex)
            {
                   System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        public void deletePreset( string presetName)
        {
            mn = MainForm.getInstance;
            string path = mn.PresetPath + mn.AppName + @"\";
            presetName += ".xml";
            System.IO.DirectoryInfo di = new System.IO.DirectoryInfo(path);
            foreach (System.IO.FileInfo File in di.GetFiles(presetName))
            {
                File.Delete();
            }
        }
    }
}
