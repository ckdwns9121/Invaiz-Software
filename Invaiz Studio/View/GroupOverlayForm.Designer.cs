namespace Invaiz_Studio.View
{
    partial class GroupOverlayForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupTitle = new System.Windows.Forms.Label();
            this.groupName4 = new System.Windows.Forms.Label();
            this.groupName3 = new System.Windows.Forms.Label();
            this.groupName2 = new System.Windows.Forms.Label();
            this.groupName1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupTitle
            // 
            this.groupTitle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupTitle.Font = new System.Drawing.Font("Noto Sans CJK KR Regular", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.groupTitle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupTitle.Location = new System.Drawing.Point(448, 0);
            this.groupTitle.Name = "groupTitle";
            this.groupTitle.Size = new System.Drawing.Size(112, 80);
            this.groupTitle.TabIndex = 9;
            this.groupTitle.Text = "label5";
            this.groupTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupName4
            // 
            this.groupName4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupName4.Font = new System.Drawing.Font("Noto Sans CJK KR Regular", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.groupName4.Location = new System.Drawing.Point(336, 0);
            this.groupName4.Name = "groupName4";
            this.groupName4.Size = new System.Drawing.Size(112, 80);
            this.groupName4.TabIndex = 8;
            this.groupName4.Text = "label4";
            this.groupName4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupName3
            // 
            this.groupName3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupName3.Font = new System.Drawing.Font("Noto Sans CJK KR Regular", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.groupName3.Location = new System.Drawing.Point(224, 0);
            this.groupName3.Name = "groupName3";
            this.groupName3.Size = new System.Drawing.Size(112, 80);
            this.groupName3.TabIndex = 7;
            this.groupName3.Text = "label3";
            this.groupName3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupName2
            // 
            this.groupName2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupName2.Font = new System.Drawing.Font("Noto Sans CJK KR Regular", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.groupName2.Location = new System.Drawing.Point(112, 0);
            this.groupName2.Name = "groupName2";
            this.groupName2.Size = new System.Drawing.Size(112, 80);
            this.groupName2.TabIndex = 6;
            this.groupName2.Text = "label2";
            this.groupName2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupName1
            // 
            this.groupName1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupName1.Font = new System.Drawing.Font("Noto Sans CJK KR Regular", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.groupName1.Location = new System.Drawing.Point(0, 0);
            this.groupName1.Name = "groupName1";
            this.groupName1.Size = new System.Drawing.Size(112, 80);
            this.groupName1.TabIndex = 5;
            this.groupName1.Text = "테스트";
            this.groupName1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupName4);
            this.panel1.Controls.Add(this.groupTitle);
            this.panel1.Controls.Add(this.groupName1);
            this.panel1.Controls.Add(this.groupName2);
            this.panel1.Controls.Add(this.groupName3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(560, 80);
            this.panel1.TabIndex = 10;
            // 
            // GroupOverlayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 80);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GroupOverlayForm";
            this.Opacity = 0.8D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GroupChangeOverlayForm";
            this.Load += new System.EventHandler(this.GroupChangeOverlayForm_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label groupTitle;
        public System.Windows.Forms.Label groupName4;
        public System.Windows.Forms.Label groupName3;
        public System.Windows.Forms.Label groupName2;
        public System.Windows.Forms.Label groupName1;
        private System.Windows.Forms.Panel panel1;
    }
}