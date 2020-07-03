using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.IO.Ports;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Invaiz_Studio
{


    public partial class MainForm : Form
    {
        delegate void EventHandlerAddCtrl();
        event EventHandlerAddCtrl OnAddCtrl;

        public CultureInfo currentCulture = System.Threading.Thread.CurrentThread.CurrentCulture;
        #region 생성자
        public MainForm()
        {
            Console.WriteLine(currentCulture.Name);
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
            this.OnAddCtrl += new EventHandlerAddCtrl(rePresetFile);
        }

        #endregion

        #region 프로세스 캐치
        public void rePresetFile()
        {
            if (AppName.Equals("Window") && !windowCheck)
            {
                Console.WriteLine("윈도우고 체크 활성아니니 실행");
                windowCheck = true;
            }
            else if (!AppName.Equals("window"))
            {
                Console.WriteLine("윈도우아니니 체크 비활성");
                windowCheck = false;
            }
            for (int i = 0; i < Payloads.Length; i++)
            {
                Payloads[i] = new DeviceData.Payload();
            }
            render.initUI();
            render.closeList();
            render.listValueInit();
            preset.getPresetFiles();
            this.CurrentGroup = 0;
            render.updateUI();
            render.resetImage(AppName);
            Console.WriteLine("변경된 그룹: " + this.CurrentGroup);
            this.groupChage = false;
            notice(this.AppName + " " + this.PresetName + " 프리셋으로 셋팅됨");
            Console.WriteLine("-----스레드 끝-----");

        }
        public void startThread()
        {
            Console.WriteLine("----스레드 시작---");
            System.Threading.Thread thread = new System.Threading.Thread(
                new System.Threading.ThreadStart(CreateCtrl));
            thread.Start();
            Console.WriteLine("----스레드 기다림---");
            thread.Join();

        }
        void CreateCtrl()
        {
            Invoke(OnAddCtrl);
        }
        #endregion 

        #region 폼 로딩, 최소화 및 종료

        public View.GeneralOverlayForm defaultOverlay = new View.GeneralOverlayForm();
        private void MainForm_Load(object sender, EventArgs e)
        {
            Console.WriteLine(Properties.Settings.Default.WIN_PRESET);
            instance = this;
            AppName = this.appBox.AppName;
            PresetName = this.presetBox.PresetName;
            Util.Preset preset = new Util.Preset();
            preset.getPresetFiles();
            //preset.settingPreset();
            Util.MainRender render = new Util.MainRender();
            render.updateUI();
        //  defaultOverlay.showGroup(currentGroup, payloads[currentGroup].groupName);
        //  defaultOverlay.Show();

            //폼 로드시 시리얼 포트 검색
            try
            {
                if (InitSerialPort())
                {
                    if (sp.IsOpen)
                    {
                        usbstate.Text = "Device Connect";
                        usbstate.ForeColor = Color.FromArgb(51, 153, 255);
                        Console.WriteLine(sp.PortName + "이 열려 져있습니다.");
                        notice("Connecting..");
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
                Util.Preset preset = new Util.Preset();
                preset.savePreset(this.PresetPath, this.AppName, this.PresetName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Visible = false;
            e.Cancel = true;
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
            Util.MainRender render = new Util.MainRender();
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

        /// <summary>
        /// USB 자동 커넥트 부분 추후에 무선/유선 추가
        /// </summary>
        /// <param name="m"></param>
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
                    if (InitSerialPort())
                    {
                        usbstate.Text = "Device Connect";
                        usbstate.ForeColor = Color.FromArgb(51, 153, 255);
                    }
                }//.....etc....
            }

            if ((m.Msg == WM_DEVICECHANGE) && (m.WParam.ToInt32() == DBT_DEVICEREMOVECOMPLETE)) //디바이스 연결 해제
            {
                int devType = Marshal.ReadInt32(m.LParam, 4);
                Console.WriteLine("연결 헤제");
                usbstate.Text = "Device Not Connect";
                usbstate.ForeColor = Color.White;
                notice("Not connected...");
                sp.Close();
            }
            base.WndProc(ref m);
        }

        /**
         * @todo 이부분에서 Usb to Com 포트 찾는거 만들기.
         */

        //무선 연결 기초
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
                notice("Not connected...");
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        //유선 연결 확인
        private bool InitSerialPort()
        {
            string[] port = SerialPort.GetPortNames();
            string name = null;

            try
            {
                // List<string> list = getPortByVPid("2EC2", "0002");
                List<string> list = getPortByVPid("0483", "5740");

                foreach (string p in port)
                {
                    //   Console.WriteLine("이건 머지" + p);
                    for (int i = 0; i < list.Count; i++)
                    {
                        //     Console.WriteLine("이름 찾음" + list[i]);
                        if (p == list[i])
                        {
                            name = p;
                            break;
                        }
                    }
                }

                if (name != null)
                {
                    if (!sp.IsOpen)
                    {
                        Console.WriteLine("Detect " + name + " Port!!!");
                        sp.PortName = name;
                        sp.BaudRate = 115200;
                        sp.DataBits = 8;
                        sp.Parity = Parity.None;
                        sp.StopBits = StopBits.One;
                        sp.Handshake = Handshake.None;
                        sp.Open();
                    }
                    return true;
                }
                else
                {
                    Console.WriteLine("Not Detect COM Port!!!");
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        //유선 연결시 VID, PID 이용해 찾기
        private static List<string> getPortByVPid(String VID, String PID)
        {
            String pattern = String.Format("^VID_{0}.PID_{1}", VID, PID);
            Console.WriteLine(pattern);
            Regex _rx = new Regex(pattern, RegexOptions.IgnoreCase);
            List<string> comports = new List<string>();
            RegistryKey rk1 = Registry.LocalMachine;
            RegistryKey rk2 = rk1.OpenSubKey("SYSTEM\\CurrentControlSet\\Enum");
            foreach (String s3 in rk2.GetSubKeyNames())
            {
                RegistryKey rk3 = rk2.OpenSubKey(s3);
                foreach (String s in rk3.GetSubKeyNames())
                {
                    if (_rx.Match(s).Success)
                    {
                        RegistryKey rk4 = rk3.OpenSubKey(s);
                        foreach (String s2 in rk4.GetSubKeyNames())
                        {
                            RegistryKey rk5 = rk4.OpenSubKey(s2);
                            RegistryKey rk6 = rk5.OpenSubKey("Device Parameters");
                            comports.Add((string)rk6.GetValue("PortName"));
                        }
                    }
                }
            }
            return comports;
        }

        #endregion

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

        private static string s = Environment.GetFolderPath(System.Environment.SpecialFolder.LocalApplicationData);
        // private static string DATA_PATH = Path.Combine(s, "Invaiz Studio", "data");
        private string PRESET_PATH = Path.Combine(s, "Invaiz Studio", "preset");

        private string DATA_PATH = @".\data";
        //  private string PRESET_PATH = @".\preset\";
        public bool windowCheck = false;
        public Util.MainRender render = new Util.MainRender();
        public Util.Preset preset = new Util.Preset();


        private Image[] appImage = {
            Invaiz_Studio.Properties.Resources.iconwin,
            Invaiz_Studio.Properties.Resources.iconps,
            Invaiz_Studio.Properties.Resources.iconai,
            Invaiz_Studio.Properties.Resources.iconae,
            Invaiz_Studio.Properties.Resources.iconpr,
            Invaiz_Studio.Properties.Resources.iconlr,
            Invaiz_Studio.Properties.Resources.iconid
        };

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
        public int CurrentGroup
        {
            get { return this.currentGroup; }
            set
            {
                this.currentGroup = value;
                defaultOverlay.showGroup(currentGroup, payloads[currentGroup].groupName);
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
            Application.ExitThread();
            Environment.Exit(0);
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
            //notifyIcon.BalloonTipTitle = "Invaiz Studio";
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

        private int currentGroup = 0;
        private bool groupChage = false;

        private int prevDir1 = -1;
        Util.PluginConnect pluginConnect = new Util.PluginConnect();
        Util.ImportWinapi importWinapi = new Util.ImportWinapi();

        int tempIndex = -1;
        int checkdata = 0;
        bool isGroupChange = false;
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
                            buttonPress[i] = Convert.ToInt32(data[i + 17]);
                        

                        for (int i = 0; i < 4; i++)
                        {
                            if (speed[i] > 0)
                            {
                                if (prevDir1 == direction[0])
                                {
                                    if (!groupChage)
                                    {
                                        importWinapi.IsProcessActive(AppName);
                                        pluginConnect.EncoderData(payloads[currentGroup], currentGroup, i, direction[i].ToString(), speed[i], this.AppName);
                                    }
                                }
                                else
                                {
                                    prevDir1 = direction[0];
                                    Console.WriteLine("씹음");
                                }
                            }
                        }

                        // Console.WriteLine(buttonPress[0] + " " + buttonPress[1] + " " + buttonPress[2] + " " + buttonPress[3] + " " + buttonPress[4]);
                        for (int i = 0; i < 5; i++)
                        {
                            buttonPress[i] = Convert.ToInt32(data[i + 17]);
                            if (buttonPress[4] == 1)
                            {
                                Console.WriteLine("그룹 체인지");
                                groupChage = true;
                                pluginConnect.overlay.GroupOverlay(4);
                                break;
                            }
                            else if (buttonPress[i] == 1)
                            {
                                if (groupChage)
                                {
                                    Console.WriteLine("그룹 " + i + "번 변경중");
                                    this.CurrentGroup = i;
                                    tempIndex = i;
                                    //pluginConnect.overlay.GroupOverlay(i);
                                    //System.Threading.Thread.Sleep(200);
                                    //pluginConnect.overlay.PayloadOverlay(true, this.currentGroup, -1);
                                  //  groupChage = false;
                                }
                                else
                                {
                                    importWinapi.IsProcessActive(AppName);
                                    pluginConnect.ButtonData(payloads[currentGroup], this.currentGroup, i, this.AppName);

                                }
                            }
                        }

                        if (buttonPress[this.tempIndex] == 0 && groupChage && this.tempIndex != -1)
                        {
                            pluginConnect.overlay.GroupOverlay(this.currentGroup);
                            System.Threading.Thread.Sleep(200);
                            pluginConnect.overlay.PayloadOverlay(true, this.currentGroup, -1);
                              groupChage = false;
                            this.tempIndex = -1;
                            Console.WriteLine("그룹 변경 완료 :" + this.currentGroup);
                        }
                    }
                }
            }

            catch
            {

            }

        }
        private void sp_DataReceived2(object sender, EventArgs e)
        {
            //this.Invoke(new EventHandler(mySerialReceived));
        }

        #endregion

        #region 애니메이션

        public bool appListShow = false;
        private void appList_tick(object sender, EventArgs e)
        {
            if (!appListShow)
            {
                appList.Height += 25;
                if (appList.Size == appList.MaximumSize)
                {
                    appTimer.Stop();
                    appListShow = true;
                    appList.customScrollbar1.Value = 0;
                    appList.app_list.AutoScrollPosition = new System.Drawing.Point(0, 0);
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
                appList.customScrollbar1.Value = 0;
                appList.app_list.AutoScrollPosition = new System.Drawing.Point(0, 0);
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

        private void setting_click(object sender, EventArgs e)
        {
            View.General gereral = new View.General();
            gereral.ShowDialog();
        }
    }
}
