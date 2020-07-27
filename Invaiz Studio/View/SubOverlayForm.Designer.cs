namespace Invaiz_Studio.View
{
    partial class SubOverlayForm
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
            this.activeGroup = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // activeGroup
            // 
            this.activeGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(63)))), ((int)(((byte)(77)))));
            this.activeGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.activeGroup.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activeGroup.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.activeGroup.Location = new System.Drawing.Point(0, 0);
            this.activeGroup.Name = "activeGroup";
            this.activeGroup.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.activeGroup.Size = new System.Drawing.Size(266, 46);
            this.activeGroup.TabIndex = 1;
            this.activeGroup.Text = "text";
            this.activeGroup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.activeGroup.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label2_MouseDown);
            this.activeGroup.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label2_MouseMove);
            // 
            // SubOverlayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(266, 46);
            this.Controls.Add(this.activeGroup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SubOverlayForm";
            this.Opacity = 0.9D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "DefaultOverlay";
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label activeGroup;
    }
}