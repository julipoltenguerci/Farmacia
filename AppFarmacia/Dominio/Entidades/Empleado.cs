using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    class Empleado : Persona
    {
        public int IdEmple { get; set; }

        public Empleado(int idEmple, string nombre, string ape) : base(nombre, ape)
        {

            IdEmple = idEmple;
            Nombre = nombre;
            Apellido = ape;
        }
    }
}
