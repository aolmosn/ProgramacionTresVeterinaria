using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesVeterinariaOtoño2015
{
    public class ClaseRegion
    {

        #region ATRIBUTOS

        public int ID;
        public String Nombre;

        #endregion

        #region CONSTRUCTORES

        //Constructor sin parametros
        public ClaseRegion() { }
        //Constructor con parametros
        public ClaseRegion(int id, String nombre)
        {
            this.ID = id;
            this.Nombre = nombre;
        }

        #endregion

        #region METODOS

         public String Consultar_Nombre(int Id_Ciudad)
                {
                    return Nombre;
                }
        #endregion
               
    }
}
