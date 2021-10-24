using AccesoDatos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
	abstract class AbstractDaoFactory
	{
		public abstract IDao CrearFacturaDao();
		public abstract IDao CrearPedidoDao();

	}
}
