using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TDS.Modulos;

namespace TDS
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
            getCursorPosition();
            this.KeyDown += MainForm_KeyDown;
            this.FormClosed += MainForm_FormClosed;

        }

        private void MainForm_Load(object sender, EventArgs e) {}

        private async void getCursorPosition()
        {

            while (true){

                int x = Cursor.Position.X;
                int y = Cursor.Position.Y;

                status_x.Text = "X: " + x;
                status_y.Text = "Y: " + y;

                await Task.Delay(100);

            }


        }

        private void btn_iniciarSesion_Click(object sender, EventArgs e)
        {

            Proceso p = Proceso.getInstance();
            p.setPath(txt_pathExe.Text);
            p.iniciarProceso();
            Thread.Sleep(3000);
            Bot.getInstance().setCuenta(txt_usuario.Text,txt_password.Text);
            Bot.getInstance().iniciarSesion();
            Thread.Sleep(500);
            Bot.getInstance().initAutoChat();

        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt && e.KeyCode == Keys.F)
            {

                int x = Cursor.Position.X;
                int y = Cursor.Position.Y;

                txt_x.Text = x.ToString();
                txt_y.Text = y.ToString();

                Bot.getInstance().setPosicion(x, y);

            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Proceso.getInstance().cerrarProceso();
        }

        private void link_git_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.github.com/CDNievas");
        }

        private void link_repo_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.github.com/CDNievas/TDSzzz");
        }

        private void btn_seleccion_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "C://";
                openFileDialog.Filter = "Exe Files (.exe)|*.exe|All Files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    var filePath = openFileDialog.FileName;

                    txt_pathExe.Text = filePath.ToString();

                }
            }

        }
    }
}
