using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
	class DetalleFactura
	{
        public Suministro Suministro { get; set; }
        public int CantidadSum { get; set; }
        public double PrecioUnitario { get; set; }
        public double Descuento { get; set; } // este debería ser un campo del detalle directamente en la base



        public DetalleFactura(Suministro suministro, int cantidad, double preunit, double desc)
        {
            Suministro = suministro;
            CantidadSum = cantidad;
            PrecioUnitario = preunit;
            Descuento = desc;
        }


        public double CalcularSubtotal()
        {
            return Suministro.Precio * CantidadSum;
        }
    }
}
