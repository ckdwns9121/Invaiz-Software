using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Invaiz_Studio.Component.Test
{
    public partial class CustomTextBox : TextBox
    {
        public CustomTextBox()
        {
            InitializeComponent();
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.R) ||
                keyData == (Keys.Control | Keys.L) ||
                keyData == (Keys.Control | Keys.E) ||
                keyData == (Keys.Control | Keys.J)) return false;
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
