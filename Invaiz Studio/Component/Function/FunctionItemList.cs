using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Invaiz_Studio.Component.Function
{
    public partial class FunctionItemList : FlowLayoutPanel
    {
        public FunctionItemList()
        {
            InitializeComponent();
            this.AutoScroll = false;

        }

        private string category;

        public FunctionItemList deepCopy()
        {
            FunctionItemList list = new FunctionItemList();
            list.category = this.category;
            return list;
        }
        public string Category
        {
            get { return this.category; }
            set { this.category = value; }
        }
    }
}
