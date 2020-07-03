namespace Invaiz_Studio.View
{
    partial class NewPresetForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.preset_name = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cancle_button = new System.Windows.Forms.Button();
            this.create_button = new System.Windows.Forms.Button();
            this.newPreset = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.newPreset.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(30, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "New Preset Name";
            // 
            // preset_name
            // 
            this.preset_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.preset_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.preset_name.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.preset_name.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.preset_name.Location = new System.Drawing.Point(0, 5);
            this.preset_name.Name = "preset_name";
            this.preset_name.Size = new System.Drawing.Size(243, 22);
            this.preset_name.TabIndex = 0;
            this.preset_name.KeyDown += new System.Windows.Forms.KeyEventHandler(this.preset_name_KeyDown);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.panel1.Controls.Add(this.preset_name);
            this.panel1.Location = new System.Drawing.Point(32, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(243, 30);
            this.panel1.TabIndex = 8;
            // 
            // cancle_button
            // 
            this.cancle_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(63)))), ((int)(((byte)(77)))));
            this.cancle_button.FlatAppearance.BorderSize = 0;
            this.cancle_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancle_button.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancle_button.ForeColor = System.Drawing.Color.White;
            this.cancle_button.Location = new System.Drawing.Point(118, 120);
            this.cancle_button.Name = "cancle_button";
            this.cancle_button.Size = new System.Drawing.Size(75, 33);
            this.cancle_button.TabIndex = 7;
            this.cancle_button.Text = "Cancle";
            this.cancle_button.UseVisualStyleBackColor = false;
            this.cancle_button.Click += new System.EventHandler(this.cancle_button_Click);
            // 
            // create_button
            // 
            this.create_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(255)))));
            this.create_button.FlatAppearance.BorderSize = 0;
            this.create_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.create_button.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.create_button.ForeColor = System.Drawing.Color.White;
            this.create_button.Location = new System.Drawing.Point(199, 120);
            this.create_button.Name = "create_button";
            this.create_button.Size = new System.Drawing.Size(75, 33);
            this.create_button.TabIndex = 6;
            this.create_button.Text = "Save";
            this.create_button.UseVisualStyleBackColor = true;
            this.create_button.Click += new System.EventHandler(this.create_button_Click);
            // 
            // newPreset
            // 
            this.newPreset.Controls.Add(this.label1);
            this.newPreset.Controls.Add(this.create_button);
            this.newPreset.Controls.Add(this.panel1);
            this.newPreset.Controls.Add(this.cancle_button);
            this.newPreset.Location = new System.Drawing.Point(0, 0);
            this.newPreset.Name = "newPreset";
            this.newPreset.Size = new System.Drawing.Size(311, 178);
            this.newPreset.TabIndex = 9;
            // 
            // CreatePresetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(1280, 800);
            this.Controls.Add(this.newPreset);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CreatePresetForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreatePresetForm";
            this.Load += new System.EventHandler(this.CreatePresetForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.newPreset.ResumeLayout(false);
            this.newPreset.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox preset_name;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cancle_button;
        private System.Windows.Forms.Button create_button;
        private System.Windows.Forms.Panel newPreset;
    }
}