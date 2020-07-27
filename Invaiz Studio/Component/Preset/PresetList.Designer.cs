namespace Invaiz_Studio.Component
{
    partial class PresetList
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox23 = new System.Windows.Forms.PictureBox();
            this.pictureBox22 = new System.Windows.Forms.PictureBox();
            this.customScrollbar1 = new CustomControls.CustomScrollbar();
            this.scrollPanel = new System.Windows.Forms.Panel();
            this.list = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox22)).BeginInit();
            this.scrollPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox23
            // 
            this.pictureBox23.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox23.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox23.Image = global::Invaiz_Studio.Properties.Resources.menu;
            this.pictureBox23.Location = new System.Drawing.Point(146, 220);
            this.pictureBox23.Name = "pictureBox23";
            this.pictureBox23.Size = new System.Drawing.Size(30, 30);
            this.pictureBox23.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox23.TabIndex = 18;
            this.pictureBox23.TabStop = false;
            this.pictureBox23.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox23_MouseClick);
            // 
            // pictureBox22
            // 
            this.pictureBox22.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox22.Image = global::Invaiz_Studio.Properties.Resources.presetadd;
            this.pictureBox22.Location = new System.Drawing.Point(115, 220);
            this.pictureBox22.Name = "pictureBox22";
            this.pictureBox22.Size = new System.Drawing.Size(30, 30);
            this.pictureBox22.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox22.TabIndex = 17;
            this.pictureBox22.TabStop = false;
            this.pictureBox22.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox22_MouseClick);
            // 
            // customScrollbar1
            // 
            this.customScrollbar1.ChannelColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.customScrollbar1.DownArrowImage = null;
            this.customScrollbar1.LargeChange = 10;
            this.customScrollbar1.Location = new System.Drawing.Point(173, 0);
            this.customScrollbar1.Maximum = 100;
            this.customScrollbar1.Minimum = 0;
            this.customScrollbar1.MinimumSize = new System.Drawing.Size(0, 218);
            this.customScrollbar1.Name = "customScrollbar1";
            this.customScrollbar1.Size = new System.Drawing.Size(5, 218);
            this.customScrollbar1.SmallChange = 1;
            this.customScrollbar1.TabIndex = 20;
            this.customScrollbar1.ThumbBottomImage = global::Invaiz_Studio.Properties.Resources.thunbspan;
            this.customScrollbar1.ThumbBottomSpanImage = global::Invaiz_Studio.Properties.Resources.thunbspan;
            this.customScrollbar1.ThumbHoverImage = null;
            this.customScrollbar1.ThumbMiddleImage = global::Invaiz_Studio.Properties.Resources.thumbmidle;
            this.customScrollbar1.ThumbNomalImage = null;
            this.customScrollbar1.ThumbTopImage = global::Invaiz_Studio.Properties.Resources.thunbspan;
            this.customScrollbar1.ThumbTopSpanImage = global::Invaiz_Studio.Properties.Resources.thunbspan;
            this.customScrollbar1.UpArrowImage = null;
            this.customScrollbar1.Value = 0;
            this.customScrollbar1.Visible = false;
            // 
            // scrollPanel
            // 
            this.scrollPanel.AutoScroll = true;
            this.scrollPanel.Controls.Add(this.list);
            this.scrollPanel.Location = new System.Drawing.Point(7, 0);
            this.scrollPanel.Name = "scrollPanel";
            this.scrollPanel.Size = new System.Drawing.Size(249, 218);
            this.scrollPanel.TabIndex = 19;
            // 
            // list
            // 
            this.list.AutoSize = true;
            this.list.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(42)))), ((int)(((byte)(51)))));
            this.list.Location = new System.Drawing.Point(0, 0);
            this.list.Margin = new System.Windows.Forms.Padding(0);
            this.list.MaximumSize = new System.Drawing.Size(188, 0);
            this.list.MinimumSize = new System.Drawing.Size(188, 218);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(188, 218);
            this.list.TabIndex = 0;
            // 
            // PresetList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(42)))), ((int)(((byte)(51)))));
            this.Controls.Add(this.customScrollbar1);
            this.Controls.Add(this.scrollPanel);
            this.Controls.Add(this.pictureBox23);
            this.Controls.Add(this.pictureBox22);
            this.Name = "PresetList";
            this.Size = new System.Drawing.Size(182, 251);
            this.Load += new System.EventHandler(this.PresetList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox22)).EndInit();
            this.scrollPanel.ResumeLayout(false);
            this.scrollPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox23;
        private System.Windows.Forms.PictureBox pictureBox22;
        public System.Windows.Forms.FlowLayoutPanel list;
        public CustomControls.CustomScrollbar customScrollbar1;
        public System.Windows.Forms.Panel scrollPanel;
    }
}
