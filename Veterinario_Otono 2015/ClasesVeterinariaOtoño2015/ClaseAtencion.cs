using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesVeterinariaOtoño2015
{
    public class ClaseAtencion
    {
        public int id;
        public int id_Mascota;
        public int id_Veterinario;
        public DateTime fechaAtencion;
        public String diagnostico;
        public String receta;

        #region CONSTRUCTORES

        public ClaseAtencion() { }
        public ClaseAtencion(int Id, int Id_Mascota, int Id_Veterinario,
                               DateTime FechaAtencion, string Diagnostico,
                                string Recetas) 
        {
            this.id = Id;
            this.id_Mascota = Id_Mascota;
            this.id_Veterinario = Id_Veterinario;
            this.fechaAtencion = FechaAtencion;
            this.diagnostico = Diagnostico;
            this.receta = Recetas;
        }
        public ClaseAtencion(int Id_Mascota, int Id_Veterinario,
                               DateTime FechaAtencion, string Diagnostico,
                                string Recetas)
        {
            this.id_Mascota = Id_Mascota;
            this.id_Veterinario = Id_Veterinario;
            this.fechaAtencion = FechaAtencion;
            this.diagnostico = Diagnostico;
            this.receta = Recetas;
        }
        #endregion

        #region METODOS

        public String Ingresar(ClaseAtencion Atencion) 
        {
            string sw = "";

            return sw;  
        }

        public String Modificar(ClaseAtencion Atencion)
        {
            string sw = "";

            return sw;
        }

        public static String Eliminar(int id_Atncion)
        {
            string sw = "";

            return sw;
        }
        #endregion


    }
}
