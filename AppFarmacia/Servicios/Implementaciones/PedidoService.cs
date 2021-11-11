using AccesoDatos;
using AccesoDatos.Interfaces;
using Dominio;
using Dominio.Dto;
using Dominio.Entidades;
using Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Implementaciones
{
	class PedidoService:IServicePedido
	{
		private IPedidoDao dao;

		public PedidoService(AbstractDaoFactory factory)
		{
			dao = factory.CrearPedidoDao();
		}

		public List<TipoSuministroDto> CantTipoSuministro(List<Parametro> parametros)
		{
			return dao.GetCantTipoSuministro(parametros);
		}

		public List<Pedido> GetPedidosByFilters(List<Parametro> parametros)
		{
			return dao.GetByFilters(parametros);
		}
	}
}
