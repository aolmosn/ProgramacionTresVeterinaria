using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesVeterinariaOtoño2015
{
    public class ClaseColor
    {
        #region ATRIBUTOS
        public String ID;
        public int Red;
        public int Green;
        public int Blue;
        public String Nombre;
        #endregion

        #region CONSTRUCTORç
        public ClaseColor() { }
        public ClaseColor(string id, int red, int green, int blue, string nombre) 
        {
            this.ID = id;
            this.Red = red;
            this.Green = green;
            this.Blue = blue;
            this.Nombre = nombre;
        }
        public ClaseColor(int red, int green, int blue, string nombre)
        {

            this.Red = red;
            this.Green = green;
            this.Blue = blue;
            this.Nombre = nombre;
        }
        #endregion

        #region METODOS

        #endregion

    }
}
