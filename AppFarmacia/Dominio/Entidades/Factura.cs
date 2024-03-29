﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
	public class Factura
	{
        public int IdFactura { get; set; }
        public DateTime Fecha { get; set; }
        public Cliente Cliente { get; set; }
        public Sucursal Sucursal { get; set; }
        public List<DetalleFactura> Detalles { get; set; }
		public double Total { get; set; }//agregue esto, tenemos que hablarlo entre nos


		public Factura()
        {
            Detalles = new List<DetalleFactura>();
        }

        public void AgregarDetalle(DetalleFactura detalle)
        {
            Detalles.Add(detalle);
        }

        public void QuitarDetalle(int indice)
        {
            Detalles.RemoveAt(indice);
        }

        public double CalcularTotal()
        {
            double total = 0;

            foreach (DetalleFactura item in Detalles)
            {
                total += item.CalcularSubtotal();
            }
            return total;
        }
    }
}
