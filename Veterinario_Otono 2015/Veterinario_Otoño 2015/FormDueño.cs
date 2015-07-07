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
    public partial class FormDueño : Form
    {
        public FormDueño()
        {
            InitializeComponent();
        }

        #region Funcion Botones
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close(); //cierra solo el formulario, no la aplicacion entera.
        }

        private void btnIngresarMascota_Click(object sender, EventArgs e)
        {

            
                FormMascota mascota = new FormMascota();
                //mascota.ShowDialog();
                mascota.txtIdDueño.Text = this.txtIdDueño.Text; //referencia metodos de otra clase
                mascota.txtRut.Text = this.txtRut.Text;
                mascota.txtNombre.Text = this.txtNombre.Text;
                mascota.txtApellidoPaterno.Text = this.txtApellidoPaterno.Text;
                mascota.txtApellidoMaterno.Text = this.txtApellidoMaterno.Text;
                mascota.MdiParent = this.MdiParent;
                mascota.Show(); //abre el from mascota

                this.btnIngresarMascota.Enabled = false;

                mascota.FormClosed += delegate
                {
                    this.btnIngresarMascota.Enabled = true;
                };
            
        }



        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (validado())
            {
                ClaseDueño dueño = new ClaseDueño(txtRut.Text, txtNombre.Text, txtApellidoPaterno.Text,
                    txtApellidoMaterno.Text, txtCelular.Text, txtEmail.Text, Convert.ToInt32(txtIdComuna.Text),
                    txtCalleNumero.Text);
                MessageBox.Show("" + dueño.Ingresar(dueño) );
              
            }
            else
            {
                MessageBox.Show("Registro no ingresado. Datos no validados");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (validado())
            {
                try
                {
                    ClaseDueño dueño = new ClaseDueño(Convert.ToInt32(this.txtIdDueño),txtRut.Text, txtNombre.Text, txtApellidoPaterno.Text,
                        txtApellidoMaterno.Text, txtCelular.Text, txtEmail.Text, Convert.ToInt32(txtIdComuna.Text),
                        txtCalleNumero.Text);
                    MessageBox.Show("Resultado: " + dueño.Modificar(dueño));
                }
                catch(Exception ex)
                {
                    if (ex.Message.Contains("'System.Windows.Forms.TextBox' al tipo"))
                    {
                        MessageBox.Show("No se puede convertir dato\nNulo del la casilla ID");
                    }
                }
                
            }
            else
            {
                MessageBox.Show("Registro no ingresado. Datos no validados");
            }
            
                
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro que desea eliminar este registro", "Eliminar Registro",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                try
                {
                    MessageBox.Show("Resultaro: " + ClaseDueño.Eliminar(Convert.ToInt32(this.txtRut.Text)));
                }
                catch (Exception ex)
                {
                    if (ex.Message.Contains("'System.Windows.Forms.TextBox' al tipo"))
                    {
                        MessageBox.Show("No se puede eliminar ya que el\nvalor de la casilla ID es nulo");
                    }
                }
            }
        }

        #endregion

        #region Metodos KeyPress

        private void txtRut_KeyPress(object sender, KeyPressEventArgs e)
        {
            int codigo = Convert.ToInt32(e.KeyChar);
            if (Char.IsDigit(e.KeyChar) || codigo == 45 || codigo == 75 || codigo == 107 || codigo == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

        }

     

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            int codigo = Convert.ToInt32(e.KeyChar);
            if (!Char.IsDigit(e.KeyChar) || codigo == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtCelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            int codigo = Convert.ToInt32(e.KeyChar);
            if (Char.IsDigit(e.KeyChar) || codigo == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        #endregion

        #region Validaciones

        Boolean verificaCorreo(String correo) 
        {
            string expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (System.Text.RegularExpressions.Regex.IsMatch(correo, expresion))
            {
                if (System.Text.RegularExpressions.Regex.Replace(correo, expresion, String.Empty).Length == 0)
                {
                    return true;
                }
                else { return false; }
            }
            else { return false; }

        }

        Boolean validado()
        
        {
            Boolean sw = true;
            if (!verificaCorreo(this.txtEmail.Text))
            {
                this.errorProviderDueño.SetError(this.txtEmail, "EMAIL INVALIDO");
                sw = false;
            }
            else {
                this.errorProviderDueño.SetError(this.txtEmail, "");
            }



            if (this.txtRut.Text.Trim() == "")
            {
                this.errorProviderDueño.SetError(this.txtRut, "NO SE PERMITE ESPACIO EN BLANCO");
                sw = false;
            }
            else {
                this.errorProviderDueño.SetError(this.txtRut, "");
            }


            if (this.txtApellidoPaterno.Text.Trim() == "") 
            {
                this.errorProviderDueño.SetError(this.txtApellidoPaterno, "NO SE PERMITE ESPACIO EN BLANCO");
                sw = false;
            }
            else{
                this.errorProviderDueño.SetError(this.txtApellidoPaterno, "");
            }


            if (this.txtApellidoMaterno.Text.Trim() == "")
            {
                this.errorProviderDueño.SetError(this.txtApellidoMaterno, "NO SE PERMITE ESPACIO EN BLANCO");
                sw = false;
            }
            else{
                this.errorProviderDueño.SetError(this.txtApellidoMaterno, "");
            }


            if (this.txtNombre.Text.Trim() == "")
            {
                this.errorProviderDueño.SetError(this.txtNombre, "NO SE PERMITE ESPACIO EN BLANCO");
                sw = false;
            } 
            else{
                this.errorProviderDueño.SetError(this.txtNombre, "");
            }


            if (this.txtCalleNumero.Text.Trim() == "")
            {
                this.errorProviderDueño.SetError(this.txtCalleNumero, "NO SE PERMITE ESPACIO EN BLANCO");
                sw = false;
            }
            else {
                this.errorProviderDueño.SetError(this.txtCalleNumero, "");
            }


            if (this.txtCelular.Text.Trim() == "")
            {
                this.errorProviderDueño.SetError(this.txtCelular, "NO SE PERMITE ESPACIO EN BLANCO");
                sw = false;
            }
            else {
                this.errorProviderDueño.SetError(this.txtCelular, "");
            }
            //Trim() ELIMINA ESPACIOS EN BLANCO ADELANTE Y AL FINAL.
            
            //validacion combobox
            if (this.cmbComuna.Text == "<<Elegir>>" || this.cmbComuna.Text == "")
            {
                this.errorProviderDueño.SetError(this.cmbComuna, "NO SE PERMITE ESPACIO EN BLANCO");
                sw = false;
            }
            else {
                this.errorProviderDueño.SetError(this.cmbComuna, "");
            }
            return sw;

        }
        #endregion


        private void FormDueño_Load(object sender, EventArgs e)
        {
            //Buscar el Formulario Mascota Para cerrarlo
            foreach (Form formulario in Application.OpenForms)
            {
                if (formulario.GetType() == typeof(FormMascota))
                {
                    formulario.Close();
                    break;
                }
            }
            //Buscar el Formulario Veterinario para cerrarlo
            foreach (Form formulario in Application.OpenForms)
            {
                if (formulario.GetType() == typeof(FormVeterinarios))
                {
                    formulario.Close();
                    break;
                }
            }
            //Buscar el Formulario Atencion para cerrarlo
            foreach (Form formulario in Application.OpenForms)
            {
                if (formulario.GetType() == typeof(FormAtencion))
                {
                    formulario.Close();
                    break;
                }
            }
        }

        private void txtRut_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbComuna_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Importar la clase comuna al programa 
            //Se debe agregar como referencia
            ClaseComuna Comuna = new ClaseComuna();
            this.txtIdComuna.Text = Convert.ToString(Comuna.ConsultaID(this.cmbComuna.Text));
            
        }

        private void txtIdComuna_TextChanged(object sender, EventArgs e)
        {
            ClaseCiudad Ciudad = new ClaseCiudad();
            this.txtIdCiudad.Text = Convert.ToString(Ciudad.ConsultaID(
                                  Convert.ToInt32(this.txtIdComuna.Text)));
            this.txtCiudad.Text = Ciudad.Consultar_Nombre(Convert.ToInt32(
                        this.txtIdCiudad.Text));
            
        }

        private void txtIdCiudad_TextChanged(object sender, EventArgs e)
        {
            ClaseRegion region = new ClaseRegion();
            this.txtRegion.Text = region.Consultar_Nombre(Convert.ToInt32(
                                    this.txtIdCiudad.Text));
        }


    }

}

