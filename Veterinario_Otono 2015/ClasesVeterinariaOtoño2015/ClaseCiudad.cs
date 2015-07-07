using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesVeterinariaOtoño2015
{
    public class ClaseCiudad
    {

        #region ATRIBUTOS
        public int ID;
        public String Nombre;
        public int ID_Region;
        #endregion

        #region CONSTRUCTORES
        //Constructor sin parametros
        public ClaseCiudad() { }
        //Constructor con parametros
        public ClaseCiudad(int id, string nombre, int id_region)
        {
            this.ID = id;
            this.Nombre = nombre;
            this.ID_Region = id_region;   
        }
        //Constructor de 2 parametros
        public ClaseCiudad(string nombre, int id_region)
        {
            this.Nombre = nombre;
            this.ID_Region = id_region;
        }
        #endregion

        #region METODOS
        public int ConsultaID(int Id_Coumna)
        {
            return ID;
        }
        public String Consultar_Nombre(int Id_Ciudad)
        {
            return Nombre;
        }
        #endregion

    }
}
