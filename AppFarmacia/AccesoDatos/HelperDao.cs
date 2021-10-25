using Dominio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
	class HelperDao
	{
		public static HelperDao instancia;
		public string ConnectionString { get; set; }
		public SqlConnection cnn { get; }
		public SqlCommand cmd { get; set; }

		private DataTable table { get; set; }
		private HelperDao()
		{
			ConnectionString = @"Data Source=NOTEBOOK-JERE\SQLEXPRESS;Initial Catalog=Farmaceutica;Integrated Security=True";
			cnn = new SqlConnection(ConnectionString);
			table = new DataTable();
		}
		public static HelperDao ObtenerInstancia()
		{
			if (instancia == null)
			{
				instancia = new HelperDao();
			}
			return instancia;
		}

		public DataTable ConsultaSQLParametros(string nombreSp, List<Parametro> parametros)
		{
			try
			{
				cnn.Open();
				cmd = new SqlCommand(nombreSp, cnn);
				cmd.Parameters.Clear();
				cmd.CommandType = CommandType.StoredProcedure;

				foreach (Parametro p in parametros)
				{
					cmd.Parameters.AddWithValue(p.Nombre, p.Valor);
				}

				table.Load(cmd.ExecuteReader());

				return table;
			}
			catch (Exception)
			{
				table = null;
				return table;
			}
			finally
			{
				if (cnn.State == ConnectionState.Open) cnn.Close();
			}

			
		}
	}
}
