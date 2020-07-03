using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Invaiz_Studio.Component
{
    public partial class PresetList : UserControl
    {
        private MainForm mn;
        public PresetList()
        {
            InitializeComponent();
            this.customScrollbar1.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.customScrollbar_MouseWheel);
            this.customScrollbar1.Scroll += new System.EventHandler(this.customScrollbar1_Scroll);
            this.scrollPanel.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.ItemList_MouseWheel);
        }

        private void pictureBox23_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mn = MainForm.getInstance;
                modifyPreset();
            }

        }
        private void modifyPreset()
        {
            foreach (Control c in mn.presetList.list.Controls)
            {
                if (c is Component.PresetItem)
                {
                    Component.PresetItem presetItem = (Component.PresetItem)c;
                    if (presetItem.modifyPreset.Visible)
                    {
                        presetItem.modifyPreset.Visible = false;
                    }
                    else
                    {
                        presetItem.rename.Text = presetItem.PresetName;
                        presetItem.modifyPreset.Visible = true;
                        presetItem.renameImg.Visible = true;
                        presetItem.checkImg.Visible = false;
                        Console.WriteLine(presetItem.PresetName + "의 포커스 : " + presetItem.ActiveControl);
                        presetItem.ActiveControl = null;
                        presetItem.rename.ReadOnly = false;
                    }
                }
            }
        }
        private void ItemList_MouseWheel(object sender, MouseEventArgs e)
        {

            try
            {
                customScrollbar1.Value = scrollPanel.AutoScrollPosition.Y * -1;
                scrollPanel.AutoScrollPosition = new Point(0, customScrollbar1.Value);

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
                scrollPanel.AutoScrollPosition = new Point(0, customScrollbar1.Value);

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
                    customScrollbar1.Value = (scrollPanel.AutoScrollPosition.Y + 120) * -1;
                    Console.WriteLine("커스텀 스크롤 밸류 업" + (list.AutoScrollPosition.Y + 120) * -1);
                    scrollPanel.AutoScrollPosition = new Point(0, customScrollbar1.Value);

                }
                else
                {
                    customScrollbar1.Value = (scrollPanel.AutoScrollPosition.Y - 120) * -1;
                    Console.WriteLine("커스텀 스크롤 밸류 다운" + (scrollPanel.AutoScrollPosition.Y - 120) * -1);
                    scrollPanel.AutoScrollPosition = new Point(0, customScrollbar1.Value);

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        private void PresetList_Load(object sender, EventArgs e)
        {
            this.customScrollbar1.Minimum = 0;
            this.customScrollbar1.Maximum = this.scrollPanel.DisplayRectangle.Height;
            this.customScrollbar1.LargeChange = customScrollbar1.Maximum / customScrollbar1.Height + this.scrollPanel.Height;
            this.customScrollbar1.SmallChange = 15;
            this.customScrollbar1.Value = Math.Abs(this.list.AutoScrollPosition.Y);
        }

        private void pictureBox22_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                View.NewPresetForm createPresetForm = new View.NewPresetForm();
                createPresetForm.ShowDialog();
            }
        }
    }
}
