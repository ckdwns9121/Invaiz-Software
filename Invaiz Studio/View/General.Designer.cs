namespace Invaiz_Studio.View
{
    partial class General
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
            this.setform = new System.Windows.Forms.Panel();
            this.set_title = new System.Windows.Forms.Label();
            this.cancle = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.setform.SuspendLayout();
            this.panel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // setform
            // 
            this.setform.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.setform.Controls.Add(this.flowLayoutPanel1);
            this.setform.Controls.Add(this.panel3);
            this.setform.Controls.Add(this.panel2);
            this.setform.Controls.Add(this.set_title);
            this.setform.Location = new System.Drawing.Point(0, 0);
            this.setform.Name = "setform";
            this.setform.Size = new System.Drawing.Size(1000, 660);
            this.setform.TabIndex = 103;
            // 
            // set_title
            // 
            this.set_title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.set_title.Dock = System.Windows.Forms.DockStyle.Top;
            this.set_title.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.set_title.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.set_title.Location = new System.Drawing.Point(0, 0);
            this.set_title.Name = "set_title";
            this.set_title.Padding = new System.Windows.Forms.Padding(45, 0, 0, 0);
            this.set_title.Size = new System.Drawing.Size(1000, 60);
            this.set_title.TabIndex = 1;
            this.set_title.Text = "설정 및 옵션";
            this.set_title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cancle
            // 
            this.cancle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(63)))), ((int)(((byte)(77)))));
            this.cancle.FlatAppearance.BorderSize = 0;
            this.cancle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancle.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cancle.Location = new System.Drawing.Point(504, 27);
            this.cancle.Name = "cancle";
            this.cancle.Size = new System.Drawing.Size(140, 40);
            this.cancle.TabIndex = 3;
            this.cancle.Text = "Cancle";
            this.cancle.UseVisualStyleBackColor = false;
            this.cancle.Click += new System.EventHandler(this.cancle_Click);
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(255)))));
            this.save.FlatAppearance.BorderSize = 0;
            this.save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.save.Location = new System.Drawing.Point(650, 27);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(140, 40);
            this.save.TabIndex = 2;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.panel2.Controls.Add(this.save);
            this.panel2.Controls.Add(this.cancle);
            this.panel2.Location = new System.Drawing.Point(177, 568);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(823, 92);
            this.panel2.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.panel3.Location = new System.Drawing.Point(177, 63);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(823, 507);
            this.panel3.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 47);
            this.button1.TabIndex = 0;
            this.button1.Text = "오버레이 설정";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button2.Location = new System.Drawing.Point(3, 109);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(172, 47);
            this.button2.TabIndex = 1;
            this.button2.Text = "언어 설정";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button5.Location = new System.Drawing.Point(3, 56);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(172, 47);
            this.button5.TabIndex = 2;
            this.button5.Text = "버전 정보";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Controls.Add(this.button5);
            this.flowLayoutPanel1.Controls.Add(this.button2);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 63);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(171, 593);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // General
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(1280, 800);
            this.Controls.Add(this.setform);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "General";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Gereral";
            this.Load += new System.EventHandler(this.Gereral_Load);
            this.setform.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel setform;
        private System.Windows.Forms.Label set_title;
        private System.Windows.Forms.Button cancle;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}