namespace Invaiz_Studio.Component
{
    partial class PresetBox
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
            this.preset_name = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // preset_name
            // 
            this.preset_name.Cursor = System.Windows.Forms.Cursors.Hand;
            this.preset_name.Font = new System.Drawing.Font("Calibri", 15F);
            this.preset_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(152)))), ((int)(((byte)(153)))));
            this.preset_name.Location = new System.Drawing.Point(0, 0);
            this.preset_name.Name = "preset_name";
            this.preset_name.Size = new System.Drawing.Size(131, 50);
            this.preset_name.TabIndex = 0;
            this.preset_name.Text = "기본값";
            this.preset_name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.preset_name.MouseClick += new System.Windows.Forms.MouseEventHandler(this.preset_name_MouseClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Invaiz_Studio.Properties.Resources.showlist;
            this.pictureBox1.Location = new System.Drawing.Point(164, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(10, 8);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.preset_name_MouseClick);
            // 
            // PresetBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.preset_name);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "PresetBox";
            this.Size = new System.Drawing.Size(183, 50);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.preset_name_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label preset_name;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
