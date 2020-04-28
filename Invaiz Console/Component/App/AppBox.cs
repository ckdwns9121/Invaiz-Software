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
    public partial class AppBox : UserControl
    {
        private MainForm mn;
        public AppBox()
        {
            InitializeComponent();
        }
        private Image appIconImage;

        [Category("Custom"), Description("appIcon")]
        public Image AppIconImage
        {
            get { return this.appIconImage; }
            set { this.appIconImage = value; this.app_icon.Image = value; }
        }

        private string appName;

        [Category("Custom"), Description("appName")]

        public string AppName
        {
            get {return this.appName; }
            set { this.appName = value; this.app_name.Text = value; }
        }

        private void app_icon_MouseClick(object sender, MouseEventArgs e)
        {
            // 프리셋 리스트가 보여지고 있을시 꺼지게 하기 위한 코드
            mn = MainForm.getInstance;
            mn.presetList.Height = 0;
            mn.presetIsShow = false;
            mn.appTimer.Start();

        }
    }
}
