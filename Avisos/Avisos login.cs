using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_1.Avisos
{
    public partial class Avisos_login : Form
    {
        public Avisos_login()
        {
            InitializeComponent();
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnmensaje_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void lblmensaje_Click(object sender, EventArgs e)
        {

        }
    }
}
