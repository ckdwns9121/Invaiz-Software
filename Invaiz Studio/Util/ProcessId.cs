using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invaiz_Studio.Util
{
    class ProcessId
    {
        private const string WINDOW = "Window";
        private const string PHOTOSHOP = "Photoshop";
        private const string ILLUSTRATOR = "Illustrator";
        private const string INDESIGN = "InDesign";
        private const string AFTEREFFECT = "AfterFX";
        private const string LIGHTROOM = "Lightroom";
        private const string PREMIREPRO = "Adobe Premiere Pro";

        public string AppNameToPID(string processName)
        {
            string str="";
            switch (processName)
            {
                case "Window":
                    str = WINDOW;
                    break;
                case "Photoshop":
                    str = PHOTOSHOP;
                    break;
                case "Illustrator":
                    str = ILLUSTRATOR;
                    break;
                case "InDesign":
                    str = INDESIGN;
                    break;
                case "AfterEffect":
                    str = AFTEREFFECT;
                    break;
                case "Lightroom":
                    str = LIGHTROOM;
                    break;
                case "PremierePro":
                    str = PREMIREPRO;
                    break;
                default:
                    str = WINDOW;
                    break;

            }
            return str;
        }

        public string PIDToAppName(string processName)
        {
            string str = "";
            switch (processName)
            {
                case "Window":
                    str = "Window";
                    break;
                case "Photoshop":
                    str = "Photoshop";
                    break;
                case "Illustrator":
                    str = "Illustrator";
                    break;
                case "InDesign":
                    str = "InDesign";
                    break;
                case "AfterFX":
                    str = "AfterEffect";
                    break;
                case "Lightroom":
                    str = "Lightroom";
                    break;
                case "Adobe Premiere Pro":
                    str = "PremierePro";
                    break;
                default:
                    str = WINDOW;
                    break;

            }
            return str;
        }
    }
}
