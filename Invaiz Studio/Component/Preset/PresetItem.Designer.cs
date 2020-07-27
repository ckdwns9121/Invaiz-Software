namespace Invaiz_Studio.Component
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
            this.checkImg = new System.Windows.Forms.PictureBox();
            this.deleteImg = new System.Windows.Forms.PictureBox();
            this.renameImg = new System.Windows.Forms.PictureBox();
            this.rename = new System.Windows.Forms.TextBox();
            this.modifyPreset.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deleteImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.renameImg)).BeginInit();
            this.SuspendLayout();
            // 
            // preset_name
            // 
            this.preset_name.Cursor = System.Windows.Forms.Cursors.Hand;
            this.preset_name.Font = new System.Drawing.Font("Noto Sans CJK KR Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.preset_name.ForeColor = System.Drawing.Color.WhiteSmoke;
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
            this.modifyPreset.BackColor = System.Drawing.Color.Transparent;
            this.modifyPreset.Controls.Add(this.checkImg);
            this.modifyPreset.Controls.Add(this.deleteImg);
            this.modifyPreset.Controls.Add(this.renameImg);
            this.modifyPreset.Controls.Add(this.rename);
            this.modifyPreset.Location = new System.Drawing.Point(0, 0);
            this.modifyPreset.Margin = new System.Windows.Forms.Padding(0);
            this.modifyPreset.Name = "modifyPreset";
            this.modifyPreset.Size = new System.Drawing.Size(160, 35);
            this.modifyPreset.TabIndex = 2;
            // 
            // checkImg
            // 
            this.checkImg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkImg.Image = global::Invaiz_Studio.Properties.Resources.renamecheck;
            this.checkImg.Location = new System.Drawing.Point(112, 8);
            this.checkImg.Name = "checkImg";
            this.checkImg.Size = new System.Drawing.Size(20, 20);
            this.checkImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.checkImg.TabIndex = 3;
            this.checkImg.TabStop = false;
            this.checkImg.Visible = false;
            this.checkImg.MouseClick += new System.Windows.Forms.MouseEventHandler(this.checkImg_MouseClick);
            // 
            // deleteImg
            // 
            this.deleteImg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteImg.Image = global::Invaiz_Studio.Properties.Resources.presetdelete;
            this.deleteImg.Location = new System.Drawing.Point(136, 8);
            this.deleteImg.Name = "deleteImg";
            this.deleteImg.Size = new System.Drawing.Size(20, 20);
            this.deleteImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.deleteImg.TabIndex = 2;
            this.deleteImg.TabStop = false;
            this.deleteImg.MouseClick += new System.Windows.Forms.MouseEventHandler(this.deleteImg_MouseClick);
            // 
            // renameImg
            // 
            this.renameImg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.renameImg.Image = global::Invaiz_Studio.Properties.Resources.presetrename;
            this.renameImg.Location = new System.Drawing.Point(112, 8);
            this.renameImg.Name = "renameImg";
            this.renameImg.Size = new System.Drawing.Size(20, 20);
            this.renameImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.renameImg.TabIndex = 1;
            this.renameImg.TabStop = false;
            this.renameImg.MouseClick += new System.Windows.Forms.MouseEventHandler(this.renameImg_MouseClick);
            // 
            // rename
            // 
            this.rename.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(63)))), ((int)(((byte)(77)))));
            this.rename.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rename.Cursor = System.Windows.Forms.Cursors.Default;
            this.rename.Font = new System.Drawing.Font("Noto Sans CJK KR Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.rename.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rename.Location = new System.Drawing.Point(6, 6);
            this.rename.Name = "rename";
            this.rename.ReadOnly = true;
            this.rename.Size = new System.Drawing.Size(91, 24);
            this.rename.TabIndex = 0;
            this.rename.TabStop = false;
            this.rename.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rename_KeyDown);
            // 
            // PresetItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(70)))));
            this.Controls.Add(this.modifyPreset);
            this.Controls.Add(this.preset_name);
            this.Name = "PresetItem";
            this.Size = new System.Drawing.Size(160, 35);
            this.modifyPreset.ResumeLayout(false);
            this.modifyPreset.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deleteImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.renameImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label preset_name;
        private System.Windows.Forms.PictureBox deleteImg;
        public System.Windows.Forms.Panel modifyPreset;
        public System.Windows.Forms.PictureBox renameImg;
        public System.Windows.Forms.PictureBox checkImg;
        public System.Windows.Forms.TextBox rename;
    }
}
