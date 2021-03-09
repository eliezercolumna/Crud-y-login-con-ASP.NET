using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;

namespace AprendeAsp.Models.db
{
    public static class Conexion
    {
        public static MySqlConnection Conectar()
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.UserID = "root";
            builder.Password = "";
            builder.Database = "prueba";
            var cn = new  MySqlConnection(builder.ToString());
            return cn;
        }
    }
}