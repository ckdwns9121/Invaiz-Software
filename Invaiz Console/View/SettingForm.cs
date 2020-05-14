using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Invaiz_Console.View
{
    public partial class SettingForm : Form
    {
        private MainForm mn;
        private string deviceNumber;
        private bool deviceCheck; //true : encoder , false : button
        private bool functionCheck=true; //true: "sendScript" , false: "sendKey";
        private int index, group;
        private string selectedFormName = "";
        private bool change;

        #region set item value
        private string excuteType,msgType,actionType;
        private int keycode1, keycode2, multi1,multi2;
        private string typeKey,formName,subName1,subName2;

        private int changeKeycode1,changeKeycode2, changeMulti1, changeMulti2;
      

        #endregion

        #region Properties

        public bool Change
        {
            get { return this.change; }
            set { this.change = value; }
        }
        public int Index
        {
            get { return this.index; }
            set { this.index = value; }
        }
        public int Group
        {
            get { return this.group; }
            set { this.group = value; }
        }
        public string SelectedFormName
        {
            get { return this.selectedFormName; }
            set { this.selectedFormName = value; ; }
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
            set { this.formName = value; }
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

        #endregion

        private List<Component.FunctionItem> basicSearchList = new List<Component.FunctionItem>();
        private List<Control> basic_controls = new List<Control>();

        private List<Component.FunctionItem> copySearchList = new List<Component.FunctionItem>();
        private List<Control> copy_controls = new List<Control>();

        #region 폼 생성 및 초기화
        public SettingForm()
        {
            InitializeComponent();


            this.customScrollbar1.Minimum = 0;
            this.customScrollbar1.Maximum = this.scrollPanel.DisplayRectangle.Height;
            // this.customScrollbar1.Maximum = 10000;

            this.customScrollbar1.LargeChange = customScrollbar1.Maximum / customScrollbar1.Height + this.scrollPanel.Height;
            this.customScrollbar1.SmallChange = 15;
            this.customScrollbar1.Value = Math.Abs(this.scrollPanel.AutoScrollPosition.Y);
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            using (SolidBrush brush = new SolidBrush(Color.FromArgb(70, 0, 0, 0)))
            {
                e.Graphics.FillRectangle(brush, e.ClipRectangle);
            }
        }
        private const int CS_DropShaodw = 0x00020000;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle = CS_DropShaodw;
                return cp;
            }
        }
        public void init(bool check, int group, int index)
        {
            mn = MainForm.getInstance;
            if (check)
            {
                this.ExcuteType = mn.Payloads[group].E_excuteType[index];
                this.MsgType = mn.Payloads[group].E_messageType[index];
                this.ActionType = mn.Payloads[group].E_actionType[index];
                this.TypeKey = mn.Payloads[group].E_typeKey[index];
                this.FormName = mn.Payloads[group].E_formName[index];
                this.Keycode1 = mn.Payloads[group].E_leftKeyCode[index];
                this.Keycode2 = mn.Payloads[group].E_rightKeyCode[index];
                this.Multi1 = mn.Payloads[group].E_leftisMulti[index];
                this.Multi2 = mn.Payloads[group].E_rightisMulti[index];
                this.SubName1 = mn.Payloads[group].E_leftSubName[index];
                this.SubName2 = mn.Payloads[group].E_rightSubName[index];
            }
            else
            {
                this.ExcuteType = mn.Payloads[group].B_excuteType[index];
                this.MsgType = mn.Payloads[group].B_messageType[index];
                this.ActionType = mn.Payloads[group].B_actionType[index];
                this.TypeKey = mn.Payloads[group].B_typeKey[index];
                this.FormName = mn.Payloads[group].B_formName[index];
                this.Keycode1 = mn.Payloads[group].B_keyCode[index];
                this.Multi1 = mn.Payloads[group].B_isMulti[index]; 
                this.SubName1 = mn.Payloads[group].B_subName[index];
            }
        }

        #endregion

        #region 생성자
        public SettingForm(bool check, int group, int index, string deviceNumber, string formName, string leftSubName, string rightSubName)
        {
            InitializeComponent();


            this.customScrollbar1.Minimum = 0;
            this.customScrollbar1.Maximum = this.scrollPanel.DisplayRectangle.Height;
            // this.customScrollbar1.Maximum = 10000;

            this.customScrollbar1.LargeChange = customScrollbar1.Maximum / customScrollbar1.Height + this.scrollPanel.Height;
            this.customScrollbar1.SmallChange = 15;
            this.customScrollbar1.Value = Math.Abs(this.scrollPanel.AutoScrollPosition.Y);

            //폼을 렌더할 시 필요한 변수
            this.deviceCheck = check;
            this.group = group;
            this.index = index;
            this.deviceNumber = deviceNumber;
            init(check, group, index);
      
            if (check)
            {
                showEncoderSetting();
            }
            else
            {
                showButtonSetting();
            }

        }
        #endregion

        #region 폼 로드
        private void SettingForm_Load(object sender, EventArgs e)
        {
            KeyPreview = true;
            mn = MainForm.getInstance;
            this.Location = mn.Location;
            // 기본 스크롤바 때문에 넓이 줄여줌
            this.customScrollbar1.Visible = false;
            this.outpanel.Width = 583;

            this.setform.Top = (int)((this.Height - setform.Height) / 2);
            this.setform.Left = (int)((this.Width - setform.Width) / 2);
            this.ActiveControl = serchText;
            
            try
            {
                
                if (this.ExcuteType.Equals("sendKey"))
                {
                    this.formName_input.Text = this.formName;
                    this.subName1_input.Text = this.subName1;
                    this.subName2_input.Text = this.subName2;
                }
                else if (this.ExcuteType.Equals("sendScript"))
                {

                }
            
            }
            catch (Exception ex)
            {
                if (String.IsNullOrEmpty(this.ExcuteType))
                {
                    Console.WriteLine("널");
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            base.OnPaint(e);
            int borderWidth = 2;
            Color borderColor = Color.FromArgb(3, 218, 197);
            ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, borderColor,
            borderWidth, ButtonBorderStyle.Solid, borderColor, borderWidth,
            ButtonBorderStyle.Solid, borderColor, borderWidth,
            ButtonBorderStyle.Solid,
            borderColor, borderWidth, ButtonBorderStyle.Solid);

        }

        #endregion

        #region UI셋팅
        private void showButtonSetting()
        {
            this.set_title.Text = "Setting - Group " + (this.group + 1).ToString() + " Button " + (this.index + 1).ToString();
            this.function_panel.Visible = true;
            this.device_number.Text = this.deviceNumber;
            this.form_name.Text = this.formName;
            this.sub_name1.Text = subName1;
            this.sub_name2.Text = null;
            getButtonItems();
            settingList();
        }

        private void showEncoderSetting()
        {
            this.set_title.Text = "Setting - Group " + (this.group + 1).ToString() + " Dial " + (this.index + 1).ToString();
            this.function_panel.Visible = true;
            this.device_number.Text = this.deviceNumber;
            this.form_name.Text = this.formName;
            this.sub_name1.Text = subName1;
            this.sub_name2.Text = subName2;
            getEncoderItems();
            settingList();
        }
        #endregion
        
        #region getItems
        public void getEncoderItems()
        {
            mn = MainForm.getInstance;
            Component.Function.FunctionItemList ItemList = new Component.Function.FunctionItemList();
            Component.Function.FunctionCategoryList categoryList = new Component.Function.FunctionCategoryList();
            try
            {
                string folderName = mn.AppName;
                string path = mn.DataPath + folderName;
                System.IO.DirectoryInfo di = new System.IO.DirectoryInfo(path);
                if (!di.Exists)
                {
                    di.Create();
                }
                path = mn.DataPath + folderName + "/rotate.xml";

                using (XmlReader reader = XmlReader.Create(path))
                {
                    while (reader.Read())
                    {
                        // Only detect start elements.
                        if (reader.IsStartElement())
                        {
                            // Get element name and switch on it.
                            switch (reader.Name)
                            {
                                case "rotate":

                                    string Name = reader["name"];
                                    if (Name != null)
                                    {
                                        // Console.WriteLine("  Has attribute name: " + Name);
                                    }
                                    // Next read will contain text.
                                    break;
                                case "category":
                                    // Console.WriteLine("Start <category> element.");
                                    string category_name = reader["category_name"];
                                    if (category_name != null)
                                    {

                                        categoryList = new Component.Function.FunctionCategoryList();
                                        categoryList.Category = category_name;

                                        Component.FunctionCategory encoderCategory = new Component.FunctionCategory();
                                        encoderCategory.CategoryName = category_name;
                                        encoderCategory.SetForm = this;
                                        categoryList.Controls.Add(encoderCategory);
                                        ItemList = new Component.Function.FunctionItemList();
                                        ItemList.Category = category_name;
                                        ItemList.AutoScroll = false;
                                        ItemList.Visible = false;
                                        categoryList.Controls.Add(ItemList);
                                        this.item_list.Controls.Add(categoryList);
                                    }
                                    break;
                                case "rotateName":
                                    // Console.WriteLine("Start <press> element.");
                                    string excuteType = reader["excuteType"];
                                    string rotateMsgType = reader["messageType"];
                                    string rotateActionType = reader["actionType"];
                                    string rotateTypeKey = reader["typeKey"];
                                    string rotateFormName = reader["formName"];
                                    string rotateLeftKeycode = reader["keycode1"];
                                    string rotateRightKeycode = reader["keycode2"];
                                    string rotateLeftMulti = reader["multi1"];
                                    string rotateRightMulti = reader["multi2"];

                                    if (rotateMsgType != null && rotateFormName != null)
                                    {
                                        Component.FunctionItem encoderItem = new Component.FunctionItem();
                                        encoderItem.deviceCheck = true;
                                        encoderItem.SetForm = this;
                                        encoderItem.ExcuteType = excuteType;
                                        encoderItem.FormName = rotateFormName;
                                        encoderItem.MsgType = rotateMsgType;
                                        encoderItem.ActionType = rotateActionType;
                                        encoderItem.TypeKey = rotateTypeKey;
                                        encoderItem.Keycode1 = Int32.Parse(rotateLeftKeycode);
                                        encoderItem.Keycode2 = Int32.Parse(rotateRightKeycode);
                                        encoderItem.Multi1 = Int32.Parse(rotateLeftMulti);
                                        encoderItem.Multi2 = Int32.Parse(rotateRightMulti);
                                        ItemList.Controls.Add(encoderItem);
                                    }
                                    break;
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                /**
                 *@Exception -> rotate , press 정보가 없을시.
                 */

                // MessageBox.Show(e.Message);
            }

        }

        private void getButtonItems()
        {

            mn = MainForm.getInstance;
            Component.Function.FunctionItemList ItemList = new Component.Function.FunctionItemList();
            Component.Function.FunctionCategoryList CategoryList = new Component.Function.FunctionCategoryList();
            string temp = "test";

            string folderName = mn.AppName;
            string path = mn.DataPath + folderName + "/press.xml";
            try
            {
                using (XmlReader reader = XmlReader.Create(path))
                {
                    while (reader.Read())
                    {
                        // Only detect start elements.
                        if (reader.IsStartElement())
                        {
                            // Get element name and switch on it.
                            switch (reader.Name)
                            {
                                case "press":
                                    string Name = reader["name"];
                                    if (Name != null)
                                    {
                                    }
                                    // Next read will contain text.
                                    break;
                                case "category":
                                    //  Console.WriteLine("Start <category> element.");
                                    string category_name = reader["category_name"];
                                    Console.WriteLine(category_name);
                                    if (category_name != null)
                                    {
                                        CategoryList = new Component.Function.FunctionCategoryList();
                                        CategoryList.Category = category_name;
                                        Component.FunctionCategory buttonCategory = new Component.FunctionCategory();
                                        buttonCategory.SetForm = this;
                                        buttonCategory.CategoryName = category_name;
                                        temp = category_name;
                                        CategoryList.Controls.Add(buttonCategory);
                                        ItemList = new Component.Function.FunctionItemList();
                                        ItemList.AutoScroll = false;
                                        ItemList.Category = category_name;
                                        ItemList.Visible = false;

                                        CategoryList.Controls.Add(ItemList);
                                        this.item_list.Controls.Add(CategoryList);

                                    }
                                    break;
                                case "toolName":
                                    //  Console.WriteLine("Start <press> element.");

                                    string pressExcuteType = reader["excuteType"];
                                    string pressMessageType = reader["messageType"]; //command
                                    string pressActionType = reader["actionType"]; //settool
                                    string pressTypeKey = reader["typeKey"]; //paintbrushtool
                                    string pressFormName = reader["formName"]; //브러쉬
                                    string pressKeycode = reader["keyCode"];
                                    string pressisMulti = reader["multi"];
                                    if (pressMessageType != null && pressTypeKey != null && pressFormName != null)
                                    {

                                        Component.FunctionItem buttonItem = new Component.FunctionItem();

                                        buttonItem.SetForm = this;
                                        buttonItem.deviceCheck = false;
                                        buttonItem.ExcuteType = pressExcuteType;
                                        buttonItem.MsgType = pressMessageType;
                                        buttonItem.ActionType = pressActionType;
                                        buttonItem.FormName = pressFormName;
                                        buttonItem.TypeKey = pressTypeKey;
                                        if (!pressKeycode.Equals("") && !pressisMulti.Equals(""))
                                        {
                                            buttonItem.Keycode1 = Int32.Parse(pressKeycode);
                                            buttonItem.Multi1 = Int32.Parse(pressisMulti);
                                        }
                                        buttonItem.CategoryName = temp;
                                        ItemList.Controls.Add(buttonItem);
                                    }
                                    break;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }

        }
        #endregion

        #region 모드 변경
        private void functionOn(object sender, MouseEventArgs e)
        {
            //모드 변경시 리스트가 넘치면 스크롤바 생성
            showScrollbar();

            this.function_on.Image = Invaiz_Console.Properties.Resources.selection;
            this.key_on.Image = Invaiz_Console.Properties.Resources.selection_off;
            this.function_panel.Visible = true;
            this.keypress_panel.Visible = false;
            this.ExcuteType = "sendScript";
            this.functionCheck = true;
            this.ActiveControl = serchText;

        }

        private void keypressOn(object sender, MouseEventArgs e)
        {
            this.customScrollbar1.Visible = false;
            this.function_on.Image = Invaiz_Console.Properties.Resources.selection_off;
            this.key_on.Image = Invaiz_Console.Properties.Resources.selection;
            this.function_panel.Visible = false;
            this.keypress_panel.Visible = true;
            this.ExcuteType = "sendKey";
            this.functionCheck = false;
            this.ActiveControl = formName_input;


            if (deviceCheck)
            {
                this.subName2_panel.Visible = true;
            }
        }
        #endregion

        #region 검색
        private void serch(string str)
        {
            this.item_list.Controls.Clear();
            //검색시 스크롤바 넘치면 생성
            showScrollbar();

            if (str.Equals(""))
            {
                //기본 셋팅 리스트를 탐색합니다.
                for (int i = 0; i < basic_controls.Count; i++)
                {
                    if (basic_controls[i].GetType() == typeof(Component.Function.FunctionCategoryList))
                    {
                        Component.Function.FunctionCategoryList category_list = (Component.Function.FunctionCategoryList)basic_controls[i];
                        this.item_list.Controls.Add(basic_controls[i]);
                        foreach (Control c in basic_controls[i].Controls)
                        {
                            if (c is Component.Function.FunctionItemList)
                            {
                                foreach (Control t in c.Controls)
                                {
                                    if (t is Component.FunctionItem)
                                    {
                                        Component.FunctionItem tmp = (Component.FunctionItem)t;
                                        tmp.init();
                                        if (tmp.FormName.Equals(this.selectedFormName))
                                        {
                                            tmp.clickUI();
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                for (int i = 0; i < copySearchList.Count; i++)
                {
                    copySearchList[i].init();
                }

            }
            else
            {
                // 리스트의 모든 데이터를 검색한다. 
                for (int i = 0; i < copySearchList.Count; i++)
                {
                    // arraylist의 모든 데이터에 입력받은 단어(charText)가 포함되어 있으면 true를 반환한다.
                    if (copySearchList[i].FormName.ToLower().Contains(serchText.Text.ToLower()))
                    {
                        this.item_list.Controls.Add(copySearchList[i]);
                        if (copySearchList[i].FormName.Equals(this.selectedFormName))
                        {
                            copySearchList[i].clickUI();
                        }
                    }
                }
            }
        }
        private void serchText_KeyUp(object sender, KeyEventArgs e)
        {
            string txt = serchText.Text;
            Console.WriteLine(txt);
            serch(txt);

            showScrollbar();
        }
        private void serchText_Click(object sender, EventArgs e)
        {
            serchText.Text = "";
        }

        private void settingList()
        {
            foreach (Control control in this.item_list.Controls)
            {

                if (control.GetType() == typeof(Component.Function.FunctionCategoryList))
                {
                    Component.Function.FunctionCategoryList categoryList = (Component.Function.FunctionCategoryList)control;
                    Component.Function.FunctionCategoryList copyCL = categoryList.deepCopy();
                    basic_controls.Add(categoryList);
                    copy_controls.Add(copyCL);
                    foreach (Control item in control.Controls)
                    {
                        if (item.GetType() == typeof(Component.FunctionCategory))
                        {
                            Component.FunctionCategory t = (Component.FunctionCategory)item;
                            Component.FunctionCategory copy_category = t.deepCopy();
                            copy_category.BackColor = Color.FromArgb(153, 180, 209);
                            copyCL.Controls.Add(copy_category);
                        }
                        if (item.GetType() == typeof(Component.Function.FunctionItemList))
                        {
                            Component.Function.FunctionItemList tmp2 = (Component.Function.FunctionItemList)item;
                            Component.Function.FunctionItemList newList = tmp2.deepCopy();
                            copyCL.Controls.Add(newList);
                            foreach (Control test in tmp2.Controls)
                            {
                                if (test.GetType() == typeof(Component.FunctionItem))
                                {
                                    Component.FunctionItem tmp3 = (Component.FunctionItem)test;
                                    Component.FunctionItem newItem = tmp3.deepCopy();

                                    basicSearchList.Add(tmp3);
                                    copySearchList.Add(newItem);
                                    newList.Controls.Add(newItem);
                                }
                            }
                        }

                    }

                }
            }
        }
        #endregion
        
        #region 저장, 취소
        private void save_Click(object sender, EventArgs e)
        {
            Util.Render render = new Util.Render();
            if (functionCheck)
            {
                if (!this.change)
                {
                    Console.WriteLine("아무것도 바꾸지 않음");
                }
                else
                {
                    this.bindingScript();
                }
            }
            else
            {
                if (String.IsNullOrEmpty(this.formName_input.Text) && String.IsNullOrEmpty(this.subName1_input.Text) && String.IsNullOrEmpty(this.subName2_input.Text))
                {
                    Console.WriteLine("비어잇네");
                    return;
                }
                else
                {
                    this.bindingKeycode();
                }
            }
            render.settingUI(this.group, this.index, this.deviceCheck);
            this.Close();
        }
        private void cancle_click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion






        Util.SetKeycode k = new Util.SetKeycode();

        #region 키입력
        private void subName1_input_KeyDown(object sender, KeyEventArgs e)
        {
            string ctrl, subText;


            if (e.Control) //컨트롤
            {
                if (e.Shift)
                {
                    if (e.Alt) //컨트롤 + 쉬프트 + 알트  + A
                    {
                        ctrl = "Ctrl + ";
                        subText = "Shift + Alt + ";
                        this.changeKeycode1 = k.setKeycode(ctrl, subText, subName1_input, e);
                        this.changeMulti1 = 7;
                    }
                    else //컨트롤 + 쉬프트 + A
                    {
                        ctrl = "Ctrl + ";
                        subText = "Shift + ";
                        this.changeKeycode1 = k.setKeycode(ctrl, subText, subName1_input, e);
                        this.changeMulti1 = 3;
                    }
                }
                else if (e.Alt) //컨트롤 + 알트 + A 
                {
                    ctrl = "Ctrl + ";
                    subText = "Alt + ";
                    this.changeKeycode1 = k.setKeycode(ctrl, subText, subName1_input, e);
                    this.changeMulti1 = 6;
                }
                else //컨트롤 + A
                {
                    ctrl = "Ctrl + ";
                    subText = "";
                    this.changeKeycode1 = k.setKeycode(ctrl, subText, subName1_input, e);
                    this.changeMulti1 = 2;
                }
            }

            else if (e.Shift) //shift O
            {
                if (e.Alt)
                {
                    ctrl = "";
                    subText = "Shift + Alt + ";
                    this.changeKeycode1 = k.setKeycode(ctrl, subText, subName1_input, e);
                    this.changeMulti1 = 8;
                }
                else
                {
                    ctrl = "";
                    subText = "Shift + ";
                    this.changeKeycode1 = k.setKeycode(ctrl, subText, subName1_input, e);
                    this.changeMulti1 = 5;
                }
            }
            else if (e.Alt) //alt O
            {
                if (e.KeyCode == Keys.F4)
                {
                    Console.WriteLine("여기");
                    e.Handled = true;
                }
                ctrl = "";
                subText = "Alt + ";
                this.changeKeycode1 = k.setKeycode(ctrl, subText, subName1_input, e);
                this.changeMulti1 = 4;
            }

            else // none
            {
                ctrl = "";
                subText = "";
                this.changeKeycode1 = k.setKeycode(ctrl, subText, subName1_input, e);
                this.changeMulti1 = 1;
            }
        }

        private void subName2_input_KeyDown(object sender, KeyEventArgs e)
        {
            string ctrl, subText;

            if (e.Control) //컨트롤
            {

                if (e.Shift)
                {
                    if (e.Alt) //컨트롤 + 쉬프트 + 알트  + A
                    {
                        ctrl = "Ctrl + ";
                        subText = "Shift + Alt + ";
                        this.changeKeycode2 = k.setKeycode(ctrl, subText, subName2_input, e);
                        this.changeMulti2 = 7;
                    }
                    else //컨트롤 + 쉬프트 + A
                    {
                        ctrl = "Ctrl + ";
                        subText = "Shift + ";
                        this.changeKeycode2 = k.setKeycode(ctrl, subText, subName2_input, e);
                        this.changeMulti2 = 3;
                    }
                }
                else if (e.Alt) //컨트롤 + 알트 + A 
                {
                    ctrl = "Ctrl + ";
                    subText = "Alt + ";
                    this.changeKeycode2 = k.setKeycode(ctrl, subText, subName2_input, e);
                    this.changeMulti2 = 6;
                }
                else //컨트롤 + A
                {
                    ctrl = "Ctrl + ";
                    subText = "";
                    this.changeKeycode2 = k.setKeycode(ctrl, subText, subName2_input, e);
                    this.changeMulti2 = 2;
                }
            }
            else if (e.Shift) //shift O
            {
                if (e.Alt)
                {
                    ctrl = "";
                    subText = "Shift + Alt + ";
                    this.changeKeycode2 = k.setKeycode(ctrl, subText, subName2_input, e);
                    this.changeMulti2 = 8;
                }
                else
                {
                    ctrl = "";
                    subText = "Shift + ";
                    this.changeKeycode2 = k.setKeycode(ctrl, subText, subName2_input, e);
                    this.changeMulti2 = 5;
                }


            }
            else if (e.Alt) //alt O
            {
                if (e.KeyCode == Keys.F4 || e.KeyCode == Keys.Tab)
                {
                    Console.WriteLine("여기");
                    e.Handled = true;
                }
                ctrl = "";
                subText = "Alt + ";
                this.changeKeycode2 = k.setKeycode(ctrl, subText, subName2_input, e);
                this.changeMulti2 = 4;

            }

            else // none
            {
                if ( e.KeyCode == Keys.Tab)
                {
                    Console.WriteLine("여기");
                    e.Handled = true;
                }
                ctrl = "";
                subText = "";
                this.changeKeycode2 = k.setKeycode(ctrl, subText, subName2_input, e);
                this.changeMulti2 = 1;
            }

        }

        #endregion

        #region 키 바인딩
        private void bindingScript()
        {
            mn = MainForm.getInstance;
            if (deviceCheck)
            {
                mn.Payloads[group].E_excuteType[index] = this.ExcuteType;
                mn.Payloads[group].E_messageType[index] = this.MsgType;
                mn.Payloads[group].E_actionType[index] = this.ActionType;
                mn.Payloads[group].E_typeKey[index] = this.TypeKey;
                mn.Payloads[group].E_formName[index] = this.FormName;
                mn.Payloads[group].E_leftKeyCode[index] = this.Keycode1;
                mn.Payloads[group].E_rightKeyCode[index] = this.Keycode2;
                mn.Payloads[group].E_leftisMulti[index] = this.Multi1;
                mn.Payloads[group].E_rightisMulti[index] = this.Multi2;
                mn.Payloads[group].E_leftSubName[index] = this.SubName1;
                mn.Payloads[group].E_rightSubName[index] = this.SubName2;

                Console.WriteLine("다이얼 기능 설정");
                Console.WriteLine("ExcuteType :" + mn.Payloads[group].E_excuteType[index]);
                Console.WriteLine("MsgType :" + mn.Payloads[group].E_messageType[index]);
                Console.WriteLine("ActionType :" + mn.Payloads[group].E_actionType[index]);
                Console.WriteLine("TypeKey :" + mn.Payloads[group].E_typeKey[index]);
                Console.WriteLine("FormName :" + mn.Payloads[group].E_formName[index]);
                Console.WriteLine("Keycode1 :" + mn.Payloads[group].E_leftKeyCode[index]);
                Console.WriteLine("Keycode2 :" + mn.Payloads[group].E_rightKeyCode[index]);
                Console.WriteLine("Multi1 :" + mn.Payloads[group].E_leftisMulti[index]);
                Console.WriteLine("Multi2 :" + mn.Payloads[group].E_rightisMulti[index]);
                Console.WriteLine("LeftSubName :" + mn.Payloads[group].E_leftSubName[index]);
                Console.WriteLine("RightSubName :" + mn.Payloads[group].E_rightSubName[index]);

            }
            else
            {
                mn.Payloads[group].B_excuteType[index] = this.ExcuteType;
                mn.Payloads[group].B_messageType[index] = this.MsgType;
                mn.Payloads[group].B_actionType[index] = this.ActionType;
                mn.Payloads[group].B_typeKey[index] = this.TypeKey;
                mn.Payloads[group].B_formName[index] = this.FormName;
                mn.Payloads[group].B_keyCode[index] = this.Keycode1;
                mn.Payloads[group].B_isMulti[index] = this.Multi1;
                mn.Payloads[group].B_subName[index] = this.SubName2;

                Console.WriteLine("버튼 기능 설정");
                Console.WriteLine("ExcuteType :" + mn.Payloads[group].B_excuteType[index]);
                Console.WriteLine("MsgType :" + mn.Payloads[group].B_messageType[index]);
                Console.WriteLine("ActionType :" + mn.Payloads[group].B_actionType[index]);
                Console.WriteLine("TypeKey :" + mn.Payloads[group].B_typeKey[index]);
                Console.WriteLine("FormName :" + mn.Payloads[group].B_formName[index]);
                Console.WriteLine("Keycode1 :" + mn.Payloads[group].B_keyCode[index]);
                Console.WriteLine("Multi1 :" + mn.Payloads[group].B_isMulti[index]);
                Console.WriteLine("SubName :" + mn.Payloads[group].B_subName[index]);
            }
        }
        private void bindingKeycode()
        {

            mn = MainForm.getInstance;
            if (deviceCheck)
            {
                this.FormName = this.formName_input.Text;
                this.Keycode1 = (changeKeycode1 == 0) ? this.Keycode1 : this.changeKeycode1;
                this.keycode2 = (changeKeycode2 == 0) ? this.Keycode2 : this.changeKeycode2;
                this.Multi1 = (changeMulti1 == 0) ? this.Multi1 : this.changeMulti1;
                this.Multi2 = (changeMulti2 == 0) ? this.Multi2 : this.changeMulti2;
                this.SubName1 = this.subName1_input.Text;
                this.SubName2 = this.subName2_input.Text;
                mn.Payloads[group].E_excuteType[index] = this.ExcuteType;
                mn.Payloads[group].E_messageType[index] = "";
                mn.Payloads[group].E_actionType[index] = "";
                mn.Payloads[group].E_typeKey[index] = "";
                mn.Payloads[group].E_formName[index] = this.FormName;
                mn.Payloads[group].E_leftKeyCode[index] = this.Keycode1;
                mn.Payloads[group].E_rightKeyCode[index] = this.Keycode2;
                mn.Payloads[group].E_leftisMulti[index] = this.Multi1;
                mn.Payloads[group].E_rightisMulti[index] = this.Multi2;
                mn.Payloads[group].E_leftSubName[index] = this.SubName1;
                mn.Payloads[group].E_rightSubName[index] = this.SubName2;

                Console.WriteLine("다이얼 사용자 키 입력");
                Console.WriteLine("ExcuteType :" + mn.Payloads[group].E_excuteType[index]);
                Console.WriteLine("MsgType :" + mn.Payloads[group].E_messageType[index]);
                Console.WriteLine("ActionType :" + mn.Payloads[group].E_actionType[index]);
                Console.WriteLine("TypeKey :" + mn.Payloads[group].E_typeKey[index]);
                Console.WriteLine("FormName :" + mn.Payloads[group].E_formName[index]);
                Console.WriteLine("Keycode1 :" + mn.Payloads[group].E_leftKeyCode[index]);
                Console.WriteLine("Keycode2 :" + mn.Payloads[group].E_rightKeyCode[index]);
                Console.WriteLine("Multi1 :" + mn.Payloads[group].E_leftisMulti[index]);
                Console.WriteLine("Multi2 :" + mn.Payloads[group].E_rightisMulti[index]);
                Console.WriteLine("LeftSubName :" + mn.Payloads[group].E_leftSubName[index]);
                Console.WriteLine("RightSubName :" + mn.Payloads[group].E_rightSubName[index]);
            }
            else
            {
                this.FormName = this.formName_input.Text;
                this.Keycode1 = (changeKeycode1 == 0) ? this.Keycode1 : this.changeKeycode1;
                this.Multi1 = (changeMulti1 == 0) ? this.Multi1 : this.changeMulti1;
                this.SubName1 = this.subName1_input.Text;
                mn.Payloads[group].B_excuteType[index] = this.ExcuteType;
                mn.Payloads[group].B_messageType[index] = "";
                mn.Payloads[group].B_actionType[index] = "";
                mn.Payloads[group].B_typeKey[index] = "";
                mn.Payloads[group].B_formName[index] = this.FormName;
                mn.Payloads[group].B_keyCode[index] = this.Keycode1;
                mn.Payloads[group].B_isMulti[index] = this.Multi1;
                mn.Payloads[group].B_subName[index] = this.SubName1;

                Console.WriteLine("버튼 사용자 키 입력");
                Console.WriteLine("ExcuteType :" + mn.Payloads[group].B_excuteType[index]);
                Console.WriteLine("MsgType :" + mn.Payloads[group].B_messageType[index]);
                Console.WriteLine("ActionType :" + mn.Payloads[group].B_actionType[index]);
                Console.WriteLine("TypeKey :" + mn.Payloads[group].B_typeKey[index]);
                Console.WriteLine("FormName :" + mn.Payloads[group].B_formName[index]);
                Console.WriteLine("Keycode1 :" + mn.Payloads[group].B_keyCode[index]);
                Console.WriteLine("Multi1 :" + mn.Payloads[group].B_isMulti[index]);
                Console.WriteLine("SubName :" + mn.Payloads[group].B_subName[index]);
            }
        }

        #endregion

        #region 스크롤 바
        private void ItemList_MouseWheel(object sender, MouseEventArgs e)
        {

            try
            {
                customScrollbar1.Value = scrollPanel.AutoScrollPosition.Y * -1;
                scrollPanel.AutoScrollPosition = new Point(0, customScrollbar1.Value);
             //   customScrollbar1.Invalidate();
               // Application.DoEvents();
            }

            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        private void customScrollbar1_Scroll(object sender, EventArgs e)
        {
            try
            {
                scrollPanel.AutoScrollPosition = new Point(0, customScrollbar1.Value);
              //  customScrollbar1.Invalidate();
               // Application.DoEvents();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


        private void customScrollbar_MouseWheel(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Delta > 0)
                {
                    customScrollbar1.Value = (scrollPanel.AutoScrollPosition.Y + 120) * -1;
                    scrollPanel.AutoScrollPosition = new Point(0, customScrollbar1.Value);
               //     customScrollbar1.Invalidate();
                 //   Application.DoEvents();
                }
                else
                {
                    customScrollbar1.Value = (scrollPanel.AutoScrollPosition.Y - 120) * -1;
                    scrollPanel.AutoScrollPosition = new Point(0, customScrollbar1.Value);
               //     customScrollbar1.Invalidate();
                 //   Application.DoEvents();
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        private void showScrollbar()
        {
            if (this.item_list.Height > 360)
            {
                this.customScrollbar1.Visible = true;
                this.customScrollbar1.Minimum = 0;
                this.customScrollbar1.Maximum = this.scrollPanel.DisplayRectangle.Height;
                this.customScrollbar1.LargeChange = this.customScrollbar1.Maximum / this.customScrollbar1.Height + this.scrollPanel.Height;
                this.customScrollbar1.SmallChange = 15;
                this.customScrollbar1.Value = Math.Abs(this.scrollPanel.AutoScrollPosition.Y);
            }
            else
            {
                this.customScrollbar1.Visible = false;

            }
        }
        #endregion

    }
}                                                    
