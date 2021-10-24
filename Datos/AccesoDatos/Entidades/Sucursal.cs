using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.AccesoDatos.Entidades
{
    class Sucursal
    {
      
        public int IdSucursal { get; set; }
        public string NombreSuc { get; set; }
        public string DireCalle { get; set; }
        public int DireAltura{ get; set; }

        //  public Barrio Barrio{ get; set; }
        public Sucursal(int idSucursal, string nombreSuc, string direCalle, int direAltura)
        {
            IdSucursal = idSucursal;
            NombreSuc = nombreSuc;
            DireCalle = direCalle;
            DireAltura = direAltura;
        }






    }
}
