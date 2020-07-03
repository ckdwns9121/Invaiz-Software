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

        private void cancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
