namespace Invaiz_Studio.Component
{
    partial class AppList
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.app_list = new System.Windows.Forms.FlowLayoutPanel();
            this.appItem1 = new Invaiz_Studio.Component.AppItem();
            this.appItem2 = new Invaiz_Studio.Component.AppItem();
            this.appItem3 = new Invaiz_Studio.Component.AppItem();
            this.appItem4 = new Invaiz_Studio.Component.AppItem();
            this.appItem5 = new Invaiz_Studio.Component.AppItem();
            this.appItem6 = new Invaiz_Studio.Component.AppItem();
            this.appItem7 = new Invaiz_Studio.Component.AppItem();
            this.customScrollbar1 = new CustomControls.CustomScrollbar();
            this.appItem8 = new Invaiz_Studio.Component.AppItem();
            this.panel1.SuspendLayout();
            this.app_list.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.app_list);
            this.panel1.Location = new System.Drawing.Point(7, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(170, 218);
            this.panel1.TabIndex = 2;
            // 
            // app_list
            // 
            this.app_list.AutoScroll = true;
            this.app_list.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.app_list.Controls.Add(this.appItem1);
            this.app_list.Controls.Add(this.appItem2);
            this.app_list.Controls.Add(this.appItem3);
            this.app_list.Controls.Add(this.appItem4);
            this.app_list.Controls.Add(this.appItem5);
            this.app_list.Controls.Add(this.appItem6);
            this.app_list.Controls.Add(this.appItem7);
            this.app_list.Controls.Add(this.appItem8);
            this.app_list.Location = new System.Drawing.Point(0, 0);
            this.app_list.Margin = new System.Windows.Forms.Padding(0);
            this.app_list.MaximumSize = new System.Drawing.Size(188, 0);
            this.app_list.MinimumSize = new System.Drawing.Size(188, 218);
            this.app_list.Name = "app_list";
            this.app_list.Size = new System.Drawing.Size(188, 218);
            this.app_list.TabIndex = 0;
            // 
            // appItem1
            // 
            this.appItem1.AppIcon = global::Invaiz_Studio.Properties.Resources.iconwin;
            this.appItem1.AppName = "Window";
            this.appItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.appItem1.Location = new System.Drawing.Point(3, 3);
            this.appItem1.Name = "appItem1";
            this.appItem1.Size = new System.Drawing.Size(160, 35);
            this.appItem1.TabIndex = 0;
            // 
            // appItem2
            // 
            this.appItem2.AppIcon = global::Invaiz_Studio.Properties.Resources.iconps;
            this.appItem2.AppName = "Photoshop";
            this.appItem2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.appItem2.Location = new System.Drawing.Point(3, 44);
            this.appItem2.Name = "appItem2";
            this.appItem2.Size = new System.Drawing.Size(160, 35);
            this.appItem2.TabIndex = 1;
            // 
            // appItem3
            // 
            this.appItem3.AppIcon = global::Invaiz_Studio.Properties.Resources.iconai;
            this.appItem3.AppName = "Illustrator";
            this.appItem3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.appItem3.Location = new System.Drawing.Point(3, 85);
            this.appItem3.Name = "appItem3";
            this.appItem3.Size = new System.Drawing.Size(160, 35);
            this.appItem3.TabIndex = 2;
            // 
            // appItem4
            // 
            this.appItem4.AppIcon = global::Invaiz_Studio.Properties.Resources.iconae;
            this.appItem4.AppName = "AfterEffect";
            this.appItem4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.appItem4.Location = new System.Drawing.Point(3, 126);
            this.appItem4.Name = "appItem4";
            this.appItem4.Size = new System.Drawing.Size(160, 35);
            this.appItem4.TabIndex = 3;
            // 
            // appItem5
            // 
            this.appItem5.AppIcon = global::Invaiz_Studio.Properties.Resources.iconpr;
            this.appItem5.AppName = "PremierePro";
            this.appItem5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.appItem5.Location = new System.Drawing.Point(3, 167);
            this.appItem5.Name = "appItem5";
            this.appItem5.Size = new System.Drawing.Size(160, 35);
            this.appItem5.TabIndex = 4;
            // 
            // appItem6
            // 
            this.appItem6.AppIcon = global::Invaiz_Studio.Properties.Resources.iconlr;
            this.appItem6.AppName = "Lightroom";
            this.appItem6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.appItem6.Location = new System.Drawing.Point(3, 208);
            this.appItem6.Name = "appItem6";
            this.appItem6.Size = new System.Drawing.Size(160, 35);
            this.appItem6.TabIndex = 5;
            // 
            // appItem7
            // 
            this.appItem7.AppIcon = global::Invaiz_Studio.Properties.Resources.iconid;
            this.appItem7.AppName = "InDesign";
            this.appItem7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.appItem7.Location = new System.Drawing.Point(3, 249);
            this.appItem7.Name = "appItem7";
            this.appItem7.Size = new System.Drawing.Size(160, 35);
            this.appItem7.TabIndex = 6;
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
            this.customScrollbar1.TabIndex = 3;
            this.customScrollbar1.ThumbBottomImage = global::Invaiz_Studio.Properties.Resources.thunbspan;
            this.customScrollbar1.ThumbBottomSpanImage = global::Invaiz_Studio.Properties.Resources.thunbspan;
            this.customScrollbar1.ThumbHoverImage = null;
            this.customScrollbar1.ThumbMiddleImage = global::Invaiz_Studio.Properties.Resources.thumbmidle;
            this.customScrollbar1.ThumbNomalImage = null;
            this.customScrollbar1.ThumbTopImage = global::Invaiz_Studio.Properties.Resources.thunbspan;
            this.customScrollbar1.ThumbTopSpanImage = global::Invaiz_Studio.Properties.Resources.thunbspan;
            this.customScrollbar1.UpArrowImage = null;
            this.customScrollbar1.Value = 0;
            // 
            // appItem8
            // 
            this.appItem8.AppIcon = null;
            this.appItem8.AppName = "ClipStudio";
            this.appItem8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.appItem8.Location = new System.Drawing.Point(3, 290);
            this.appItem8.Name = "appItem8";
            this.appItem8.Size = new System.Drawing.Size(160, 35);
            this.appItem8.TabIndex = 7;
            // 
            // AppList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.Controls.Add(this.customScrollbar1);
            this.Controls.Add(this.panel1);
            this.Name = "AppList";
            this.Size = new System.Drawing.Size(182, 251);
            this.Load += new System.EventHandler(this.AppList_Load);
            this.panel1.ResumeLayout(false);
            this.app_list.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private AppItem appItem1;
        private AppItem appItem2;
        private AppItem appItem3;
        private AppItem appItem4;
        public System.Windows.Forms.FlowLayoutPanel app_list;
        private AppItem appItem5;
        private AppItem appItem6;
        private AppItem appItem7;
        public CustomControls.CustomScrollbar customScrollbar1;
        private AppItem appItem8;
    }
}
