using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace MangaDb.Classes.DAL
{
    public class Conexao
    {
        public static string connectionString = "conexao";
        public static MySqlConnection connection = new MySqlConnection(connectionString);
        public static void Conectar()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();

            }

        }
        public static void Desconectar()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();

            }
        }
    }
}
}
