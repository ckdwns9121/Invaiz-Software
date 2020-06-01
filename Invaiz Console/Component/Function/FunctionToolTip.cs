using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;

namespace Invaiz_Console.Component.Function
{
    public partial class FunctionToolTip : ToolTip
    {

        private int thisWidth = 0;
        private int thisHeight = 0;

        [System.Runtime.InteropServices.DllImport("User32.dll")]
        static extern bool MoveWindow(IntPtr h, int x, int y, int width, int height, bool redraw);
        private void toolTip1_Draw(object sender, DrawToolTipEventArgs e)
        {
            e.DrawBackground();
            e.DrawBorder();
            e.DrawText();
            var t = (ToolTip)sender;
            var h = t.GetType().GetProperty("Handle",
              System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            var handle = (IntPtr)h.GetValue(t);
            var c = e.AssociatedControl;
            var location = c.Parent.PointToScreen(new Point(c.Right - e.Bounds.Width, c.Bottom));
            MoveWindow(handle, location.X, location.Y, e.Bounds.Width, e.Bounds.Height, false);
        }

        public FunctionToolTip()
        {
            InitializeComponent();
            this.OwnerDraw = true;
            this.Popup += new PopupEventHandler(this.OnPopup);
            this.Draw += new DrawToolTipEventHandler(this.OnDraw);
        }
        private void OnPopup(object sender, PopupEventArgs e) // use this event to set the size of the tool tip
        {
            e.ToolTipSize = new Size(120, 60);
        }

        private void OnDraw(object sender, DrawToolTipEventArgs e) // use this event to customise the tool tip
        {

            System.Drawing.Font f = new System.Drawing.Font("Calibri", 12.0f);

            Graphics g = e.Graphics;
            Color myRgbColor = new Color();
            myRgbColor = Color.FromArgb(255, 47, 49, 46);
            LinearGradientBrush b = new LinearGradientBrush(e.Bounds,
                myRgbColor, myRgbColor, 45f);

            g.FillRectangle(b, e.Bounds);

            //Pen myPen = new Pen(Brushes.Red, 1);
            //myPen.LineJoin = System.Drawing.Drawing2D.LineJoin.Round;

            // g.DrawRectangle(myPen, new Rectangle(e.Bounds.X, e.Bounds.Y, e.Bounds.Width - 1, e.Bounds.Height - 1));

            //g.DrawString(e.ToolTipText, new Font(e.Font, FontStyle.Bold), Brushes.Black,
            //    new PointF(e.Bounds.X + 6, e.Bounds.Y + 6)); // shadow layer

                g.DrawString(e.ToolTipText, f, Brushes.White,
                   new PointF(e.Bounds.X + 10, e.Bounds.Y + 10)); // top layer


           
            var t = (ToolTip)sender;
            var h = t.GetType().GetProperty("Handle",
              System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            var handle = (IntPtr)h.GetValue(t);
            var c = e.AssociatedControl;
            var location = c.Parent.PointToScreen(new Point(c.Right - e.Bounds.Width, c.Bottom));
            MoveWindow(handle, location.X, location.Y, e.Bounds.Width, e.Bounds.Height, false);

            b.Dispose();
        }

        public void teset()
        {
            Console.WriteLine("툴팁생성");
        }
    }
}
