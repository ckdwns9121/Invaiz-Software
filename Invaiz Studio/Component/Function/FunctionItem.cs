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
    public partial class FunctionItem : UserControl
    {

        private MainForm mn;
        public FunctionItem()
        {
            InitializeComponent();
        }
        public FunctionItem deepCopy()
        {
            FunctionItem functionItem = new FunctionItem();
            functionItem.deviceCheck = this.deviceCheck;
            functionItem.CategoryName = this.CategoryName;
            functionItem.ExcuteType = this.ExcuteType;
            functionItem.MsgType = this.MsgType;
            functionItem.ActionType = this.ActionType;
            functionItem.TypeKey = this.TypeKey;
            functionItem.Keycode1 = this.Keycode1;
            functionItem.Keycode2 = this.keycode2;
            functionItem.Multi1 = this.Multi1;
            functionItem.Multi2 = this.Multi2;
            functionItem.FormName = this.FormName;
            functionItem.SubName1 = this.SubName1;
            functionItem.SubName2 = this.SubName2;
            functionItem.SetForm = this.SetForm;
            return functionItem;
        }

        public bool deviceCheck; //true : encoder ,false :button
        private string category_name;
        private string excuteType;
        private string msgType;
        private string actionType;
        private int keycode1;
        private int keycode2;
        private int multi1;
        private int multi2;
        private string typeKey;
        private string formName;
        private string subName1;
        private string subName2;

        private View.SettingForm settingForm;

        public View.SettingForm SetForm
        {
            get { return this.settingForm; }
            set { this.settingForm = value; }        
        }
        public string ExcuteType
        {
            get { return this.excuteType; }
            set { this.excuteType = value; }
        }
        public string MsgType
        {
            get { return this.msgType; }
            set { this.msgType = value; }
        }
        public string ActionType
        {
            get { return this.actionType; }
            set { this.actionType = value; }
        }

        public string FormName
        {
            get { return this.formName; }
            set { this.form_name.Text = value; this.formName = value; }
        }
        public string TypeKey
        {
            get { return this.typeKey; }
            set { this.typeKey = value; }
        }

        public int Keycode1
        {
            get { return this.keycode1; }
            set { this.keycode1 = value; }
        }
        public int Multi1
        {
            get { return this.multi1; }
            set { this.multi1 = value; }
        }

        public int Keycode2
        {
            get { return this.keycode2; }
            set { this.keycode2 = value; }
        }
        public int Multi2
        {
            get { return this.multi2; }
            set { this.multi2 = value; }
        }

        public string SubName1
        {
            get { return this.subName1; }
            set { this.subName1 = value; }
        }
        public string SubName2
        {
            get { return this.subName2; }
            set { this.subName2 = value; }
        }

        public string CategoryName
        {
            get { return this.category_name; }
            set { this.category_name = value; }
        }

        public void init()
        {
            this.selection = false;
            this.BackColor = Color.FromArgb(89, 105, 128);
            this.form_name.Image = null;

        }
        public void clickUI()
        {
            selection = true;
            this.BackColor = Color.FromArgb(0, 100, 255);
            this.form_name.Image = Invaiz_Studio.Properties.Resources.select_on;
            SetForm.SelectedFormName = this.FormName;
            SetForm.Change = true;
            Console.WriteLine(SetForm.SelectedFormName + "클릭한 아이템 이름");
        }

        public bool selection = false;
        private void FunctionItem_MouseMove(object sender, MouseEventArgs e)
        {
            if (!selection)
                this.BackColor = Color.FromArgb(0, 100, 255);

        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            if (!selection)
                this.BackColor = Color.FromArgb(0, 100, 255);
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            if(!selection)
                this.BackColor = Color.FromArgb(89, 105, 128);
        }

        private void form_name_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {

                foreach (Control c in settingForm.item_list.Controls)
                {
                    if (c is Component.Function.FunctionCategoryList)
                    {

                        foreach (Control t in c.Controls)
                        {
                            if (t is Component.Function.FunctionItemList)
                            {
                                foreach (Control s in t.Controls)
                                {
                                    if (s is Component.FunctionItem)
                                    {
                                        Component.FunctionItem reset = (Component.FunctionItem)s;
                                        reset.init();
                                    }
                                }
                            }
                        }

                    }
                    //검색 했을시 리스트 아이템
                    if (c is Component.FunctionItem)
                    {
                        Component.FunctionItem reset = (Component.FunctionItem)c;
                        reset.init();
                    }
                }

                bindingData();
                clickUI();
            }
        }
        private void bindingData()
        {

            if (deviceCheck)
            {

                SetForm.ExcuteType = this.ExcuteType;
                SetForm.MsgType = this.MsgType;
                SetForm.ActionType = this.ActionType;
                SetForm.TypeKey = this.TypeKey;
                SetForm.FormName = this.FormName;
                SetForm.Keycode1 = this.Keycode1;
                SetForm.Keycode2 = this.Keycode2;

                SetForm.Multi1 = this.Multi1;
                SetForm.Multi2 = this.Multi2;
                SetForm.SubName1 = this.SubName1;
                SetForm.SubName2 = this.SubName2;

            }
            else
            {

                SetForm.ExcuteType = this.ExcuteType;
                SetForm.MsgType = this.MsgType;
                SetForm.ActionType = this.ActionType;
                SetForm.TypeKey = this.TypeKey;
                SetForm.FormName = this.FormName;
                SetForm.Keycode1 = this.Keycode1;
                SetForm.Multi1 = this.Multi1;
                SetForm.SubName1 = this.SubName1;

            }

        }
    }
}
