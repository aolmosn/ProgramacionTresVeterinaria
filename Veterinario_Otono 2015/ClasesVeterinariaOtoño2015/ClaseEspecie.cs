using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace ClasesVeterinariaOtoño2015
{
    public class ClaseEspecie
    {
        #region ATRIBUTOS
        public int ID;
        public String Nombre;
        #endregion
        
        #region CONSTRUCTORES
        //constructor sin parametro
        public ClaseEspecie() { }
        //Constructor con parametros
        public ClaseEspecie(int id, string nombre)
        {
            this.ID = id;
            this.Nombre = nombre;
        }
        //Constuctor con parametros
        public ClaseEspecie(string nombre)
        {
            this.Nombre = nombre;   
        }
        #endregion

        #region METODOS

        public String Ingresar(ClaseEspecie especie)
        {
            String sw = "";
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = ClaseConectar.Dir;
                SqlCommand cmm = new SqlCommand("IngresarEspecie", con);//Procedimiento almacenado
                cmm.CommandType = CommandType.StoredProcedure;
                cmm.Parameters.Add("@nombre", SqlDbType.NVarChar);
                cmm.Parameters["@nombre"].Value = especie.Nombre;
                con.Open();
                sw = Convert.ToString(cmm.ExecuteNonQuery());
                con.Close();

            }
            catch (Exception ex)
            {
                sw = ex.Message;
            }
            return sw;
        }

        public String Modificar(ClaseEspecie especie)
        {
            String sw = "";
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = ClaseConectar.Dir;
                SqlCommand cmm = new SqlCommand("ModificarEspecie", con);//Procedimiento almacenado
                cmm.CommandType = CommandType.StoredProcedure;
                cmm.Parameters.Add("@id", SqlDbType.NVarChar);
                cmm.Parameters.Add("@nombre", SqlDbType.NVarChar);
                cmm.Parameters["@id"].Value = especie.ID;
                cmm.Parameters["@nombre"].Value = especie.Nombre;
                con.Open();
                sw = Convert.ToString(cmm.ExecuteNonQuery());
                con.Close();

            }
            catch (Exception ex)
            {
                sw = ex.Message;
            }
            return sw;
        }

        public static String Eliminar(int id)
        {
            String sw = "";
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = ClaseConectar.Dir;
                SqlCommand cmm = new SqlCommand("EliminarEspecie", con);//Procedimiento almacenado
                cmm.CommandType = CommandType.StoredProcedure;
                cmm.Parameters.Add("@id", SqlDbType.NVarChar);

                cmm.Parameters["@id"].Value =id;

                con.Open();
                sw = Convert.ToString(cmm.ExecuteNonQuery());
                con.Close();

            }
            catch (Exception ex)
            {
                sw = ex.Message;
            }
            return sw;
        }

        public static SqlDataAdapter llenarGrilla() 
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ClaseConectar.Dir;
            con.Open();
            SqlDataAdapter DA = new SqlDataAdapter("SELECT * FROM ESPECIE", con);
            con.Close();
            return DA;
        }

        public static SqlCommand llenaCombo()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ClaseConectar.Dir;
            con.Open();
            SqlCommand cmm = new SqlCommand("select nombre from especie ", con);
            return cmm;
        }


        public static int ConsultaCodigo(String nombre)
        {
            int sw;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ClaseConectar.Dir;
            SqlCommand cmm = new SqlCommand("", con);
            cmm.Parameters.Add("@nombre", SqlDbType.VarChar);
            cmm.Parameters["@nombre"].Value = nombre;
            cmm.CommandText = "select ID from Especie where nombre = @nombre";
            con.Open();
            SqlDataReader lee = cmm.ExecuteReader();
            lee.Read();
            sw = Convert.ToInt32(lee.GetValue(0));
            return sw;
        }





        #endregion
    }
}
