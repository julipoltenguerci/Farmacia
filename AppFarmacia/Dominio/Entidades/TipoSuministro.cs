using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class TipoSuministro
    {
        public int IdTipoSuministro { get; set; }
        public string NomTipoSuministro { get; set; }

        public TipoSuministro(int idTipoSuministro, string nomTipoSuministro)
        {
            IdTipoSuministro = idTipoSuministro;
            NomTipoSuministro = nomTipoSuministro;
        }
    }
}
