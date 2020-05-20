using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invaiz_Console.Util
{
    using System;
    using System.Windows.Forms;
    using System.Runtime.InteropServices;
    using System.Diagnostics;
    using System.DirectoryServices.ActiveDirectory;

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
            Console.WriteLine("현재 실행중인 프로세스" + ps.ProcessName);
            return processName.Equals(ps.ProcessName) ? true : false;
        }
        public bool IsProcessActive(string processName)
        {

            Util.ProcessId processId = new ProcessId();
            processName = processId.AppNameToPID(processName);

            IntPtr handle = IntPtr.Zero;
            uint pid = 0;
            Process ps = null;
            handle = GetForegroundWindow();        // 활성화 윈도우
            GetWindowThreadProcessId(handle, out pid); // 핸들로 프로세스아이디 얻어옴
            ps = Process.GetProcessById((int)pid); // 프로세스아이디로 프로세스 검색
            Console.WriteLine("2......현재 실행중인 프로세스" + ps.ProcessName);
            bool check = processName.Equals(ps.ProcessName) ? true : false;


            if (ps.ProcessName.Equals("Invaiz Console"))
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
                Console.WriteLine("3.....활성화 된  PID : " + processName);
                Render render = new Render();
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
                    Console.WriteLine("4.......찾은 프로세스" + process.ProcessName);
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

        [DllImport("user32.dll")]
        private extern static void SendInput(int nInputs, ref INPUT pInputs, int cbsize);
        [DllImport("user32.dll", EntryPoint = "MapVirtualKeyA")]
        private extern static int MapVirtualKey(int wCode, int wMapType);

        private const int INPUT_KEYBOARD = 1;
        private const int KEYEVENTF_KEYDOWN = 0x0;
        private const int KEYEVENTF_KEYUP = 0x2;
        private const int KEYEVENTF_EXTENDEDKEY = 0x1;

        public void Send(int key, bool isEXTEND)
        {

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
