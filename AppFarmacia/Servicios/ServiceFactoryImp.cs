﻿using AccesoDatos;
using Servicios.Implementaciones;
using Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios
{
	public class ServiceFactoryImp : AbstractServiceFactory
	{
		public override IService CrearService(AbstractDaoFactory factory)
		{
			return new FacturaService(factory);
		}
	}
}
