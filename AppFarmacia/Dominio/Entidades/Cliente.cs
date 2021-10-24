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
        public string  TelCli { get; set; }
        public string CalleCli { get; set; }
        public int AlturaCli { get; set; }
        //public Barrios Barrio { get; set; }

        public Cliente(int idCliente, string nombre, string ape, string tel, string calle, int alt): base(nombre, ape) 
        {

            IdCliente = idCliente;
            Nombre = nombre;
            Apellido = ape;
            TelCli = tel;
            CalleCli = calle;
            AlturaCli = alt;

        }

       
    }
}
