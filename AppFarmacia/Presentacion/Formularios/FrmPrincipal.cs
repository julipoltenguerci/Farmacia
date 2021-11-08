using Presentacion.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Dominio.Enumeracion;

namespace Presentacion
{
	public partial class FrmPrincipal : Form
	{
		public FrmPrincipal()
		{
			InitializeComponent();
		}

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de abandonar la aplicación?",
               "SALIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
               MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        //private void btnConocenos_Click(object sender, EventArgs e)
        //{
        //    OpenChildForm(new FrmConocenos(), sender);
        //}


        //private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //	new FrmConsultar(Accion.Factura).ShowDialog();
        //}

        //      private void consultarToolStripMenuItem1_Click(object sender, EventArgs e)
        //      {
        //	new FrmConsultar(Accion.Pedido).ShowDialog();
        //}

    }
}
