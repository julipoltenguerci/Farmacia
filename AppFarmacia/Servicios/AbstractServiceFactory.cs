﻿using Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios
{
	abstract class AbstractServiceFactory
	{
		public abstract IService CrearService();
	}
}
