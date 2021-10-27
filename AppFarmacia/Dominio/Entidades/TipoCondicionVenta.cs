using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class TipoCondicionVenta
    {
        public int IdTipoCondVta { get; set; }
        public string TipoCondVta { get; set; }

        public TipoCondicionVenta(int idTipoCondVta, string tipoCondVta)
        {
            IdTipoCondVta = idTipoCondVta;
            TipoCondVta = tipoCondVta;
        }

    }
}
