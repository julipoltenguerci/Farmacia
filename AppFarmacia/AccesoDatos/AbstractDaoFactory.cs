using AccesoDatos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
	public abstract class AbstractDaoFactory
	{
		public abstract IFacturaDao CrearFacturaDao();
		public abstract IPedidoDao CrearPedidoDao();

	}
}
