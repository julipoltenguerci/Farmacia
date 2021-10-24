using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    class Localidades
    {
        public int IdLocalidad { get; set; }
        public string NomLocalidad { get; set; }
        public Barrio Barrio { get; set; }
        public Localidades(int idLocalidad, string nomLocalidad, Barrio barrioL)
        {
            this.IdLocalidad = idLocalidad;
            this.NomLocalidad = nomLocalidad;
            this.Barrio = barrioL;            
        }
    }
}
