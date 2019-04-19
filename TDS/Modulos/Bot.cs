using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TDS.Modulos
{

    public class Bot
    {

        private static Bot bot = new Bot();
        private bool estadoAutoChat = false;
        private string username;
        private string password;
        private int xPos;
        private int yPos;

        private Bot(){ }

        public static Bot getInstance()
        {
            return bot;
        }

        public void setCuenta(string username, string password)
        {

            this.username = username;
            this.password = password;

        }

        public void setPosicion(int x, int y)
        {

            this.xPos = x;
            this.yPos = y;

        }

        public async void initAutoChat()
        {

            this.estadoAutoChat = true;
            while (estadoAutoChat){

                var textoChat = Emulador.leerChat();
                Console.WriteLine("--------------------------------");
                Console.WriteLine(textoChat);

                // Logica anti GM
                if (detectedGM(textoChat))
                {
                    this.stopAutoChat();
                    Proceso.getInstance().reiniciarProceso();
                    break;
                } else
                {
                    await Task.Delay(30000);
                }

            }

        }

        public void stopAutoChat()
        {
            this.estadoAutoChat = false;
        }

        public void iniciarSesion()
        {
           Emulador.iniciarSesion(this.username, this.password); 
        }

        public void ponerseALaburar()
        {
            Emulador.ponerseALaburar(this.xPos, this.yPos);
        }

        private bool detectedGM(string msg)
        {
            return Regex.IsMatch(msg, "^ \r", RegexOptions.Multiline);
        }

    }
}
