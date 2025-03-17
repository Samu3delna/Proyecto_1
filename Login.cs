using BLL;
using Proyecto_1.Avisos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_1
{
    public partial class Login : Form
    {

        private LoginBLL AccesoCapaBll = new LoginBLL();
        public Login()
        {
            InitializeComponent();
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnlógin_Click(object sender, EventArgs e)
        {
            if (txtusuario.Text != "" && txtcontra.Text != "")
            {
                var respuesta = AccesoCapaBll.InciarSeccion(txtcontra.Text, txtusuario.Text);

                if (respuesta.Ok)
                {
                    
                    this.Hide();
                    Menu_principal menu = new Menu_principal();
                    menu.Show();
                }
                else
                {
                    Avisos_login aviso = new Avisos_login();
                    aviso.lblmensaje.Text = "Inicio de sección exitoso!";
                    aviso.ShowDialog();                   

                }

            }else
            {
                Avisos_login aviso = new Avisos_login();
                aviso.lblmensaje.Text = "Ocurrio un error!";
                aviso.ShowDialog();
            }



        }
    }
}
