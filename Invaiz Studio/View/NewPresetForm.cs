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
    public partial class NewPresetForm : Form
    {
        private MainForm mn;
        public NewPresetForm()
        {
            InitializeComponent();
        }

        private const int CS_DropShaodw = 0x00020000;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle = CS_DropShaodw;
                return cp;
            }
        }


        protected override void OnPaintBackground(PaintEventArgs e)
        {
            using (SolidBrush brush = new SolidBrush(Color.FromArgb(70, 0, 0, 0)))
            {
                e.Graphics.FillRectangle(brush, e.ClipRectangle);
            }
        }
        private void cancle_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void create_button_Click(object sender, EventArgs e)
        {
            if (this.preset_name.Text == "")
            {
                MessageBox.Show("프리셋 이름을 입력해주세요.");
            }

            else if (this.preset_name.Text.Length >= 10)
            {
                MessageBox.Show("프리셋 이름이 너무 깁니다.");
            }
            else
            {
                if (createPreset())
                {
                    this.Close();
                }
                else
                {
                    MessageBox.Show("프리셋이 이미 존재합니다.");
                }
            }
        }
        private bool createPreset()
        {


            string currentFilePath = mn.PresetPath + @"\" + mn.AppName + @"\" + this.preset_name.Text + ".xml";
            if (System.IO.File.Exists(currentFilePath)) //파일 존재?
            {
                Console.WriteLine("파일이 존재합니다");
                return false;
            }

            mn = MainForm.getInstance;
            Util.Preset preset = new Util.Preset();
            Console.WriteLine(mn.PresetName + "을 저장합니다");
            preset.savePreset(mn.PresetPath,mn.AppName,mn.PresetName);

            Component.PresetItem presetItem = new Component.PresetItem();
            presetItem.PresetName = this.preset_name.Text;

            mn.PresetName = this.preset_name.Text;
           
            mn.presetList.list.Controls.Add(presetItem);

            Console.WriteLine(mn.PresetName + "을 생성합니다");
            preset.savePreset(mn.PresetPath, mn.AppName, mn.PresetName);

            //프리셋 생성한뒤 모든 데이터값 초기화;
            for(int i = 0; i < mn.Payloads.Length; i++)
            {
                mn.Payloads[i] = new DeviceData.Payload();
            }
            Util.MainRender render = new Util.MainRender();
            render.initUI();
            render.closeList();

            string appName = mn.AppName;

            switch (appName)
            {
                case "Window":
                    Properties.Settings.Default.WIN_PRESET = this.preset_name.Text;
                    break;
                case "Photoshop":
                    Properties.Settings.Default.PS_PRESET = this.preset_name.Text;
                    break;
                case "Illustrator":
                    Properties.Settings.Default.AI_PRESET = this.preset_name.Text;
                    break;
                case "AfterEffect":
                    Properties.Settings.Default.AE_PRESET = this.preset_name.Text;
                    break;
                case "PremierePro":
                    Properties.Settings.Default.PR_PRESET = this.preset_name.Text;
                    break;
                case "Lightroom":
                    Properties.Settings.Default.LR_PRESET = this.preset_name.Text;
                    break;
                case "InDesign":
                    Properties.Settings.Default.ID_PRESET = this.preset_name.Text;
                    break;
                default:
                    Properties.Settings.Default.Save();
                    break;
            }
            Properties.Settings.Default.Save();
            return true;
        }

        private void preset_name_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                createPreset();
                this.Close();
            }
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void CreatePresetForm_Load(object sender, EventArgs e)
        {
            mn = MainForm.getInstance;
            this.Location = mn.Location;
            this.newPreset.Top = (int)((this.Height - newPreset.Height) / 2);
            this.newPreset.Left = (int)((this.Width - newPreset.Width) / 2);

            this.ActiveControl = preset_name;
        }
    }
}
