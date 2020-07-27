namespace Invaiz_Studio.Component.Setting
{
    partial class Overlay
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.secondBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.showToggle2 = new System.Windows.Forms.PictureBox();
            this.showToggle = new System.Windows.Forms.PictureBox();
            this.toggleBox = new System.Windows.Forms.PictureBox();
            this.point8 = new System.Windows.Forms.Button();
            this.point9 = new System.Windows.Forms.Button();
            this.point7 = new System.Windows.Forms.Button();
            this.point5 = new System.Windows.Forms.Button();
            this.point6 = new System.Windows.Forms.Button();
            this.point4 = new System.Windows.Forms.Button();
            this.point2 = new System.Windows.Forms.Button();
            this.point3 = new System.Windows.Forms.Button();
            this.point1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.showToggle2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showToggle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggleBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.secondBox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.showToggle2);
            this.panel1.Controls.Add(this.showToggle);
            this.panel1.Controls.Add(this.toggleBox);
            this.panel1.Controls.Add(this.point8);
            this.panel1.Controls.Add(this.point9);
            this.panel1.Controls.Add(this.point7);
            this.panel1.Controls.Add(this.point5);
            this.panel1.Controls.Add(this.point6);
            this.panel1.Controls.Add(this.point4);
            this.panel1.Controls.Add(this.point2);
            this.panel1.Controls.Add(this.point3);
            this.panel1.Controls.Add(this.point1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(808, 510);
            this.panel1.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Noto Sans CJK KR Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Location = new System.Drawing.Point(152, 368);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 24);
            this.label6.TabIndex = 18;
            this.label6.Text = "초";
            // 
            // secondBox
            // 
            this.secondBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(80)))), ((int)(((byte)(93)))));
            this.secondBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.secondBox.Font = new System.Drawing.Font("Noto Sans CJK KR Regular", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.secondBox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.secondBox.Location = new System.Drawing.Point(66, 370);
            this.secondBox.MaxLength = 1;
            this.secondBox.Name = "secondBox";
            this.secondBox.Size = new System.Drawing.Size(82, 23);
            this.secondBox.TabIndex = 17;
            this.secondBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.second_KeyPress);
            this.secondBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.secondBox_KeyUp);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Noto Sans CJK KR Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(213, 368);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 24);
            this.label5.TabIndex = 16;
            this.label5.Text = "항상표시";
            // 
            // showToggle2
            // 
            this.showToggle2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showToggle2.Image = global::Invaiz_Studio.Properties.Resources.selection_off;
            this.showToggle2.Location = new System.Drawing.Point(190, 370);
            this.showToggle2.Name = "showToggle2";
            this.showToggle2.Size = new System.Drawing.Size(20, 20);
            this.showToggle2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.showToggle2.TabIndex = 15;
            this.showToggle2.TabStop = false;
            this.showToggle2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.showToggle_MouseClick);
            // 
            // showToggle
            // 
            this.showToggle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showToggle.Image = global::Invaiz_Studio.Properties.Resources.selection_off;
            this.showToggle.Location = new System.Drawing.Point(40, 370);
            this.showToggle.Name = "showToggle";
            this.showToggle.Size = new System.Drawing.Size(20, 20);
            this.showToggle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.showToggle.TabIndex = 14;
            this.showToggle.TabStop = false;
            this.showToggle.MouseClick += new System.Windows.Forms.MouseEventHandler(this.showToggle_MouseClick);
            // 
            // toggleBox
            // 
            this.toggleBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.toggleBox.Image = global::Invaiz_Studio.Properties.Resources.toggleon;
            this.toggleBox.Location = new System.Drawing.Point(748, 9);
            this.toggleBox.Name = "toggleBox";
            this.toggleBox.Size = new System.Drawing.Size(50, 50);
            this.toggleBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.toggleBox.TabIndex = 13;
            this.toggleBox.TabStop = false;
            this.toggleBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // point8
            // 
            this.point8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(80)))), ((int)(((byte)(93)))));
            this.point8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.point8.FlatAppearance.BorderSize = 0;
            this.point8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.point8.Font = new System.Drawing.Font("Noto Sans CJK KR Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.point8.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.point8.Location = new System.Drawing.Point(133, 244);
            this.point8.Name = "point8";
            this.point8.Size = new System.Drawing.Size(90, 60);
            this.point8.TabIndex = 12;
            this.point8.Text = "8";
            this.point8.UseVisualStyleBackColor = false;
            this.point8.MouseClick += new System.Windows.Forms.MouseEventHandler(this.point1_MouseClick);
            // 
            // point9
            // 
            this.point9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(80)))), ((int)(((byte)(93)))));
            this.point9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.point9.FlatAppearance.BorderSize = 0;
            this.point9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.point9.Font = new System.Drawing.Font("Noto Sans CJK KR Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.point9.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.point9.Location = new System.Drawing.Point(229, 244);
            this.point9.Name = "point9";
            this.point9.Size = new System.Drawing.Size(90, 60);
            this.point9.TabIndex = 11;
            this.point9.Text = "9";
            this.point9.UseVisualStyleBackColor = false;
            this.point9.MouseClick += new System.Windows.Forms.MouseEventHandler(this.point1_MouseClick);
            // 
            // point7
            // 
            this.point7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(80)))), ((int)(((byte)(93)))));
            this.point7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.point7.FlatAppearance.BorderSize = 0;
            this.point7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.point7.Font = new System.Drawing.Font("Noto Sans CJK KR Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.point7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.point7.Location = new System.Drawing.Point(37, 244);
            this.point7.Name = "point7";
            this.point7.Size = new System.Drawing.Size(90, 60);
            this.point7.TabIndex = 10;
            this.point7.Text = "7";
            this.point7.UseVisualStyleBackColor = false;
            this.point7.MouseClick += new System.Windows.Forms.MouseEventHandler(this.point1_MouseClick);
            // 
            // point5
            // 
            this.point5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(80)))), ((int)(((byte)(93)))));
            this.point5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.point5.FlatAppearance.BorderSize = 0;
            this.point5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.point5.Font = new System.Drawing.Font("Noto Sans CJK KR Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.point5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.point5.Location = new System.Drawing.Point(133, 178);
            this.point5.Name = "point5";
            this.point5.Size = new System.Drawing.Size(90, 60);
            this.point5.TabIndex = 9;
            this.point5.Text = "5";
            this.point5.UseVisualStyleBackColor = false;
            this.point5.MouseClick += new System.Windows.Forms.MouseEventHandler(this.point1_MouseClick);
            // 
            // point6
            // 
            this.point6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(80)))), ((int)(((byte)(93)))));
            this.point6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.point6.FlatAppearance.BorderSize = 0;
            this.point6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.point6.Font = new System.Drawing.Font("Noto Sans CJK KR Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.point6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.point6.Location = new System.Drawing.Point(229, 178);
            this.point6.Name = "point6";
            this.point6.Size = new System.Drawing.Size(90, 60);
            this.point6.TabIndex = 8;
            this.point6.Text = "6";
            this.point6.UseVisualStyleBackColor = false;
            this.point6.MouseClick += new System.Windows.Forms.MouseEventHandler(this.point1_MouseClick);
            // 
            // point4
            // 
            this.point4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(80)))), ((int)(((byte)(93)))));
            this.point4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.point4.FlatAppearance.BorderSize = 0;
            this.point4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.point4.Font = new System.Drawing.Font("Noto Sans CJK KR Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.point4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.point4.Location = new System.Drawing.Point(37, 178);
            this.point4.Name = "point4";
            this.point4.Size = new System.Drawing.Size(90, 60);
            this.point4.TabIndex = 7;
            this.point4.Text = "4";
            this.point4.UseVisualStyleBackColor = false;
            this.point4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.point1_MouseClick);
            // 
            // point2
            // 
            this.point2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(80)))), ((int)(((byte)(93)))));
            this.point2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.point2.FlatAppearance.BorderSize = 0;
            this.point2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.point2.Font = new System.Drawing.Font("Noto Sans CJK KR Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.point2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.point2.Location = new System.Drawing.Point(133, 112);
            this.point2.Name = "point2";
            this.point2.Size = new System.Drawing.Size(90, 60);
            this.point2.TabIndex = 6;
            this.point2.Text = "2";
            this.point2.UseVisualStyleBackColor = false;
            this.point2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.point1_MouseClick);
            // 
            // point3
            // 
            this.point3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(80)))), ((int)(((byte)(93)))));
            this.point3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.point3.FlatAppearance.BorderSize = 0;
            this.point3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.point3.Font = new System.Drawing.Font("Noto Sans CJK KR Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.point3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.point3.Location = new System.Drawing.Point(229, 112);
            this.point3.Name = "point3";
            this.point3.Size = new System.Drawing.Size(90, 60);
            this.point3.TabIndex = 5;
            this.point3.Text = "3";
            this.point3.UseVisualStyleBackColor = false;
            this.point3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.point1_MouseClick);
            // 
            // point1
            // 
            this.point1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(80)))), ((int)(((byte)(93)))));
            this.point1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.point1.FlatAppearance.BorderSize = 0;
            this.point1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.point1.Font = new System.Drawing.Font("Noto Sans CJK KR Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.point1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.point1.Location = new System.Drawing.Point(37, 112);
            this.point1.Name = "point1";
            this.point1.Size = new System.Drawing.Size(90, 60);
            this.point1.TabIndex = 4;
            this.point1.Text = "1";
            this.point1.UseVisualStyleBackColor = false;
            this.point1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.point1_MouseClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Noto Sans CJK KR Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(37, 325);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "오버레이 표시 시간";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Noto Sans CJK KR Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(33, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "오버레이 위치 설정";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Noto Sans CJK KR Regular", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(197, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(254, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "사용자가 설정한 기능을 디스플레이에 표시합니다.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Noto Sans CJK KR Regular", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(32, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "메인 오버레이";
            // 
            // Overlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(63)))), ((int)(((byte)(77)))));
            this.Controls.Add(this.panel1);
            this.Name = "Overlay";
            this.Size = new System.Drawing.Size(832, 510);
            this.Load += new System.EventHandler(this.Overlay_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.showToggle2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showToggle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggleBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button point8;
        private System.Windows.Forms.Button point9;
        private System.Windows.Forms.Button point7;
        private System.Windows.Forms.Button point5;
        private System.Windows.Forms.Button point6;
        private System.Windows.Forms.Button point4;
        private System.Windows.Forms.Button point2;
        private System.Windows.Forms.Button point3;
        private System.Windows.Forms.Button point1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox toggleBox;
        private System.Windows.Forms.TextBox secondBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox showToggle2;
        private System.Windows.Forms.PictureBox showToggle;
        private System.Windows.Forms.Label label6;
    }
}
