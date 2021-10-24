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
        public double PrecioUnitarioFact { get; set; }
        public Descuento Descuento { get; set; }

        //Public TipoVenta Tipoventa{get; set;}
        //Autorizacion Autorizacion {get; set;}

        public DetalleFactura(Suministro suministro, int cantidad, double preunit, Descuento desc)
        {
            Suministro = suministro;
            CantidadSum = cantidad;
            PrecioUnitarioFact = preunit;
            Descuento = desc;
        }


        public double CalcularSubtotal()
        {
            return Suministro.Precio * CantidadSum;
        }
    }
}
