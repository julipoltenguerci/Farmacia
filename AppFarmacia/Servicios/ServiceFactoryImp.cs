﻿using Servicios.Implementaciones;
using Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios
{
	class ServiceFactoryImp:AbstractServiceFactory
	{
		public override IService CrearService()
		{
			return new FacturaService();
		}
	}
}
