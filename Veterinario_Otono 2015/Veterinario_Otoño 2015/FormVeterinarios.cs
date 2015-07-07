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
    public partial class FormVeterinarios : Form
    {
        public FormVeterinarios()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
           
            this.Close();
        }

        private void FormVeterinarios_Load(object sender, EventArgs e)
        {

        }
        #region EVENTOS KEYPRESS

        private void txtRutVeterinario_KeyPress(object sender, KeyPressEventArgs e)
        {
            int codigo = Convert.ToInt32(e.KeyChar);
            //Si digito es un numero o k o guion o k
            if (Char.IsDigit(e.KeyChar) || codigo == 45 || codigo == 75 || codigo == 107 || codigo == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }


        private void txtNombreVeterinario_KeyPress(object sender, KeyPressEventArgs e)
        {
            int codigo = Convert.ToInt32(e.KeyChar);
            if (!Char.IsDigit(e.KeyChar) || codigo == 8) //8 para borrar
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
            //Si es un digito....
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

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                ClaseVeterinario veterinario = new ClaseVeterinario(this.txtRutVeterinario.Text, this.txtNombreVeterinario.Text,
                    this.txtApellidoPaterno.Text, this.txtApellidoMaterno.Text, this.txtCelular.Text, this.txtEmail.Text, this.txtIdEspecialidad.Text);
                if (validar())
                {
                    MessageBox.Show("Resultado: " + veterinario.Ingresar(veterinario));
                }
            }
            catch (Exception ex) 
            {
            
            }
        }

        //Validacion de los 
        public bool validar()
        {
            bool valid = true;

            //Validacion del Rut Veterinario
            if (txtRutVeterinario.Text.Trim() == "")
            {
                this.errorProviderVeterinario.SetError(this.txtRutVeterinario, "Debe Ingresar Rut del Veterinario");
                valid = false;
            }
            else
            {
                this.errorProviderVeterinario.SetError(this.txtRutVeterinario, "");
            }


            //Validacion del Nombre Veterinario
            if (this.txtNombreVeterinario.Text.Trim() == "")
            {
                this.errorProviderVeterinario.SetError(this.txtNombreVeterinario, "Debe Ingresar Nombre del Veterinario");
                valid = false;
            }
            else
            {
                this.errorProviderVeterinario.SetError(this.txtNombreVeterinario, "");
            }
            //Validacion Apellido Paterno
            if (this.txtApellidoPaterno.Text.Trim() == "")
            {
                this.errorProviderVeterinario.SetError(this.txtApellidoPaterno, "Debe Ingresar Apellido del Veterinario");
                valid = false;
            }
            else
            {
                this.errorProviderVeterinario.SetError(this.txtApellidoPaterno, "");
            }
            //Validacion apellido Materno Veterinario
            if (this.txtApellidoMaterno.Text.Trim() == "")
            {
                this.errorProviderVeterinario.SetError(this.txtApellidoMaterno, "Debe Ingresar Apellido del Veterinario");
                valid = false;
            }
            else
            {
                this.errorProviderVeterinario.SetError(this.txtApellidoMaterno, "");
            }
            //Validacion Celular
            if (this.txtCelular.Text.Trim() == "")
            {
                this.errorProviderVeterinario.SetError(this.txtCelular, "Debe Ingresar numero de Celular del Veterinario");
                valid = false;
            }
            else
            {
                this.errorProviderVeterinario.SetError(this.txtCelular, "");
            }
            //Validar Correo
            if (!valCorreo(this.txtEmail.Text))
            {
                this.errorProviderVeterinario.SetError(this.txtEmail, "Correo Invalido");
                valid = false;
            }
            else
            {
                this.errorProviderVeterinario.SetError(this.txtEmail, "");

            }
            //Validacion del CMBComuna
            if (this.cmbEspecialidad.Text == "<<Elegir>>" || this.cmbEspecialidad.Text == "")//Verificacion ComboBox Comuna
            {
                this.errorProviderVeterinario.SetError(this.cmbEspecialidad, "No se permite valor en blanco");
                valid = false;
            }
            else { this.errorProviderVeterinario.SetError(this.cmbEspecialidad, ""); }

            return valid;
        }


        //Validar direccion correo valida
        private bool valCorreo(string Correo)
        {
            string expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (System.Text.RegularExpressions.Regex.IsMatch(Correo, expresion))
            {
                if (System.Text.RegularExpressions.Regex.Replace(Correo, expresion, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }



        }

        private void FormVeterinarios_FormClosed(object sender, FormClosedEventArgs e)
        {
            foreach (Form formulario in Application.OpenForms) {
                TextBox textoNombre = new TextBox();
                TextBox textoId = new TextBox();
                textoNombre = (TextBox)formulario.Controls["txtVeterinario"];
                textoNombre.Text = this.txtNombreVeterinario.Text + " " +
                    this.txtApellidoPaterno.Text + " " +
                    this.txtApellidoMaterno.Text;
                textoId = (TextBox)formulario.Controls["txtIdVeterinario"];
                textoId.Text = this.txtIdVeterinario.Text;
                break;


            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                ClaseVeterinario veterinario = new ClaseVeterinario(Convert.ToInt32(this.txtIdVeterinario.Text), this.txtRutVeterinario.Text, this.txtNombreVeterinario.Text,
                    this.txtApellidoPaterno.Text, this.txtApellidoMaterno.Text, this.txtCelular.Text, this.txtEmail.Text, this.txtIdEspecialidad.Text);
                if (validar())
                {
                    MessageBox.Show("Resultado: " + veterinario.Ingresar(veterinario));
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro que desea eliminar este registro", "Eliminar Registro",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                try
                {
                    MessageBox.Show("Resultaro: " + ClaseDueño.Eliminar(Convert.ToInt32(this.txtRutVeterinario.Text)));
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
    }
}
