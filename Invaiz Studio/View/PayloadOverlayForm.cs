using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Invaiz_Studio.View
{
    public partial class PayloadOverlayForm : Form
    {

        private MainForm mn;
        public const int WS_EX_TRANSPARENT = 0x00000020;
        public const int GWL_EXSTYLE = (-20);

        [DllImport("user32.dll")]
        public static extern int GetWindowLong(IntPtr hwnd, int index);

        [DllImport("user32.dll")]
        public static extern int SetWindowLong(IntPtr hwnd, int index, int newStyle);

        public PayloadOverlayForm()
        {
            InitializeComponent();
            int initStyle = GetWindowLong(this.Handle, -20);
            SetWindowLong(this.Handle, -20, initStyle | 0x80000 | 0x20);
            this.TopMost = true;
            this.Opacity = 0.8;
        }
        public void ResetLocation()
        {
            int screenIndex = getScreenIndex();
            int temp_x = Screen.AllScreens[screenIndex].Bounds.X + (Screen.AllScreens[screenIndex].Bounds.Width / 2);
            int temp_y = Screen.AllScreens[screenIndex].Bounds.Y + Screen.AllScreens[screenIndex].Bounds.Height;


            int screen_x = Screen.AllScreens[screenIndex].Bounds.X;
            int screen_y = Screen.AllScreens[screenIndex].Bounds.Y;
            int screen_width = Screen.AllScreens[screenIndex].Bounds.Width;
            int screen_height = Screen.AllScreens[screenIndex].Bounds.Height;


            switch (Properties.Settings.Default.OL_LOCATION)
            {
                case 0:
                    this.Location = new Point(screen_x, screen_y); //1
                    break;
                case 1:
                    this.Location = new Point(screen_x + (screen_width / 2) - this.Size.Width / 2, screen_y); //2
                    break;
                case 2:
                    this.Location = new Point(screen_x + screen_width - this.Width, screen_y); //3
                    break;
                case 3:
                    this.Location = new Point(screen_x, (screen_y + screen_height) / 2 - this.Size.Height / 2); //4

                    break;
                case 4:
                    this.Location = new Point((screen_x + (screen_width / 2)) - this.Size.Width / 2, (screen_y + screen_height) / 2 - this.Size.Height / 2); //5

                    break;
                case 5:
                    this.Location = new Point(screen_x + screen_width - this.Width, screen_y + screen_height / 2 - this.Size.Height / 2); //6

                    break;
                case 6:
                    this.Location = new Point(screen_x, screen_y + screen_height - this.Size.Height - 70); //7

                    break;
                case 7:
                    this.Location = new Point(screen_x + (screen_width / 2) - this.Size.Width / 2, screen_y + screen_height - this.Size.Height - 70); //8

                    break;
                case 8:
                    this.Location = new Point(screen_x + screen_width - this.Width, screen_y + screen_height - this.Size.Height - 70); //9
                    break;
                default:
                    this.Location = new Point(screen_x + (screen_width / 2) - this.Size.Width / 2, screen_y + screen_height - this.Size.Height - 70); //8
                    break;

            }

            //   this.Location = new Point(screen_x, screen_y) ; //1 
            //  this.Location = new Point(screen_x+ (screen_width/2) - this.Size.Width / 2, screen_y); //2
            // this.Location = new Point(screen_x+screen_width - this.Width , screen_y); //3
            // this.Location = new Point(screen_x, (screen_y+screen_height) / 2 - this.Size.Height / 2); //4
            //  this.Location = new Point((screen_x+(screen_width/2)) - this.Size.Width / 2, (screen_y+screen_height)/2 - this.Size.Height/2); //5
            //this.Location = new Point(screen_x+screen_width - this.Width , screen_y+screen_height/2 - this.Size.Height/2); //6

            // this.Location = new Point(screen_x, screen_y+screen_height - this.Size.Height - 70); //7
            // this.Location = new Point(screen_x + (screen_width / 2) - this.Size.Width / 2 , screen_y+screen_height - this.Size.Height - 70); //8
            //   this.Location = new Point(screen_x + screen_width - this.Width, screen_y+screen_height - this.Size.Height - 70); //9





        }

        //그룹 변경됬을 시 전체 키맵핑 보여주기 위한 오버레이
        public void init(int group)
        {
            ResetLocation();
            firstInit(group);
        }

        // 이벤트 발생 시 CEP 리턴값이 없는 경우 설정한 이름 보여주는 오버레이
        public void init(bool deviceCheck, int index, int group)
        {
            ResetLocation();

            firstInit(group, index, deviceCheck);
        }
        public void init(bool deviceCheck, int index, int group, string str)
        {
            ResetLocation();
            firstInit(group, index, str, deviceCheck);
        }

        private Util.MainRender render = new Util.MainRender();
        // 그룹 변경시 그룹핑된 값 보여주는 오버레이
        public void firstInit(int group)
        {
            mn = MainForm.getInstance;
            Component.DeviceButton[] deviceButtons = { deviceButton1, deviceButton2, deviceButton3, deviceButton4 };
            Component.DeviceEncoder[] deviceEncoders = { deviceEncoder1, deviceEncoder2, deviceEncoder3, deviceEncoder4 };
            Component.Device.DeviceGroupButton deviceGroupButton = deviceGroupButton1;
            deviceGroupButton1.GroupNumber = "Group" + (group + 1).ToString();

            for (int i = 0; i < deviceButtons.Length; i++)
            {
                deviceButtons[i].BackgroundImage = deviceButtons[i].NomalImage;
                deviceButtons[i].form_name.ForeColor = deviceButtons[i].NomalColor;
                deviceButtons[i].form_name.Text = String.IsNullOrEmpty(mn.Payloads[group].B_formName[i]) ? "" : render.newLineText(mn.Payloads[group].B_formName[i]);

                deviceEncoders[i].BackgroundImage = deviceEncoders[i].NomalImage;

                float currentSize = 12.0F;
                deviceEncoders[i].form_name.Font = new Font(deviceEncoders[i].form_name.Font.Name, currentSize, deviceEncoders[i].form_name.Font.Style, deviceEncoders[i].form_name.Font.Unit);
                deviceEncoders[i].form_name.ForeColor = deviceEncoders[i].NomalColor;
                deviceEncoders[i].form_name.Text = String.IsNullOrEmpty(mn.Payloads[group].E_formName[i]) ? "" : render.newLineText(mn.Payloads[group].E_formName[i]);

            }

        }

        // 리턴값 없을 시

        public void firstInit(int group, int index, bool deviceCheck)
        {
            mn = MainForm.getInstance;
            Component.DeviceButton[] deviceButtons = { deviceButton1, deviceButton2, deviceButton3, deviceButton4 };
            Component.DeviceEncoder[] deviceEncoders = { deviceEncoder1, deviceEncoder2, deviceEncoder3, deviceEncoder4 };
            deviceGroupButton1.GroupNumber = "Group" + (group + 1).ToString();


            for (int i = 0; i < deviceButtons.Length; i++)
            {

                deviceButtons[i].BackgroundImage = deviceButtons[i].NomalImage;
                deviceButtons[i].form_name.ForeColor = deviceButtons[i].NomalColor;
                deviceButtons[i].form_name.Text = String.IsNullOrEmpty(mn.Payloads[group].B_formName[i]) ? "" : render.newLineText(mn.Payloads[group].B_formName[i]);
                deviceEncoders[i].BackgroundImage = deviceEncoders[i].NomalImage;

                float currentSize = 12.0F;
                deviceEncoders[i].form_name.Font = new Font(deviceEncoders[i].form_name.Font.Name, currentSize, deviceEncoders[i].form_name.Font.Style, deviceEncoders[i].form_name.Font.Unit);
                deviceEncoders[i].form_name.ForeColor = deviceEncoders[i].NomalColor;
                deviceEncoders[i].form_name.Text = String.IsNullOrEmpty(mn.Payloads[group].E_formName[i]) ? "" : render.newLineText(mn.Payloads[group].E_formName[i]);

            }


            if (deviceCheck)
            {
                deviceEncoders[index].BackgroundImage = deviceEncoders[index].HoverImage;
                deviceEncoders[index].form_name.ForeColor = deviceEncoders[index].HoverColor;
                deviceEncoders[index].form_name.Text = String.IsNullOrEmpty(mn.Payloads[group].E_formName[index]) ? "" : render.newLineText(mn.Payloads[group].E_formName[index]);
            }
            else
            {
                deviceButtons[index].BackgroundImage = deviceButtons[index].HoverImage;
                deviceButtons[index].form_name.ForeColor = deviceButtons[index].HoverColor;
            }

        }


        // 리턴값 있을시 오버레이
        public void firstInit(int group, int index, string str, bool deviceCheck)
        {
            mn = MainForm.getInstance;


            Component.DeviceButton[] deviceButtons = { deviceButton1, deviceButton2, deviceButton3, deviceButton4 };
            Component.DeviceEncoder[] deviceEncoders = { deviceEncoder1, deviceEncoder2, deviceEncoder3, deviceEncoder4 };

            deviceGroupButton1.GroupNumber = "Group" + (group + 1).ToString();

            for (int i = 0; i < deviceButtons.Length; i++)
            {

                deviceButtons[i].BackgroundImage = deviceButtons[i].NomalImage;
                deviceButtons[i].form_name.ForeColor = deviceButtons[i].NomalColor;
                deviceButtons[i].form_name.Text = String.IsNullOrEmpty(mn.Payloads[group].B_formName[i]) ? "" : render.newLineText(mn.Payloads[group].B_formName[i]);
                deviceEncoders[i].BackgroundImage = deviceEncoders[i].NomalImage;

                if (index == i && deviceCheck) continue;
                else
                {
                    float currentSize = 12.0F;
                    deviceEncoders[i].form_name.Font = new Font(deviceEncoders[i].form_name.Font.Name, currentSize, deviceEncoders[i].form_name.Font.Style, deviceEncoders[i].form_name.Font.Unit);
                    deviceEncoders[i].form_name.ForeColor = deviceEncoders[i].NomalColor;
                    deviceEncoders[i].form_name.Text = String.IsNullOrEmpty(mn.Payloads[group].E_formName[i]) ? "" : render.newLineText(mn.Payloads[group].E_formName[i]);
                }

            }

            if (deviceCheck)
            {
                deviceEncoders[index].BackgroundImage = deviceEncoders[index].HoverImage;
                deviceEncoders[index].form_name.ForeColor = deviceEncoders[index].HoverColor;

                if (!str.Equals(mn.Payloads[group].E_formName[index]))
                {
                    Console.WriteLine("오버레이" + str);
                    float currentSize;
                    currentSize = 20.0F;
                    deviceEncoders[index].form_name.Font = new Font(deviceEncoders[index].form_name.Font.Name, currentSize,
                         deviceEncoders[index].form_name.Font.Style, deviceEncoders[index].form_name.Font.Unit);
                    deviceEncoders[index].form_name.Text = str;
                }
                else
                {
                    float currentSize;
                    currentSize = 12.0F;
                    deviceEncoders[index].form_name.Font = new Font(deviceEncoders[index].form_name.Font.Name, currentSize,
                         deviceEncoders[index].form_name.Font.Style, deviceEncoders[index].form_name.Font.Unit);
                    deviceEncoders[index].form_name.Text = render.newLineText(str);
                }
            }
            else
            {
                deviceButtons[index].BackgroundImage = deviceButtons[index].HoverImage;
                deviceButtons[index].form_name.ForeColor = deviceButtons[index].HoverColor;
            }

        }

        private void panel2_MouseEnter(object sender, EventArgs e)
        {
            // Console.WriteLine("마우스다운");
        }
        private int getScreenIndex()
        {
            int screenIndex = 0;
            for (int i = 0; i < System.Windows.Forms.Screen.AllScreens.Length; i++)
            {
                int cursorPointx = Cursor.Position.X;
                int cursorPointy = Cursor.Position.Y;

                int startX = System.Windows.Forms.Screen.AllScreens[i].Bounds.X;
                int endX = startX + System.Windows.Forms.Screen.AllScreens[i].Bounds.Width;

                int startY = System.Windows.Forms.Screen.AllScreens[i].Bounds.Y;
                int endY = startY + System.Windows.Forms.Screen.AllScreens[i].Bounds.Height;
                if ((startX < cursorPointx && endX > cursorPointx) && (startY < cursorPointy && endY > cursorPointy))
                {
                    //Console.WriteLine("디바이스 네임" + System.Windows.Forms.Screen.AllScreens[i].DeviceName);
                    //Console.WriteLine("인덱스" + i);
                    //Console.WriteLine(System.Windows.Forms.Screen.AllScreens[i].Bounds);
                    screenIndex = i;
                }
            }
            return screenIndex;

        }
    }
}
