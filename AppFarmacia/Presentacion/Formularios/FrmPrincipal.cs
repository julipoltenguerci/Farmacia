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
        private Form activeForm;
        public FrmPrincipal()
        {
            InitializeComponent();
            EstiloBotonera();
        }

        public void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelChild.Controls.Add(childForm);
            this.panelChild.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void EstiloBotonera()
        {
            panelBotoneraConsultas.Visible = false;

        }

        private void HideSubMenu()
        {
            if (panelBotoneraConsultas.Visible)
            {
                panelBotoneraConsultas.Visible = false;
            }

        }

        private void ShowSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                HideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }

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

        private void btnConocenos_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new FrmConocenos(), sender);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void btnConsulta1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmConsulta1(), sender);
            HideSubMenu();
        }

        private void btnConsultas_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelBotoneraConsultas);
        }
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
