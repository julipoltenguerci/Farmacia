using AccesoDatos;
using Dominio;
using Dominio.Dto;
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
	public partial class FrmConsulta3 : Form
	{
		private IServicePedido service;

		public FrmConsulta3()
		{
			InitializeComponent();
			service= new ServiceFactoryImp().CrearPedidoService(new DaoFactoryImp());
		}

		private void FrmConsulta3_Load(object sender, EventArgs e)
		{
			CargarCombos();
			CargarGrilla();
		}

		private void CargarCombos()
		{
			CargarFiltroFecha();
			CargarFiltrosAvanzados();
			chkAnioMes.Checked = true;			
		}

		private void CargarFiltrosAvanzados()
		{
			var lstMonedas = new[]
			{
				new { id = 1, tipo = "Tipo Suministro" },
				new { id = 2, tipo = "Proveedor" }
			};
			
			cboFiltro.Items.Clear();
			cboFiltro.DataSource = lstMonedas;
			cboFiltro.ValueMember = "id";
			cboFiltro.DisplayMember = "tipo";
			cboFiltro.SelectedIndex = 0;
		}

		private void CargarFiltroFecha()
		{
			
			string[] filtrosFecha = new string[] { "Ultimo Mes", "Ultimos 3 meses", "Ultimos 6 meses", "Ultimo año"};
			cboFiltroFecha.Items.Clear();
			cboFiltroFecha.Items.AddRange(filtrosFecha);
			cboFiltroFecha.SelectedIndex = 3;
		}

		private void CargarGrilla()
		{
			List<TipoSuministroDto> lst = new List<TipoSuministroDto>();
			List<Parametro> parametros = new List<Parametro>();
			int tipo = 0;
			int agrupar = 0;
			parametros.Add(new Parametro("@fechaDesde", dtpFechaDesde.Value));
			parametros.Add(new Parametro("@fechaHasta", dtpFechaHasta.Value));

			if (cboFiltro.SelectedIndex==0)
			{
				parametros.Add(new Parametro("@tipoSuministro", txtFiltro.Text));
			}
			else
			{
				parametros.Add(new Parametro("@proveedor",txtFiltro.Text));
				tipo = 1;
			}
			if (chkAnioMes.Checked)
			{
				agrupar = 0;
			}
			if (chkAnio.Checked)
			{
				agrupar = 1;	
			}
			if (chkProv.Checked)
			{
				agrupar = 2;
			}
			parametros.Add(new Parametro("@tipo", tipo));
			parametros.Add(new Parametro("@agrupar", agrupar));

			lst = service.CantTipoSuministro(parametros);

			dgvConsulta.Rows.Clear();
			foreach (TipoSuministroDto item in lst)
			{
				dgvConsulta.Rows.Add(new object[] { item.Anio,item.Mes,item.NombreProveedor,item.TipoSuministro,item.CantTipoSuministro });
			}			
		}

		private void chkAnioMes_Click(object sender, EventArgs e)
		{
			chkAnio.Checked = false;
			chkProv.Checked = false;
			cboFiltro.SelectedIndex = 0;
			AplicarVistaAnioMes();
			CargarGrilla();
		}

		private void chkAnio_Click(object sender, EventArgs e)
		{
			chkAnioMes.Checked = false;
			chkProv.Checked = false;
			cboFiltro.SelectedIndex = 0;
			AplicarVistaAnio();
			CargarGrilla();
		}

		private void chkProv_Click(object sender, EventArgs e)
		{
			chkAnio.Checked = false;
			chkAnioMes.Checked = false;
			AplicarVistaProveedores();
			CargarGrilla();
		}

		private void btnConsultar_Click(object sender, EventArgs e)
		{
			CargarGrilla();
		}

		private void cboFiltroFecha_SelectedIndexChanged(object sender, EventArgs e)
		{
			switch (cboFiltroFecha.SelectedIndex)
			{
				case 0:
					dtpFechaDesde.Value = DateTime.Today.AddMonths(-1);
					break;
				case 1:
					dtpFechaDesde.Value = DateTime.Today.AddMonths(-3);
					break;
				case 2:
					dtpFechaDesde.Value = DateTime.Today.AddMonths(-6);
					break;
				case 3:
					dtpFechaDesde.Value = DateTime.Today.AddYears(-1);
					break;
			}
		}
		private void AplicarVistaAnioMes()
		{
			dgvConsulta.Columns[0].Visible = true;
			dgvConsulta.Columns[1].Visible = true;
			dgvConsulta.Columns[2].Visible = false;
		}
		private void AplicarVistaAnio()
		{
			dgvConsulta.Columns[0].Visible = true;
			dgvConsulta.Columns[1].Visible = false;
			dgvConsulta.Columns[2].Visible = false;
		}
		private void AplicarVistaProveedores()
		{
			dgvConsulta.Columns[0].Visible = false;
			dgvConsulta.Columns[1].Visible = false;
			dgvConsulta.Columns[2].Visible = true;
		}
		private void cboFiltro_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cboFiltro.SelectedIndex==1)
			{
				chkProv.Checked = true;
				chkAnio.Checked = false;
				chkAnioMes.Checked = false;
				AplicarVistaProveedores();				
				CargarGrilla();

			}			
		}

       
    }
}
