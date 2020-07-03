using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Invaiz_Studio.Component.Device
{
    public partial class DeviceGroupButton : UserControl
    {
        public DeviceGroupButton()
        {
            InitializeComponent();
        }

        [Category("Custom"), Description("GroupNumber")]

        private string groupNumber;

        public string GroupNumber
        {
            get { return this.groupNumber; }
            set { this.groupNumber = value; this.form_name.Text = value; }
        }

        [Category("Custom"), Description("NomalColor")]

        private Color nomalColor;
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

        private void form_name_MouseMove(object sender, MouseEventArgs e)
        {
            this.form_name.ForeColor = this.HoverColor;
            this.BackgroundImage = this.HoverImage;
        }

        private void form_name_MouseLeave(object sender, EventArgs e)
        {
            this.form_name.ForeColor = this.NomalColor;
            this.BackgroundImage = this.NomalImage;
        }

        private void form_name_MouseHover(object sender, EventArgs e)
        {
            this.form_name.ForeColor = this.HoverColor;
            this.BackgroundImage = this.HoverImage;
        }
    }
}
