namespace Invaiz_Studio.Component
{
    partial class DeviceButton
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
            this.form_name = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // form_name
            // 
            this.form_name.BackColor = System.Drawing.Color.Transparent;
            this.form_name.Cursor = System.Windows.Forms.Cursors.Hand;
            this.form_name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.form_name.Font = new System.Drawing.Font("Noto Sans CJK KR Regular", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.form_name.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.form_name.Location = new System.Drawing.Point(0, 0);
            this.form_name.Name = "form_name";
            this.form_name.Size = new System.Drawing.Size(81, 42);
            this.form_name.TabIndex = 3;
            this.form_name.Text = "브러쉬";
            this.form_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.form_name.MouseClick += new System.Windows.Forms.MouseEventHandler(this.form_name_MouseClick);
            this.form_name.MouseLeave += new System.EventHandler(this.panel1_MouseLeave);
            this.form_name.MouseHover += new System.EventHandler(this.panel1_MouseHover);
            this.form_name.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // DeviceButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::Invaiz_Studio.Properties.Resources.buttonnone;
            this.Controls.Add(this.form_name);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "DeviceButton";
            this.Size = new System.Drawing.Size(81, 42);
            this.MouseLeave += new System.EventHandler(this.panel1_MouseLeave);
            this.MouseHover += new System.EventHandler(this.panel1_MouseHover);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label form_name;
    }
}
