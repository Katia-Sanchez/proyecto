using System;
using System.Data;
using System.Data.SqlClient;


namespace ProyectoCerealesVentura
{
    class Conexion1
    {
        private static SqlConnection conexion1()
        {
            SqlConnection conec = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\ProyectoCerealesVentura\\ProyectoCerealesVentura\\DBventura.mdf;Integrated Security=True");

            return conec;
        }

        public DataSet readQuery (string query, string table)
        {
            SqlDataAdapter dada = new SqlDataAdapter(query, conexion1());
            DataSet das = new DataSet();
            dada.Fill(das, table); //llenado de tabla

            return das;
        }

        public DataRow[] readQuery (string query, string table, bool datarow)
        {
            DataTable tab = readQuery(query, table).Tables[table];
            DataRow[] rows = tab.Select();
            return rows;
        }

        public bool setData(String query)
        {
            try
            {
                SqlCommand comd = new SqlCommand(query, conexion1());
                comd.Connection.Open();
                comd.ExecuteNonQuery();

                return true;
            }
            catch(Exception e)
            {

            }
        }
    }
}
                      

