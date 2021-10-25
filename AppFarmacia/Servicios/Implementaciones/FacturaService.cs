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

namespace Servicios.Implementaciones
{
	class FacturaService:IService
	{
		private IDao dao;

		public FacturaService(AbstractDaoFactory factory)
		{
			dao = factory.CrearFacturaDao();
		}
		public List<Factura> GetFacturasByFilters(List<Parametro> parametros)
		{
			return dao.GetByFilters(parametros);
		}
	}
}
