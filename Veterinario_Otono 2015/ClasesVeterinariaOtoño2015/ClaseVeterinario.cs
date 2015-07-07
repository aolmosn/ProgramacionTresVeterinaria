using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesVeterinariaOtoño2015
{
    public class ClaseVeterinario
    {
        #region ATRIBUTOS
        public int IdVeterinario;
        public String Rut;
        public String Nombre;
        public String ApPaterno;
        public String ApMaterno;
        public String Celular;
        public String email;
        public String Especialidad;
        #endregion

        #region CONSTRUCTOR

        public ClaseVeterinario() { }
        
        public ClaseVeterinario(int idVeterinario, string rut, string nombre, string apPaterno,
            string apMaterno, string Celular, string email, string especialidad) 
        {
            this.IdVeterinario = idVeterinario;
            this.Rut = rut;
            this.Nombre = nombre;
            this.ApPaterno = apPaterno;
            this.ApMaterno = apMaterno;
            this.Celular = Celular;
            this.email = email;
            this.Especialidad = especialidad;
        }
       
        public ClaseVeterinario(string rut, string nombre, string apPaterno,
            string apMaterno, string Celular, string email, string especialidad)
        {
            this.Rut = rut;
            this.Nombre = nombre;
            this.ApPaterno = apPaterno;
            this.ApMaterno = apMaterno;
            this.Celular = Celular;
            this.email = email;
            this.Especialidad = especialidad;
        }

        #endregion

        public String Ingresar(ClaseVeterinario vt) 
        {
            String sw ="";
            return sw;
        }
        public String Modificar(ClaseVeterinario vt)
        {
            String sw = "";
            return sw;
        }
        public static String Eliminar(int Id)
        {
            String sw = "";
            return sw;
        }
    }
}
