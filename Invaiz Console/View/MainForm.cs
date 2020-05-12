using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Invaiz_Console
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            for (int i = 0; i < payloads.Length; i++)
            {
                payloads[i] = new DeviceData.Payload();
            }
            this.customScrollbar1.Minimum = 0;
            this.customScrollbar1.Maximum = this.deviceList.DisplayRectangle.Height * 2;
            this.customScrollbar1.LargeChange = customScrollbar1.Maximum / customScrollbar1.Height + this.deviceList.Height;
            this.customScrollbar1.SmallChange = 15;
            this.customScrollbar1.Value = Math.Abs(this.deviceList.AutoScrollPosition.Y);
        }


        #region dropshadow
        private const int CS_DropShaodw = 0x00020000;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle = CS_DropShaodw;
                return cp;
            }
        }
        #endregion

        #region value
        private static MainForm instance;
        private DeviceData.Payload[] payloads = new DeviceData.Payload[4];
        private string APP_NAME;
        private string PRESET_NAME;
        private const string DATA_PATH = @".\data\";
        private const string PRESET_PATH = @".\preset\";
        #endregion

        #region Properties
        public static MainForm getInstance
        {
            get { return instance; }
        }


        public DeviceData.Payload[] Payloads
        {
            get { return this.payloads; }
            set { this.payloads = value; }
        }

        public string AppName
        {
            get { return this.APP_NAME; }
            set
            {
                this.APP_NAME = value;
                this.appBox.AppName = value;
            }
        }
        public string PresetName
        {
            get { return this.PRESET_NAME; }
            set
            {
                this.PRESET_NAME = value;
                this.presetBox.PresetName = value;
            }
        }
        public string PresetPath
        {
            get { return PRESET_PATH; }
        }
        public string DataPath
        {
            get { return DATA_PATH; }
        }

        #endregion

        #region 폼 로딩, 최소화 및 종료

        private void MainForm_Load(object sender, EventArgs e)
        {

 
            instance = this;

            AppName = this.appBox.AppName;
            PresetName = this.presetBox.PresetName;
            Util.Preset preset = new Util.Preset();
            preset.getPresetFiles();
            preset.settingPreset();
            Util.Render render = new Util.Render();
            render.updateUI();

            try
            {
                if (GetSerialPort())
                {
                    sp.Open();
                    if (sp.IsOpen)
                    {
                        usbstate.Text = "Device Connect";
                        usbstate.ForeColor = Color.FromArgb(3, 218, 197);
                        Console.WriteLine(sp.PortName + "이 열려 져있습니다.");
                        notice("Connect !");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                if (sp.IsOpen)
                {
                    sp.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void appClosed_click(object sender, EventArgs e)
        {
             this.Visible = false;

            //Application.Exit();
            //Util.Preset preset = new Util.Preset();
            //preset.savePreset(this.PresetPath, this.AppName, this.PresetName);
        }

        private void minimized_click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private Point mousePoint;

        private void app_MouseDown(object sender, MouseEventArgs e)
        {
            Util.Render render = new Util.Render();
            render.closeList();
            mousePoint = new Point(e.X, e.Y);
        }


        private void app_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                Location = new Point(this.Left - (mousePoint.X - e.X),
                    this.Top - (mousePoint.Y - e.Y));
            }
        }
        #endregion

        #region USB CONNECT
        protected override void WndProc(ref Message m)

        {

            UInt32 WM_DEVICECHANGE = 0x0219;
            UInt32 DBT_DEVTUP_VOLUME = 0x02;
            UInt32 DBT_DEVICEARRIVAL = 0x8000;
            UInt32 DBT_DEVICEREMOVECOMPLETE = 0x8004;

            if ((m.Msg == WM_DEVICECHANGE) && (m.WParam.ToInt32() == DBT_DEVICEARRIVAL))

            {
                Console.WriteLine("디바이스가 연결되었습니다.");
                int devType = Marshal.ReadInt32(m.LParam, 4);

                if (devType == DBT_DEVTUP_VOLUME)
                {
                    usbstate.Text = "Device Connect";
                    Console.WriteLine("USB 장치가 연결 됨");
                }
                else
                {
                    Console.WriteLine("USB to COM 장치가 연결 됨");
                    usbstate.Text = "Device Connect";
                    usbstate.ForeColor = Color.FromArgb(3, 218, 197);
                    notice("Connect !");

                    //단순하게 test하기 위해 젤 마지막 포트이름을 뿌려 봄
                    foreach (string str in SerialPort.GetPortNames())
                    {
                        this.portName = str;
                        Console.WriteLine("현재 연결된 디바이스 포트는 : " + str);
                    }
                    sp.PortName = this.portName;
                    sp.BaudRate = 115200;
                    sp.DataBits = 8;
                    sp.Parity = Parity.None;
                    sp.StopBits = StopBits.One;
                    sp.Handshake = Handshake.None;
                    sp.Open();

                }//.....etc....
            }

            if ((m.Msg == WM_DEVICECHANGE) && (m.WParam.ToInt32() == DBT_DEVICEREMOVECOMPLETE)) //디바이스 연결 해제
            {
                int devType = Marshal.ReadInt32(m.LParam, 4);
                Console.WriteLine("연결 헤제");
                usbstate.Text = "Device Not Connect";
                usbstate.ForeColor = Color.White;
                notice("Not Connect !");
                sp.Close();
            }
            base.WndProc(ref m);
        }

        /**
         * @todo 이부분에서 Usb to Com 포트 찾는거 만들기.
         */
        private bool GetSerialPort()
        {
            try
            {
                foreach (string str in SerialPort.GetPortNames())
                {
                    this.portName = str;
                    Console.WriteLine("포트번호 : " + this.portName);
                    sp.PortName = this.portName;
                    sp.BaudRate = 115200;
                    sp.DataBits = 8;
                    sp.Parity = Parity.None;
                    sp.StopBits = StopBits.One;
                    sp.Handshake = Handshake.None;
                    Console.WriteLine("설정끝 : " + this.portName);
                    return true;
                }
                Console.WriteLine("연결 안댐");
                usbstate.Text = "Device Not Connect";
                usbstate.ForeColor = Color.White;
                notice("Not Connect !");
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        #endregion

        #region 노티스 아이콘
        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Location = new Point(Screen.PrimaryScreen.Bounds.Width / 2 - this.Size.Width / 2
            , Screen.PrimaryScreen.Bounds.Height / 2 - this.Size.Height / 2);
            this.Visible = true;


        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Util.Preset preset = new Util.Preset();
            preset.savePreset(this.PresetPath, this.AppName, this.PresetName);
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.invaiz.com");
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
 
                this.Location = new Point(Screen.PrimaryScreen.Bounds.Width / 2 - this.Size.Width / 2
                 , Screen.PrimaryScreen.Bounds.Height / 2 - this.Size.Height / 2);
                this.Visible = true;

        }
        private void notice(string msg)
        {
            //notifyIcon.BalloonTipText = msg;
            //notifyIcon.BalloonTipTitle = "Invaiz notice";
            //notifyIcon.ShowBalloonTip(1);
            //notifyIcon.Visible = true;
        }
        #endregion

        #region data control
        public readonly int[] BAUDRATE = { 9600, 19200, 38400, 57600, 115200 };
        private int[] position = new int[4];
        private int[] speed = new int[4];
        private int[] direction = new int[4];
        private int[] push = new int[4];

        private int[] buttonPress = new int[5];



        private int groupControl = 0;
        private bool groupChage = false;


        private int prevDir1 = -1;
        Util.PluginConnect pluginConnect = new Util.PluginConnect();

        private void sp_DataReceived(object sender, EventArgs e)
        {
            try
            {
                if (sp.IsOpen)
                {
                    string s = sp.ReadLine();
                    string[] data = s.Split(',');
                    if (data[0] == "$0")
                    {
                        for (int i = 0; i < 4; i++)
                        {
                            position[i] = Convert.ToInt32(data[i * 4 + 1]);
                            speed[i] = Convert.ToInt32(data[i * 4 + 2]) * 10;
                            direction[i] = Convert.ToInt32(data[i * 4 + 3]); //0 왼쪽 1 오른쪽
                            push[i] = Convert.ToInt32(data[i * 4 + 4]); //이거 안씀
                        }

                        for (int i = 0; i < 5; i++)
                        {
                            buttonPress[i] = Convert.ToInt32(data[i + 17]);
                        }

                        for (int i = 0; i < 4; i++)
                        {
                            if (speed[i] > 0)
                            {

                                if (prevDir1 == direction[0])
                                {
                                    if (!groupChage)
                                    {
                                        pluginConnect.EncoderData(payloads[groupControl], groupControl, i, direction[i].ToString(), speed[i], this.AppName);
                                    }

                                }
                                else
                                {
                                    prevDir1 = direction[0];
                                    Console.WriteLine("씹음");
                                }
                            }
                        }
//                       Console.WriteLine(buttonPress[0] + " " + buttonPress[1] + " " + buttonPress[2] + " " + buttonPress[3] + " " + buttonPress[4]);

                        for (int i = 0; i < 5; i++)
                        {   
                            if(buttonPress[4] == 1)
                            {
                                groupChage = true;
                                pluginConnect.overlay.GroupOverlay(4);
                            }
                            else if(buttonPress[i] == 1)
                            {
                                if (groupChage)
                                {
                                    this.groupControl = i;
                                    pluginConnect.overlay.GroupOverlay(i);
                                    System.Threading.Thread.Sleep(200);
                                    pluginConnect.overlay.PayloadOverlay(true, this.groupControl, -1);
                                    groupChage = false;
                                }
                                else
                                {
                                    pluginConnect.ButtonData(payloads[groupControl], this.groupControl, i, this.AppName);

                                }
                            }
                        }
                    }

                }
            }
            catch
            {

            }
        }

        #endregion

        #region 애니메이션

        public bool appListShow=false;
        private void appList_tick(object sender, EventArgs e)
        {
            if (!appListShow)
            {
                appList.Height += 25;
                if (appList.Size == appList.MaximumSize)
                {
                    appTimer.Stop();
                    appListShow = true;
                }
            }
            else
            {
                appList.Height -= 25;
                if (appList.Size == appList.MinimumSize)
                {
                    appTimer.Stop();
                    appListShow = false;
                }
            }
        }

        public bool presetIsShow = false;
        private void presetTimer_Tick(object sender, EventArgs e)
        {
            if (!presetIsShow)
            {
                presetList.Height += 25;
                if (presetList.Size == presetList.MaximumSize)
                {
                    presetTimer.Stop();
                    presetIsShow = true;
                }
            }
            else
            {
                presetList.Height -= 25;
                if (presetList.Size == presetList.MinimumSize)
                {
                    presetTimer.Stop();
                    presetIsShow = false;
                }
            }
        }

        #endregion

        #region 마우스 휠
        private void customScrollbar1_Scroll(object sender, EventArgs e)
        {
            try
            {

                deviceList.AutoScrollPosition = new Point(0, customScrollbar1.Value);
                Console.WriteLine("custom: " + customScrollbar1.Value.ToString());
                customScrollbar1.Invalidate();
                Application.DoEvents();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void Device_MouseWheel(object sender, MouseEventArgs e)
        {

            customScrollbar1.Value = deviceList.AutoScrollPosition.Y * -1;
            deviceList.AutoScrollPosition = new Point(0, customScrollbar1.Value);
            customScrollbar1.Invalidate();
            Application.DoEvents();

        }

        private void customScrollbar_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0)
            {
                customScrollbar1.Value = (deviceList.AutoScrollPosition.Y + 120) * -1;
                Console.WriteLine("커스텀 스크롤 밸류 업" + (deviceList.AutoScrollPosition.Y + 120) * -1);
                deviceList.AutoScrollPosition = new Point(0, customScrollbar1.Value);
                customScrollbar1.Invalidate();
                Application.DoEvents();
            }
            else
            {
                customScrollbar1.Value = (deviceList.AutoScrollPosition.Y - 120) * -1;
                Console.WriteLine("커스텀 스크롤 밸류 다운" + (deviceList.AutoScrollPosition.Y - 120) * -1);
                deviceList.AutoScrollPosition = new Point(0, customScrollbar1.Value);
                customScrollbar1.Invalidate();
                Application.DoEvents();
            }

        }
        #endregion
    }
}
