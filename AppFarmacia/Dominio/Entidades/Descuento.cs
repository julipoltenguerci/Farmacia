using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    class Descuento
    {
        
        public int IdDescuento { get; set; }
        public int CantidadDesc { get; set; }

        public Descuento(int idDescuento, int cantidadDesc)
        {
            IdDescuento = idDescuento;
            CantidadDesc = cantidadDesc;
        }


    }
}
