using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trial_and_Error
{
	public class AdoDotNet
	{
		public void demo()
		{
			SqlConnection con = new SqlConnection();
			con.ConnectionString = "";

			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "";
			cmd.Connection = con;
			con.Open();

			//connected architecture.
			//read data only in forword only way
			SqlDataReader rdr = cmd.ExecuteReader();

			if (rdr != null && rdr.HasRows)
			{
				while (rdr.Read())
				{

				}
			}


			//disconnected architecture.
			DataSet ds = new DataSet();
			SqlDataAdapter adp = new SqlDataAdapter(cmd);
			adp.Fill(ds);
		}
	}
}
