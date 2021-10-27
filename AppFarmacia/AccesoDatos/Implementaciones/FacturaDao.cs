using AccesoDatos.Interfaces;
using Dominio;
using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Implementaciones
{
	class FacturaDao : IDao
	{   
        public List<object> GetByFilters(List<Parametro> parametros)
        {
            
            List<object> lst = new List<object>(); //Recibe una list de object
            //Acá sacamos el datatable que teniamos como new por que el Helper ya devuelve un objeto datatable
            try
            {   
                DataTable  tabla = HelperDao.ObtenerInstancia().ConsultaSQLParametros("PA_CONSULTA_FACTURAS_FILTRO", parametros);

                foreach (DataRow row in tabla.Rows)
                {
                    Factura oFactura = new Factura();

                    oFactura.IdFactura = Convert.ToInt32(row["id_factura"].ToString());
                    oFactura.Fecha = Convert.ToDateTime(row["fecha"].ToString());
                    oFactura.Total = Convert.ToDouble(row["total"].ToString());

                    Cliente oCliente = new Cliente();
                    oCliente.Apellido = row["apellido"].ToString();
                    oCliente.Nombre = row["nombre"].ToString();

                    oFactura.Cliente = oCliente;

                    if (!row["fechaB"].Equals(DBNull.Value)) //Columna agregada

                        lst.Add(oFactura);
                }
            }
            catch (SqlException)
            {
                lst = null;
            }
            return lst;
        }

       
        
    }
}
