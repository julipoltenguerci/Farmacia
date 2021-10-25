using Dominio;
using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Interfaces
{
	public interface IService
	{
		public List<Factura> GetFacturasByFilters(List<Parametro> parametros);
	}
}
