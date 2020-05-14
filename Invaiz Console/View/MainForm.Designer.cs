namespace Invaiz_Console
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        private System.IO.Ports.SerialPort sp;
        private string portName;
        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.sp = new System.IO.Ports.SerialPort(this.components);
            this.main_area = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.Presets = new System.Windows.Forms.Label();
            this.Appliction = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.set_area = new System.Windows.Forms.Panel();
            this.customScrollbar1 = new CustomControls.CustomScrollbar();
            this.label1 = new System.Windows.Forms.Label();
            this.outpanel = new System.Windows.Forms.Panel();
            this.deviceList = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.nav_area = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.usbstate = new System.Windows.Forms.Label();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.presetItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.appTimer = new System.Windows.Forms.Timer(this.components);
            this.presetTimer = new System.Windows.Forms.Timer(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.deviceGroup1 = new Invaiz_Console.Component.DeviceGroup();
            this.deviceGroupButton1 = new Invaiz_Console.Component.Device.DeviceGroupButton();
            this.deviceButton4 = new Invaiz_Console.Component.DeviceButton();
            this.deviceButton3 = new Invaiz_Console.Component.DeviceButton();
            this.deviceButton2 = new Invaiz_Console.Component.DeviceButton();
            this.deviceButton1 = new Invaiz_Console.Component.DeviceButton();
            this.deviceEncoder4 = new Invaiz_Console.Component.DeviceEncoder();
            this.deviceEncoder3 = new Invaiz_Console.Component.DeviceEncoder();
            this.deviceEncoder2 = new Invaiz_Console.Component.DeviceEncoder();
            this.deviceEncoder1 = new Invaiz_Console.Component.DeviceEncoder();
            this.deviceGroup2 = new Invaiz_Console.Component.DeviceGroup();
            this.deviceGroupButton2 = new Invaiz_Console.Component.Device.DeviceGroupButton();
            this.deviceButton8 = new Invaiz_Console.Component.DeviceButton();
            this.deviceButton7 = new Invaiz_Console.Component.DeviceButton();
            this.deviceButton6 = new Invaiz_Console.Component.DeviceButton();
            this.deviceButton5 = new Invaiz_Console.Component.DeviceButton();
            this.deviceEncoder8 = new Invaiz_Console.Component.DeviceEncoder();
            this.deviceEncoder7 = new Invaiz_Console.Component.DeviceEncoder();
            this.deviceEncoder6 = new Invaiz_Console.Component.DeviceEncoder();
            this.deviceEncoder5 = new Invaiz_Console.Component.DeviceEncoder();
            this.deviceGroup3 = new Invaiz_Console.Component.DeviceGroup();
            this.deviceGroupButton3 = new Invaiz_Console.Component.Device.DeviceGroupButton();
            this.deviceButton12 = new Invaiz_Console.Component.DeviceButton();
            this.deviceButton11 = new Invaiz_Console.Component.DeviceButton();
            this.deviceButton10 = new Invaiz_Console.Component.DeviceButton();
            this.deviceButton9 = new Invaiz_Console.Component.DeviceButton();
            this.deviceEncoder12 = new Invaiz_Console.Component.DeviceEncoder();
            this.deviceEncoder11 = new Invaiz_Console.Component.DeviceEncoder();
            this.deviceEncoder10 = new Invaiz_Console.Component.DeviceEncoder();
            this.deviceEncoder9 = new Invaiz_Console.Component.DeviceEncoder();
            this.deviceGroup4 = new Invaiz_Console.Component.DeviceGroup();
            this.deviceGroupButton4 = new Invaiz_Console.Component.Device.DeviceGroupButton();
            this.deviceButton16 = new Invaiz_Console.Component.DeviceButton();
            this.deviceButton15 = new Invaiz_Console.Component.DeviceButton();
            this.deviceButton14 = new Invaiz_Console.Component.DeviceButton();
            this.deviceButton13 = new Invaiz_Console.Component.DeviceButton();
            this.deviceEncoder16 = new Invaiz_Console.Component.DeviceEncoder();
            this.deviceEncoder15 = new Invaiz_Console.Component.DeviceEncoder();
            this.deviceEncoder14 = new Invaiz_Console.Component.DeviceEncoder();
            this.deviceEncoder13 = new Invaiz_Console.Component.DeviceEncoder();
            this.presetList = new Invaiz_Console.Component.PresetList();
            this.appList = new Invaiz_Console.Component.AppList();
            this.presetBox = new Invaiz_Console.Component.PresetBox();
            this.appBox = new Invaiz_Console.Component.AppBox();
            this.mainKeypad = new Invaiz_Console.Component.MainKeypad();
            this.main_area.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.set_area.SuspendLayout();
            this.outpanel.SuspendLayout();
            this.deviceList.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.nav_area.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // sp
            // 
            this.sp.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.sp_DataReceived);
            // 
            // main_area
            // 
            this.main_area.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.main_area.Controls.Add(this.presetList);
            this.main_area.Controls.Add(this.panel6);
            this.main_area.Controls.Add(this.panel5);
            this.main_area.Controls.Add(this.appList);
            this.main_area.Controls.Add(this.presetBox);
            this.main_area.Controls.Add(this.Presets);
            this.main_area.Controls.Add(this.Appliction);
            this.main_area.Controls.Add(this.appBox);
            this.main_area.Controls.Add(this.mainKeypad);
            this.main_area.Controls.Add(this.pictureBox1);
            this.main_area.Location = new System.Drawing.Point(0, 0);
            this.main_area.Name = "main_area";
            this.main_area.Size = new System.Drawing.Size(553, 740);
            this.main_area.TabIndex = 0;
            this.main_area.MouseDown += new System.Windows.Forms.MouseEventHandler(this.app_MouseDown);
            this.main_area.MouseMove += new System.Windows.Forms.MouseEventHandler(this.app_MouseMove);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.panel6.Location = new System.Drawing.Point(300, 190);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(180, 1);
            this.panel6.TabIndex = 25;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.panel5.Location = new System.Drawing.Point(90, 190);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(180, 1);
            this.panel5.TabIndex = 24;
            // 
            // Presets
            // 
            this.Presets.AutoSize = true;
            this.Presets.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.Presets.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Presets.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(137)))), ((int)(((byte)(137)))));
            this.Presets.Location = new System.Drawing.Point(296, 119);
            this.Presets.Name = "Presets";
            this.Presets.Size = new System.Drawing.Size(98, 19);
            this.Presets.TabIndex = 21;
            this.Presets.Text = "Active Preset";
            // 
            // Appliction
            // 
            this.Appliction.AutoSize = true;
            this.Appliction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.Appliction.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appliction.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(137)))), ((int)(((byte)(137)))));
            this.Appliction.Location = new System.Drawing.Point(86, 119);
            this.Appliction.Name = "Appliction";
            this.Appliction.Size = new System.Drawing.Size(87, 19);
            this.Appliction.TabIndex = 20;
            this.Appliction.Text = "Application";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Invaiz_Console.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // set_area
            // 
            this.set_area.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.set_area.Controls.Add(this.customScrollbar1);
            this.set_area.Controls.Add(this.label1);
            this.set_area.Controls.Add(this.outpanel);
            this.set_area.Controls.Add(this.panel4);
            this.set_area.Controls.Add(this.pictureBox3);
            this.set_area.Controls.Add(this.pictureBox2);
            this.set_area.Location = new System.Drawing.Point(553, 0);
            this.set_area.Name = "set_area";
            this.set_area.Size = new System.Drawing.Size(727, 740);
            this.set_area.TabIndex = 1;
            this.set_area.MouseDown += new System.Windows.Forms.MouseEventHandler(this.app_MouseDown);
            this.set_area.MouseMove += new System.Windows.Forms.MouseEventHandler(this.app_MouseMove);
            // 
            // customScrollbar1
            // 
            this.customScrollbar1.ChannelColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.customScrollbar1.DownArrowImage = null;
            this.customScrollbar1.LargeChange = 10;
            this.customScrollbar1.Location = new System.Drawing.Point(721, 82);
            this.customScrollbar1.Maximum = 100;
            this.customScrollbar1.Minimum = 0;
            this.customScrollbar1.MinimumSize = new System.Drawing.Size(0, 56);
            this.customScrollbar1.Name = "customScrollbar1";
            this.customScrollbar1.Size = new System.Drawing.Size(5, 631);
            this.customScrollbar1.SmallChange = 1;
            this.customScrollbar1.TabIndex = 27;
            this.customScrollbar1.ThumbBottomImage = global::Invaiz_Console.Properties.Resources.thunbspan;
            this.customScrollbar1.ThumbBottomSpanImage = global::Invaiz_Console.Properties.Resources.thunbspan;
            this.customScrollbar1.ThumbHoverImage = null;
            this.customScrollbar1.ThumbMiddleImage = global::Invaiz_Console.Properties.Resources.thumbmidle;
            this.customScrollbar1.ThumbNomalImage = null;
            this.customScrollbar1.ThumbTopImage = global::Invaiz_Console.Properties.Resources.thunbspan;
            this.customScrollbar1.ThumbTopSpanImage = global::Invaiz_Console.Properties.Resources.thunbspan;
            this.customScrollbar1.UpArrowImage = null;
            this.customScrollbar1.Value = 0;
            this.customScrollbar1.Scroll += new System.EventHandler(this.customScrollbar1_Scroll);
            this.customScrollbar1.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.customScrollbar_MouseWheel);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(106, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 23);
            this.label1.TabIndex = 21;
            this.label1.Text = "Device Setting";
            // 
            // outpanel
            // 
            this.outpanel.Controls.Add(this.deviceList);
            this.outpanel.Location = new System.Drawing.Point(104, 61);
            this.outpanel.Name = "outpanel";
            this.outpanel.Size = new System.Drawing.Size(559, 652);
            this.outpanel.TabIndex = 4;
            // 
            // deviceList
            // 
            this.deviceList.AutoScroll = true;
            this.deviceList.Controls.Add(this.deviceGroup1);
            this.deviceList.Controls.Add(this.panel1);
            this.deviceList.Controls.Add(this.deviceGroup2);
            this.deviceList.Controls.Add(this.panel2);
            this.deviceList.Controls.Add(this.deviceGroup3);
            this.deviceList.Controls.Add(this.panel3);
            this.deviceList.Controls.Add(this.deviceGroup4);
            this.deviceList.Controls.Add(this.panel7);
            this.deviceList.Location = new System.Drawing.Point(0, 21);
            this.deviceList.Name = "deviceList";
            this.deviceList.Size = new System.Drawing.Size(638, 651);
            this.deviceList.TabIndex = 0;
            this.deviceList.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.Device_MouseWheel);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Invaiz_Console.Properties.Resources.background;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Controls.Add(this.deviceGroupButton1);
            this.panel1.Controls.Add(this.deviceButton4);
            this.panel1.Controls.Add(this.deviceButton3);
            this.panel1.Controls.Add(this.deviceButton2);
            this.panel1.Controls.Add(this.deviceButton1);
            this.panel1.Controls.Add(this.deviceEncoder4);
            this.panel1.Controls.Add(this.deviceEncoder3);
            this.panel1.Controls.Add(this.deviceEncoder2);
            this.panel1.Controls.Add(this.deviceEncoder1);
            this.panel1.Location = new System.Drawing.Point(3, 77);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(535, 210);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::Invaiz_Console.Properties.Resources.background;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel2.Controls.Add(this.deviceGroupButton2);
            this.panel2.Controls.Add(this.deviceButton8);
            this.panel2.Controls.Add(this.deviceButton7);
            this.panel2.Controls.Add(this.deviceButton6);
            this.panel2.Controls.Add(this.deviceButton5);
            this.panel2.Controls.Add(this.deviceEncoder8);
            this.panel2.Controls.Add(this.deviceEncoder7);
            this.panel2.Controls.Add(this.deviceEncoder6);
            this.panel2.Controls.Add(this.deviceEncoder5);
            this.panel2.Location = new System.Drawing.Point(3, 394);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 3, 3, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(535, 210);
            this.panel2.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::Invaiz_Console.Properties.Resources.background;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel3.Controls.Add(this.deviceGroupButton3);
            this.panel3.Controls.Add(this.deviceButton12);
            this.panel3.Controls.Add(this.deviceButton11);
            this.panel3.Controls.Add(this.deviceButton10);
            this.panel3.Controls.Add(this.deviceButton9);
            this.panel3.Controls.Add(this.deviceEncoder12);
            this.panel3.Controls.Add(this.deviceEncoder11);
            this.panel3.Controls.Add(this.deviceEncoder10);
            this.panel3.Controls.Add(this.deviceEncoder9);
            this.panel3.Location = new System.Drawing.Point(3, 711);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 3, 3, 30);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(535, 210);
            this.panel3.TabIndex = 5;
            // 
            // panel7
            // 
            this.panel7.BackgroundImage = global::Invaiz_Console.Properties.Resources.background;
            this.panel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel7.Controls.Add(this.deviceGroupButton4);
            this.panel7.Controls.Add(this.deviceButton16);
            this.panel7.Controls.Add(this.deviceButton15);
            this.panel7.Controls.Add(this.deviceButton14);
            this.panel7.Controls.Add(this.deviceButton13);
            this.panel7.Controls.Add(this.deviceEncoder16);
            this.panel7.Controls.Add(this.deviceEncoder15);
            this.panel7.Controls.Add(this.deviceEncoder14);
            this.panel7.Controls.Add(this.deviceEncoder13);
            this.panel7.Location = new System.Drawing.Point(3, 1028);
            this.panel7.Margin = new System.Windows.Forms.Padding(3, 3, 3, 30);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(535, 210);
            this.panel7.TabIndex = 7;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1, 740);
            this.panel4.TabIndex = 2;
            this.panel4.Visible = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Invaiz_Console.Properties.Resources.close;
            this.pictureBox3.Location = new System.Drawing.Point(696, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 30);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.appClosed_click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Invaiz_Console.Properties.Resources.mini;
            this.pictureBox2.Location = new System.Drawing.Point(665, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.minimized_click);
            // 
            // nav_area
            // 
            this.nav_area.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.nav_area.Controls.Add(this.button2);
            this.nav_area.Controls.Add(this.button1);
            this.nav_area.Controls.Add(this.usbstate);
            this.nav_area.Location = new System.Drawing.Point(0, 740);
            this.nav_area.Name = "nav_area";
            this.nav_area.Size = new System.Drawing.Size(1280, 60);
            this.nav_area.TabIndex = 0;
            this.nav_area.MouseDown += new System.Windows.Forms.MouseEventHandler(this.app_MouseDown);
            this.nav_area.MouseMove += new System.Windows.Forms.MouseEventHandler(this.app_MouseMove);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::Invaiz_Console.Properties.Resources.setting;
            this.button1.Location = new System.Drawing.Point(1226, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 50);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // usbstate
            // 
            this.usbstate.AutoSize = true;
            this.usbstate.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usbstate.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.usbstate.Location = new System.Drawing.Point(542, 20);
            this.usbstate.Name = "usbstate";
            this.usbstate.Size = new System.Drawing.Size(187, 23);
            this.usbstate.TabIndex = 0;
            this.usbstate.Text = "Device Not Connected";
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.contextMenuStrip;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Invaiz";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.presetItem,
            this.toolStripSeparator2,
            this.aboutToolStripMenuItem,
            this.showToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip1";
            this.contextMenuStrip.Size = new System.Drawing.Size(112, 98);
            // 
            // presetItem
            // 
            this.presetItem.Name = "presetItem";
            this.presetItem.Size = new System.Drawing.Size(111, 22);
            this.presetItem.Text = "Presets";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(108, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.showToolStripMenuItem.Text = "Show";
            this.showToolStripMenuItem.Click += new System.EventHandler(this.showToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // appTimer
            // 
            this.appTimer.Interval = 10;
            this.appTimer.Tick += new System.EventHandler(this.appList_tick);
            // 
            // presetTimer
            // 
            this.presetTimer.Interval = 10;
            this.presetTimer.Tick += new System.EventHandler(this.presetTimer_Tick);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Transparent;
            this.button2.Location = new System.Drawing.Point(12, 10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 41);
            this.button2.TabIndex = 2;
            this.button2.Text = "Guide";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // deviceGroup1
            // 
            this.deviceGroup1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.deviceGroup1.GroupName = "";
            this.deviceGroup1.GroupNumber = "Group1";
            this.deviceGroup1.HoverColor = System.Drawing.Color.Empty;
            this.deviceGroup1.Location = new System.Drawing.Point(3, 3);
            this.deviceGroup1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 30);
            this.deviceGroup1.Name = "deviceGroup1";
            this.deviceGroup1.NomalColor = System.Drawing.Color.Empty;
            this.deviceGroup1.Number = 0;
            this.deviceGroup1.Size = new System.Drawing.Size(557, 41);
            this.deviceGroup1.TabIndex = 0;
            // 
            // deviceGroupButton1
            // 
            this.deviceGroupButton1.BackColor = System.Drawing.Color.Transparent;
            this.deviceGroupButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deviceGroupButton1.BackgroundImage")));
            this.deviceGroupButton1.GroupNumber = "Group1";
            this.deviceGroupButton1.HoverColor = System.Drawing.Color.WhiteSmoke;
            this.deviceGroupButton1.HoverImage = ((System.Drawing.Image)(resources.GetObject("deviceGroupButton1.HoverImage")));
            this.deviceGroupButton1.Location = new System.Drawing.Point(416, 140);
            this.deviceGroupButton1.Name = "deviceGroupButton1";
            this.deviceGroupButton1.NomalColor = System.Drawing.Color.WhiteSmoke;
            this.deviceGroupButton1.NomalImage = ((System.Drawing.Image)(resources.GetObject("deviceGroupButton1.NomalImage")));
            this.deviceGroupButton1.Size = new System.Drawing.Size(81, 42);
            this.deviceGroupButton1.TabIndex = 8;
            // 
            // deviceButton4
            // 
            this.deviceButton4.BackColor = System.Drawing.Color.Transparent;
            this.deviceButton4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deviceButton4.BackgroundImage")));
            this.deviceButton4.ButtonNumber = "B4";
            this.deviceButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deviceButton4.FormName = null;
            this.deviceButton4.Group = 0;
            this.deviceButton4.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(255)))));
            this.deviceButton4.HoverImage = ((System.Drawing.Image)(resources.GetObject("deviceButton4.HoverImage")));
            this.deviceButton4.Index = 3;
            this.deviceButton4.Location = new System.Drawing.Point(322, 140);
            this.deviceButton4.Name = "deviceButton4";
            this.deviceButton4.NomalColor = System.Drawing.Color.WhiteSmoke;
            this.deviceButton4.NomalImage = ((System.Drawing.Image)(resources.GetObject("deviceButton4.NomalImage")));
            this.deviceButton4.Size = new System.Drawing.Size(81, 42);
            this.deviceButton4.SubName = null;
            this.deviceButton4.TabIndex = 7;
            // 
            // deviceButton3
            // 
            this.deviceButton3.BackColor = System.Drawing.Color.Transparent;
            this.deviceButton3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deviceButton3.BackgroundImage")));
            this.deviceButton3.ButtonNumber = "B3";
            this.deviceButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deviceButton3.FormName = null;
            this.deviceButton3.Group = 0;
            this.deviceButton3.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(255)))));
            this.deviceButton3.HoverImage = ((System.Drawing.Image)(resources.GetObject("deviceButton3.HoverImage")));
            this.deviceButton3.Index = 2;
            this.deviceButton3.Location = new System.Drawing.Point(228, 140);
            this.deviceButton3.Name = "deviceButton3";
            this.deviceButton3.NomalColor = System.Drawing.Color.WhiteSmoke;
            this.deviceButton3.NomalImage = ((System.Drawing.Image)(resources.GetObject("deviceButton3.NomalImage")));
            this.deviceButton3.Size = new System.Drawing.Size(81, 42);
            this.deviceButton3.SubName = null;
            this.deviceButton3.TabIndex = 6;
            // 
            // deviceButton2
            // 
            this.deviceButton2.BackColor = System.Drawing.Color.Transparent;
            this.deviceButton2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deviceButton2.BackgroundImage")));
            this.deviceButton2.ButtonNumber = "B2";
            this.deviceButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deviceButton2.FormName = null;
            this.deviceButton2.Group = 0;
            this.deviceButton2.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(255)))));
            this.deviceButton2.HoverImage = ((System.Drawing.Image)(resources.GetObject("deviceButton2.HoverImage")));
            this.deviceButton2.Index = 1;
            this.deviceButton2.Location = new System.Drawing.Point(134, 140);
            this.deviceButton2.Name = "deviceButton2";
            this.deviceButton2.NomalColor = System.Drawing.Color.WhiteSmoke;
            this.deviceButton2.NomalImage = ((System.Drawing.Image)(resources.GetObject("deviceButton2.NomalImage")));
            this.deviceButton2.Size = new System.Drawing.Size(81, 42);
            this.deviceButton2.SubName = null;
            this.deviceButton2.TabIndex = 5;
            // 
            // deviceButton1
            // 
            this.deviceButton1.BackColor = System.Drawing.Color.Transparent;
            this.deviceButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deviceButton1.BackgroundImage")));
            this.deviceButton1.ButtonNumber = "B1";
            this.deviceButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deviceButton1.FormName = null;
            this.deviceButton1.Group = 0;
            this.deviceButton1.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(255)))));
            this.deviceButton1.HoverImage = ((System.Drawing.Image)(resources.GetObject("deviceButton1.HoverImage")));
            this.deviceButton1.Index = 0;
            this.deviceButton1.Location = new System.Drawing.Point(40, 140);
            this.deviceButton1.Name = "deviceButton1";
            this.deviceButton1.NomalColor = System.Drawing.Color.WhiteSmoke;
            this.deviceButton1.NomalImage = ((System.Drawing.Image)(resources.GetObject("deviceButton1.NomalImage")));
            this.deviceButton1.Size = new System.Drawing.Size(81, 42);
            this.deviceButton1.SubName = null;
            this.deviceButton1.TabIndex = 4;
            // 
            // deviceEncoder4
            // 
            this.deviceEncoder4.BackColor = System.Drawing.Color.Transparent;
            this.deviceEncoder4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deviceEncoder4.BackgroundImage")));
            this.deviceEncoder4.EncoderNumber = "D4";
            this.deviceEncoder4.FormName = null;
            this.deviceEncoder4.Group = 0;
            this.deviceEncoder4.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(255)))));
            this.deviceEncoder4.HoverImage = ((System.Drawing.Image)(resources.GetObject("deviceEncoder4.HoverImage")));
            this.deviceEncoder4.Index = 3;
            this.deviceEncoder4.LeftSubName = null;
            this.deviceEncoder4.Location = new System.Drawing.Point(413, 20);
            this.deviceEncoder4.Name = "deviceEncoder4";
            this.deviceEncoder4.NomalColor = System.Drawing.Color.WhiteSmoke;
            this.deviceEncoder4.NomalImage = ((System.Drawing.Image)(resources.GetObject("deviceEncoder4.NomalImage")));
            this.deviceEncoder4.RightSubName = null;
            this.deviceEncoder4.Size = new System.Drawing.Size(99, 99);
            this.deviceEncoder4.TabIndex = 3;
            // 
            // deviceEncoder3
            // 
            this.deviceEncoder3.BackColor = System.Drawing.Color.Transparent;
            this.deviceEncoder3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deviceEncoder3.BackgroundImage")));
            this.deviceEncoder3.EncoderNumber = "D3";
            this.deviceEncoder3.FormName = null;
            this.deviceEncoder3.Group = 0;
            this.deviceEncoder3.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(255)))));
            this.deviceEncoder3.HoverImage = ((System.Drawing.Image)(resources.GetObject("deviceEncoder3.HoverImage")));
            this.deviceEncoder3.Index = 2;
            this.deviceEncoder3.LeftSubName = null;
            this.deviceEncoder3.Location = new System.Drawing.Point(282, 20);
            this.deviceEncoder3.Name = "deviceEncoder3";
            this.deviceEncoder3.NomalColor = System.Drawing.Color.WhiteSmoke;
            this.deviceEncoder3.NomalImage = ((System.Drawing.Image)(resources.GetObject("deviceEncoder3.NomalImage")));
            this.deviceEncoder3.RightSubName = null;
            this.deviceEncoder3.Size = new System.Drawing.Size(99, 99);
            this.deviceEncoder3.TabIndex = 2;
            // 
            // deviceEncoder2
            // 
            this.deviceEncoder2.BackColor = System.Drawing.Color.Transparent;
            this.deviceEncoder2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deviceEncoder2.BackgroundImage")));
            this.deviceEncoder2.EncoderNumber = "D2";
            this.deviceEncoder2.FormName = null;
            this.deviceEncoder2.Group = 0;
            this.deviceEncoder2.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(255)))));
            this.deviceEncoder2.HoverImage = ((System.Drawing.Image)(resources.GetObject("deviceEncoder2.HoverImage")));
            this.deviceEncoder2.Index = 1;
            this.deviceEncoder2.LeftSubName = null;
            this.deviceEncoder2.Location = new System.Drawing.Point(151, 20);
            this.deviceEncoder2.Name = "deviceEncoder2";
            this.deviceEncoder2.NomalColor = System.Drawing.Color.WhiteSmoke;
            this.deviceEncoder2.NomalImage = ((System.Drawing.Image)(resources.GetObject("deviceEncoder2.NomalImage")));
            this.deviceEncoder2.RightSubName = null;
            this.deviceEncoder2.Size = new System.Drawing.Size(99, 99);
            this.deviceEncoder2.TabIndex = 1;
            // 
            // deviceEncoder1
            // 
            this.deviceEncoder1.BackColor = System.Drawing.Color.Transparent;
            this.deviceEncoder1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deviceEncoder1.BackgroundImage")));
            this.deviceEncoder1.EncoderNumber = "D1";
            this.deviceEncoder1.FormName = null;
            this.deviceEncoder1.Group = 0;
            this.deviceEncoder1.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(255)))));
            this.deviceEncoder1.HoverImage = ((System.Drawing.Image)(resources.GetObject("deviceEncoder1.HoverImage")));
            this.deviceEncoder1.Index = 0;
            this.deviceEncoder1.LeftSubName = null;
            this.deviceEncoder1.Location = new System.Drawing.Point(20, 20);
            this.deviceEncoder1.Name = "deviceEncoder1";
            this.deviceEncoder1.NomalColor = System.Drawing.Color.WhiteSmoke;
            this.deviceEncoder1.NomalImage = ((System.Drawing.Image)(resources.GetObject("deviceEncoder1.NomalImage")));
            this.deviceEncoder1.RightSubName = null;
            this.deviceEncoder1.Size = new System.Drawing.Size(99, 99);
            this.deviceEncoder1.TabIndex = 0;
            // 
            // deviceGroup2
            // 
            this.deviceGroup2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.deviceGroup2.GroupName = "";
            this.deviceGroup2.GroupNumber = "Group2";
            this.deviceGroup2.HoverColor = System.Drawing.Color.Empty;
            this.deviceGroup2.Location = new System.Drawing.Point(3, 320);
            this.deviceGroup2.Margin = new System.Windows.Forms.Padding(3, 3, 3, 30);
            this.deviceGroup2.Name = "deviceGroup2";
            this.deviceGroup2.NomalColor = System.Drawing.Color.Empty;
            this.deviceGroup2.Number = 1;
            this.deviceGroup2.Size = new System.Drawing.Size(557, 41);
            this.deviceGroup2.TabIndex = 2;
            // 
            // deviceGroupButton2
            // 
            this.deviceGroupButton2.BackColor = System.Drawing.Color.Transparent;
            this.deviceGroupButton2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deviceGroupButton2.BackgroundImage")));
            this.deviceGroupButton2.GroupNumber = "Group2";
            this.deviceGroupButton2.HoverColor = System.Drawing.Color.WhiteSmoke;
            this.deviceGroupButton2.HoverImage = ((System.Drawing.Image)(resources.GetObject("deviceGroupButton2.HoverImage")));
            this.deviceGroupButton2.Location = new System.Drawing.Point(416, 140);
            this.deviceGroupButton2.Name = "deviceGroupButton2";
            this.deviceGroupButton2.NomalColor = System.Drawing.Color.WhiteSmoke;
            this.deviceGroupButton2.NomalImage = ((System.Drawing.Image)(resources.GetObject("deviceGroupButton2.NomalImage")));
            this.deviceGroupButton2.Size = new System.Drawing.Size(81, 42);
            this.deviceGroupButton2.TabIndex = 8;
            // 
            // deviceButton8
            // 
            this.deviceButton8.BackColor = System.Drawing.Color.Transparent;
            this.deviceButton8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deviceButton8.BackgroundImage")));
            this.deviceButton8.ButtonNumber = "B4";
            this.deviceButton8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deviceButton8.FormName = null;
            this.deviceButton8.Group = 1;
            this.deviceButton8.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(255)))));
            this.deviceButton8.HoverImage = ((System.Drawing.Image)(resources.GetObject("deviceButton8.HoverImage")));
            this.deviceButton8.Index = 3;
            this.deviceButton8.Location = new System.Drawing.Point(322, 140);
            this.deviceButton8.Name = "deviceButton8";
            this.deviceButton8.NomalColor = System.Drawing.Color.WhiteSmoke;
            this.deviceButton8.NomalImage = ((System.Drawing.Image)(resources.GetObject("deviceButton8.NomalImage")));
            this.deviceButton8.Size = new System.Drawing.Size(81, 42);
            this.deviceButton8.SubName = null;
            this.deviceButton8.TabIndex = 7;
            // 
            // deviceButton7
            // 
            this.deviceButton7.BackColor = System.Drawing.Color.Transparent;
            this.deviceButton7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deviceButton7.BackgroundImage")));
            this.deviceButton7.ButtonNumber = "B3";
            this.deviceButton7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deviceButton7.FormName = null;
            this.deviceButton7.Group = 1;
            this.deviceButton7.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(255)))));
            this.deviceButton7.HoverImage = ((System.Drawing.Image)(resources.GetObject("deviceButton7.HoverImage")));
            this.deviceButton7.Index = 2;
            this.deviceButton7.Location = new System.Drawing.Point(228, 140);
            this.deviceButton7.Name = "deviceButton7";
            this.deviceButton7.NomalColor = System.Drawing.Color.WhiteSmoke;
            this.deviceButton7.NomalImage = ((System.Drawing.Image)(resources.GetObject("deviceButton7.NomalImage")));
            this.deviceButton7.Size = new System.Drawing.Size(81, 42);
            this.deviceButton7.SubName = null;
            this.deviceButton7.TabIndex = 6;
            // 
            // deviceButton6
            // 
            this.deviceButton6.BackColor = System.Drawing.Color.Transparent;
            this.deviceButton6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deviceButton6.BackgroundImage")));
            this.deviceButton6.ButtonNumber = "B2";
            this.deviceButton6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deviceButton6.FormName = null;
            this.deviceButton6.Group = 1;
            this.deviceButton6.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(255)))));
            this.deviceButton6.HoverImage = ((System.Drawing.Image)(resources.GetObject("deviceButton6.HoverImage")));
            this.deviceButton6.Index = 1;
            this.deviceButton6.Location = new System.Drawing.Point(134, 140);
            this.deviceButton6.Name = "deviceButton6";
            this.deviceButton6.NomalColor = System.Drawing.Color.WhiteSmoke;
            this.deviceButton6.NomalImage = ((System.Drawing.Image)(resources.GetObject("deviceButton6.NomalImage")));
            this.deviceButton6.Size = new System.Drawing.Size(81, 42);
            this.deviceButton6.SubName = null;
            this.deviceButton6.TabIndex = 5;
            // 
            // deviceButton5
            // 
            this.deviceButton5.BackColor = System.Drawing.Color.Transparent;
            this.deviceButton5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deviceButton5.BackgroundImage")));
            this.deviceButton5.ButtonNumber = "B1";
            this.deviceButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deviceButton5.FormName = null;
            this.deviceButton5.Group = 1;
            this.deviceButton5.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(255)))));
            this.deviceButton5.HoverImage = ((System.Drawing.Image)(resources.GetObject("deviceButton5.HoverImage")));
            this.deviceButton5.Index = 0;
            this.deviceButton5.Location = new System.Drawing.Point(40, 140);
            this.deviceButton5.Name = "deviceButton5";
            this.deviceButton5.NomalColor = System.Drawing.Color.WhiteSmoke;
            this.deviceButton5.NomalImage = ((System.Drawing.Image)(resources.GetObject("deviceButton5.NomalImage")));
            this.deviceButton5.Size = new System.Drawing.Size(81, 42);
            this.deviceButton5.SubName = null;
            this.deviceButton5.TabIndex = 4;
            // 
            // deviceEncoder8
            // 
            this.deviceEncoder8.BackColor = System.Drawing.Color.Transparent;
            this.deviceEncoder8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deviceEncoder8.BackgroundImage")));
            this.deviceEncoder8.EncoderNumber = "D4";
            this.deviceEncoder8.FormName = null;
            this.deviceEncoder8.Group = 1;
            this.deviceEncoder8.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(255)))));
            this.deviceEncoder8.HoverImage = ((System.Drawing.Image)(resources.GetObject("deviceEncoder8.HoverImage")));
            this.deviceEncoder8.Index = 3;
            this.deviceEncoder8.LeftSubName = null;
            this.deviceEncoder8.Location = new System.Drawing.Point(413, 20);
            this.deviceEncoder8.Name = "deviceEncoder8";
            this.deviceEncoder8.NomalColor = System.Drawing.Color.WhiteSmoke;
            this.deviceEncoder8.NomalImage = ((System.Drawing.Image)(resources.GetObject("deviceEncoder8.NomalImage")));
            this.deviceEncoder8.RightSubName = null;
            this.deviceEncoder8.Size = new System.Drawing.Size(99, 99);
            this.deviceEncoder8.TabIndex = 3;
            // 
            // deviceEncoder7
            // 
            this.deviceEncoder7.BackColor = System.Drawing.Color.Transparent;
            this.deviceEncoder7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deviceEncoder7.BackgroundImage")));
            this.deviceEncoder7.EncoderNumber = "D3";
            this.deviceEncoder7.FormName = null;
            this.deviceEncoder7.Group = 1;
            this.deviceEncoder7.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(255)))));
            this.deviceEncoder7.HoverImage = ((System.Drawing.Image)(resources.GetObject("deviceEncoder7.HoverImage")));
            this.deviceEncoder7.Index = 2;
            this.deviceEncoder7.LeftSubName = null;
            this.deviceEncoder7.Location = new System.Drawing.Point(282, 20);
            this.deviceEncoder7.Name = "deviceEncoder7";
            this.deviceEncoder7.NomalColor = System.Drawing.Color.WhiteSmoke;
            this.deviceEncoder7.NomalImage = ((System.Drawing.Image)(resources.GetObject("deviceEncoder7.NomalImage")));
            this.deviceEncoder7.RightSubName = null;
            this.deviceEncoder7.Size = new System.Drawing.Size(99, 99);
            this.deviceEncoder7.TabIndex = 2;
            // 
            // deviceEncoder6
            // 
            this.deviceEncoder6.BackColor = System.Drawing.Color.Transparent;
            this.deviceEncoder6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deviceEncoder6.BackgroundImage")));
            this.deviceEncoder6.EncoderNumber = "D2";
            this.deviceEncoder6.FormName = null;
            this.deviceEncoder6.Group = 1;
            this.deviceEncoder6.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(255)))));
            this.deviceEncoder6.HoverImage = ((System.Drawing.Image)(resources.GetObject("deviceEncoder6.HoverImage")));
            this.deviceEncoder6.Index = 1;
            this.deviceEncoder6.LeftSubName = null;
            this.deviceEncoder6.Location = new System.Drawing.Point(151, 20);
            this.deviceEncoder6.Name = "deviceEncoder6";
            this.deviceEncoder6.NomalColor = System.Drawing.Color.WhiteSmoke;
            this.deviceEncoder6.NomalImage = ((System.Drawing.Image)(resources.GetObject("deviceEncoder6.NomalImage")));
            this.deviceEncoder6.RightSubName = null;
            this.deviceEncoder6.Size = new System.Drawing.Size(99, 99);
            this.deviceEncoder6.TabIndex = 1;
            // 
            // deviceEncoder5
            // 
            this.deviceEncoder5.BackColor = System.Drawing.Color.Transparent;
            this.deviceEncoder5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deviceEncoder5.BackgroundImage")));
            this.deviceEncoder5.EncoderNumber = "D1";
            this.deviceEncoder5.FormName = null;
            this.deviceEncoder5.Group = 1;
            this.deviceEncoder5.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(255)))));
            this.deviceEncoder5.HoverImage = ((System.Drawing.Image)(resources.GetObject("deviceEncoder5.HoverImage")));
            this.deviceEncoder5.Index = 0;
            this.deviceEncoder5.LeftSubName = null;
            this.deviceEncoder5.Location = new System.Drawing.Point(20, 20);
            this.deviceEncoder5.Name = "deviceEncoder5";
            this.deviceEncoder5.NomalColor = System.Drawing.Color.WhiteSmoke;
            this.deviceEncoder5.NomalImage = ((System.Drawing.Image)(resources.GetObject("deviceEncoder5.NomalImage")));
            this.deviceEncoder5.RightSubName = null;
            this.deviceEncoder5.Size = new System.Drawing.Size(99, 99);
            this.deviceEncoder5.TabIndex = 0;
            // 
            // deviceGroup3
            // 
            this.deviceGroup3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.deviceGroup3.GroupName = null;
            this.deviceGroup3.GroupNumber = "Group3";
            this.deviceGroup3.HoverColor = System.Drawing.Color.Empty;
            this.deviceGroup3.Location = new System.Drawing.Point(3, 637);
            this.deviceGroup3.Margin = new System.Windows.Forms.Padding(3, 3, 3, 30);
            this.deviceGroup3.Name = "deviceGroup3";
            this.deviceGroup3.NomalColor = System.Drawing.Color.Empty;
            this.deviceGroup3.Number = 2;
            this.deviceGroup3.Size = new System.Drawing.Size(557, 41);
            this.deviceGroup3.TabIndex = 4;
            // 
            // deviceGroupButton3
            // 
            this.deviceGroupButton3.BackColor = System.Drawing.Color.Transparent;
            this.deviceGroupButton3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deviceGroupButton3.BackgroundImage")));
            this.deviceGroupButton3.GroupNumber = "Group3";
            this.deviceGroupButton3.HoverColor = System.Drawing.Color.WhiteSmoke;
            this.deviceGroupButton3.HoverImage = ((System.Drawing.Image)(resources.GetObject("deviceGroupButton3.HoverImage")));
            this.deviceGroupButton3.Location = new System.Drawing.Point(416, 140);
            this.deviceGroupButton3.Name = "deviceGroupButton3";
            this.deviceGroupButton3.NomalColor = System.Drawing.Color.WhiteSmoke;
            this.deviceGroupButton3.NomalImage = ((System.Drawing.Image)(resources.GetObject("deviceGroupButton3.NomalImage")));
            this.deviceGroupButton3.Size = new System.Drawing.Size(81, 42);
            this.deviceGroupButton3.TabIndex = 8;
            // 
            // deviceButton12
            // 
            this.deviceButton12.BackColor = System.Drawing.Color.Transparent;
            this.deviceButton12.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deviceButton12.BackgroundImage")));
            this.deviceButton12.ButtonNumber = "B4";
            this.deviceButton12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deviceButton12.FormName = null;
            this.deviceButton12.Group = 2;
            this.deviceButton12.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(255)))));
            this.deviceButton12.HoverImage = ((System.Drawing.Image)(resources.GetObject("deviceButton12.HoverImage")));
            this.deviceButton12.Index = 3;
            this.deviceButton12.Location = new System.Drawing.Point(322, 140);
            this.deviceButton12.Name = "deviceButton12";
            this.deviceButton12.NomalColor = System.Drawing.Color.WhiteSmoke;
            this.deviceButton12.NomalImage = ((System.Drawing.Image)(resources.GetObject("deviceButton12.NomalImage")));
            this.deviceButton12.Size = new System.Drawing.Size(81, 42);
            this.deviceButton12.SubName = null;
            this.deviceButton12.TabIndex = 7;
            // 
            // deviceButton11
            // 
            this.deviceButton11.BackColor = System.Drawing.Color.Transparent;
            this.deviceButton11.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deviceButton11.BackgroundImage")));
            this.deviceButton11.ButtonNumber = "B3";
            this.deviceButton11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deviceButton11.FormName = null;
            this.deviceButton11.Group = 2;
            this.deviceButton11.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(255)))));
            this.deviceButton11.HoverImage = ((System.Drawing.Image)(resources.GetObject("deviceButton11.HoverImage")));
            this.deviceButton11.Index = 2;
            this.deviceButton11.Location = new System.Drawing.Point(228, 140);
            this.deviceButton11.Name = "deviceButton11";
            this.deviceButton11.NomalColor = System.Drawing.Color.WhiteSmoke;
            this.deviceButton11.NomalImage = ((System.Drawing.Image)(resources.GetObject("deviceButton11.NomalImage")));
            this.deviceButton11.Size = new System.Drawing.Size(81, 42);
            this.deviceButton11.SubName = null;
            this.deviceButton11.TabIndex = 6;
            // 
            // deviceButton10
            // 
            this.deviceButton10.BackColor = System.Drawing.Color.Transparent;
            this.deviceButton10.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deviceButton10.BackgroundImage")));
            this.deviceButton10.ButtonNumber = "B2";
            this.deviceButton10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deviceButton10.FormName = null;
            this.deviceButton10.Group = 2;
            this.deviceButton10.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(255)))));
            this.deviceButton10.HoverImage = ((System.Drawing.Image)(resources.GetObject("deviceButton10.HoverImage")));
            this.deviceButton10.Index = 1;
            this.deviceButton10.Location = new System.Drawing.Point(134, 140);
            this.deviceButton10.Name = "deviceButton10";
            this.deviceButton10.NomalColor = System.Drawing.Color.WhiteSmoke;
            this.deviceButton10.NomalImage = ((System.Drawing.Image)(resources.GetObject("deviceButton10.NomalImage")));
            this.deviceButton10.Size = new System.Drawing.Size(81, 42);
            this.deviceButton10.SubName = null;
            this.deviceButton10.TabIndex = 5;
            // 
            // deviceButton9
            // 
            this.deviceButton9.BackColor = System.Drawing.Color.Transparent;
            this.deviceButton9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deviceButton9.BackgroundImage")));
            this.deviceButton9.ButtonNumber = "B1";
            this.deviceButton9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deviceButton9.FormName = null;
            this.deviceButton9.Group = 2;
            this.deviceButton9.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(255)))));
            this.deviceButton9.HoverImage = ((System.Drawing.Image)(resources.GetObject("deviceButton9.HoverImage")));
            this.deviceButton9.Index = 0;
            this.deviceButton9.Location = new System.Drawing.Point(40, 140);
            this.deviceButton9.Name = "deviceButton9";
            this.deviceButton9.NomalColor = System.Drawing.Color.WhiteSmoke;
            this.deviceButton9.NomalImage = ((System.Drawing.Image)(resources.GetObject("deviceButton9.NomalImage")));
            this.deviceButton9.Size = new System.Drawing.Size(81, 42);
            this.deviceButton9.SubName = null;
            this.deviceButton9.TabIndex = 4;
            // 
            // deviceEncoder12
            // 
            this.deviceEncoder12.BackColor = System.Drawing.Color.Transparent;
            this.deviceEncoder12.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deviceEncoder12.BackgroundImage")));
            this.deviceEncoder12.EncoderNumber = "D4";
            this.deviceEncoder12.FormName = null;
            this.deviceEncoder12.Group = 2;
            this.deviceEncoder12.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(255)))));
            this.deviceEncoder12.HoverImage = ((System.Drawing.Image)(resources.GetObject("deviceEncoder12.HoverImage")));
            this.deviceEncoder12.Index = 3;
            this.deviceEncoder12.LeftSubName = null;
            this.deviceEncoder12.Location = new System.Drawing.Point(413, 20);
            this.deviceEncoder12.Name = "deviceEncoder12";
            this.deviceEncoder12.NomalColor = System.Drawing.Color.WhiteSmoke;
            this.deviceEncoder12.NomalImage = ((System.Drawing.Image)(resources.GetObject("deviceEncoder12.NomalImage")));
            this.deviceEncoder12.RightSubName = null;
            this.deviceEncoder12.Size = new System.Drawing.Size(99, 99);
            this.deviceEncoder12.TabIndex = 3;
            // 
            // deviceEncoder11
            // 
            this.deviceEncoder11.BackColor = System.Drawing.Color.Transparent;
            this.deviceEncoder11.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deviceEncoder11.BackgroundImage")));
            this.deviceEncoder11.EncoderNumber = "D3";
            this.deviceEncoder11.FormName = null;
            this.deviceEncoder11.Group = 2;
            this.deviceEncoder11.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(255)))));
            this.deviceEncoder11.HoverImage = ((System.Drawing.Image)(resources.GetObject("deviceEncoder11.HoverImage")));
            this.deviceEncoder11.Index = 2;
            this.deviceEncoder11.LeftSubName = null;
            this.deviceEncoder11.Location = new System.Drawing.Point(282, 20);
            this.deviceEncoder11.Name = "deviceEncoder11";
            this.deviceEncoder11.NomalColor = System.Drawing.Color.WhiteSmoke;
            this.deviceEncoder11.NomalImage = ((System.Drawing.Image)(resources.GetObject("deviceEncoder11.NomalImage")));
            this.deviceEncoder11.RightSubName = null;
            this.deviceEncoder11.Size = new System.Drawing.Size(99, 99);
            this.deviceEncoder11.TabIndex = 2;
            // 
            // deviceEncoder10
            // 
            this.deviceEncoder10.BackColor = System.Drawing.Color.Transparent;
            this.deviceEncoder10.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deviceEncoder10.BackgroundImage")));
            this.deviceEncoder10.EncoderNumber = "D2";
            this.deviceEncoder10.FormName = null;
            this.deviceEncoder10.Group = 2;
            this.deviceEncoder10.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(255)))));
            this.deviceEncoder10.HoverImage = ((System.Drawing.Image)(resources.GetObject("deviceEncoder10.HoverImage")));
            this.deviceEncoder10.Index = 1;
            this.deviceEncoder10.LeftSubName = null;
            this.deviceEncoder10.Location = new System.Drawing.Point(151, 20);
            this.deviceEncoder10.Name = "deviceEncoder10";
            this.deviceEncoder10.NomalColor = System.Drawing.Color.WhiteSmoke;
            this.deviceEncoder10.NomalImage = ((System.Drawing.Image)(resources.GetObject("deviceEncoder10.NomalImage")));
            this.deviceEncoder10.RightSubName = null;
            this.deviceEncoder10.Size = new System.Drawing.Size(99, 99);
            this.deviceEncoder10.TabIndex = 1;
            // 
            // deviceEncoder9
            // 
            this.deviceEncoder9.BackColor = System.Drawing.Color.Transparent;
            this.deviceEncoder9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deviceEncoder9.BackgroundImage")));
            this.deviceEncoder9.EncoderNumber = "D1";
            this.deviceEncoder9.FormName = null;
            this.deviceEncoder9.Group = 2;
            this.deviceEncoder9.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(255)))));
            this.deviceEncoder9.HoverImage = ((System.Drawing.Image)(resources.GetObject("deviceEncoder9.HoverImage")));
            this.deviceEncoder9.Index = 0;
            this.deviceEncoder9.LeftSubName = null;
            this.deviceEncoder9.Location = new System.Drawing.Point(20, 20);
            this.deviceEncoder9.Name = "deviceEncoder9";
            this.deviceEncoder9.NomalColor = System.Drawing.Color.WhiteSmoke;
            this.deviceEncoder9.NomalImage = ((System.Drawing.Image)(resources.GetObject("deviceEncoder9.NomalImage")));
            this.deviceEncoder9.RightSubName = null;
            this.deviceEncoder9.Size = new System.Drawing.Size(99, 99);
            this.deviceEncoder9.TabIndex = 0;
            // 
            // deviceGroup4
            // 
            this.deviceGroup4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.deviceGroup4.GroupName = null;
            this.deviceGroup4.GroupNumber = "Group4";
            this.deviceGroup4.HoverColor = System.Drawing.Color.Empty;
            this.deviceGroup4.Location = new System.Drawing.Point(3, 954);
            this.deviceGroup4.Margin = new System.Windows.Forms.Padding(3, 3, 3, 30);
            this.deviceGroup4.Name = "deviceGroup4";
            this.deviceGroup4.NomalColor = System.Drawing.Color.Empty;
            this.deviceGroup4.Number = 3;
            this.deviceGroup4.Size = new System.Drawing.Size(557, 41);
            this.deviceGroup4.TabIndex = 6;
            // 
            // deviceGroupButton4
            // 
            this.deviceGroupButton4.BackColor = System.Drawing.Color.Transparent;
            this.deviceGroupButton4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deviceGroupButton4.BackgroundImage")));
            this.deviceGroupButton4.GroupNumber = "Group4";
            this.deviceGroupButton4.HoverColor = System.Drawing.Color.WhiteSmoke;
            this.deviceGroupButton4.HoverImage = ((System.Drawing.Image)(resources.GetObject("deviceGroupButton4.HoverImage")));
            this.deviceGroupButton4.Location = new System.Drawing.Point(416, 140);
            this.deviceGroupButton4.Name = "deviceGroupButton4";
            this.deviceGroupButton4.NomalColor = System.Drawing.Color.WhiteSmoke;
            this.deviceGroupButton4.NomalImage = ((System.Drawing.Image)(resources.GetObject("deviceGroupButton4.NomalImage")));
            this.deviceGroupButton4.Size = new System.Drawing.Size(81, 42);
            this.deviceGroupButton4.TabIndex = 8;
            // 
            // deviceButton16
            // 
            this.deviceButton16.BackColor = System.Drawing.Color.Transparent;
            this.deviceButton16.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deviceButton16.BackgroundImage")));
            this.deviceButton16.ButtonNumber = "B4";
            this.deviceButton16.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deviceButton16.FormName = null;
            this.deviceButton16.Group = 3;
            this.deviceButton16.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(255)))));
            this.deviceButton16.HoverImage = ((System.Drawing.Image)(resources.GetObject("deviceButton16.HoverImage")));
            this.deviceButton16.Index = 3;
            this.deviceButton16.Location = new System.Drawing.Point(322, 140);
            this.deviceButton16.Name = "deviceButton16";
            this.deviceButton16.NomalColor = System.Drawing.Color.WhiteSmoke;
            this.deviceButton16.NomalImage = ((System.Drawing.Image)(resources.GetObject("deviceButton16.NomalImage")));
            this.deviceButton16.Size = new System.Drawing.Size(81, 42);
            this.deviceButton16.SubName = null;
            this.deviceButton16.TabIndex = 7;
            // 
            // deviceButton15
            // 
            this.deviceButton15.BackColor = System.Drawing.Color.Transparent;
            this.deviceButton15.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deviceButton15.BackgroundImage")));
            this.deviceButton15.ButtonNumber = "B3";
            this.deviceButton15.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deviceButton15.FormName = null;
            this.deviceButton15.Group = 3;
            this.deviceButton15.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(255)))));
            this.deviceButton15.HoverImage = ((System.Drawing.Image)(resources.GetObject("deviceButton15.HoverImage")));
            this.deviceButton15.Index = 2;
            this.deviceButton15.Location = new System.Drawing.Point(228, 140);
            this.deviceButton15.Name = "deviceButton15";
            this.deviceButton15.NomalColor = System.Drawing.Color.WhiteSmoke;
            this.deviceButton15.NomalImage = ((System.Drawing.Image)(resources.GetObject("deviceButton15.NomalImage")));
            this.deviceButton15.Size = new System.Drawing.Size(81, 42);
            this.deviceButton15.SubName = null;
            this.deviceButton15.TabIndex = 6;
            // 
            // deviceButton14
            // 
            this.deviceButton14.BackColor = System.Drawing.Color.Transparent;
            this.deviceButton14.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deviceButton14.BackgroundImage")));
            this.deviceButton14.ButtonNumber = "B2";
            this.deviceButton14.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deviceButton14.FormName = null;
            this.deviceButton14.Group = 3;
            this.deviceButton14.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(255)))));
            this.deviceButton14.HoverImage = ((System.Drawing.Image)(resources.GetObject("deviceButton14.HoverImage")));
            this.deviceButton14.Index = 1;
            this.deviceButton14.Location = new System.Drawing.Point(134, 140);
            this.deviceButton14.Name = "deviceButton14";
            this.deviceButton14.NomalColor = System.Drawing.Color.WhiteSmoke;
            this.deviceButton14.NomalImage = ((System.Drawing.Image)(resources.GetObject("deviceButton14.NomalImage")));
            this.deviceButton14.Size = new System.Drawing.Size(81, 42);
            this.deviceButton14.SubName = null;
            this.deviceButton14.TabIndex = 5;
            // 
            // deviceButton13
            // 
            this.deviceButton13.BackColor = System.Drawing.Color.Transparent;
            this.deviceButton13.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deviceButton13.BackgroundImage")));
            this.deviceButton13.ButtonNumber = "B1";
            this.deviceButton13.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deviceButton13.FormName = null;
            this.deviceButton13.Group = 3;
            this.deviceButton13.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(255)))));
            this.deviceButton13.HoverImage = ((System.Drawing.Image)(resources.GetObject("deviceButton13.HoverImage")));
            this.deviceButton13.Index = 0;
            this.deviceButton13.Location = new System.Drawing.Point(40, 140);
            this.deviceButton13.Name = "deviceButton13";
            this.deviceButton13.NomalColor = System.Drawing.Color.WhiteSmoke;
            this.deviceButton13.NomalImage = ((System.Drawing.Image)(resources.GetObject("deviceButton13.NomalImage")));
            this.deviceButton13.Size = new System.Drawing.Size(81, 42);
            this.deviceButton13.SubName = null;
            this.deviceButton13.TabIndex = 4;
            // 
            // deviceEncoder16
            // 
            this.deviceEncoder16.BackColor = System.Drawing.Color.Transparent;
            this.deviceEncoder16.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deviceEncoder16.BackgroundImage")));
            this.deviceEncoder16.EncoderNumber = "D4";
            this.deviceEncoder16.FormName = null;
            this.deviceEncoder16.Group = 3;
            this.deviceEncoder16.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(255)))));
            this.deviceEncoder16.HoverImage = ((System.Drawing.Image)(resources.GetObject("deviceEncoder16.HoverImage")));
            this.deviceEncoder16.Index = 3;
            this.deviceEncoder16.LeftSubName = null;
            this.deviceEncoder16.Location = new System.Drawing.Point(413, 20);
            this.deviceEncoder16.Name = "deviceEncoder16";
            this.deviceEncoder16.NomalColor = System.Drawing.Color.WhiteSmoke;
            this.deviceEncoder16.NomalImage = ((System.Drawing.Image)(resources.GetObject("deviceEncoder16.NomalImage")));
            this.deviceEncoder16.RightSubName = null;
            this.deviceEncoder16.Size = new System.Drawing.Size(99, 99);
            this.deviceEncoder16.TabIndex = 3;
            // 
            // deviceEncoder15
            // 
            this.deviceEncoder15.BackColor = System.Drawing.Color.Transparent;
            this.deviceEncoder15.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deviceEncoder15.BackgroundImage")));
            this.deviceEncoder15.EncoderNumber = "D3";
            this.deviceEncoder15.FormName = null;
            this.deviceEncoder15.Group = 3;
            this.deviceEncoder15.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(255)))));
            this.deviceEncoder15.HoverImage = ((System.Drawing.Image)(resources.GetObject("deviceEncoder15.HoverImage")));
            this.deviceEncoder15.Index = 2;
            this.deviceEncoder15.LeftSubName = null;
            this.deviceEncoder15.Location = new System.Drawing.Point(282, 20);
            this.deviceEncoder15.Name = "deviceEncoder15";
            this.deviceEncoder15.NomalColor = System.Drawing.Color.WhiteSmoke;
            this.deviceEncoder15.NomalImage = ((System.Drawing.Image)(resources.GetObject("deviceEncoder15.NomalImage")));
            this.deviceEncoder15.RightSubName = null;
            this.deviceEncoder15.Size = new System.Drawing.Size(99, 99);
            this.deviceEncoder15.TabIndex = 2;
            // 
            // deviceEncoder14
            // 
            this.deviceEncoder14.BackColor = System.Drawing.Color.Transparent;
            this.deviceEncoder14.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deviceEncoder14.BackgroundImage")));
            this.deviceEncoder14.EncoderNumber = "D2";
            this.deviceEncoder14.FormName = null;
            this.deviceEncoder14.Group = 3;
            this.deviceEncoder14.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(255)))));
            this.deviceEncoder14.HoverImage = ((System.Drawing.Image)(resources.GetObject("deviceEncoder14.HoverImage")));
            this.deviceEncoder14.Index = 1;
            this.deviceEncoder14.LeftSubName = null;
            this.deviceEncoder14.Location = new System.Drawing.Point(151, 20);
            this.deviceEncoder14.Name = "deviceEncoder14";
            this.deviceEncoder14.NomalColor = System.Drawing.Color.WhiteSmoke;
            this.deviceEncoder14.NomalImage = ((System.Drawing.Image)(resources.GetObject("deviceEncoder14.NomalImage")));
            this.deviceEncoder14.RightSubName = null;
            this.deviceEncoder14.Size = new System.Drawing.Size(99, 99);
            this.deviceEncoder14.TabIndex = 1;
            // 
            // deviceEncoder13
            // 
            this.deviceEncoder13.BackColor = System.Drawing.Color.Transparent;
            this.deviceEncoder13.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deviceEncoder13.BackgroundImage")));
            this.deviceEncoder13.EncoderNumber = "D1";
            this.deviceEncoder13.FormName = null;
            this.deviceEncoder13.Group = 3;
            this.deviceEncoder13.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(255)))));
            this.deviceEncoder13.HoverImage = ((System.Drawing.Image)(resources.GetObject("deviceEncoder13.HoverImage")));
            this.deviceEncoder13.Index = 0;
            this.deviceEncoder13.LeftSubName = null;
            this.deviceEncoder13.Location = new System.Drawing.Point(20, 20);
            this.deviceEncoder13.Name = "deviceEncoder13";
            this.deviceEncoder13.NomalColor = System.Drawing.Color.WhiteSmoke;
            this.deviceEncoder13.NomalImage = ((System.Drawing.Image)(resources.GetObject("deviceEncoder13.NomalImage")));
            this.deviceEncoder13.RightSubName = null;
            this.deviceEncoder13.Size = new System.Drawing.Size(99, 99);
            this.deviceEncoder13.TabIndex = 0;
            // 
            // presetList
            // 
            this.presetList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.presetList.Location = new System.Drawing.Point(299, 194);
            this.presetList.MaximumSize = new System.Drawing.Size(182, 251);
            this.presetList.MinimumSize = new System.Drawing.Size(182, 0);
            this.presetList.Name = "presetList";
            this.presetList.Size = new System.Drawing.Size(182, 0);
            this.presetList.TabIndex = 26;
            // 
            // appList
            // 
            this.appList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.appList.Location = new System.Drawing.Point(89, 195);
            this.appList.MaximumSize = new System.Drawing.Size(182, 251);
            this.appList.MinimumSize = new System.Drawing.Size(182, 0);
            this.appList.Name = "appList";
            this.appList.Size = new System.Drawing.Size(182, 0);
            this.appList.TabIndex = 23;
            // 
            // presetBox
            // 
            this.presetBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.presetBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.presetBox.Location = new System.Drawing.Point(300, 137);
            this.presetBox.Name = "presetBox";
            this.presetBox.PresetName = "기본값";
            this.presetBox.Size = new System.Drawing.Size(183, 50);
            this.presetBox.TabIndex = 22;
            // 
            // appBox
            // 
            this.appBox.AppIconImage = global::Invaiz_Console.Properties.Resources.iconwin;
            this.appBox.AppName = "Window";
            this.appBox.BackColor = System.Drawing.Color.Transparent;
            this.appBox.Location = new System.Drawing.Point(86, 137);
            this.appBox.Name = "appBox";
            this.appBox.Size = new System.Drawing.Size(183, 50);
            this.appBox.TabIndex = 2;
            // 
            // mainKeypad
            // 
            this.mainKeypad.BackColor = System.Drawing.Color.Transparent;
            this.mainKeypad.Location = new System.Drawing.Point(58, 293);
            this.mainKeypad.Name = "mainKeypad";
            this.mainKeypad.Size = new System.Drawing.Size(476, 199);
            this.mainKeypad.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 800);
            this.Controls.Add(this.nav_area);
            this.Controls.Add(this.set_area);
            this.Controls.Add(this.main_area);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1280, 800);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Invaiz";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.main_area.ResumeLayout(false);
            this.main_area.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.set_area.ResumeLayout(false);
            this.set_area.PerformLayout();
            this.outpanel.ResumeLayout(false);
            this.deviceList.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.nav_area.ResumeLayout(false);
            this.nav_area.PerformLayout();
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel main_area;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel set_area;
        private System.Windows.Forms.Panel nav_area;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Component.MainKeypad mainKeypad;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label Presets;
        private System.Windows.Forms.Label Appliction;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel outpanel;
        public Component.AppList appList;
        public Component.AppBox appBox;
        public Component.PresetBox presetBox;
        public Component.PresetList presetList;
        public System.Windows.Forms.FlowLayoutPanel deviceList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label usbstate;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        public System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem presetItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        public System.Windows.Forms.Timer appTimer;
        public Component.DeviceGroup deviceGroup1;
        private System.Windows.Forms.Panel panel1;
        private Component.Device.DeviceGroupButton deviceGroupButton1;
        public Component.DeviceGroup deviceGroup2;
        private System.Windows.Forms.Panel panel2;
        private Component.Device.DeviceGroupButton deviceGroupButton2;
        public Component.DeviceGroup deviceGroup3;
        private System.Windows.Forms.Panel panel3;
        private Component.Device.DeviceGroupButton deviceGroupButton3;
        public Component.DeviceGroup deviceGroup4;
        private System.Windows.Forms.Panel panel7;
        private Component.Device.DeviceGroupButton deviceGroupButton4;
        public Component.DeviceButton deviceButton4;
        public Component.DeviceButton deviceButton3;
        public Component.DeviceButton deviceButton2;
        public Component.DeviceButton deviceButton1;
        public Component.DeviceEncoder deviceEncoder4;
        public Component.DeviceEncoder deviceEncoder3;
        public Component.DeviceEncoder deviceEncoder2;
        public Component.DeviceEncoder deviceEncoder1;
        public Component.DeviceButton deviceButton8;
        public Component.DeviceButton deviceButton7;
        public Component.DeviceButton deviceButton6;
        public Component.DeviceButton deviceButton5;
        public Component.DeviceEncoder deviceEncoder8;
        public Component.DeviceEncoder deviceEncoder7;
        public Component.DeviceEncoder deviceEncoder6;
        public Component.DeviceEncoder deviceEncoder5;
        public Component.DeviceButton deviceButton12;
        public Component.DeviceButton deviceButton11;
        public Component.DeviceButton deviceButton10;
        public Component.DeviceButton deviceButton9;
        public Component.DeviceEncoder deviceEncoder12;
        public Component.DeviceEncoder deviceEncoder11;
        public Component.DeviceEncoder deviceEncoder10;
        public Component.DeviceEncoder deviceEncoder9;
        public Component.DeviceButton deviceButton16;
        public Component.DeviceButton deviceButton15;
        public Component.DeviceButton deviceButton14;
        public Component.DeviceButton deviceButton13;
        public Component.DeviceEncoder deviceEncoder16;
        public Component.DeviceEncoder deviceEncoder15;
        public Component.DeviceEncoder deviceEncoder14;
        public Component.DeviceEncoder deviceEncoder13;
        public System.Windows.Forms.Timer presetTimer;
        public CustomControls.CustomScrollbar customScrollbar1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

