using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class Autorizacion
    {
        public int IdAutorizacion { get; set; }
        public bool Estado { get; set; }
        public DateTime Fecha { get; set; }
        public Medico Medico { get; set; }
        public ObraSocial ObraSocial { get; set; }

        public Autorizacion(int idAutorizacion, bool estado, DateTime fecha, Medico medico, ObraSocial obraSocial)
        {
            IdAutorizacion = idAutorizacion;
            Estado = estado;
            Fecha = fecha;
            Medico = medico;
            ObraSocial = obraSocial;
        }
    }
}
