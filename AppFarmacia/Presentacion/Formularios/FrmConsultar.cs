using AccesoDatos;
using Dominio;
using Dominio.Entidades;
using Servicios;
using Servicios.Implementaciones;
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
using static Dominio.Enumeracion;

namespace Presentacion.Formularios
{   
	public partial class FrmConsultar : Form
	{
		private IServiceFactura gestorFactura;
		private IServicePedido gestorPedido;
		private Accion modo;
		
		public FrmConsultar(Accion modo)
		{
			InitializeComponent();
			this.modo = modo;
			if (modo.Equals(Accion.Factura))
			{
				gestorFactura = new ServiceFactoryImp().CrearFacturaService(new DaoFactoryImp());
			}
			if (modo.Equals(Accion.Pedido))
			{ 
				gestorPedido = new ServiceFactoryImp().CrearPedidoService(new DaoFactoryImp());
			}
		}

		private void FrmConsultar_Load(object sender, EventArgs e)
		{
			CargarFiltroFecha();
			CargarTiposFiltros();

            if (modo.Equals(Accion.Factura))
            {
                CargarGrillaConFacturas();

            }
            if (modo.Equals(Accion.Pedido))
            {
                CargarGrillaConPedidos();
                this.dgvConsulta.Columns[0].HeaderText = "Nro Pedido";
                this.dgvConsulta.Columns[2].HeaderText = "Proveedor";
            }

        }

		private void CargarGrillaConPedidos()
		{
			
			List<Pedido> lst = new List<Pedido>();
			List<Parametro> filtros = CargarParametros(Accion.Pedido);

			dgvConsulta.Rows.Clear();
			lst = gestorPedido.GetPedidosByFilters(filtros);


			foreach (Pedido item in lst)
			{
				dgvConsulta.Rows.Add(new object[] { item.IdPedido, item.Fpedido.ToString("dd/MM/yyyy"), item.ProveedorPedido.NombreProveedor.ToString(), item.Total.ToString(), ""/*item.GetFechaBajaFormato()*/ }) ;
			}

		}

		private void CargarGrillaConFacturas()
		{
			List<Factura> lst = new List<Factura>();

			List<Parametro> filtros=CargarParametros(Accion.Factura);

			dgvConsulta.Rows.Clear();
			lst =gestorFactura.GetFacturasByFilters(filtros);


			foreach (Factura item in lst)
			{
				dgvConsulta.Rows.Add(new object[] { item.IdFactura, item.Fecha.ToString("dd/MM/yyyy"), item.Cliente.ToString(), item.Total, ""/*item.GetFechaBajaFormato()*/ });
			}
			
		}
		private List<Parametro> CargarParametros(Accion modo)
		{
			List<Parametro> filtros = new List<Parametro>();
			filtros.Add(new Parametro("@fechaDesde", dtpFechaDesde.Value));
			filtros.Add(new Parametro("@fechaHasta", dtpFechaHasta.Value));

			object filtroTexto = DBNull.Value;
			if (!String.IsNullOrEmpty(txtFiltro.Text))
				filtroTexto = txtFiltro.Text;

			if (modo.Equals(Accion.Factura))
			{
				if (cboFiltro.SelectedIndex == 0)
				{
					filtros.Add(new Parametro("@nroFactura", filtroTexto));
				}
				else
				{
					filtros.Add(new Parametro("@cliente", filtroTexto));
				}
			}
			else
			{
				if (cboFiltro.SelectedIndex == 0)
				{
					filtros.Add(new Parametro("@nroPedido", filtroTexto));
				}
				else
				{
					filtros.Add(new Parametro("@Proveedor", filtroTexto));
				}
			}

			string conInactivos = "N";
			if (chkBajas.Checked)
				conInactivos = "S";
			filtros.Add(new Parametro("@activo", conInactivos));

			filtros.Add(new Parametro("@tipo", cboFiltro.SelectedIndex));

			return filtros;
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
			if (modo.Equals(Accion.Factura))
			{
				string[] tiposFiltros = new string[] { "Numero Factura", "Cliente", "Inactivos" };

				cboFiltro.Items.Clear();
				cboFiltro.Items.AddRange(tiposFiltros);
				cboFiltro.SelectedIndex = 0;
			}
            else
            {
				string[] tiposFiltros = new string[] { "Numero Pedido", "Proveedor", "Inactivos" };

				cboFiltro.Items.Clear();
				cboFiltro.Items.AddRange(tiposFiltros);
				cboFiltro.SelectedIndex = 0;
			}
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
			if (modo.Equals(Accion.Factura))
			{
				CargarGrillaConFacturas();
			}
			if (modo.Equals(Accion.Pedido))
            {
				CargarGrillaConPedidos();
            }

		}

		private void btnEliminarFiltro_Click(object sender, EventArgs e)
		{
			dgvConsulta.Rows.Clear();
			cboFiltroFecha_SelectedIndexChanged(null,null);

			if (modo.Equals(Accion.Factura))
			{
				CargarGrillaConFacturas();
			}
			else
			{
				CargarGrillaConPedidos();
			}
		}

    }
}
