﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.AccesoDatos.Entidades
{
    class Medico:Persona
    {
        public int IdMedico { get; set; }

        public Medico(int idmedico, string nomb, string ape ) : base(nomb, ape)
        {
            IdMedico = idmedico;
            Nombre = nomb;
            Apellido = ape;
        }





    }
}
