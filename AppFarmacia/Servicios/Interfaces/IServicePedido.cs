using Dominio;
using Dominio.Dto;
using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Interfaces
{
	public interface IServicePedido
	{
		public List<Pedido> GetPedidosByFilters(List<Parametro> parametros);
		public List<TipoSuminstroDto> CantTipoSuministro(List<Parametro> parametros);
	}
}
