using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesVeterinariaOtoño2015
{

    public class ClaseComuna
    {

        #region ATRIBUTOS
        //Atributos de la clase
        public int ID;
        public String Nombre;
        public int ID_Ciudad;
        #endregion

        #region CONSTRUCTORES
        
        //Constructor sin parametros
        public ClaseComuna() { }
        //Contructor con parametros
        public ClaseComuna(int id, string Nombre, int id_ciudad) 
        {
            this.ID = id;
            this.Nombre = Nombre;
            this.ID_Ciudad = id_ciudad;
        }
        //Constructor con parametro nombre y region
        public ClaseComuna(string nombre, int id_ciudad)
        {
            this.Nombre = nombre;
            this.ID_Ciudad = id_ciudad;
        }

        #endregion

        #region METODOS

        public int ConsultaID(String nombre)
        {
            return ID;
        }
        
        #endregion
        
    }
}
