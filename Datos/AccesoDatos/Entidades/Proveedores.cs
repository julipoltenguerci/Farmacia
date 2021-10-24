using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.AccesoDatos.Entidades
{
    class Proveedores
    {
        
        public int IdProveedor { get; set; }
        public string NombreProveedor { get; set; }
        public string RazonSocial { get; set; }
        public int Cuit { get; set; }

        public string  CalleProv{ get; set; }
        public int AlturaProv { get; set; }
        //Barrio Barrio?

        public Proveedores(int idProveedor, string nombreProveedor, string razonSocial, int cuit, string calleProv, int alturaProv)
        {
            IdProveedor = idProveedor;
            NombreProveedor = nombreProveedor;
            RazonSocial = razonSocial;
            Cuit = cuit;
            CalleProv = calleProv;
            AlturaProv = alturaProv;
        }


    }
}
