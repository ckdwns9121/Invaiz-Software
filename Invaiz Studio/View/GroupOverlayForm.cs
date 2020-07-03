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

namespace Invaiz_Studio.View
{
    public partial class GroupOverlayForm : Form
    {
        private MainForm mn;
        public const int WS_EX_TRANSPARENT = 0x00000020;
        public const int GWL_EXSTYLE = (-20);
        public bool isShow = false;

        [DllImport("user32.dll")]
        public static extern int GetWindowLong(IntPtr hwnd, int index);

        [DllImport("user32.dll")]
        public static extern int SetWindowLong(IntPtr hwnd, int index, int newStyle);

        public GroupOverlayForm()
        {
            InitializeComponent();
            int initStyle = GetWindowLong(this.Handle, -20);
            SetWindowLong(this.Handle, -20, initStyle | 0x80000 | 0x20);
            this.TopMost = true;
        }

        public void ResetLocation()
        {
            int screenIndex = getScreenIndex();
            int screen_x = Screen.AllScreens[screenIndex].Bounds.X + (Screen.AllScreens[screenIndex].Bounds.Width / 2);
            int screen_y = Screen.AllScreens[screenIndex].Bounds.Y + Screen.AllScreens[screenIndex].Bounds.Height;
            Console.WriteLine(screen_x);
            this.Location = new Point(screen_x - this.Size.Width / 2
            , screen_y - this.Size.Height - 70);
        }

        private int getScreenIndex()
        {
            int screenIndex = 0;
            for (int i = 0; i < System.Windows.Forms.Screen.AllScreens.Length; i++)
            {
                int cursorPointx = Cursor.Position.X;
                int cursorPointy = Cursor.Position.Y;

                int startX = System.Windows.Forms.Screen.AllScreens[i].Bounds.X;
                int endX = startX + System.Windows.Forms.Screen.AllScreens[i].Bounds.Width;

                int startY = System.Windows.Forms.Screen.AllScreens[i].Bounds.Y;
                int endY = startY + System.Windows.Forms.Screen.AllScreens[i].Bounds.Height;
                if ((startX < cursorPointx && endX > cursorPointx) && (startY < cursorPointy && endY > cursorPointy))
                {
                    Console.WriteLine("디바이스 네임" + System.Windows.Forms.Screen.AllScreens[i].DeviceName);
                    Console.WriteLine("인덱스" + i);
                    Console.WriteLine(System.Windows.Forms.Screen.AllScreens[i].Bounds);
                    screenIndex = i;
                }
            }
            return screenIndex;

        }
        private void GroupChangeOverlayForm_Load(object sender, EventArgs e)
        {
            ResetLocation();
  
        }
        public void init(int index)
        {
            ResetLocation();
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
                labels[i].ForeColor = Color.FromArgb(0, 0, 0);
            }
            labels[index].BackColor = Color.FromArgb(54, 63, 77);
            labels[index].ForeColor = Color.FromArgb(245, 245, 245);

        }
    }
}
