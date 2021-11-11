using AccesoDatos.Interfaces;
using Dominio;
using Dominio.Dto;
using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Implementaciones
{
	class PedidoDao : IPedidoDao
	{
        public List<Pedido> GetByFilters(List<Parametro> parametros)
        {
			List<Pedido> lst = new List<Pedido>();
			
			try
			{
				DataTable tabla = HelperDao.ObtenerInstancia().ConsultaSQLParametros("PA_CONSULTA_PEDIDO_FILTRO", parametros);

				foreach (DataRow row in tabla.Rows)
				{
					Pedido oPedido = new Pedido();

					oPedido.IdPedido = Convert.ToInt32(row["id_pedido"].ToString());
					oPedido.Fpedido = Convert.ToDateTime(row["fecha"].ToString());
					oPedido.Total = Convert.ToDouble(row["Total"].ToString());

					Proveedor oProveedor = new Proveedor();
					oProveedor.NombreProveedor = row["nom_proveedor"].ToString();


					oPedido.ProveedorPedido = oProveedor;

                    if (!row["fechaB"].Equals(DBNull.Value))
					{
						//aca se agrega el campo si existe fecha de baja, dejo a modo ejemplo hasta que agreguemos esto en bd
						//oPedido.FechaBaja = Convert.ToDateTime(row["fecha_baja"].ToString());
					}

					lst.Add(oPedido);
                }
            }
			catch (SqlException)
			{
				lst = null;
			}
			return lst;
		}

		public List<TipoSuministroDto> GetCantTipoSuministro(List<Parametro> parametros)
		{
			List<TipoSuministroDto> lst = new List<TipoSuministroDto>();

			try
			{
				DataTable tabla = HelperDao.ObtenerInstancia().ConsultaSQLParametros("PA_CONSULTA3_TIPO_SUMINISTRO", parametros);
				//falta terminar el sp
				foreach (DataRow row in tabla.Rows)
				{
					TipoSuministroDto tipoSuminstroDto = new TipoSuministroDto();

					if (tabla.Columns.Contains("Anio"))
					{
						if (!row["Anio"].ToString().Equals(DBNull.Value))
						{
							tipoSuminstroDto.Anio = Convert.ToInt32(row["Anio"].ToString());
						}
						else
						{
							tipoSuminstroDto.Anio = 0;
						}
					}
					if (tabla.Columns.Contains("Mes"))
					{
						if (!row["Mes"].ToString().Equals(DBNull.Value))
						{
							tipoSuminstroDto.Mes = Convert.ToInt32(row["Mes"].ToString());
						}
						else
						{
							tipoSuminstroDto.Mes = 0;
						}
					}					
					if (tabla.Columns.Contains("Proveedor"))
					{
						if (!row["Proveedor"].ToString().Equals(DBNull.Value))
						{
							tipoSuminstroDto.NombreProveedor = row["Proveedor"].ToString();
						}
						else
						{
							tipoSuminstroDto.NombreProveedor = "";
						}
					}


					tipoSuminstroDto.TipoSuministro = row["TipoSuministro"].ToString();
					tipoSuminstroDto.CantTipoSuministro = Convert.ToInt32(row["CantidadTotal"].ToString());

					
					lst.Add(tipoSuminstroDto);
				}
			}
			catch (SqlException)
			{
				lst = null;
			}

			return lst;
		}
	}
}
