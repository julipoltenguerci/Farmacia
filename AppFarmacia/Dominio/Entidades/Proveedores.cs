﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    class Proveedores
    {
        public int IdProveedor { get; set; }
        public string NombreProveedor { get; set; }
        public string RazonSocial { get; set; }
        public string Cuit { get; set; }

        public string CalleProv { get; set; }
        public int AlturaProv { get; set; }
        //Public Barrios Barrio {get;set;}

        public Proveedores(int idProveedor, string nombreProveedor, string razonSocial, string cuit, string calle, int altura)
        {
            IdProveedor = idProveedor;
            NombreProveedor = nombreProveedor;
            RazonSocial = razonSocial;
            Cuit = cuit;
            CalleProv = calle;
            AlturaProv = altura;
        }
    }
}
