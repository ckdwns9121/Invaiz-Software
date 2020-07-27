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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.save = new System.Windows.Forms.Button();
            this.set_title = new System.Windows.Forms.Label();
            this.overlay = new Invaiz_Studio.Component.Setting.Overlay();
            this.setform.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // setform
            // 
            this.setform.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(42)))), ((int)(((byte)(51)))));
            this.setform.Controls.Add(this.pictureBox1);
            this.setform.Controls.Add(this.flowLayoutPanel1);
            this.setform.Controls.Add(this.panel3);
            this.setform.Controls.Add(this.panel2);
            this.setform.Controls.Add(this.set_title);
            this.setform.Location = new System.Drawing.Point(0, 0);
            this.setform.Name = "setform";
            this.setform.Size = new System.Drawing.Size(1000, 660);
            this.setform.TabIndex = 103;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Invaiz_Studio.Properties.Resources.close;
            this.pictureBox1.Location = new System.Drawing.Point(957, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 32);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(42)))), ((int)(((byte)(51)))));
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Controls.Add(this.button5);
            this.flowLayoutPanel1.Controls.Add(this.button2);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 60);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(168, 600);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Noto Sans CJK KR Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(172, 47);
            this.button1.TabIndex = 0;
            this.button1.Text = "오버레이 설정";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Noto Sans CJK KR Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button5.Location = new System.Drawing.Point(3, 56);
            this.button5.Name = "button5";
            this.button5.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.button5.Size = new System.Drawing.Size(172, 47);
            this.button5.TabIndex = 2;
            this.button5.Text = "버전 정보";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Noto Sans CJK KR Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(3, 109);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(172, 47);
            this.button2.TabIndex = 1;
            this.button2.Text = "언어 설정";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(63)))), ((int)(((byte)(77)))));
            this.panel3.Controls.Add(this.overlay);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(168, 60);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(832, 510);
            this.panel3.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(63)))), ((int)(((byte)(77)))));
            this.panel2.Controls.Add(this.save);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 570);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1000, 90);
            this.panel2.TabIndex = 5;
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(255)))));
            this.save.FlatAppearance.BorderSize = 0;
            this.save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save.Font = new System.Drawing.Font("Noto Sans CJK KR Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.save.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.save.Location = new System.Drawing.Point(846, 27);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(140, 40);
            this.save.TabIndex = 2;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // set_title
            // 
            this.set_title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(42)))), ((int)(((byte)(51)))));
            this.set_title.Dock = System.Windows.Forms.DockStyle.Top;
            this.set_title.Font = new System.Drawing.Font("Noto Sans CJK KR Regular", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.set_title.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.set_title.Location = new System.Drawing.Point(0, 0);
            this.set_title.Name = "set_title";
            this.set_title.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.set_title.Size = new System.Drawing.Size(1000, 60);
            this.set_title.TabIndex = 1;
            this.set_title.Text = "설정 및 옵션";
            this.set_title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // overlay
            // 
            this.overlay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(63)))), ((int)(((byte)(77)))));
            this.overlay.Location = new System.Drawing.Point(0, 0);
            this.overlay.Name = "overlay";
            this.overlay.OL_Location = 7;
            this.overlay.OL_Second = 3;
            this.overlay.OnlyShow = false;
            this.overlay.Size = new System.Drawing.Size(832, 510);
            this.overlay.TabIndex = 0;
            this.overlay.Toggle = true;
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel setform;
        private System.Windows.Forms.Label set_title;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Component.Setting.Overlay overlay;
    }
}