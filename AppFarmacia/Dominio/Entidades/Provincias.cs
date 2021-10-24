using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    class Provincias
    {
        public int IdProvincia { get; set; }
        public string NomProvincia { get; set; }
        public Localidades Localidad { get; set; }
        public Provincias(int idProv,string nomProv,Localidades localiProv)
        {
            this.IdProvincia = idProv;
            this.NomProvincia = nomProv;
            this.Localidad = localiProv;
        }


    }
}
