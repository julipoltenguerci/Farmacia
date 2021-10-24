using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
	class Medico:Persona
	{
        public int IdMedico { get; set; }
        public string Matricula { get; set; }

        public Medico(int idmedico, string nomb, string ape, string matricula) : base(nomb, ape)
        {
            IdMedico = idmedico;
            Nombre = nomb;
            Apellido = ape;
            Matricula = matricula;

        }
    }
}
