namespace Invaiz_Studio.Component
{
    partial class AppItem
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
            this.app_name = new System.Windows.Forms.Label();
            this.app_icon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.app_icon)).BeginInit();
            this.SuspendLayout();
            // 
            // app_name
            // 
            this.app_name.BackColor = System.Drawing.Color.Transparent;
            this.app_name.Cursor = System.Windows.Forms.Cursors.Hand;
            this.app_name.Dock = System.Windows.Forms.DockStyle.Top;
            this.app_name.Font = new System.Drawing.Font("Noto Sans CJK KR Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.app_name.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.app_name.Location = new System.Drawing.Point(38, 0);
            this.app_name.Margin = new System.Windows.Forms.Padding(3, 1, 4, 0);
            this.app_name.Name = "app_name";
            this.app_name.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.app_name.Size = new System.Drawing.Size(122, 35);
            this.app_name.TabIndex = 4;
            this.app_name.Text = "Illustrator";
            this.app_name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.app_name.MouseClick += new System.Windows.Forms.MouseEventHandler(this.app_icon_MouseClick);
            this.app_name.MouseLeave += new System.EventHandler(this.app_icon_MouseLeave);
            this.app_name.MouseHover += new System.EventHandler(this.app_icon_MouseHover);
            this.app_name.MouseMove += new System.Windows.Forms.MouseEventHandler(this.app_icon_MouseMove);
            // 
            // app_icon
            // 
            this.app_icon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.app_icon.Dock = System.Windows.Forms.DockStyle.Left;
            this.app_icon.Image = global::Invaiz_Studio.Properties.Resources.iconai;
            this.app_icon.Location = new System.Drawing.Point(0, 0);
            this.app_icon.Name = "app_icon";
            this.app_icon.Size = new System.Drawing.Size(38, 35);
            this.app_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.app_icon.TabIndex = 3;
            this.app_icon.TabStop = false;
            this.app_icon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.app_icon_MouseClick);
            this.app_icon.MouseLeave += new System.EventHandler(this.app_icon_MouseLeave);
            this.app_icon.MouseHover += new System.EventHandler(this.app_icon_MouseHover);
            this.app_icon.MouseMove += new System.Windows.Forms.MouseEventHandler(this.app_icon_MouseMove);
            // 
            // AppItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(70)))));
            this.Controls.Add(this.app_name);
            this.Controls.Add(this.app_icon);
            this.Name = "AppItem";
            this.Size = new System.Drawing.Size(160, 35);
            ((System.ComponentModel.ISupportInitialize)(this.app_icon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label app_name;
        private System.Windows.Forms.PictureBox app_icon;
    }
}
