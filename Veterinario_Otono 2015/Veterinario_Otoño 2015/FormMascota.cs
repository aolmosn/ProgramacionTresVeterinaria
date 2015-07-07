using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClasesVeterinariaOtoño2015;

namespace Veterinario_Otoño_2015
{
    public partial class FormMascota : Form
    {
        public FormMascota()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (Validado())
            {
               String Sexo="";
                if(radioButtonHembra.Checked) Sexo = "HEMBRA";
                if(radioButtonMacho.Checked)Sexo = "MACHO";
                if(radioButtonHermafrodita.Checked) Sexo ="HERMAFRODITA";
                try
                {
                    ClaseMascota mascota = new ClaseMascota(this.txtNombreMascota.Text, Convert.ToInt32(this.txtIdRaza.Text),
                                                            this.dateTimeFechaNacimiento.Value, Sexo, this.txtIDColor.Text, Convert.ToInt32(this.txtIdDueño.Text));
                    
                                                             
                    MessageBox.Show("Registro Ingresado" + mascota.ingresar(mascota));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
            else
            {
                MessageBox.Show("Registro no ingresado. Datos no validados");
            }

        }

        #region Validaciones
        private Boolean Validado()
        {
            bool sw = true;

            if (this.txtNombreMascota.Text.Trim() == "")
            {
                this.errorProviderMascota.SetError(this.txtNombreMascota, "DEBE INGRESAR NOMBRE");
                sw = false;
            }
            else {
                this.errorProviderMascota.SetError(this.txtNombreMascota, "");
            }



            if (this.cmbEspecie.Text == "" || this.cmbEspecie.Text == "<<Elegir>>")
            {
                this.errorProviderMascota.SetError(this.cmbEspecie, "DEBE ELEGIR ESPECIE");
                sw = false;
            }
            else{
                this.errorProviderMascota.SetError(this.cmbEspecie, "");
            }


            if (this.cmbRaza.Text == "" || this.cmbRaza.Text == "<<Elegir>>")
            {
                this.errorProviderMascota.SetError(this.cmbRaza, "DEBE ELEGIR RAZA");
                sw = false;
            }
            else{
                this.errorProviderMascota.SetError(this.cmbRaza, "");
            }



            if (this.cmbColor.Text == "" || this.cmbColor.Text == "<<Elegir>>")
            {
                this.errorProviderMascota.SetError(this.cmbColor, "DEBE ELEGIR COLOR");
                sw = false;
            }
            else
            {
                this.errorProviderMascota.SetError(this.cmbColor, "");
            }

            if(!this.radioButtonHembra.Checked && !this.radioButtonMacho.Checked && !this.radioButtonHermafrodita.Checked)
            {
                this.errorProviderMascota.SetError(this.groupBoxSexo, "DEBE ELEGIR EL SEXO DE LA MASCOTA");
                sw = false;
            }
            else{
                this.errorProviderMascota.SetError(this.groupBoxSexo, "");
            }
           
            
            if (this.dateTimeFechaNacimiento.Value > DateTime.Now)
            {
                this.errorProviderMascota.SetError(this.dateTimeFechaNacimiento, "Fecha no puede ser mayor");
                sw = false;
            }
            else{
                this.errorProviderMascota.SetError(this.dateTimeFechaNacimiento, "");
            }

            return sw;
        }


        #endregion

        private void FormMascota_Load(object sender, EventArgs e)
        {
            foreach (Form formulario in Application.OpenForms)
            {
                if (formulario.GetType() == typeof(FormAtencion))
                {
                    formulario.Close();
                    break;
                }
            }
            MenuStrip elMenu = new MenuStrip();
            elMenu = (MenuStrip) this.MdiParent.Controls["menuStripPrincipal"]; /*informacion de form1*/
            ToolStripMenuItem Opcion = new ToolStripMenuItem();
            Opcion = (ToolStripMenuItem)elMenu.Items["ingresoToolStripMenuItem"];
            Opcion.DropDownItems["mascotaToolStripMenuItem"].Enabled = false;

            ToolStrip elBoton = new ToolStrip();
            elBoton = (ToolStrip)this.MdiParent.Controls["toolStrip1"];
            elBoton.Items["toolStripBtnMascotas"].Enabled = false;

            foreach (Form formulario in Application.OpenForms)
            {
                if (formulario.GetType() == typeof(FormDueño))
                {
                    Button boton = new Button();
                    boton = (Button)formulario.Controls["btnIngresarMascota"];
                    boton.Enabled = false;
                    break;
                }
            }
        }

        private void FormMascota_FormClosed(object sender, FormClosedEventArgs e)
        {
            MenuStrip elMenu = new MenuStrip();
            elMenu = (MenuStrip)this.MdiParent.Controls["menuStripPrincipal"]; /*informacion de form1*/
            ToolStripMenuItem Opcion = new ToolStripMenuItem();
            Opcion = (ToolStripMenuItem)elMenu.Items["ingresoToolStripMenuItem"];
            Opcion.DropDownItems["mascotaToolStripMenuItem"].Enabled = true;

            ToolStrip elBoton = new ToolStrip();
            elBoton = (ToolStrip)this.MdiParent.Controls["toolStrip1"];
            elBoton.Items["toolStripBtnMascotas"].Enabled = true;

            foreach (Form formulario in Application.OpenForms)
            {
                if (formulario.GetType() == typeof(FormDueño))
                {
                    Button boton = new Button();
                    boton = (Button)formulario.Controls["btnIngresarMascota"];
                    boton.Enabled = true;
                    break;
                }
            }
        }

        private void btnIngresarAtencion_Click(object sender, EventArgs e)
        {
            FormAtencion Atencion = new FormAtencion();

            //Poniendo los campos en el formulario de atención.
            Atencion.txtAtencionNombreM.Text = this.txtNombreMascota.Text;
            Atencion.txtAtencionEsp.Text = this.cmbEspecie.Text;
            Atencion.txtAtencionRaza.Text = this.cmbRaza.Text;
            Atencion.txtAtencionNombreD.Text = this.txtNombre.Text;
            Atencion.txtAtencionApePat.Text = this.txtApellidoPaterno.Text;
            Atencion.txtAtencionApeMat.Text = this.txtApellidoMaterno.Text;

            Atencion.MdiParent = this.MdiParent;
            Atencion.Show();
            this.btnIngresarAtencion.Enabled = false;
            Atencion.FormClosed += delegate
            {
                this.btnIngresarAtencion.Enabled = true;
                
            };
           
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (Validado())
            {
                try
                {
                    String Sexo = "";
                    if (radioButtonHembra.Checked) Sexo = "HEMBRA";
                    if (radioButtonMacho.Checked) Sexo = "MACHO";
                    if (radioButtonHermafrodita.Checked) Sexo = "HERMAFRODITA";
                    ClaseMascota mascota = new ClaseMascota(Convert.ToInt32(this.txtIdMascota.Text), this.txtNombreMascota.Text,
                                                            Convert.ToInt32(this.txtIdRaza.Text),this.dateTimeFechaNacimiento.Value,
                                                            Sexo, this.txtIDColor.Text, Convert.ToInt32(this.txtIdDueño.Text));
                    
                    MessageBox.Show("Registro Ingresado");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else
            {
                MessageBox.Show("Registro no ingresado. Datos no validados");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Esta seguro de que desea eliminar este registro?", "Eliminar",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    MessageBox.Show("Resultado: " + ClaseMascota.Eliminar(Convert.ToInt32(this.txtIdMascota.Text)));
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
