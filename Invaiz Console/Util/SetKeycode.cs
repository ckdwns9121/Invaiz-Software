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

            //if (e.KeyCode == Keys.A)
            //{
            //    textbox.Text = ctrl + shift + "A";
            //    return (int)e.KeyCode;
            //}
            //if (e.KeyCode == Keys.B)
            //{
            //    textbox.Text = ctrl + shift + "B";
            //    return (int)e.KeyCode;
            //}
            //if (e.KeyCode == Keys.C)
            //{
            //    textbox.Text = ctrl + shift + "C";
            //    return (int)e.KeyCode;
            //}
            //if (e.KeyCode == Keys.D)
            //{
            //    textbox.Text = ctrl + shift + "D";
            //    return (int)e.KeyCode;
            //}
            //if (e.KeyCode == Keys.E)
            //{
            //    textbox.Text = ctrl + shift + "E";
            //    return (int)e.KeyCode;
            //}
            //if (e.KeyCode == Keys.F)
            //{
            //    textbox.Text = ctrl + shift + "F";
            //    return (int)e.KeyCode;
            //}
            //if (e.KeyCode == Keys.G)
            //{
            //    textbox.Text = ctrl + shift + "G";
            //    return (int)e.KeyCode;
            //}
            //if (e.KeyCode == Keys.H)
            //{
            //    textbox.Text = ctrl + shift + "H";
            //    return (int)e.KeyCode;
            //}
            //if (e.KeyCode == Keys.I)
            //{
            //    textbox.Text = ctrl + shift + "I";
            //    return (int)e.KeyCode;
            //}
            //if (e.KeyCode == Keys.J)
            //{
            //    textbox.Text = ctrl + shift + "J";
            //    return (int)e.KeyCode;
            //}
            //if (e.KeyCode == Keys.K)
            //{
            //    textbox.Text = ctrl + shift + "K";
            //    return (int)e.KeyCode;
            //}
            //if (e.KeyCode == Keys.L)
            //{
            //    textbox.Text = ctrl + shift + "L";
            //    return (int)e.KeyCode;
            //}
            //if (e.KeyCode == Keys.M)
            //{
            //    textbox.Text = ctrl + shift + "M";
            //    return (int)e.KeyCode;
            //}
            //if (e.KeyCode == Keys.N)
            //{
            //    textbox.Text = ctrl + shift + "N";
            //    return (int)e.KeyCode;
            //}
            //if (e.KeyCode == Keys.O)
            //{
            //    textbox.Text = ctrl + shift + "O";
            //    return (int)e.KeyCode;
            //}
            //if (e.KeyCode == Keys.P)
            //{
            //    textbox.Text = ctrl + shift + "P";
            //    return (int)e.KeyCode;
            //}
            //if (e.KeyCode == Keys.Q)
            //{
            //    textbox.Text = ctrl + shift + "Q";
            //    return (int)e.KeyCode;
            //}
            //if (e.KeyCode == Keys.R)
            //{
            //    textbox.Text = ctrl + shift + "R";
            //    return (int)e.KeyCode;
            //}
            //if (e.KeyCode == Keys.S)
            //{
            //    textbox.Text = ctrl + shift + "S";
            //    return (int)e.KeyCode;
            //}
            //if (e.KeyCode == Keys.T)
            //{
            //    textbox.Text = ctrl + shift + "T";
            //    return (int)e.KeyCode;
            //}
            //if (e.KeyCode == Keys.U)
            //{
            //    textbox.Text = ctrl + shift + "U";
            //    return (int)e.KeyCode;
            //}
            //if (e.KeyCode == Keys.V)
            //{
            //    textbox.Text = ctrl + shift + "V";
            //    return (int)e.KeyCode;
            //}
            //if (e.KeyCode == Keys.W)
            //{
            //    textbox.Text = ctrl + shift + "W";
            //    return (int)e.KeyCode;
            //}
            //if (e.KeyCode == Keys.X)
            //{
            //    textbox.Text = ctrl + shift + "X";
            //    return (int)e.KeyCode;
            //}
            //if (e.KeyCode == Keys.Y)
            //{
            //    textbox.Text = ctrl + shift + "Y";
            //    return (int)e.KeyCode;
            //}
            //if (e.KeyCode == Keys.Z)
            //{
            //    textbox.Text = ctrl + shift + "Z";
            //    return (int)e.KeyCode;
            //}
            //if (e.KeyCode == Keys.Back)
            //{
            //    textbox.Text = ctrl + shift + "Backspace";
            //    return (int)e.KeyCode;
            //}
            //if (e.KeyCode == Keys.Space)
            //{
            //    textbox.Text = ctrl + shift + "Space";
            //    return (int)e.KeyCode;
            //}
            //if (e.KeyCode == Keys.NumPad0)
            //{
            //    textbox.Text = ctrl + shift + "Num0";
            //    return (int)e.KeyCode;
            //}
            //if (e.KeyCode == Keys.NumPad1)
            //{
            //    textbox.Text = ctrl + shift + "Num1";
            //    return (int)e.KeyCode;
            //}
            //if (e.KeyCode == Keys.NumPad2)
            //{
            //    textbox.Text = ctrl + shift + "Num2";
            //    return (int)e.KeyCode;
            //}
            //if (e.KeyCode == Keys.NumPad3)
            //{
            //    textbox.Text = ctrl + shift + "Num3";
            //    return (int)e.KeyCode;
            //}
            //if (e.KeyCode == Keys.NumPad4)
            //{
            //    textbox.Text = ctrl + shift + "Num4";
            //    return (int)e.KeyCode;
            //}
            //if (e.KeyCode == Keys.NumPad5)
            //{
            //    textbox.Text = ctrl + shift + "Num5";
            //    return (int)e.KeyCode;
            //}
            //if (e.KeyCode == Keys.NumPad6)
            //{
            //    textbox.Text = ctrl + shift + "Num6";
            //    return (int)e.KeyCode;
            //}
            //if (e.KeyCode == Keys.NumPad7)
            //{
            //    textbox.Text = ctrl + shift + "Num7";
            //    return (int)e.KeyCode;
            //}
            //if (e.KeyCode == Keys.NumPad8)
            //{
            //    textbox.Text = ctrl + shift + "Num8";
            //    return (int)e.KeyCode;
            //}
            //if (e.KeyCode == Keys.NumPad9)
            //{
            //    textbox.Text = ctrl + shift + "Num9";
            //    return (int)e.KeyCode;
            //}

            //if (e.KeyCode == Keys.D0)
            //{
            //    textbox.Text = ctrl + shift + "0";
            //    return (int)e.KeyCode;
            //}
            //if (e.KeyCode == Keys.D1)
            //{
            //    textbox.Text = ctrl + shift + "1";
            //    return (int)e.KeyCode;
            //}
            //if (e.KeyCode == Keys.D2)
            //{
            //    textbox.Text = ctrl + shift + "2";
            //    return (int)e.KeyCode;
            //}
            //if (e.KeyCode == Keys.D3)
            //{
            //    textbox.Text = ctrl + shift + "3";
            //    return (int)e.KeyCode;
            //}
            //if (e.KeyCode == Keys.D4)
            //{
            //    textbox.Text = ctrl + shift + "4";
            //    return (int)e.KeyCode;
            //}
            //if (e.KeyCode == Keys.D5)
            //{
            //    textbox.Text = ctrl + shift + "5";
            //    return (int)e.KeyCode;
            //}
            //if (e.KeyCode == Keys.D6)
            //{
            //    textbox.Text = ctrl + shift + "6";
            //    return (int)e.KeyCode;
            //}
            //if (e.KeyCode == Keys.D7)
            //{
            //    textbox.Text = ctrl + shift + "7";
            //    return (int)e.KeyCode;
            //}
            //if (e.KeyCode == Keys.D8)
            //{
            //    textbox.Text = ctrl + shift + "8";
            //    return (int)e.KeyCode;
            //}
            //if (e.KeyCode == Keys.D9)
            //{
            //    textbox.Text = ctrl + shift + "9";
            //    return (int)e.KeyCode;
            //}

            //if (e.KeyCode == Keys.Oemplus)
            //{
            //    textbox.Text = ctrl + shift + "=";
            //    return (int)e.KeyCode;
            //}
            //if (e.KeyCode == Keys.OemMinus)
            //{
            //    textbox.Text = ctrl + shift + "-";
            //    return (int)e.KeyCode;
            //}
            //if (e.KeyCode == Keys.Oem4)
            //{
            //    textbox.Text = ctrl + shift + "[";
            //    return (int)e.KeyCode;
            //}
            //if (e.KeyCode == Keys.Oem6)
            //{
            //    textbox.Text = ctrl + shift + "]";
            //    return (int)e.KeyCode;
            //}
            //if (e.KeyCode == Keys.Left)
            //{
            //    textbox.Text = ctrl + shift + "←";
            //    return (int)e.KeyCode;
            //}
            //if (e.KeyCode == Keys.Up)
            //{
            //    textbox.Text = ctrl + shift + "↑";
            //    return (int)e.KeyCode;
            //}
            //if (e.KeyCode == Keys.Right)
            //{
            //    textbox.Text = ctrl + shift + "→";
            //    return (int)e.KeyCode;
            //}
            //if (e.KeyCode == Keys.Down)
            //{
            //    textbox.Text = ctrl + shift + "↓";
            //    return (int)e.KeyCode;
            //}
            //if (e.KeyCode == Keys.Oemcomma)
            //{
            //    textbox.Text = ctrl + shift + "Comma";
            //    return (int)e.KeyCode;
            //}
            //if (e.KeyCode == Keys.OemPeriod)
            //{
            //    textbox.Text = ctrl + shift + ".";
            //    return (int)e.KeyCode;
            //}
            //if (e.KeyCode == Keys.OemQuestion)
            //{
            //    textbox.Text = ctrl + shift + "/";
            //    return (int)e.KeyCode;
            //}
            //if (e.KeyCode == Keys.F1)
            //{
            //    textbox.Text = ctrl + shift + "F1";
            //    return (int)e.KeyCode;
            //}
            //if (e.KeyCode == Keys.F2)
            //{
            //    textbox.Text = ctrl + shift + "F2";
            //    return (int)e.KeyCode;
            //}
            //if (e.KeyCode == Keys.F3)
            //{
            //    textbox.Text = ctrl + shift + "F3";
            //    return (int)e.KeyCode;
            //}
            //if (e.KeyCode == Keys.F4)
            //{
            //    textbox.Text = ctrl + shift + "F4";
            //    return (int)e.KeyCode;
            //}
            //if (e.KeyCode == Keys.F5)
            //{
            //    textbox.Text = ctrl + shift + "F5";
            //    return (int)e.KeyCode;
            //}
            //if (e.KeyCode == Keys.F6)
            //{
            //    textbox.Text = ctrl + shift + "F6";
            //    return (int)e.KeyCode;
            //}
            //if (e.KeyCode == Keys.F7)
            //{
            //    textbox.Text = ctrl + shift + "F7";
            //    return (int)e.KeyCode;
            //}
            //if (e.KeyCode == Keys.F8)
            //{
            //    textbox.Text = ctrl + shift + "F8";
            //    return (int)e.KeyCode;
            //}
            //if (e.KeyCode == Keys.F9)
            //{
            //    textbox.Text = ctrl + shift + "F9";
            //    return (int)e.KeyCode;
            //}
            //if (e.KeyCode == Keys.F10)
            //{
            //    textbox.Text = ctrl + shift + "F10";
            //    return (int)e.KeyCode;
            //}
            //if (e.KeyCode == Keys.F11)
            //{
            //    textbox.Text = ctrl + shift + "F11";
            //    return (int)e.KeyCode;
            //}
            //if (e.KeyCode == Keys.F12)
            //{
            //    textbox.Text = ctrl + shift + "F12";
            //    return (int)e.KeyCode;
            //}
            //if(e.KeyCode == Keys.PageUp)
            //{
            //    textbox.Text = ctrl + shift + "PageUp";
            //    return (int)e.KeyCode;
            //}
            //if (e.KeyCode == Keys.PageDown)
            //{
            //    textbox.Text = ctrl + shift + "PageDown";
            //    return (int)e.KeyCode;
            //}
            //if (e.KeyCode == Keys.Insert)
            //{
            //    textbox.Text = ctrl + shift + "Insert";
            //    return (int)e.KeyCode;
            //}
            //if (e.KeyCode == Keys.Delete)
            //{
            //    textbox.Text = ctrl + shift + "Delete";
            //    return (int)e.KeyCode;
            //}
            //if (e.KeyCode == Keys.Home)
            //{
            //    textbox.Text = ctrl + shift + "Home";
            //    return (int)e.KeyCode;
            //}
            //if (e.KeyCode == Keys.End)
            //{
            //    textbox.Text = ctrl + shift + "End";
            //    return (int)e.KeyCode;
            //}
            //if (e.KeyCode == Keys.Add)
            //{
            //    textbox.Text = ctrl + shift + "+";
            //    return (int)e.KeyCode;
            //}
            //if (e.KeyCode == Keys.Subtract)
            //{
            //    textbox.Text = ctrl + shift + "-";
            //    return (int)e.KeyCode;
            //}
            //if (e.KeyCode == Keys.Multiply)
            //{
            //    textbox.Text = ctrl + shift + "*";
            //    return (int)e.KeyCode;
            //}
            //if (e.KeyCode == Keys.Oemtilde)
            //{
            //    textbox.Text = ctrl + shift + "~";
            //    return (int)e.KeyCode;
            //}
        }
    }
}
