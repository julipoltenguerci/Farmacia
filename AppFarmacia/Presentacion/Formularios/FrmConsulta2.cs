using AccesoDatos;
using Dominio;
using Dominio.Entidades;
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
    public partial class FrmConsulta2 : Form
    {
        private IServiceFactura gestor;

    


        public FrmConsulta2()
        {
            InitializeComponent();
            gestor = new ServiceFactoryImp().CrearFacturaService(new DaoFactoryImp());
            
        }

        private void FrmConsulta2_Load(object sender, EventArgs e)
        {
            CargarTipoSuministro();
        }


        private void CargarFacturasTipo()
        {
            List<Parametro> filtros = new List<Parametro>();

            int estado = 0;

            filtros.Add(new Parametro("@fechaDesde", dtpFechaDesdeF.Value));
            filtros.Add(new Parametro("@fechaHasta", dtpFechaHastaf.Value));
            if(chkBoxAutorizados.Checked)
                { estado = 1; }
            filtros.Add(new Parametro("@tipo", cboTipoSuministros.SelectedValue));
            filtros.Add(new Parametro("@estado", estado));

            dgvConsultaFactura.Rows.Clear();

            DataTable tabla = new DataTable();

            tabla = gestor.GetFacturasTipo(filtros);


            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                 dgvConsultaFactura.Rows.Add(tabla.Rows[i]["Nro Factura"], tabla.Rows[i]["Total Factura"], tabla.Rows[i]["Autorizado"]
                     ,tabla.Rows[i]["Fecha Fac"], tabla.Rows[i]["Nombre Suministro"], tabla.Rows[i]["Tipo suministro"]);
            }


        }


        private void CargarTipoSuministro()
        {
            List<Parametro> param = new List<Parametro>();

           

            DataTable tabla = gestor.GetCombo("Tipos_Suministros");


            cboTipoSuministros.DataSource = tabla;
            cboTipoSuministros.ValueMember = tabla.Columns[0].ColumnName;
            cboTipoSuministros.DisplayMember = tabla.Columns[1].ColumnName;
            cboTipoSuministros.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void btnConsultaFac_Click(object sender, EventArgs e)
        {
            CargarFacturasTipo();
        }
    }
}
