using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Invaiz_Console.Util
{
    class SetKeycode
    {




        public int setKeycode(string ctrl, string shift, TextBox textbox, KeyEventArgs e)
        {
            int code = (int)e.KeyCode;

            //CTRL SHIFT ALT RETURN
            if (code == 17 || code == 16 || code == 18)
            {
                return (int)e.KeyCode;
            }
            KeysConverter converter = new KeysConverter();
            // string str = converter.ConvertToInvariantString((int)e.KeyCode);
            string str = converter.ConvertToString(code);
            Console.WriteLine(str);

            switch (str)
            {
                case "Oemtilde":
                    str = "`";
                    break;
                case "Oemcomma":
                    str = ",";
                    break;
                case "OemPeriod":
                    str = ".";
                    break;
                case "OemQuestion":
                    str = "/";
                    break;
                case "OemMinus":
                    str = "Minus";
                    break;
                case "Oemplus":
                    str = "Plus";
                    break;
                case "Oem5":
                    str =@"\";
                    break;
                case "OemOpenBrackets":
                    str = "[";
                    break;
                case "Oem6":
                    str = "]";
                    break;
                case "Oem7":
                    str = "'";
                    break;
                case "Oem1":
                    str = ";";
                    break;
                default:
                    break;
            }
            textbox.Text = ctrl + shift + str;
            return (int)e.KeyCode;
        }
    }
}
