﻿using AccesoDatos;
using Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios
{
	public abstract class AbstractServiceFactory
	{
		public abstract IService CrearService(AbstractDaoFactory factory);
	}
}
