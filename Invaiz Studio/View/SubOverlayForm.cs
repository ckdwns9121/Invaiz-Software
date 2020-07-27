using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Invaiz_Studio.View
{
    public partial class SubOverlayForm : Form
    {
        public SubOverlayForm()
        {
            InitializeComponent();
        }
        private Point mousePoint;
        private void label2_MouseDown(object sender, MouseEventArgs e)
        {
            mousePoint = new Point(e.X, e.Y);
        }

        private void label2_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                Location = new Point(this.Left - (mousePoint.X - e.X),
                    this.Top - (mousePoint.Y - e.Y));
            }
        }
        public void showGroup(int group , string groupName)
        {
            this.activeGroup.Text = "활성화그룹: "+groupName+"(Group"+ (group+1).ToString()+")";
        }
    }
}
