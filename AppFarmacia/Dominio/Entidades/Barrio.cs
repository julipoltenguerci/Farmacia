using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
     public class Barrio
    {
        public int IdBarrio { get; set; }
        public string NomBarrio { get; set; }
        public Barrio(int idBarrio,string nomBarrio)
        {
            this.IdBarrio = idBarrio;
            this.NomBarrio = nomBarrio;
        }
    }
}
