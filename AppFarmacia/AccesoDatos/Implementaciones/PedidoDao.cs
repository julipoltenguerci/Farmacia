using AccesoDatos.Interfaces;
using Dominio;
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


	

	}
}
