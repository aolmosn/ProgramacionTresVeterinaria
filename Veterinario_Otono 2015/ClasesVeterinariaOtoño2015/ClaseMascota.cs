using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesVeterinariaOtoño2015
{
    public class ClaseMascota
    {
        public int ID;
        public String Nombre;
        public int id_Raza;
        public DateTime FechaNacimiento;
        public String Sexo;
        public String id_Color;
        public int id_Dueño;

        #region CONSTRUCTORES
        public ClaseMascota() { }
        public ClaseMascota(int id, string nombre, int id_raza, DateTime fechaNacimiento, string sexo, string id_color, int id_dueño)
        {
            this.ID = id;
            this.Nombre = nombre;
            this.id_Raza = id_raza;
            this.FechaNacimiento = fechaNacimiento;
            this.Sexo = sexo;
            this.id_Color = id_color;
            this.id_Dueño = id_dueño;
        }
        public ClaseMascota(string nombre, int id_raza, DateTime fechaNacimiento, string sexo, string id_color, int id_dueño)
        {
            this.Nombre = nombre;
            this.id_Raza = id_raza;
            this.FechaNacimiento = fechaNacimiento;
            this.Sexo = sexo;
            this.id_Color = id_color;
            this.id_Dueño = id_dueño;
        }
        #endregion

        #region METODOS

        #region METODOS CRUD
        public String ingresar(ClaseMascota mascota)
        {
            String SW = "";
            return SW;
        }

        public String modificar(ClaseMascota mascota)
        {
            String SW = "";
            return SW;
        }

        public static String Eliminar(int id)
        {
            String SW = "";
            return SW;
        }
        #endregion

        #endregion
    }
}
