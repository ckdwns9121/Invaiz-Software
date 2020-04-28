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
    public partial class DeviceGroup : UserControl
    {
        private MainForm mn;
        public DeviceGroup()
        {
            InitializeComponent();
        }

        [Category("Custom"), Description("Number")]

        private int number;

        public int Number
        {
            get { return this.number; }
            set { this.number = value; }
        }

        private string groupNumber;

        [Category("Custom"), Description("GroupNumber")]

        public string GroupNumber
        {
            get { return this.groupNumber; }
            set { this.groupNumber = value; this.group_number.Text = value; }
        }

        private string groupName;

        [Category("Custom"), Description("GroupName")]
        public string GroupName
        {
            get { return this.groupName; }
            set { this.groupName = value; this.group_name.Text = value; this.group_renameInput.Text = value; }
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
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            this.BackColor = this.HoverColor;
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = this.NomalColor;

        }

        private void panel1_MouseHover(object sender, EventArgs e)
        {
            this.BackColor = this.HoverColor;
        }

        public void init()
        {
            this.BackColor = NomalColor;
            this.GroupName = "";
        }
        public void update(string groupName)
        {
            this.GroupName = groupName;
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            mn = MainForm.getInstance;
            mn.appList.Height = 0;
            mn.presetList.Height = 0;
            mn.appListShow = false;
            mn.presetIsShow = false;
        }

        private bool rename = false;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            mn = MainForm.getInstance;
            mn.appList.Height = 0;
            mn.presetList.Height = 0;
            mn.appListShow = false;
            mn.presetIsShow = false;

            if (!rename)
            {
                rename_icon.Image = Invaiz_Console.Properties.Resources.group_off;
                this.group_rename.Visible = true;
                this.ActiveControl = group_renameInput;

            }
            else if (rename)
            {
                rename_icon.Image = Invaiz_Console.Properties.Resources.group_on;
                this.GroupName = group_renameInput.Text;
                mn.Payloads[Number].groupName = this.GroupName;
                this.group_rename.Visible = false;
            }
            rename = !rename;
        }

        private void group_renameInput_KeyUp_1(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                rename_icon.Image = Invaiz_Console.Properties.Resources.group_on;
                this.GroupName = group_renameInput.Text;
                mn.Payloads[Number].groupName = this.GroupName;
                this.group_rename.Visible = false;
                rename = !rename;
            }
        }
    }

}
