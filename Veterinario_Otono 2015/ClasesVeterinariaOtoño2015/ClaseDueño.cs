using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesVeterinariaOtoño2015
{
    public class ClaseDueño
    {
        #region ATRIBUTOS
        public int ID;
        public String RUT;
        public String Nombre;
        public String ApPaterno;
        public String ApMaterno;
        public String Celular;
        public String CorreoElectronico;
        public int ID_Comuna;
        public String CalleYNumero;
        #endregion

        #region CONSTRUCTORES
        public ClaseDueño() { }

        public ClaseDueño(int id, string rut, string nombre, string apPaterno,
            string apMaterno, string celular, string correoElectronico, int id_comuna, string calleynumero)
        { 
            this.ID = id;
            this.RUT = rut;
            this.Nombre = nombre;
            this.ApPaterno = apPaterno;
            this.ApMaterno = apMaterno;
            this.Celular = celular;
            this.CorreoElectronico = correoElectronico;
            this.ID_Comuna = id_comuna;
            this.CalleYNumero = calleynumero;
        }

        public ClaseDueño(string rut, string nombre, string apPaterno,
            string apMaterno, string celular, string correoElectronico, int id_comuna, string calleynumero)
        {
            this.RUT = rut;
            this.Nombre = nombre;
            this.ApPaterno = apPaterno;
            this.ApMaterno = apMaterno;
            this.Celular = celular;
            this.CorreoElectronico = correoElectronico;
            this.ID_Comuna = id_comuna;
            this.CalleYNumero = calleynumero;
        }
        #endregion

        #region METODOS CRUD

        public String Ingresar(ClaseDueño dueño)
        {
            String sw = "";

            return sw;
        }

        public String Modificar(ClaseDueño dueño)
        {
            String sw = "";

            return sw;
        }

        public static String Eliminar(int id)
        {
            String sw = "";

            return sw;
        }

        #endregion


    }
}
