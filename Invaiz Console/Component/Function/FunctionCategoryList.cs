using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Invaiz_Console.Component.Function
{
    public partial class FunctionCategoryList : FlowLayoutPanel
    {
        public FunctionCategoryList()
        {
            InitializeComponent();
        }

        private string category;
        public bool isShow = true;

        public FunctionCategoryList deepCopy()
        {
            FunctionCategoryList list = new FunctionCategoryList();
            list.category = this.category;
            list.isShow = this.isShow;
            return list;
        }
        public string Category
        {
            get { return this.category; }
            set { this.category = value; }
        }
    }
}
