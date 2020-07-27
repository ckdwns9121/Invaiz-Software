using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Invaiz_Studio.Component
{
    public partial class FunctionCategory : UserControl
    {
        public FunctionCategory()
        {
            InitializeComponent();
        }

        public FunctionCategory deepCopy()
        {
            FunctionCategory functionCategory = new FunctionCategory();
            functionCategory.toggle = this.toggle;
            functionCategory.CategoryName = this.CategoryName;
            functionCategory.SetForm = this.SetForm;
            return functionCategory;
        }

        public bool toggle = false;

        private string categoryName;
        [Category("Custom"), Description("CatagoryName")]
        public string CategoryName
        {
            get { return this.categoryName; }
            set { this.categoryName = value; this.category_name.Text = value; }
        }

        private View.SettingForm settingForm;
        public View.SettingForm SetForm
        {
            get { return this.settingForm; }
            set { this.settingForm = value; }
        }


        private Image openImage = Invaiz_Studio.Properties.Resources.folder2;
        private Image closeImage = Invaiz_Studio.Properties.Resources.folder;




        private void showItemList()
        {
            foreach (Control c in settingForm.item_list.Controls)
            {
                if (c is Component.Function.FunctionCategoryList)
                {
                    foreach (Control t in c.Controls)
                    {

                        if (t is Component.Function.FunctionItemList)
                        {
                            string catecory = ((Component.Function.FunctionItemList)t).Category;
                            if (this.categoryName.Equals(catecory))
                            {
                                ((Component.Function.FunctionItemList)t).Visible = !((Component.Function.FunctionItemList)t).Visible;
                            }
                        }
                    }
                }
            }

            
            if (settingForm.item_list.Height > 360)
            {
                Console.WriteLine("넘어감"+ settingForm.scrollPanel.DisplayRectangle.Height);
                settingForm.customScrollbar1.Visible = true;
                settingForm.customScrollbar1.Minimum = 0;
                settingForm.customScrollbar1.Maximum = settingForm.scrollPanel.DisplayRectangle.Height;

                settingForm.customScrollbar1.LargeChange = settingForm.customScrollbar1.Maximum / settingForm.customScrollbar1.Height + settingForm.scrollPanel.Height;
                settingForm.customScrollbar1.SmallChange = 15;
                settingForm.customScrollbar1.Value = Math.Abs(settingForm.scrollPanel.AutoScrollPosition.Y);
            }
            else
            {
                Console.WriteLine("안넘어감");
                settingForm.customScrollbar1.Visible = false;
                settingForm.customScrollbar1.Minimum = 0;
                settingForm.customScrollbar1.Maximum = settingForm.scrollPanel.DisplayRectangle.Height;
                settingForm.customScrollbar1.LargeChange = settingForm.customScrollbar1.Maximum / settingForm.customScrollbar1.Height + settingForm.scrollPanel.Height;
                settingForm.customScrollbar1.SmallChange = 15;
                settingForm.customScrollbar1.Value = Math.Abs(settingForm.scrollPanel.AutoScrollPosition.Y);


            }


        }

        private void category_name_MouseClick(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                if (!toggle)
                {
                    this.BackColor = Color.FromArgb(42, 48, 57);
                    this.category_name.Image = openImage;
                    toggle = true;
                    showItemList();
                }
                else
                {
                    this.BackColor = Color.FromArgb(54, 63, 77); 
                    this.category_name.Image = closeImage;
                    toggle = false;
                    showItemList();
                }
            }
        }
    }
}
