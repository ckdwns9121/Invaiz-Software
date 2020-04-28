namespace Invaiz_Console.Component
{
    partial class PresetItem
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
            this.modifyPreset = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rename = new System.Windows.Forms.TextBox();
            this.modifyPreset.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // preset_name
            // 
            this.preset_name.Cursor = System.Windows.Forms.Cursors.Hand;
            this.preset_name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.preset_name.Font = new System.Drawing.Font("Calibri", 13.5F);
            this.preset_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(152)))), ((int)(((byte)(153)))));
            this.preset_name.Location = new System.Drawing.Point(0, 0);
            this.preset_name.Name = "preset_name";
            this.preset_name.Size = new System.Drawing.Size(160, 35);
            this.preset_name.TabIndex = 0;
            this.preset_name.Text = "기본값";
            this.preset_name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.preset_name.MouseClick += new System.Windows.Forms.MouseEventHandler(this.preset_name_MouseClick);
            this.preset_name.MouseLeave += new System.EventHandler(this.preset_name_MouseLeave);
            this.preset_name.MouseHover += new System.EventHandler(this.preset_name_MouseHover);
            this.preset_name.MouseMove += new System.Windows.Forms.MouseEventHandler(this.preset_name_MouseMove);
            // 
            // modifyPreset
            // 
            this.modifyPreset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.modifyPreset.Controls.Add(this.pictureBox2);
            this.modifyPreset.Controls.Add(this.pictureBox1);
            this.modifyPreset.Controls.Add(this.rename);
            this.modifyPreset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.modifyPreset.Location = new System.Drawing.Point(0, 0);
            this.modifyPreset.Margin = new System.Windows.Forms.Padding(0);
            this.modifyPreset.Name = "modifyPreset";
            this.modifyPreset.Size = new System.Drawing.Size(160, 35);
            this.modifyPreset.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::Invaiz_Console.Properties.Resources.presetdelete;
            this.pictureBox2.Location = new System.Drawing.Point(136, 8);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Invaiz_Console.Properties.Resources.presetrename;
            this.pictureBox1.Location = new System.Drawing.Point(112, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // rename
            // 
            this.rename.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.rename.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rename.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rename.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rename.Location = new System.Drawing.Point(6, 6);
            this.rename.Name = "rename";
            this.rename.ReadOnly = true;
            this.rename.Size = new System.Drawing.Size(91, 23);
            this.rename.TabIndex = 0;
            // 
            // PresetItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.modifyPreset);
            this.Controls.Add(this.preset_name);
            this.Name = "PresetItem";
            this.Size = new System.Drawing.Size(160, 35);
            this.modifyPreset.ResumeLayout(false);
            this.modifyPreset.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label preset_name;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox rename;
        public System.Windows.Forms.Panel modifyPreset;
    }
}
