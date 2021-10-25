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
	public partial class FrmConsultar : Form
	{
		private IService gestor;
		public FrmConsultar()
		{
			InitializeComponent();
			gestor = new ServiceFactoryImp().CrearService(new DaoFactoryImp());
		}

		private void FrmConsultar_Load(object sender, EventArgs e)
		{
			CargarFiltroFecha();
			CargarTiposFiltros();
			CargarGrillaConFacturas();
		}

		private void CargarGrillaConFacturas()
		{
			List<Parametro> filtros = new List<Parametro>();
			filtros.Add(new Parametro("@fechaDesde", dtpFechaDesde.Value));
			filtros.Add(new Parametro("@fechaHasta", dtpFechaHasta.Value));

			object filtroTexto = DBNull.Value;
			if (!String.IsNullOrEmpty(txtFiltro.Text))
				filtroTexto = txtFiltro.Text;
			if (cboFiltro.SelectedIndex == 0)
			{
				filtros.Add(new Parametro("@nroFactura", filtroTexto));
			}
			else
			{
				filtros.Add(new Parametro("@cliente", filtroTexto));
			}

			string conInactivos = "N";
			if (chkBajas.Checked)
				conInactivos = "S";
			filtros.Add(new Parametro("@activo", conInactivos));

			filtros.Add(new Parametro("@tipo", cboFiltro.SelectedIndex));

			List<Factura> lst = new List<Factura>();

			lst=gestor.GetFacturasByFilters(filtros);
			CargarGrilla(lst);
		}
		private void CargarGrilla(List<Factura> lst)
		{
			foreach (Factura item in lst)
			{
				dgvConsulta.Rows.Add(new object[] { item.IdFactura, item.Fecha.ToString("dd/MM/yyyy"), item.Cliente.ToString(), item.Total, ""/*item.GetFechaBajaFormato()*/ });
			}
		}
		private void CargarFiltroFecha()
		{
			string[] filtrosFecha = new string[] { "Hoy", "Ayer", "Ultimos 7 dias", "Ultimos 14 dias", "Ultimos 28 dias" };
			cboFiltroFecha.Items.Clear();
			cboFiltroFecha.Items.AddRange(filtrosFecha);
			cboFiltroFecha.SelectedIndex = 4;
		}
		private void CargarTiposFiltros()
		{
			string[] tiposFiltros = new string[] { "Numero Factura", "Cliente", "Inactivos" };
			cboFiltro.Items.Clear();
			cboFiltro.Items.AddRange(tiposFiltros);
			cboFiltro.SelectedIndex = 0;
		}

		private void cboFiltroFecha_SelectedIndexChanged(object sender, EventArgs e)
		{
			switch (cboFiltroFecha.SelectedIndex)
			{
				case 0:
					dtpFechaDesde.Value = DateTime.Today;
					break;
				case 1:
					dtpFechaDesde.Value = DateTime.Today.AddDays(-1);
					break;
				case 2:
					dtpFechaDesde.Value = DateTime.Today.AddDays(-7);
					break;
				case 3:
					dtpFechaDesde.Value = DateTime.Today.AddDays(-14);
					break;
				case 4:
					dtpFechaDesde.Value = DateTime.Today.AddDays(-28);
					break;
			}
		}

		private void btnConsultar_Click(object sender, EventArgs e)
		{
			CargarGrillaConFacturas();
		}

		private void btnEliminarFiltro_Click(object sender, EventArgs e)
		{
			dgvConsulta.Rows.Clear();
		}
	}
}
