namespace TDS
{
    partial class MainForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_iniciarSesion = new System.Windows.Forms.Button();
            this.txt_x = new System.Windows.Forms.TextBox();
            this.txt_y = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.status_x = new System.Windows.Forms.ToolStripStatusLabel();
            this.status_y = new System.Windows.Forms.ToolStripStatusLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.link_git = new System.Windows.Forms.LinkLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.link_repo = new System.Windows.Forms.LinkLabel();
            this.txt_pathExe = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_seleccion = new System.Windows.Forms.Button();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_usuario
            // 
            this.txt_usuario.Location = new System.Drawing.Point(12, 140);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(187, 20);
            this.txt_usuario.TabIndex = 2;
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(12, 189);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.Size = new System.Drawing.Size(187, 20);
            this.txt_password.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Contraseña";
            // 
            // btn_iniciarSesion
            // 
            this.btn_iniciarSesion.Location = new System.Drawing.Point(221, 140);
            this.btn_iniciarSesion.Name = "btn_iniciarSesion";
            this.btn_iniciarSesion.Size = new System.Drawing.Size(187, 69);
            this.btn_iniciarSesion.TabIndex = 6;
            this.btn_iniciarSesion.Text = "Iniciar Sesion";
            this.btn_iniciarSesion.UseVisualStyleBackColor = true;
            this.btn_iniciarSesion.Click += new System.EventHandler(this.btn_iniciarSesion_Click);
            // 
            // txt_x
            // 
            this.txt_x.Enabled = false;
            this.txt_x.Location = new System.Drawing.Point(30, 256);
            this.txt_x.Name = "txt_x";
            this.txt_x.Size = new System.Drawing.Size(43, 20);
            this.txt_x.TabIndex = 8;
            this.txt_x.Text = "0";
            // 
            // txt_y
            // 
            this.txt_y.Enabled = false;
            this.txt_y.Location = new System.Drawing.Point(101, 256);
            this.txt_y.Name = "txt_y";
            this.txt_y.Size = new System.Drawing.Size(43, 20);
            this.txt_y.TabIndex = 9;
            this.txt_y.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "X:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(83, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Y:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.status_x,
            this.status_y});
            this.statusStrip1.Location = new System.Drawing.Point(0, 304);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(421, 24);
            this.statusStrip1.TabIndex = 13;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // status_x
            // 
            this.status_x.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.status_x.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.status_x.Name = "status_x";
            this.status_x.Size = new System.Drawing.Size(30, 19);
            this.status_x.Text = "X: 0";
            // 
            // status_y
            // 
            this.status_y.Name = "status_y";
            this.status_y.Size = new System.Drawing.Size(26, 19);
            this.status_y.Text = "Y: 0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(222, 26);
            this.label5.TabIndex = 14;
            this.label5.Text = "Use Alt + F para poder guardar la posicion del\r\nmouse y asi retomar la tarea";
            // 
            // link_git
            // 
            this.link_git.AutoSize = true;
            this.link_git.Location = new System.Drawing.Point(297, 225);
            this.link_git.Name = "link_git";
            this.link_git.Size = new System.Drawing.Size(110, 13);
            this.link_git.TabIndex = 15;
            this.link_git.TabStop = true;
            this.link_git.Text = "Creado por CDNievas";
            this.link_git.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_git_LinkClicked);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(5, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(205, 37);
            this.label6.TabIndex = 16;
            this.label6.Text = "TDS zzz v1.0";
            // 
            // link_repo
            // 
            this.link_repo.AutoSize = true;
            this.link_repo.Location = new System.Drawing.Point(344, 247);
            this.link_repo.Name = "link_repo";
            this.link_repo.Size = new System.Drawing.Size(63, 13);
            this.link_repo.TabIndex = 17;
            this.link_repo.TabStop = true;
            this.link_repo.Text = "Link GitHub";
            this.link_repo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_repo_LinkClicked_1);
            // 
            // txt_pathExe
            // 
            this.txt_pathExe.Location = new System.Drawing.Point(12, 89);
            this.txt_pathExe.Name = "txt_pathExe";
            this.txt_pathExe.Size = new System.Drawing.Size(220, 20);
            this.txt_pathExe.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Path al TDS.exe";
            // 
            // btn_seleccion
            // 
            this.btn_seleccion.Location = new System.Drawing.Point(248, 75);
            this.btn_seleccion.Name = "btn_seleccion";
            this.btn_seleccion.Size = new System.Drawing.Size(159, 47);
            this.btn_seleccion.TabIndex = 20;
            this.btn_seleccion.Text = "Seleccionar Archivo";
            this.btn_seleccion.UseVisualStyleBackColor = true;
            this.btn_seleccion.Click += new System.EventHandler(this.btn_seleccion_Click);
            // 
            // openFile
            // 
            this.openFile.FileName = "aoExe";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 328);
            this.Controls.Add(this.btn_seleccion);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_pathExe);
            this.Controls.Add(this.link_repo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.link_git);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_y);
            this.Controls.Add(this.txt_x);
            this.Controls.Add(this.btn_iniciarSesion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_usuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "TDS zzz v1.0";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_iniciarSesion;
        private System.Windows.Forms.TextBox txt_x;
        private System.Windows.Forms.TextBox txt_y;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel status_x;
        private System.Windows.Forms.ToolStripStatusLabel status_y;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.LinkLabel link_git;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.LinkLabel link_repo;
        private System.Windows.Forms.TextBox txt_pathExe;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_seleccion;
        private System.Windows.Forms.OpenFileDialog openFile;
    }
}

