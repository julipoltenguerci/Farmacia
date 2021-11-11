using Dominio;
using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Interfaces
{
	public interface IFacturaDao
	{
		List<Factura> GetByFilters(List<Parametro> parametros);
		DataTable GetFacturasAfiliados(List<Parametro> parametros);
		DataTable GetFacturasTipo(List<Parametro> parametros);
	    DataTable GetCombo(string tabla);

	}
}
