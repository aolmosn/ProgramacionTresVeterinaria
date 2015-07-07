using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace ClasesVeterinariaOtoño2015
{
    public class ClaseRaza
    {
        #region ATRIBUTOS

        public int ID;
        public string Nombre;
        public int id_Especie;

        #endregion

        #region CONSTRUCTORES
        
        //Constructor sin parametros
        public ClaseRaza() { }
        //Cosntructor con parametros
        public ClaseRaza(int id, string nombre, int id_especie) 
        {
            this.ID = id;
            this.Nombre = nombre;
            this.id_Especie = id_especie;
        }
        //Constructor con parmetros
        public ClaseRaza(string nombre, int id_especie) 
        {
            this.Nombre = nombre;
            this.id_Especie = id_especie;
        }

        #endregion

        #region METODOS

        public static SqlDataAdapter llenagrilla(int id)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ClaseConectar.Dir;
            con.Open();
            SqlDataAdapter DA = new SqlDataAdapter("Select * from Raza where ID_ESPECIE  = '" + id + "'", con);
            con.Close();
            return DA;

        }
        #endregion
    }
}
