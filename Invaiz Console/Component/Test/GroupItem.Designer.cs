namespace Invaiz_Console.Component
{
    partial class GroupItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GroupItem));
            this.panel1 = new System.Windows.Forms.Panel();
            this.deviceEncoder1 = new Invaiz_Console.Component.DeviceEncoder();
            this.deviceEncoder2 = new Invaiz_Console.Component.DeviceEncoder();
            this.deviceEncoder3 = new Invaiz_Console.Component.DeviceEncoder();
            this.deviceEncoder4 = new Invaiz_Console.Component.DeviceEncoder();
            this.deviceButton1 = new Invaiz_Console.Component.DeviceButton();
            this.deviceButton2 = new Invaiz_Console.Component.DeviceButton();
            this.deviceButton3 = new Invaiz_Console.Component.DeviceButton();
            this.deviceButton4 = new Invaiz_Console.Component.DeviceButton();
            this.deviceGroupButton1 = new Invaiz_Console.Component.Device.DeviceGroupButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Invaiz_Console.Properties.Resources.background;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Controls.Add(this.deviceGroupButton1);
            this.panel1.Controls.Add(this.deviceButton4);
            this.panel1.Controls.Add(this.deviceButton3);
            this.panel1.Controls.Add(this.deviceButton2);
            this.panel1.Controls.Add(this.deviceButton1);
            this.panel1.Controls.Add(this.deviceEncoder4);
            this.panel1.Controls.Add(this.deviceEncoder3);
            this.panel1.Controls.Add(this.deviceEncoder2);
            this.panel1.Controls.Add(this.deviceEncoder1);
            this.panel1.Location = new System.Drawing.Point(7, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(535, 210);
            this.panel1.TabIndex = 0;
            // 
            // deviceEncoder1
            // 
            this.deviceEncoder1.BackColor = System.Drawing.Color.Transparent;
            this.deviceEncoder1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deviceEncoder1.BackgroundImage")));
            this.deviceEncoder1.EncoderNumber = null;
            this.deviceEncoder1.FormName = null;
            this.deviceEncoder1.Group = 0;
            this.deviceEncoder1.HoverColor = System.Drawing.Color.Empty;
            this.deviceEncoder1.HoverImage = null;
            this.deviceEncoder1.Index = 0;
            this.deviceEncoder1.LeftSubName = null;
            this.deviceEncoder1.Location = new System.Drawing.Point(20, 20);
            this.deviceEncoder1.Name = "deviceEncoder1";
            this.deviceEncoder1.NomalColor = System.Drawing.Color.Empty;
            this.deviceEncoder1.NomalImage = null;
            this.deviceEncoder1.RightSubName = null;
            this.deviceEncoder1.Size = new System.Drawing.Size(99, 99);
            this.deviceEncoder1.TabIndex = 0;
            // 
            // deviceEncoder2
            // 
            this.deviceEncoder2.BackColor = System.Drawing.Color.Transparent;
            this.deviceEncoder2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deviceEncoder2.BackgroundImage")));
            this.deviceEncoder2.EncoderNumber = null;
            this.deviceEncoder2.FormName = null;
            this.deviceEncoder2.Group = 0;
            this.deviceEncoder2.HoverColor = System.Drawing.Color.Empty;
            this.deviceEncoder2.HoverImage = null;
            this.deviceEncoder2.Index = 0;
            this.deviceEncoder2.LeftSubName = null;
            this.deviceEncoder2.Location = new System.Drawing.Point(151, 20);
            this.deviceEncoder2.Name = "deviceEncoder2";
            this.deviceEncoder2.NomalColor = System.Drawing.Color.Empty;
            this.deviceEncoder2.NomalImage = null;
            this.deviceEncoder2.RightSubName = null;
            this.deviceEncoder2.Size = new System.Drawing.Size(99, 99);
            this.deviceEncoder2.TabIndex = 1;
            // 
            // deviceEncoder3
            // 
            this.deviceEncoder3.BackColor = System.Drawing.Color.Transparent;
            this.deviceEncoder3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deviceEncoder3.BackgroundImage")));
            this.deviceEncoder3.EncoderNumber = null;
            this.deviceEncoder3.FormName = null;
            this.deviceEncoder3.Group = 0;
            this.deviceEncoder3.HoverColor = System.Drawing.Color.Empty;
            this.deviceEncoder3.HoverImage = null;
            this.deviceEncoder3.Index = 0;
            this.deviceEncoder3.LeftSubName = null;
            this.deviceEncoder3.Location = new System.Drawing.Point(282, 20);
            this.deviceEncoder3.Name = "deviceEncoder3";
            this.deviceEncoder3.NomalColor = System.Drawing.Color.Empty;
            this.deviceEncoder3.NomalImage = null;
            this.deviceEncoder3.RightSubName = null;
            this.deviceEncoder3.Size = new System.Drawing.Size(99, 99);
            this.deviceEncoder3.TabIndex = 2;
            // 
            // deviceEncoder4
            // 
            this.deviceEncoder4.BackColor = System.Drawing.Color.Transparent;
            this.deviceEncoder4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deviceEncoder4.BackgroundImage")));
            this.deviceEncoder4.EncoderNumber = null;
            this.deviceEncoder4.FormName = null;
            this.deviceEncoder4.Group = 0;
            this.deviceEncoder4.HoverColor = System.Drawing.Color.Empty;
            this.deviceEncoder4.HoverImage = null;
            this.deviceEncoder4.Index = 0;
            this.deviceEncoder4.LeftSubName = null;
            this.deviceEncoder4.Location = new System.Drawing.Point(413, 20);
            this.deviceEncoder4.Name = "deviceEncoder4";
            this.deviceEncoder4.NomalColor = System.Drawing.Color.Empty;
            this.deviceEncoder4.NomalImage = null;
            this.deviceEncoder4.RightSubName = null;
            this.deviceEncoder4.Size = new System.Drawing.Size(99, 99);
            this.deviceEncoder4.TabIndex = 3;
            // 
            // deviceButton1
            // 
            this.deviceButton1.BackColor = System.Drawing.Color.Transparent;
            this.deviceButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deviceButton1.BackgroundImage")));
            this.deviceButton1.ButtonNumber = null;
            this.deviceButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deviceButton1.FormName = null;
            this.deviceButton1.Group = 0;
            this.deviceButton1.HoverColor = System.Drawing.Color.Empty;
            this.deviceButton1.HoverImage = null;
            this.deviceButton1.Index = 0;
            this.deviceButton1.Location = new System.Drawing.Point(40, 140);
            this.deviceButton1.Name = "deviceButton1";
            this.deviceButton1.NomalColor = System.Drawing.Color.Empty;
            this.deviceButton1.NomalImage = null;
            this.deviceButton1.Size = new System.Drawing.Size(81, 42);
            this.deviceButton1.SubName = null;
            this.deviceButton1.TabIndex = 4;
            // 
            // deviceButton2
            // 
            this.deviceButton2.BackColor = System.Drawing.Color.Transparent;
            this.deviceButton2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deviceButton2.BackgroundImage")));
            this.deviceButton2.ButtonNumber = null;
            this.deviceButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deviceButton2.FormName = null;
            this.deviceButton2.Group = 0;
            this.deviceButton2.HoverColor = System.Drawing.Color.Empty;
            this.deviceButton2.HoverImage = null;
            this.deviceButton2.Index = 0;
            this.deviceButton2.Location = new System.Drawing.Point(134, 140);
            this.deviceButton2.Name = "deviceButton2";
            this.deviceButton2.NomalColor = System.Drawing.Color.Empty;
            this.deviceButton2.NomalImage = null;
            this.deviceButton2.Size = new System.Drawing.Size(81, 42);
            this.deviceButton2.SubName = null;
            this.deviceButton2.TabIndex = 5;
            // 
            // deviceButton3
            // 
            this.deviceButton3.BackColor = System.Drawing.Color.Transparent;
            this.deviceButton3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deviceButton3.BackgroundImage")));
            this.deviceButton3.ButtonNumber = null;
            this.deviceButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deviceButton3.FormName = null;
            this.deviceButton3.Group = 0;
            this.deviceButton3.HoverColor = System.Drawing.Color.Empty;
            this.deviceButton3.HoverImage = null;
            this.deviceButton3.Index = 0;
            this.deviceButton3.Location = new System.Drawing.Point(228, 140);
            this.deviceButton3.Name = "deviceButton3";
            this.deviceButton3.NomalColor = System.Drawing.Color.Empty;
            this.deviceButton3.NomalImage = null;
            this.deviceButton3.Size = new System.Drawing.Size(81, 42);
            this.deviceButton3.SubName = null;
            this.deviceButton3.TabIndex = 6;
            // 
            // deviceButton4
            // 
            this.deviceButton4.BackColor = System.Drawing.Color.Transparent;
            this.deviceButton4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deviceButton4.BackgroundImage")));
            this.deviceButton4.ButtonNumber = null;
            this.deviceButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deviceButton4.FormName = null;
            this.deviceButton4.Group = 0;
            this.deviceButton4.HoverColor = System.Drawing.Color.Empty;
            this.deviceButton4.HoverImage = null;
            this.deviceButton4.Index = 0;
            this.deviceButton4.Location = new System.Drawing.Point(322, 140);
            this.deviceButton4.Name = "deviceButton4";
            this.deviceButton4.NomalColor = System.Drawing.Color.Empty;
            this.deviceButton4.NomalImage = null;
            this.deviceButton4.Size = new System.Drawing.Size(81, 42);
            this.deviceButton4.SubName = null;
            this.deviceButton4.TabIndex = 7;
            // 
            // deviceGroupButton1
            // 
            this.deviceGroupButton1.BackColor = System.Drawing.Color.Transparent;
            this.deviceGroupButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deviceGroupButton1.BackgroundImage")));
            this.deviceGroupButton1.GroupNumber = null;
            this.deviceGroupButton1.HoverColor = System.Drawing.Color.Empty;
            this.deviceGroupButton1.HoverImage = null;
            this.deviceGroupButton1.Location = new System.Drawing.Point(416, 140);
            this.deviceGroupButton1.Name = "deviceGroupButton1";
            this.deviceGroupButton1.NomalColor = System.Drawing.Color.Empty;
            this.deviceGroupButton1.NomalImage = null;
            this.deviceGroupButton1.Size = new System.Drawing.Size(81, 42);
            this.deviceGroupButton1.TabIndex = 8;
            // 
            // GroupItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.panel1);
            this.Name = "GroupItem";
            this.Size = new System.Drawing.Size(557, 430);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Device.DeviceGroupButton deviceGroupButton1;
        private DeviceButton deviceButton4;
        private DeviceButton deviceButton3;
        private DeviceButton deviceButton2;
        private DeviceButton deviceButton1;
        private DeviceEncoder deviceEncoder4;
        private DeviceEncoder deviceEncoder3;
        private DeviceEncoder deviceEncoder2;
        private DeviceEncoder deviceEncoder1;
    }
}
