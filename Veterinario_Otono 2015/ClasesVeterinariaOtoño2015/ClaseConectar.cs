using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace ClasesVeterinariaOtoño2015
{
    public class ClaseConectar
    {
        public static String Dir = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\andre_000\Documents\BaseVeterinaria2015.mdf;Integrated Security=True;Connect Timeout=30";

        public static void Abrir() 
        {
            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString = Dir;
            cnn.Open();
        }

        public static void Cerrar()
        {
            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString = Dir;
            cnn.Close();
        }
    }
}
