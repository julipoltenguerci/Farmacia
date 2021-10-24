using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
	class Cliente:Persona
	{
        public int IdCliente { get; set; }

        public Cliente(int idCliente, string nombre, string ape) : base(nombre, ape)
        {

            IdCliente = idCliente;
            Nombre = nombre;
            Apellido = ape;
        }
    }
}
