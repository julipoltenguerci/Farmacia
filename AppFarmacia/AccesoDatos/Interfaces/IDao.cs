using Dominio;
using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Interfaces
{
	public interface IDao
	{
        List<object> GetByFilters(List<Parametro> parametro);

        //List<Factura> GetByFilters(List<Parametro> parametros);
     
    }
}
