using Dominio;
using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Dominio.Enumeracion;

namespace Servicios.Interfaces
{
	public interface IServiceFactura
	{
		
			
		//public List<object> GetByFilters(List<Parametro> parametros, Accion modo);
		public List<Factura> GetFacturasByFilters(List<Parametro> parametros);
		public DataTable GetFacturasAfiliados(List<Parametro> parametros);
	}
}
