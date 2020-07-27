using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invaiz_Studio.Util
{
    using System;
    using System.Windows.Forms;
    using System.Runtime.InteropServices;
    using System.Diagnostics;
    using System.DirectoryServices.ActiveDirectory;
    using System.ComponentModel;

    class ImportWinapi
    {

        [DllImport("user32.dll", SetLastError = true)]
        static extern uint GetWindowThreadProcessId(IntPtr hWnd, out uint lpdwProcessId);
        [DllImport("user32.dll")]
        static extern uint GetWindowThreadProcessId(IntPtr hWnd, IntPtr ProcessId);
        [DllImport("user32.dll")]
        private static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll")]
        private static extern bool SetForegroundWindow(IntPtr hWnd);

        [DllImport("user32.dll")]
        private static extern bool ShowWindowAsync(IntPtr hWnd, int nCmdShow);

        [DllImport("user32.dll")]
        public static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);


        private const int SW_SHOWNORMAL = 1;
        private const int SW_SHOWMINIMIZED = 2;
        private const int SW_SHOWMAXIMIZED = 3;

        public bool CurrentProcess(string processName)
        {

            IntPtr handle = IntPtr.Zero;
            uint pid = 0;
            Process ps = null;
            handle = GetForegroundWindow();        // 활성화 윈도우
            GetWindowThreadProcessId(handle, out pid); // 핸들로 프로세스아이디 얻어옴
            ps = Process.GetProcessById((int)pid); // 프로세스아이디로 프로세스 검색
          //  Console.WriteLine("현재 실행중인 프로세스" + ps.ProcessName);
            return processName.Equals(ps.ProcessName) ? true : false;
        }
        public bool IsProcessActive(string processName)
        {

            Util.ProcessId processId = new ProcessId();
            processName = processId.AppNameToPID(processName);
            Console.WriteLine("프로세스 이름" + processName); 
            IntPtr handle = IntPtr.Zero;
            uint pid = 0;
            Process ps = null;
            handle = GetForegroundWindow();        // 활성화 윈도우
            GetWindowThreadProcessId(handle, out pid); // 핸들로 프로세스아이디 얻어옴
            ps = Process.GetProcessById((int)pid); // 프로세스아이디로 프로세스 검색
           // Console.WriteLine("2......현재 실행중인 프로세스" + ps.ProcessName);
            bool check = processName.Equals(ps.ProcessName) ? true : false;

            if (ps.ProcessName.Equals("Invaiz Studio"))
            {
                Console.WriteLine("3........여기 드러옴");
                MainForm mn = MainForm.getInstance;
                ProcessCall(mn.AppName);
                return true;
            }
            else if (check) return true ;
            else
            {
                processName = processId.PIDToAppName(ps.ProcessName);
              //  Console.WriteLine("3.....활성화 된  PID : " + processName);
                MainRender render = new MainRender();
                render.ProcessChangeReRender(processName);
                return false;
            }
        }

        public string CurrentProcess()

        {
            IntPtr handle = IntPtr.Zero;
            uint pid = 0;
            Process ps = null;
            handle = GetForegroundWindow();        // 활성화 윈도우
            GetWindowThreadProcessId(handle, out pid); // 핸들로 프로세스아이디 얻어옴
            ps = Process.GetProcessById((int)pid); // 프로세스아이디로 프로세스 검색
            Console.WriteLine("현재 실행중인 프로세스" + ps.ProcessName);
            return ps.ProcessName;

        }

        public void ProcessCall(string processName)
        {
            Util.ProcessId processId = new ProcessId();
            processName = processId.AppNameToPID(processName);

            foreach (Process process in Process.GetProcesses())
            {
                //Console.WriteLine("프로세스 이름" + process.ProcessName);
                // 소프트웨어에 등록된 프로그램이랑 활성 프로세스가 같으면 
                // 그 프로세스 활성화.
                if (process.ProcessName == processName)
                {
                    //Console.WriteLine("4.......찾은 프로세스" + process.ProcessName);
                    Console.WriteLine(SetForegroundWindow(process.MainWindowHandle).ToString());
                    SetForegroundWindow(process.MainWindowHandle);
                }
            }
        }

        [StructLayout(LayoutKind.Sequential)]
        private struct MOUSEINPUT
        {
            public int dx;
            public int dy;
            public int mouseData;
            public int dwFlags;
            public int time;
            public int dwExtraInfo;
        };

        [StructLayout(LayoutKind.Sequential)]
        private struct KEYBDINPUT
        {
            public short wVk;
            public short wScan;
            public int dwFlags;
            public int time;
            public int dwExtraInfo;
        };

        [StructLayout(LayoutKind.Sequential)]
        private struct HARDWAREINPUT
        {
            public int uMsg;
            public short wParamL;
            public short wParamH;
        };

        [StructLayout(LayoutKind.Explicit)]
        private struct INPUT
        {
            [FieldOffset(0)]
            public int type;
            [FieldOffset(4)]
            public MOUSEINPUT no;
            [FieldOffset(4)]
            public KEYBDINPUT ki;
            [FieldOffset(4)]
            public HARDWAREINPUT hi;
        };

        [Flags]
        private enum MouseEventType
        {
            MOUSEEVENTF_MOVE = 0x0001,
            MOUSEEVENTF_LEFTDOWN = 0x0002,
            MOUSEEVENTF_LEFTUP = 0x0004,
            MOUSEEVENTF_RIGHTDOWN = 0x0008,
            MOUSEEVENTF_RIGHTUP = 0x0010,
            MOUSEEVENTF_MIDDLEDOWN = 0x0020,
            MOUSEEVENTF_MIDDLEUP = 0x0040,
            MOUSEEVENTF_XDOWN = 0x0080,
            MOUSEEVENTF_XUP = 0x0100,
            MOUSEEVENTF_WHEEL = 0x0800,
            MOUSEEVENTF_HWHEEL = 0x1000,
            MOUSEEVENTF_ABSOLUTE = 0x8000
        }

        //[DllImport("user32.dll")]
        //private extern static uint SendInput(int nInputs, INPUT[] pInputs, int cbsize);

        [DllImport("user32.dll")]
        private extern static uint SendInput(int nInputs, ref INPUT pInputs, int cbsize);
        [DllImport("user32.dll", EntryPoint = "MapVirtualKeyA")]
        private extern static int MapVirtualKey(int wCode, int wMapType);

        private const int INPUT_KEYBOARD = 1;
        private const int KEYEVENTF_KEYDOWN = 0x0;
        private const int KEYEVENTF_KEYUP = 0x2;
        private const int KEYEVENTF_EXTENDEDKEY = 0x1;

        private const int INPUT_MOUSE = 0X0;
        private const int MOUSEEVENTF_WHEEL = 0x0800;
        private const int MOUSEEVENTF_HWHEEL = 0x1000;

        public void mouseWheel(int direction , bool check)
        {
            Console.WriteLine("마우스 휠");
            INPUT inp = new INPUT();
            inp.type = INPUT_MOUSE;
            inp.no.dx = 0;
            inp.no.dy = 0;
            inp.no.mouseData = direction;
            inp.no.time = 0;
            inp.no.dwFlags = (check) ? MOUSEEVENTF_WHEEL : MOUSEEVENTF_HWHEEL;
            inp.no.dwExtraInfo = 0;
            SendInput(1, ref inp, Marshal.SizeOf(inp));

        }
        List<INPUT> inputs = new List<INPUT>();
        INPUT[] i = new INPUT[2];
        public void Send(int key, bool isEXTEND)
        {
            Console.WriteLine("Gd");

            //원래코드
            INPUT inp = new INPUT();
            inp.type = INPUT_KEYBOARD;
            inp.ki.wVk = (short)key;
            inp.ki.wScan = (short)MapVirtualKey(inp.ki.wVk, 0);
            inp.ki.dwFlags = ((isEXTEND) ? (KEYEVENTF_EXTENDEDKEY) : 0x0) | KEYEVENTF_KEYDOWN;
            inp.ki.time = 0;
            inp.ki.dwExtraInfo = 0;
            SendInput(1, ref inp, Marshal.SizeOf(inp));
            System.Threading.Thread.Sleep(100);
            inp.ki.dwFlags = ((isEXTEND) ? (KEYEVENTF_EXTENDEDKEY) : 0x0) | KEYEVENTF_KEYUP;
            SendInput(1, ref inp, Marshal.SizeOf(inp));
            //원래코드

            //i[0] = new INPUT();
            //i[0].type = INPUT_KEYBOARD;
            //i[0].ki.wVk = (short)key;
            //i[0].ki.wScan = (short)MapVirtualKey(i[0].ki.wVk, 0);
            //i[0].ki.dwFlags = ((isEXTEND) ? (KEYEVENTF_EXTENDEDKEY) : 0x0) | KEYEVENTF_KEYDOWN;
            //i[0].ki.time = 0;
            //i[0].ki.dwExtraInfo = 0;

            ////i[1] = new INPUT();

            ////i[1].type = INPUT_KEYBOARD;
            ////i[1].ki.wVk = (short)key;
            ////i[1].ki.wScan = (short)MapVirtualKey(i[1].ki.wVk, 0);
            ////i[1].ki.dwFlags = ((isEXTEND) ? (KEYEVENTF_EXTENDEDKEY) : 0x0) | KEYEVENTF_KEYDOWN;
            ////i[1].ki.time = 0;
            ////i[1].ki.dwExtraInfo = 0;

            //INPUT input = new INPUT();

            //input.type = INPUT_KEYBOARD;
            //input.ki.wVk = (short)key;
            //input.ki.wScan = (short)MapVirtualKey(input.ki.wVk, 0);
            //input.ki.dwFlags = ((isEXTEND) ? (KEYEVENTF_EXTENDEDKEY) : 0x0) | KEYEVENTF_KEYDOWN;
            //input.ki.time = 0;
            //input.ki.dwExtraInfo = 0;

            //inputs.Add(input);


            //input = new INPUT();

            //input.type = INPUT_KEYBOARD;
            //input.ki.wVk = (short)65;
            //input.ki.wScan = (short)MapVirtualKey(input.ki.wVk, 0);
            //input.ki.dwFlags = ((isEXTEND) ? (KEYEVENTF_EXTENDEDKEY) : 0x0) | KEYEVENTF_KEYDOWN;
            //input.ki.time = 0;
            //input.ki.dwExtraInfo = 0;
            //inputs.Add(input);

            //input = new INPUT();

            //input.type = INPUT_KEYBOARD;
            //input.ki.wVk = (short)66;
            //input.ki.wScan = (short)MapVirtualKey(input.ki.wVk, 0);
            //input.ki.dwFlags = ((isEXTEND) ? (KEYEVENTF_EXTENDEDKEY) : 0x0) | KEYEVENTF_KEYDOWN;
            //input.ki.time = 0;
            //input.ki.dwExtraInfo = 0;
            //inputs.Add(input);
            //uint result = SendInput(inputs.Count, inputs.ToArray(), Marshal.SizeOf(inputs[0]));
            //if (result == 0)
            //    throw new Win32Exception(Marshal.GetLastWin32Error());

            //inputs.Clear();
            //Console.WriteLine("결과값");
            //System.Threading.Thread.Sleep(100);
            //inp.ki.dwFlags = ((isEXTEND) ? (KEYEVENTF_EXTENDEDKEY) : 0x0) | KEYEVENTF_KEYUP;
            //SendInput(1, ref inp, Marshal.SizeOf(inp));


        }

        public void SendKeyDown(int keycode, bool isEXTEND)
        {

            INPUT inp = new INPUT();
            inp.type = INPUT_KEYBOARD;
            inp.ki.wVk = (short)keycode;
            inp.ki.wScan = (short)MapVirtualKey(inp.ki.wVk, 0);
            inp.ki.dwFlags = ((isEXTEND) ? (KEYEVENTF_EXTENDEDKEY) : 0x0) | KEYEVENTF_KEYDOWN;
            inp.ki.time = 0;
            inp.ki.dwExtraInfo = 0;
            SendInput(1, ref inp, Marshal.SizeOf(inp));
        }

        public void SendKeyUp(int keycode, bool isEXTEND)
        {
            INPUT inp = new INPUT();
            inp.type = INPUT_KEYBOARD;
            inp.ki.wVk = (short)keycode;
            inp.ki.wScan = (short)MapVirtualKey(inp.ki.wVk, 0);
            inp.ki.dwFlags = ((isEXTEND) ? (KEYEVENTF_EXTENDEDKEY) : 0x0) | KEYEVENTF_KEYUP;
            inp.ki.time = 0;
            inp.ki.dwExtraInfo = 0;
            SendInput(1, ref inp, Marshal.SizeOf(inp));
        }
    }
}
