using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    class DetallePedido
    {
        //quedo ok ger
        public int IdDetalleP { get; set; }        
        public Suministro SuministroPedido { get; set; }
        public Medico MedicoPedido { get; set; }
        public int CantidadPedido { get; set; }
        public double PrecioPedido { get; set; }

        public DetallePedido(int idDetalleP,Suministro suministroPedido,Medico medicoDP,int cantidadPedido,double precioPedido)
        {
            this.IdDetalleP = idDetalleP;
            this.SuministroPedido = suministroPedido;
            this.MedicoPedido = medicoDP;
            this.CantidadPedido = cantidadPedido;
            this.PrecioPedido = precioPedido;
        }
    }
}
