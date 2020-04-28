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
    public partial class AppList : UserControl
    {
        public AppList()
        {
            InitializeComponent();

            this.customScrollbar1.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.customScrollbar_MouseWheel);
            this.customScrollbar1.Scroll += new System.EventHandler(this.customScrollbar1_Scroll);
            this.app_list.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.ItemList_MouseWheel);
        }


        private void ItemList_MouseWheel(object sender, MouseEventArgs e)
        {

            try
            {
                customScrollbar1.Value = app_list.AutoScrollPosition.Y * -1;
                app_list.AutoScrollPosition = new Point(0, customScrollbar1.Value);

            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        private void customScrollbar1_Scroll(object sender, EventArgs e)
        {
            try
            {
                app_list.AutoScrollPosition = new Point(0, customScrollbar1.Value);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


        private void customScrollbar_MouseWheel(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Delta > 0)
                {
                    customScrollbar1.Value = (app_list.AutoScrollPosition.Y + 120) * -1;
                    Console.WriteLine("커스텀 스크롤 밸류 업" + (app_list.AutoScrollPosition.Y + 120) * -1);
                    app_list.AutoScrollPosition = new Point(0, customScrollbar1.Value);
                
                }
                else
                {
                    customScrollbar1.Value = (app_list.AutoScrollPosition.Y - 120) * -1;
                    Console.WriteLine("커스텀 스크롤 밸류 다운" + (app_list.AutoScrollPosition.Y - 120) * -1);
                    app_list.AutoScrollPosition = new Point(0, customScrollbar1.Value);
            
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        private void AppList_Load(object sender, EventArgs e)
        {
            this.customScrollbar1.Minimum = 0;
            this.customScrollbar1.Maximum = this.app_list.DisplayRectangle.Height;
            this.customScrollbar1.LargeChange = customScrollbar1.Maximum / customScrollbar1.Height + this.app_list.Height;
            this.customScrollbar1.SmallChange = 15;
            this.customScrollbar1.Value = Math.Abs(this.app_list.AutoScrollPosition.Y);
        }
    }
}
