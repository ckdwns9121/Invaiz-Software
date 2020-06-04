using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Invaiz_Console.Component
{
    public partial class DeviceEncoder : UserControl
    {

        private MainForm mn;
        public DeviceEncoder()
        {
            InitializeComponent();
           // this.tip = new Component.Function.FunctionToolTip();
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



        [Category("Custom"), Description("EncoderNumber")]
        
        private string encoderNumber;
        public string EncoderNumber
        {
            get { return this.encoderNumber; }
            set { this.encoderNumber = value;}
        }
        [Category("Custom"), Description("FormName")]

        private string formName;
        public string FormName
        {
            get { return this.formName; }
            set { this.formName = value; this.form_name.Text = value; }
        }

        [Category("Custom"), Description("RotateLeft")]

        private string leftSubName;

        public string LeftSubName
        {
            get { return this.leftSubName; }
            set { this.leftSubName = value;  }
        }


        [Category("Custom"), Description("RotateRight")]

        private string rightSubName;

        public string RightSubName
        {
            get { return this.rightSubName; }
            set { this.rightSubName = value;}
        }

        [Category("Custom"), Description("HoverColor")]

        private Color hoverColor;

        public Color HoverColor
        {
            get { return this.hoverColor; }
            set { this.hoverColor = value; }
        }

        [Category("Custom"), Description("NomalColor")]

        private Color nomalColor;

        public Color NomalColor
        {
            get { return this.nomalColor; }
            set { this.nomalColor = value; }
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

        private void panel1_MouseHover(object sender, EventArgs e)
        {
            mn = MainForm.getInstance;

            this.form_name.ForeColor = this.HoverColor;
            this.BackgroundImage = this.HoverImage;
         //   this.tip = new Component.Function.FunctionToolTip(mn.Payloads[group].E_leftSubName[index].Length , 60);
           // if (mn.Payloads[group].E_leftSubName[index].Length != 0)
            //{
              //  this.tip.SetToolTip(this.form_name, "CCW: " + mn.Payloads[group].E_leftSubName[index] + "\n" + "CW: " + mn.Payloads[group].E_rightSubName[index]);
            //}
          //  this.tip.teset();
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            this.form_name.ForeColor = this.NomalColor;
            this.BackgroundImage = this.NomalImage;

        }

        public void init()
        {
            this.form_name.ForeColor = NomalColor;
            this.BackgroundImage = NomalImage;
            this.FormName = "";
            this.LeftSubName = "";
            this.RightSubName = "";
        }
        public void update(string formName, string rotateLeft, string rotateRight) 
        {
            this.FormName = formName;
            this.LeftSubName = rotateLeft;
            this.RightSubName = rotateRight;
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            mn = MainForm.getInstance;
            mn.appList.Height = 0;
            mn.presetList.Height = 0;
            mn.appListShow = false;
            mn.presetIsShow = false;
            View.SettingForm settingForm = new View.SettingForm(true, this.group, this.index, this.encoderNumber, this.formName, this.leftSubName, this.rightSubName);
            settingForm.ShowDialog();
        }
    }
}
