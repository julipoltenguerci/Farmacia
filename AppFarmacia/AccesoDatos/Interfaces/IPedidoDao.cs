using Dominio;
using Dominio.Dto;
using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Interfaces
{
	public interface IPedidoDao
	{
        //List<object> GetByFilters(List<Parametro> parametro);

        List<Pedido> GetByFilters(List<Parametro> parametros);
		List<TipoSuministroDto> GetCantTipoSuministro(List<Parametro> parametros);
	}
}
