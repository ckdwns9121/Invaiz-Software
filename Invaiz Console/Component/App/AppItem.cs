using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Invaiz_Console.Component
{
    public partial class AppItem : UserControl
    {
        private MainForm mn;
        public AppItem()
        {
            InitializeComponent();
        }
        private string appName;

        [Category("Custom"), Description("AppName")]

        public string AppName
        {
            get { return this.appName; }
            set { this.appName = value; this.app_name.Text = value; }
        }
        private Image appIcon;

        [Category("Custom"), Description("AppIcon")]

        public Image AppIcon
        {
            get { return this.appIcon;}
            set { this.appIcon = value; this.app_icon.Image = value; }
        }

        private void app_icon_MouseMove(object sender, MouseEventArgs e)
        {
            this.app_name.ForeColor = Color.FromArgb(245, 245, 245);
         //   this.BackColor = Color.FromArgb(153, 111, 204);
            this.BackColor = Color.FromArgb(51, 153, 255);

        }

        private void app_icon_MouseHover(object sender, EventArgs e)
        {
            this.app_name.ForeColor = Color.FromArgb(245, 245, 245);
            //this.BackColor = Color.FromArgb(153, 111, 204);
            this.BackColor = Color.FromArgb(51, 153, 255);

        }

        private void app_icon_MouseLeave(object sender, EventArgs e)
        {
            this.app_name.ForeColor = Color.FromArgb(152, 152, 153);
            this.BackColor = Color.FromArgb(64, 64, 64);
        }

        private void app_icon_MouseClick(object sender, MouseEventArgs e)
        {
            mn = MainForm.getInstance;
            if (!this.AppName.Equals("Window"))
            {
                Console.WriteLine("윈도우 아님");
                mn.windowCheck = false;
            }
            if (mn.AppName.Equals(this.AppName))
            {
                mn.appList.Height = 0;
                mn.appListShow = false;
                return;
            }
            else
            {
                this.savePrevPreset();
                this.initPayload(); //앱 초기화시 데이터 초기화
                this.initUI(); // 앱 초기화시 화면 초기화
                this.getPresets(); //프리셋 가져오기
                this.initGroup();
                this.updateUI(); //가져온 프리셋으로 재 렌더
            }
        }
        private void savePrevPreset()
        {
            Util.Preset preset = new Util.Preset();
            preset.savePreset(mn.PresetPath,mn.AppName,mn.PresetName);
        }
        private void initPayload()
        {
            for (int i = 0; i < mn.Payloads.Length; i++)
            {
                mn.Payloads[i] = new DeviceData.Payload();
            }
        }
        Util.ProcessId constValue = new Util.ProcessId();
        private void initUI()
        {
            
            mn.appBox.AppIconImage = this.AppIcon;
            mn.AppName = this.AppName;
            Util.Render render = new Util.Render();
            render.initUI();
            render.closeList();
            render.listValueInit();
        }
        private void getPresets()
        {
            mn = MainForm.getInstance;
            Util.Preset preset = new Util.Preset();
            preset.getPresetFiles();
        }

        private void updateUI()
        {
            Util.Render render = new Util.Render();
            render.updateUI();
        }
        private void initGroup()
        {
            mn = MainForm.getInstance;
            mn.CurrentGroup = 0;
        }
    }
}
