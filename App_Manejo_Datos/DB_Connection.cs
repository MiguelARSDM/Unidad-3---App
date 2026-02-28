using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Manejo_Datos
{
    public class DB_Connection
    {

        public static SqlConnection OpenConnection() //Metodo para acceder a la base de datos
        {
            SqlConnection connection = new SqlConnection("Server=MARS;Database=LP2;Trusted_Connection=True;TrustServerCertificate=True;");
            connection.Open();

            return connection;
        }

    }
}
