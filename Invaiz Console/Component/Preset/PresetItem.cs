﻿using System;
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
    public partial class PresetItem : UserControl
    {
        private MainForm mn;
        public PresetItem()
        {
            InitializeComponent();
            this.modifyPreset.Visible = false;
        }
        public string PresetName
        {
            get { return this.preset_name.Text;}
            set { this.preset_name.Text = value; this.rename.Text = value; }
        }

        private void preset_name_MouseHover(object sender, EventArgs e)
        {
            this.preset_name.ForeColor = Color.FromArgb(245, 245, 245);
            this.BackColor = Color.FromArgb(153, 111, 204);
        }

        private void preset_name_MouseLeave(object sender, EventArgs e)
        {
            this.preset_name.ForeColor = Color.FromArgb(152, 152, 153);
            this.BackColor = Color.FromArgb(64, 64, 64);
        }

        private void preset_name_MouseMove(object sender, MouseEventArgs e)
        {
            this.preset_name.ForeColor = Color.FromArgb(245, 245, 245);
            this.BackColor = Color.FromArgb(153, 111, 204);
        }

        private void preset_name_MouseClick(object sender, MouseEventArgs e)
        {
            prevSavePreset();
            initUI();
            settingPreset();
            updateUI();
    
        }
        //이전 프리셋 저장
        private void prevSavePreset()
        {
            mn = MainForm.getInstance;
            Util.Preset preset = new Util.Preset();
            preset.savePreset(mn.PresetPath,mn.AppName,mn.PresetName);
        }

        //화면 초기화
        private void initUI()
        {
            mn = MainForm.getInstance;
            Util.Render render = new Util.Render();
            render.initUI();
            render.closeList();
        }
        
        //교체할 프리셋과 바인딩
        private void settingPreset()
        {
            mn = MainForm.getInstance;
            mn.PresetName = this.PresetName;
            Util.Preset preset = new Util.Preset();
            preset.settingPreset();
        }
        //교체할 프리셋 값으로 화면 업데이트
        private void updateUI()
        {
            Util.Render render = new Util.Render();
            render.updateUI();
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            mn = MainForm.getInstance;
            if (mn.PresetName.Equals(this.PresetName))
            {
                MessageBox.Show("현재 작업중인 프리셋은 삭제할 수 없습니다.");
            }
            else
            {
                Util.Preset preset = new Util.Preset();
                preset.deletePreset(this.PresetName);
                updateList(this.PresetName);

                if (mn.presetList.list.Height > 218)
                {
                    Console.WriteLine("스크롤 참" + mn.presetList.scrollPanel.Height);
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

        private void updateList(string presetName)
        {
            foreach (Control c in mn.presetList.list.Controls)
            {
                if (c is Component.PresetItem)
                {
                    Component.PresetItem presetItem = (Component.PresetItem)c;
                    if (presetItem.PresetName.Equals(presetName))
                    {
                        mn.presetList.list.Controls.Remove(presetItem);
                    }
                }
            }
        }
    }
}