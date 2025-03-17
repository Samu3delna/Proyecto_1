using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_1

{
    public partial class Menu_principal : Form
    {
        public Menu_principal()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
           
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToLongDateString();
            lblHora.Text = DateTime.Now.ToString(" h mm ss tt");
        }
        private void AbrirFormPanel(object FormHijo)
        {
            if (this.PanelContenedor.Controls.Count > 0)
                this.PanelContenedor.Controls.RemoveAt(0);

            Form fh = FormHijo as Form;
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.PanelContenedor.Controls.Add(fh);
            this.PanelContenedor.Tag = fh;
            fh.Show();
        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PanelContenedor_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            MantUsuario Usuario = new MantUsuario();
            AbrirFormPanel(Usuario);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnReporteria_Click(object sender, EventArgs e)
        {

        }
    }
}
