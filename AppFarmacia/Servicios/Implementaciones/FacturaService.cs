using AccesoDatos;
using AccesoDatos.Interfaces;
using Dominio;
using Dominio.Entidades;
using Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Dominio.Enumeracion;

namespace Servicios.Implementaciones
{   
	class FacturaService:IService
	{
		private IDao daoFactura;
		private IDao daoPedido;

		public FacturaService(AbstractDaoFactory factory)
		{
			daoFactura = factory.CrearFacturaDao();
			daoPedido = factory.CrearPedidoDao();
		}

		public List<object> GetByFilters(List<Parametro> parametros,Accion modo)
		{   if(modo.Equals(Accion.Factura))
			return daoFactura.GetByFilters(parametros);
            else
            {
		     return daoPedido.GetByFilters(parametros);
            }
		}

    }
}
