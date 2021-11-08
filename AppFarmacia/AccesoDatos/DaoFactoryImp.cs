using AccesoDatos.Implementaciones;
using AccesoDatos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
	public class DaoFactoryImp : AbstractDaoFactory
	{
		public override IFacturaDao CrearFacturaDao()
		{
			return new FacturaDao();
		}
		public override IPedidoDao CrearPedidoDao()
		{
			return new PedidoDao();
		}
	}
}
