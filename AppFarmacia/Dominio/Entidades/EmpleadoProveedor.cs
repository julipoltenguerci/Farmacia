using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
	public class EmpleadoProveedor:Persona
	{
        public int IdEmpleProv { get; set; }

        public EmpleadoProveedor(int id, string nomb, string ape) : base(nomb, ape)
        {
            IdEmpleProv = id;
            Nombre = nomb;
            Apellido = ape;
        }
    }
}
