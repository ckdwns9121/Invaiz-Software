using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invaiz_Studio.DeviceData
{
    public class Payload
    {
        public string groupName;
        /// <summary>
        /// encoder payload
        /// </summary>
        public string[] E_excuteType = new string[4];
        public string[] E_messageType = new string[4];
        public string[] E_actionType = new string[4];
        public string[] E_typeKey = new string[4];
        public string[] E_formName = new string[4]; ///formName
        public string[] E_leftSubName = new string[4];
        public string[] E_rightSubName = new string[4];

        public int[] E_leftKeyCode = new int[4]; // 키코드 값.
        public int[] E_leftisMulti = new int[4]; // 1: 싱글 , 2: 컨트롤 , 3:컨트롤+쉬프트 , 4:알트 

        public int[] E_rightKeyCode = new int[4]; 
        public int[] E_rightisMulti = new int[4];

        /// <summary>
        /// button payload
        /// </summary>
        public string[] B_excuteType = new string[4];
        public string[] B_messageType = new string[4];
        public string[] B_actionType = new string[4];
        public string[] B_typeKey = new string[4];
        public string[] B_formName = new string[4]; ///formName
        public string[] B_subName = new string[4];

        public int[] B_keyCode = new int[4]; // 키코드 값.
        public int[] B_isMulti = new int[4]; // 1: 싱글 , 2: 컨트롤 , 3:컨트롤+쉬프트 , 4:알트  5: 쉬프트


    }

}
