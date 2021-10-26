using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
	class Pedido
	{
        public int IdPedido { get; set; }
        public DateTime Fpedido { get; set; }
        public DateTime Fentrega { get; set; }
        public Empleado EmpleadoPedido { get; set; }
        public Sucursal SucursalPedido { get; set; }
        public EmpleadoProveedor EproveedorPedido { get; set; }
        public Proveedor ProveedorPedido { get; set; }
        public List<DetallePedido> Dpedido { get; set; }


        public Pedido()
        {
            Dpedido = new List<DetallePedido>();
        }

        public void AgregarDetalle(DetallePedido detalle)
        {
            Dpedido.Add(detalle);
        }

        public void QuitarDetalle(int indice)
        {
            Dpedido.RemoveAt(indice);
        }




    }
}
