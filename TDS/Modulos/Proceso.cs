using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TDS.Modulos;

namespace TDS.Modulos
{
    public class Proceso
    {

        private static Proceso singleton = new Proceso();
        private Process proceso;
        public string path;

        private Proceso() { }

        public static Proceso getInstance()
        {
            return singleton;
        }

        public Process obtenerProceso()
        {
            return this.proceso;
        }

        public void setPath(string path)
        {
            this.path = path;
        }

        public void iniciarProceso()
        {

            ProcessStartInfo psi = new ProcessStartInfo(path);
            psi.WindowStyle = ProcessWindowStyle.Minimized;
            proceso = Process.Start(psi);
            proceso.WaitForInputIdle();

        }

        public void reiniciarProceso()
        {
            this.cerrarProceso();
            this.iniciarProceso();

            Thread.Sleep(3000);
            Bot.getInstance().iniciarSesion();
            Thread.Sleep(3000);
            Bot.getInstance().initAutoChat();
            Bot.getInstance().ponerseALaburar();

        }
        
        public void cerrarProceso()
        {

            if( proceso != null) {
                var appWin = proceso.MainWindowHandle;
                if (appWin != IntPtr.Zero)
                {

                    // Post a colse message
                    PostMessage(appWin, (uint)WindowsMessages.WM_CLOSE, 0, 0);
                    // Delay for it to get the message
                    System.Threading.Thread.Sleep(1000);
                    // Clear internal handle
                    appWin = IntPtr.Zero;
                    proceso = null;

                }
            }

        }

        // Import funciones
        [DllImport("user32.dll")]
        static extern bool PostMessage(IntPtr hWnd, uint Msg, int wParam, int lParam);

    }
}
