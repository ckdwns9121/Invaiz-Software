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
    public partial class PresetBox : UserControl
    {
        private MainForm mn;
        public PresetBox()
        {
            InitializeComponent();
        }
        private string presetName;

        [Category("Custom"), Description("presetName")]
        public string PresetName
        {
            get { return this.presetName; }
            set { this.presetName = value; this.preset_name.Text = value; }
        }

        private void preset_name_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                //프로세스 리스트가 보여질때 꺼지게하는 코드.
                mn = MainForm.getInstance;
                mn.appList.Height = 0;
                mn.appListShow = false;

                mn.presetTimer.Start();

                foreach (Control c in mn.presetList.list.Controls)
                {
                    if (c is Component.PresetItem)
                    {
                        Component.PresetItem presetItem = (Component.PresetItem)c;
                        presetItem.modifyPreset.Visible = false;
                    }
                }

                if (mn.presetList.list.Height > 218)
                {
                    mn.presetList.customScrollbar1.Visible = true;
                    mn.presetList.customScrollbar1.Minimum = 0;
                    mn.presetList.customScrollbar1.Maximum = mn.presetList.scrollPanel.DisplayRectangle.Height;
                    mn.presetList.customScrollbar1.LargeChange = mn.presetList.customScrollbar1.Maximum / mn.presetList.customScrollbar1.Height + mn.presetList.scrollPanel.Height;
                    mn.presetList.customScrollbar1.SmallChange = 15;
                    mn.presetList.customScrollbar1.Value = Math.Abs(mn.presetList.AutoScrollPosition.Y);
                }
                else
                {
                    mn.presetList.customScrollbar1.Visible = false;

                }
            }
        }
    }
}
