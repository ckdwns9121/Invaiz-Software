namespace Invaiz_Console.Component
{
    partial class DeviceGroup
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
            this.group_number = new System.Windows.Forms.Label();
            this.group_name = new System.Windows.Forms.Label();
            this.group_renameInput = new System.Windows.Forms.TextBox();
            this.group_rename = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rename_icon = new System.Windows.Forms.PictureBox();
            this.group_rename.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rename_icon)).BeginInit();
            this.SuspendLayout();
            // 
            // group_number
            // 
            this.group_number.Cursor = System.Windows.Forms.Cursors.Default;
            this.group_number.Font = new System.Drawing.Font("Calibri", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.group_number.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.group_number.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.group_number.Location = new System.Drawing.Point(0, 0);
            this.group_number.Name = "group_number";
            this.group_number.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.group_number.Size = new System.Drawing.Size(99, 40);
            this.group_number.TabIndex = 0;
            this.group_number.Text = "GROUP1";
            this.group_number.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.group_number.Click += new System.EventHandler(this.panel1_Click);
            this.group_number.MouseLeave += new System.EventHandler(this.panel1_MouseLeave);
            this.group_number.MouseHover += new System.EventHandler(this.panel1_MouseHover);
            this.group_number.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // group_name
            // 
            this.group_name.Cursor = System.Windows.Forms.Cursors.Default;
            this.group_name.Font = new System.Drawing.Font("Calibri", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.group_name.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.group_name.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.group_name.Location = new System.Drawing.Point(105, 0);
            this.group_name.Name = "group_name";
            this.group_name.Size = new System.Drawing.Size(336, 40);
            this.group_name.TabIndex = 1;
            this.group_name.Text = "브러쉬 그룹";
            this.group_name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.group_name.Click += new System.EventHandler(this.panel1_Click);
            this.group_name.MouseLeave += new System.EventHandler(this.panel1_MouseLeave);
            this.group_name.MouseHover += new System.EventHandler(this.panel1_MouseHover);
            this.group_name.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // group_renameInput
            // 
            this.group_renameInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.group_renameInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.group_renameInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.group_renameInput.Font = new System.Drawing.Font("Calibri", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.group_renameInput.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.group_renameInput.Location = new System.Drawing.Point(2, 5);
            this.group_renameInput.Name = "group_renameInput";
            this.group_renameInput.Size = new System.Drawing.Size(351, 20);
            this.group_renameInput.TabIndex = 4;
            this.group_renameInput.KeyUp += new System.Windows.Forms.KeyEventHandler(this.group_renameInput_KeyUp_1);
            // 
            // group_rename
            // 
            this.group_rename.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.group_rename.Controls.Add(this.group_renameInput);
            this.group_rename.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.group_rename.Location = new System.Drawing.Point(109, 5);
            this.group_rename.Name = "group_rename";
            this.group_rename.Size = new System.Drawing.Size(353, 30);
            this.group_rename.TabIndex = 5;
            this.group_rename.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(12, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(450, 1);
            this.panel1.TabIndex = 6;
            // 
            // rename_icon
            // 
            this.rename_icon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rename_icon.Dock = System.Windows.Forms.DockStyle.Right;
            this.rename_icon.Image = global::Invaiz_Console.Properties.Resources.group_on;
            this.rename_icon.Location = new System.Drawing.Point(517, 0);
            this.rename_icon.Name = "rename_icon";
            this.rename_icon.Size = new System.Drawing.Size(40, 41);
            this.rename_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.rename_icon.TabIndex = 3;
            this.rename_icon.TabStop = false;
            this.rename_icon.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // DeviceGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.group_rename);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.rename_icon);
            this.Controls.Add(this.group_name);
            this.Controls.Add(this.group_number);
            this.Name = "DeviceGroup";
            this.Size = new System.Drawing.Size(557, 41);
            this.group_rename.ResumeLayout(false);
            this.group_rename.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rename_icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label group_number;
        private System.Windows.Forms.Label group_name;
        private System.Windows.Forms.PictureBox rename_icon;
        private System.Windows.Forms.TextBox group_renameInput;
        private System.Windows.Forms.Panel group_rename;
        private System.Windows.Forms.Panel panel1;
    }
}
