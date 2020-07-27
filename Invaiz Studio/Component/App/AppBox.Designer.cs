namespace Invaiz_Studio.Component
{
    partial class AppBox
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.app_icon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.app_icon)).BeginInit();
            this.SuspendLayout();
            // 
            // app_name
            // 
            this.app_name.Cursor = System.Windows.Forms.Cursors.Hand;
            this.app_name.Font = new System.Drawing.Font("Noto Sans CJK KR Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.app_name.ForeColor = System.Drawing.SystemColors.Window;
            this.app_name.Location = new System.Drawing.Point(49, 5);
            this.app_name.Name = "app_name";
            this.app_name.Size = new System.Drawing.Size(113, 40);
            this.app_name.TabIndex = 1;
            this.app_name.Text = "Photoshop";
            this.app_name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.app_name.MouseClick += new System.Windows.Forms.MouseEventHandler(this.app_icon_MouseClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Invaiz_Studio.Properties.Resources.showlist;
            this.pictureBox1.Location = new System.Drawing.Point(161, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.app_icon_MouseClick);
            // 
            // app_icon
            // 
            this.app_icon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.app_icon.Image = global::Invaiz_Studio.Properties.Resources.iconps;
            this.app_icon.Location = new System.Drawing.Point(3, 5);
            this.app_icon.Name = "app_icon";
            this.app_icon.Size = new System.Drawing.Size(40, 40);
            this.app_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.app_icon.TabIndex = 0;
            this.app_icon.TabStop = false;
            this.app_icon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.app_icon_MouseClick);
            // 
            // AppBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.app_name);
            this.Controls.Add(this.app_icon);
            this.Name = "AppBox";
            this.Size = new System.Drawing.Size(183, 50);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.app_icon_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.app_icon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox app_icon;
        private System.Windows.Forms.Label app_name;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
