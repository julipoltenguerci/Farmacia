using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Formularios
{
    public partial class FrmConsulta4 : Form
    {
        public FrmConsulta4()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtConsulta.Visible = true;
               // this.Size = new Size(706, 651);
            }
            else
            {
                //this.Size = new Size(706, 475);
                txtConsulta.Visible = false;
            }
        }
    }
}
