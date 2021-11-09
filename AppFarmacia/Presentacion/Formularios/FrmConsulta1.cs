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
    public partial class FrmConsulta1 : Form
    {
        private IServiceFactura gestor;
        public FrmConsulta1()
        {
            InitializeComponent();
            InitializeTrackBar();
            CargarObrasSociales();
            gestor = new ServiceFactoryImp().CrearFacturaService(new DaoFactoryImp());
        }
        private void InitializeTrackBar()
        {
            tkbDescuento.TickStyle = TickStyle.Both;

            tkbDescuento.Minimum = 0;
            tkbDescuento.Maximum = 100;

            tkbDescuento.TickFrequency = 10;
            tkbDescuento.ValueChanged += new System.EventHandler(TrackBar1_ValueChanged);
            this.Controls.Add(this.tkbDescuento);
        }
        private void TrackBar1_ValueChanged(object sender, System.EventArgs e)
        {
            label1.Text = tkbDescuento.Value.ToString() + '%';
        }
        private void CargarGrilla()
        {
            List<Parametro> filtros = new List<Parametro>();
            filtros.Add(new Parametro("@fechaFactura", dtpFechaFactura.Value));
            filtros.Add(new Parametro("@descuento", tkbDescuento.Value));
            filtros.Add(new Parametro("@idObraSocial", cboFiltroObraSocial.SelectedValue));


            //List<Parametro> filtros = CargarParametros(Accion.Factura);

            //dgvConsulta.Rows.Clear();
            dgvConsulta1.DataSource = gestor.GetFacturasAfiliados(filtros);


            //foreach (Factura item in lst)
            //{
            //    dgvConsulta.Rows.Add(new object[] { item.IdFactura, item.Fecha.ToString("dd/MM/yyyy"), item.Cliente.ToString(), item.Total, ""/*item.GetFechaBajaFormato()*/ });
            //}

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            CargarGrilla();
        }
        private void CargarObrasSociales()
        {
            List<ObraSocial> oSociales = new List<ObraSocial>();

            oSociales.Add(new ObraSocial(1, "Osde"));
            oSociales.Add(new ObraSocial(2, "Swiss Medical"));
            oSociales.Add(new ObraSocial(3, "Daspu"));


            //oSociales.Add(2, "Medife");
            cboFiltroObraSocial.Items.Clear();
            cboFiltroObraSocial.DisplayMember = "NomObraSocial";
            cboFiltroObraSocial.ValueMember = "IdObraSocial";
            cboFiltroObraSocial.DataSource = oSociales;
            cboFiltroObraSocial.SelectedItem = 1;
        }
    }
}
