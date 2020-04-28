namespace Invaiz_Console.Component
{
    partial class FunctionCategory
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
            this.category_name = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // category_name
            // 
            this.category_name.Cursor = System.Windows.Forms.Cursors.Hand;
            this.category_name.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.category_name.Image = global::Invaiz_Console.Properties.Resources.folder;
            this.category_name.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.category_name.Location = new System.Drawing.Point(0, 0);
            this.category_name.Name = "category_name";
            this.category_name.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.category_name.Size = new System.Drawing.Size(570, 30);
            this.category_name.TabIndex = 1;
            this.category_name.Text = "Tools";
            this.category_name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.category_name.Click += new System.EventHandler(this.category_name_Click);
            // 
            // FunctionCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.category_name);
            this.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.Name = "FunctionCategory";
            this.Size = new System.Drawing.Size(570, 30);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label category_name;
    }
}
