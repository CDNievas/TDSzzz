using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TDS.Modulos
{
    public static class Emulador
    {

        public static void hacerClick(int x, int y)
        {

            Thread.Sleep(300);
            SetCursorPos(x, y);
            mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, x, y, 0, 0);

        }
        
        public static string leerChat()
        {

            var formChat = buscarFormChat();
            return GetControlText(formChat);

        }

        public static void teclear(string msg)
        {
            Thread.Sleep(300);
            SendKeys.SendWait(msg);
        }
  
        public static void iniciarSesion(string username, string password){

            // Busca form inicial
            IntPtr formInicial = FindWindow(null, "ConectarSrvrTds");

            Rect r = new Rect();
            GetWindowRect(formInicial, ref r);

            int x = r.Left;
            int y = r.Top;

            Process p = Proceso.getInstance().obtenerProceso();
            SetForegroundWindow(p.MainWindowHandle);

            Emulador.hacerClick(x+400,y+280);
            Thread.Sleep(1000);
            Emulador.teclear(username + "{TAB}" + password + "{ENTER}");

        }

        public static void ponerseALaburar(int x, int y)
        {

            Process p = Proceso.getInstance().obtenerProceso();
            SetForegroundWindow(p.MainWindowHandle);
            Emulador.hacerClick(x,y);
            Emulador.teclear("{F8}");

        }

        private static IntPtr buscarFormChat()
        {

            Process p = Proceso.getInstance().obtenerProceso();

            List<IntPtr> listaVentanas = EnumerateProcessWindowHandles(p.Id);
            List<IntPtr> listaHijos = new List<IntPtr>();

            foreach (IntPtr ventana in listaVentanas)
            {
                listaHijos.InsertRange(0, GetAllChildrenWindowHandles(ventana, "RichTextWndClass"));
            }

            return listaHijos[0];

        }


        // Funciones bajo nivel
        private static int GetControlTextLength(IntPtr hTextBox)
        {
            // helper for GetTextBoxText
            uint WM_GETTEXTLENGTH = 0x000E;
            int result = SendMessage4(hTextBox, WM_GETTEXTLENGTH,
              0, 0);
            return result;
        }

        private static string GetControlText(IntPtr hTextBox)
        {
            uint WM_GETTEXT = 0x000D;
            int len = GetControlTextLength(hTextBox);
            if (len <= 0) return null;  // no text
            StringBuilder sb = new StringBuilder(len + 1);
            SendMessage3(hTextBox, WM_GETTEXT, len + 1, sb);
            return sb.ToString();
        }

        /* 
         [DllImport("user32.dll", EntryPoint = "GetWindowText", CharSet = CharSet.Auto)]
         static extern IntPtr GetWindowCaption(IntPtr hwnd, StringBuilder lpString, int maxCount);

         private static string GetWindowCaption(IntPtr hwnd)
         {
             StringBuilder sb = new StringBuilder(256);
             GetWindowCaption(hwnd, sb, 256);
             return sb.ToString();
         }

         */

        static List<IntPtr> EnumerateProcessWindowHandles(int processId)
        {
            var handles = new List<IntPtr>();

            foreach (ProcessThread thread in Process.GetProcessById(processId).Threads)
                EnumThreadWindows(thread.Id,
                    (hWnd, lParam) => { handles.Add(hWnd); return true; }, IntPtr.Zero);

            return handles;
        }

        private static List<IntPtr> GetAllChildrenWindowHandles(IntPtr hParent, string claseWindow)
        {

            List<IntPtr> result = new List<IntPtr>();
            IntPtr prevChild = IntPtr.Zero;
            IntPtr currChild = IntPtr.Zero;
            var corte = true;
            while (corte) {
                currChild = FindWindowEx(hParent, prevChild, claseWindow, null);
                if (currChild == IntPtr.Zero)
                {
                    corte = false;
                    break;
                }
                result.Add(currChild);
                prevChild = currChild;
            }
            return result;

        }

        // Import funciones
        [DllImport("user32.dll")]
        private static extern int SetForegroundWindow(IntPtr hWnd);

        [DllImport("user32.dll", EntryPoint = "SendMessage", CharSet = CharSet.Auto)]
        static extern int SendMessage3(IntPtr hwndControl, uint Msg, int wParam, StringBuilder strBuffer); // get text

        [DllImport("user32.dll", EntryPoint = "SendMessage", CharSet = CharSet.Auto)]
        static extern int SendMessage4(IntPtr hwndControl, uint Msg, int wParam, int lParam);  // text length

        [DllImport("user32.dll")]
        static extern bool PostMessage(IntPtr hWnd, uint Msg, int wParam, int lParam);

        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
        public static extern void mouse_event(long dwFlags, long dx, long dy, long cButtons, long dwExtraInfo);

        [DllImport("user32.dll")]
        static extern bool SetCursorPos(int x, int y);

        [DllImport("user32.dll")]
        static extern bool EnumThreadWindows(int dwThreadId, EnumThreadDelegate lpfn, IntPtr lParam);

        delegate bool EnumThreadDelegate(IntPtr hWnd, IntPtr lParam);

        [DllImport("user32.dll", EntryPoint = "FindWindowEx", CharSet = CharSet.Auto)]
        static extern IntPtr FindWindowEx(IntPtr hwndParent, IntPtr hwndChildAfter, string lpszClass, string lpszWindow);

        [DllImport("user32.dll", SetLastError = true)]
        static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll")]
        public static extern bool GetWindowRect(IntPtr hwnd, ref Rect rectangle);

        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;
        private const int MOUSEEVENTF_RIGHTDOWN = 0x08;
        private const int MOUSEEVENTF_RIGHTUP = 0x10;

        [StructLayout(LayoutKind.Sequential)]
        public struct Rect
        {
            public int Left;        // x position of upper-left corner
            public int Top;         // y position of upper-left corner
            public int Right;       // x position of lower-right corner
            public int Bottom;      // y position of lower-right corner
        }

    }
}
