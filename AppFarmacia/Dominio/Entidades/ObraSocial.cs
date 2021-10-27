using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class ObraSocial
    {
        public int IdObraSocial { get; set; }
        public string NomObraSocial { get; set; }

        public ObraSocial(int idObraSocial, string nomObraSocial)
        {
            IdObraSocial = idObraSocial;
            NomObraSocial = nomObraSocial;
        }
    }
}
