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
	class FacturaDao : IFacturaDao
	{   
        public List<Factura> GetByFilters(List<Parametro> parametros)
        {
            
            List<Factura> lst = new List<Factura>();

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

                    if (!row["fechaB"].Equals(DBNull.Value))
					{
                        //aca se agrega el campo si existe fecha de baja, dejo a modo ejemplo hasta que agreguemos esto en bd
                        //oPedido.FechaBaja = Convert.ToDateTime(row["fecha_baja"].ToString());
                    }

                    lst.Add(oFactura);
                }
            }
            catch (SqlException)
            {
                lst = null;
            }
            return lst;
        }

        public DataTable GetFacturasAfiliados(List<Parametro> parametros)
        {

            DataTable tabla = new DataTable();

            try
            {
                tabla = HelperDao.ObtenerInstancia().ConsultaSQLParametros("PA_COMPRAS_AFILIADOS", parametros);

                return tabla;
            }
            catch (SqlException)
            {
                tabla = null;
            }
            return tabla;
        }
        public List<Factura> ConsultaFacturasPorAño(List<Parametro> parametros)
        {
            List<Factura> lst = new List<Factura>();
            try
            {
                DataTable tabla = HelperDao.ObtenerInstancia().ConsultaSQLParametros("PA_CONSULTA_SUCURSAL", parametros);
                foreach (DataRow row in tabla.Rows)
                {
                    Factura oFactura = new Factura();
                    oFactura.Fecha = Convert.ToDateTime(row["fecha"].ToString());
                    oFactura.Total = Convert.ToDouble(row["total"].ToString());

                    Sucursal oSucursal = new Sucursal();
                    oSucursal.NombreSuc= row["Sucursal"].ToString();


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
