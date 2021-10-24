using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
	class Sucursal
	{
        public int IdSucursal { get; set; }
        public string NombreSuc { get; set; }
        public string CalleSuc { get; set; }
        public int AlturaSuc { get; set; }

        public Barrio Barrio{ get; set; }
        public Sucursal(int idSucursal, string nombreSuc, string calle, int num,Barrio barrio)
        {
            IdSucursal = idSucursal;
            NombreSuc = nombreSuc;
            CalleSuc = calle;
            AlturaSuc = num;
            Barrio = barrio;
        }
    }
}
