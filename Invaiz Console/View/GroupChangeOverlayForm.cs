using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Invaiz_Console.View
{
    public partial class GroupChangeOverlayForm : Form
    {
        private MainForm mn;
        public const int WS_EX_TRANSPARENT = 0x00000020;
        public const int GWL_EXSTYLE = (-20);
        public bool isShow = false;

        [DllImport("user32.dll")]
        public static extern int GetWindowLong(IntPtr hwnd, int index);

        [DllImport("user32.dll")]
        public static extern int SetWindowLong(IntPtr hwnd, int index, int newStyle);

        public GroupChangeOverlayForm()
        {
            InitializeComponent();
            int initStyle = GetWindowLong(this.Handle, -20);
            SetWindowLong(this.Handle, -20, initStyle | 0x80000 | 0x20);
            this.TopMost = true;
        }

        private void GroupChangeOverlayForm_Load(object sender, EventArgs e)
        {

            this.Location = new Point(Screen.PrimaryScreen.Bounds.Width / 2 - this.Size.Width / 2
            , Screen.PrimaryScreen.Bounds.Height - this.Size.Height - 70);
        }
        public void init(int index)
        {
            mn = MainForm.getInstance;

            this.groupName1.Text = mn.Payloads[0].groupName;
            this.groupName2.Text = mn.Payloads[1].groupName;
            this.groupName3.Text = mn.Payloads[2].groupName;
            this.groupName4.Text = mn.Payloads[3].groupName;
            this.groupTitle.Text = "그룹 변경";

            Label[] labels = { this.groupName1, this.groupName2, this.groupName3, this.groupName4, this.groupTitle };
            for(int i = 0; i < labels.Length; i++)
            {
                labels[i].BackColor = Color.FromArgb(245, 245, 245);
            }
            labels[index].BackColor = Color.FromArgb(54, 63, 77);

        }
    }
}
