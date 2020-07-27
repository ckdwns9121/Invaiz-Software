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
    public partial class General : Form
    {
        private MainForm mn;
        public General()
        {
            InitializeComponent();
        }
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            using (SolidBrush brush = new SolidBrush(Color.FromArgb(70, 0, 0, 0)))
            {
                e.Graphics.FillRectangle(brush, e.ClipRectangle);
            }
        }
        private void Gereral_Load(object sender, EventArgs e)
        {
            this.setform.Top = (int)((this.Height - setform.Height) / 2);
            this.setform.Left = (int)((this.Width - setform.Width) / 2);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void save_Click(object sender, EventArgs e)
        {
            mn = MainForm.getInstance;

            Console.WriteLine("저장");

            Console.WriteLine(overlay.Toggle);
            Properties.Settings.Default.OL_CHECK= overlay.Toggle ;
            Properties.Settings.Default.OL_LOCATION = overlay.OL_Location;
            Properties.Settings.Default.OL_SHOW = overlay.OnlyShow;
            Properties.Settings.Default.OL_SECOND = overlay.OL_Second;
            Properties.Settings.Default.Save();
            if (!Properties.Settings.Default.OL_CHECK)
            {
                mn.OverlayCheck();
            }
            mn.InitOverlayTimer();
            Console.WriteLine("마지막 확인"+overlay.Toggle);
     
            this.Close();
  
        }
    }
}
