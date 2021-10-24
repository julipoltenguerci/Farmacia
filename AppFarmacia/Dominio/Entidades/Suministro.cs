using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
	class Suministro
	{
        public int IdSuministro { get; set; }
        public int CodigodeBarras { get; set; }
        public string NombreSuministro { get; set; }
        public double Precio { get; set; }
        public bool TipoSuministro { get; set; }

        public bool TipoCondVenta { get; set; }


        public Suministro(int idSuministro, int codigodeBarras, string nombreSuministro, double precio, bool tipoSuministro, bool tipoCondVenta)
        {
            IdSuministro = idSuministro;
            CodigodeBarras = codigodeBarras;
            NombreSuministro = nombreSuministro;
            Precio = precio;
            TipoSuministro = tipoSuministro;
            TipoCondVenta = tipoCondVenta;

        }
    }
}
