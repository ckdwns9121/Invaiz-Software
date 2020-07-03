using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Invaiz_Studio.Component
{
    public partial class DeviceButton : UserControl
    {
        private MainForm mn;
        public DeviceButton()
        {
            InitializeComponent();
        }

        public DeviceButton deepCopy(DeviceButton temp)
        {
            DeviceButton deviceButton = new DeviceButton();
            deviceButton.Index = temp.Index;
            deviceButton.Group = temp.Group;
            deviceButton.ButtonNumber = temp.ButtonNumber;

            return deviceButton;
        }
        [Category("Custom"), Description("Index")]

        private int index;

        public int Index
        {
            get { return this.index; }
            set { this.index = value; }
        }

        [Category("Custom"), Description("Group")]

        private int group;

        public int Group
        {
            get { return this.group; }
            set { this.group = value; }
        }


        [Category("Custom"), Description("ButtonNumber")]

        private string buttonNumber;

        public string ButtonNumber
        {
            get { return this.buttonNumber; }
            set { this.buttonNumber = value;}
        }

        [Category("Custom"), Description("FormName")]

        private string formName;

        public string FormName
        {
            get { return this.formName; }
            set { this.formName = value; this.form_name.Text = value; }
        }


        [Category("Custom"), Description("ButtonShotcut")]

        private string subName;

        public string SubName
        {
            get { return this.subName; }
            set { this.subName = value;  }
        }
        private Color nomalColor;

        [Category("Custom"), Description("NomalColor")]
        public Color NomalColor
        {
            get { return this.nomalColor; }
            set { this.nomalColor = value; }
        }

        private Color hoverColor;

        [Category("Custom"), Description("HoverColor")]
        public Color HoverColor
        {
            get { return this.hoverColor; }
            set { this.hoverColor = value; }
        }

        [Category("Custom"), Description("NomalImage")]

        private Image nomalImage;

        public Image NomalImage
        {
            get { return this.nomalImage; }
            set { this.nomalImage = value; }
        }
        [Category("Custom"), Description("HoverImage")]

        private Image hoverImage;
        public Image HoverImage
        {
            get { return this.hoverImage; }
            set { this.hoverImage = value; }
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            this.form_name.ForeColor = this.HoverColor;
            this.BackgroundImage = this.HoverImage;
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            this.form_name.ForeColor = this.nomalColor;
            this.BackgroundImage = this.NomalImage;

        }

        private void panel1_MouseHover(object sender, EventArgs e)
        {
            this.form_name.ForeColor = this.HoverColor;
            this.BackgroundImage = this.HoverImage;

        }
        public void init()
        {
            this.form_name.ForeColor = nomalColor;
            this.BackgroundImage = this.NomalImage;
            this.FormName = "";
            this.SubName = "";
        }
        public void update(string formName, string subName)
        {
            this.FormName = formName;
            this.SubName = subName;
        }



        private void form_name_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mn = MainForm.getInstance;
                mn.appList.Height = 0;
                mn.presetList.Height = 0;
                mn.appListShow = false;
                mn.presetIsShow = false;

                View.SettingForm settingForm = new View.SettingForm(false, this.group, this.index, this.buttonNumber, this.formName, this.subName, null);
                settingForm.ShowDialog();
            }
        }
    }
}
