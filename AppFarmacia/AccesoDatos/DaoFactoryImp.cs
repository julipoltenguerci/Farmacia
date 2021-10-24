using AccesoDatos.Implementaciones;
using AccesoDatos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
	class DaoFactoryImp : AbstractDaoFactory
	{
		public override IDao CrearFacturaDao()
		{
			return new FacturaDao();
		}
		public override IDao CrearPedidoDao()
		{
			return new PedidoDao();
		}
	}
}
