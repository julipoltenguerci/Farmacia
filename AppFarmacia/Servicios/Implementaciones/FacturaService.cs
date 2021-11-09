﻿using AccesoDatos;
using AccesoDatos.Interfaces;
using Dominio;
using Dominio.Entidades;
using Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Dominio.Enumeracion;

namespace Servicios.Implementaciones
{   
	class FacturaService:IServiceFactura
	{
		private IFacturaDao dao;

		public FacturaService(AbstractDaoFactory factory)
		{
			dao = factory.CrearFacturaDao();
		}

		public List<Factura> GetFacturasByFilters(List<Parametro> parametros)
		{   
			return dao.GetByFilters(parametros);
		}
		public DataTable GetFacturasAfiliados(List<Parametro> parametros)
		{
			return dao.GetFacturasAfiliados(parametros);
		}

	}
}
