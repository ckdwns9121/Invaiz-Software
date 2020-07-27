using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Remoting.Messaging;
using System.Runtime.CompilerServices;

namespace Invaiz_Studio.Component.Setting
{
    public partial class Overlay : UserControl
    {
    
        public Overlay()
        {
            InitializeComponent();

        }
        private bool toggle;
        private int location;
        private bool onlyShow;
        private int ol_second;

        public bool Toggle 
        {
            get { return this.toggle; }
            set { this.toggle = value; }
        }
        public int OL_Location
        {
            get { return this.location; }
            set { this.location = value; }
        }
        public bool OnlyShow
        {
            get { return this.onlyShow; }
            set { this.onlyShow = value; }
        }
        public int OL_Second
        {
            get { return this.ol_second; }
            set { this.ol_second = value; }
        }
 

        private void Overlay_Load(object sender, EventArgs e)
        {
            toggle = Properties.Settings.Default.OL_CHECK;
            location = Properties.Settings.Default.OL_LOCATION;
            onlyShow = Properties.Settings.Default.OL_SHOW;
            ol_second = Properties.Settings.Default.OL_SECOND;
            this.toggleBox.Image = (toggle) ? Properties.Resources.toggleon : Properties.Resources.toggleoff;
            this.secondBox.Text = ol_second.ToString();
            location_init();
            showToggle_init();
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                toggle = !toggle;
                this.toggleBox.Image = (toggle) ? Properties.Resources.toggleon : Properties.Resources.toggleoff;
            }
        }

        private void point1_MouseClick(object sender, MouseEventArgs e)
        {
            Button[] buttons = { point1, point2, point3, point4, point5, point6, point7, point8,point9 };
            Button param = sender as Button;
            int index  = Int32.Parse(param.Text.ToString())-1;
            for (int i = 0; i < buttons.Length; i++)
            {
                buttons[i].BackColor= Color.FromArgb(72, 80, 93);
            }
            buttons[index].BackColor = Color.FromArgb(0, 100, 255);
            location = index;
        }

        private void location_init()
        {
            Button[] buttons = { point1, point2, point3, point4, point5, point6, point7, point8, point9 };
            for (int i = 0; i < buttons.Length; i++)
            {
                buttons[i].BackColor = Color.FromArgb(72, 80, 93);
            }
            buttons[location].BackColor = Color.FromArgb(0, 100, 255);
        }
        private void showToggle_init()
        {
            if (!onlyShow)
            {
                showToggle.Image = Properties.Resources.selection;
                showToggle2.Image = Properties.Resources.selection_off;
                onlyShow = false;
            }
            else
            {
                showToggle.Image = Properties.Resources.selection_off;
                showToggle2.Image = Properties.Resources.selection;
                onlyShow = true;
            }
        }

        private void second_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.secondBox.Text = "";
            //숫자만 입력되도록 필터링
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))    //숫자와 백스페이스를 제외한 나머지를 바로 처리
            {
                e.Handled = true;
            }
  
  
        }

        private void showToggle_MouseClick(object sender, MouseEventArgs e)
        {
            PictureBox box = sender as PictureBox;
            Console.WriteLine(box.Name);
            if (box.Name.Equals("showToggle")){
                showToggle.Image = Properties.Resources.selection;
                showToggle2.Image = Properties.Resources.selection_off;
                onlyShow = false;
            }
            else
            {
                showToggle.Image = Properties.Resources.selection_off;
                showToggle2.Image = Properties.Resources.selection;
                onlyShow = true;
            }
        }

        private void secondBox_KeyUp(object sender, KeyEventArgs e)
        {

            if (this.secondBox.Text.ToString().Length != 0)
            {
                if (this.secondBox.Text.ToString().Equals("0"))
                {
                    Console.WriteLine("0이다");
                    this.secondBox.Text = "3";
                    ol_second = 3;
                    Console.WriteLine(ol_second + "초");
                }
                else
                {
                    ol_second = Int32.Parse(this.secondBox.Text.ToString());
                    Console.WriteLine(ol_second + "초");
                }
            }
            else
            {
                this.secondBox.Text = "3";
                ol_second = 3;
                Console.WriteLine(ol_second + "초");
            }
        }
    }
}
