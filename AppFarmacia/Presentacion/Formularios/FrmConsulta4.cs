using AccesoDatos;
using Dominio;
using Servicios;
using Servicios.Interfaces;
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
        private IServiceFactura gestor;
        public FrmConsulta4()
        {
            InitializeComponent();
            gestor = new ServiceFactoryImp().CrearFacturaService(new DaoFactoryImp());
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            CargarSucursal();
        }

        

        private void FrmConsulta4_Load(object sender, EventArgs e)
        {
            //CargarSucursal();
        }
        private void CargarSucursal()
        {
            List<Parametro> filtros = new List<Parametro>();

            int estado = 0;

            filtros.Add(new Parametro("@Anio", Convert.ToInt32(txtAnio.Text.ToString())));
            filtros.Add(new Parametro("@Sucursal", txtFiltro.Text.ToString()));          
            

            dgvConsulta.Rows.Clear();

            DataTable tabla = new DataTable();

            tabla = gestor.CargarSucursal(filtros);


            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                dgvConsulta.Rows.Add(tabla.Rows[i][0], tabla.Rows[i][1], tabla.Rows[i][2], tabla.Rows[i][3]);
            }
        }
    }
}
