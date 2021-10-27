using Dominio;
using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Dominio.Enumeracion;

namespace Servicios.Interfaces
{
	public interface IService
	{
		
			
		public List<object> GetByFilters(List<Parametro> parametros, Accion modo);
		//public List<Pedido> GetPedidosByFilters(List<Parametro> parametros);
	}
}
