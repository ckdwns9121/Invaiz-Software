﻿namespace Invaiz_Console.Component
{
    partial class MainKeypad
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
            this.keypad = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.keypad)).BeginInit();
            this.SuspendLayout();
            // 
            // keypad
            // 
            this.keypad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.keypad.Image = global::Invaiz_Console.Properties.Resources.product;
            this.keypad.Location = new System.Drawing.Point(0, 0);
            this.keypad.Name = "keypad";
            this.keypad.Size = new System.Drawing.Size(476, 199);
            this.keypad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.keypad.TabIndex = 0;
            this.keypad.TabStop = false;
            // 
            // MainKeypad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.keypad);
            this.Name = "MainKeypad";
            this.Size = new System.Drawing.Size(476, 199);
            ((System.ComponentModel.ISupportInitialize)(this.keypad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox keypad;
    }
}
