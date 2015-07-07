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
    public partial class FormAtencion : Form
    {
        public RichTextBox cuadroTexto = new RichTextBox();

        public FormAtencion()
        {
            InitializeComponent();
        }

        private void FormAtencion_Load(object sender, EventArgs e)
        {
            MenuStrip elMenu = new MenuStrip();
            elMenu = (MenuStrip)this.MdiParent.Controls["menuStripPrincipal"]; /*informacion de form1*/
            ToolStripMenuItem Opcion = new ToolStripMenuItem();
            Opcion = (ToolStripMenuItem)elMenu.Items["ingresoToolStripMenuItem"];
            Opcion.DropDownItems["atencionesToolStripMenuItem"].Enabled = false;

            ToolStrip elBoton = new ToolStrip();
            elBoton = (ToolStrip)this.MdiParent.Controls["toolStrip1"];
            elBoton.Items["toolStripAtencion"].Enabled = false;

            foreach (Form formulario in Application.OpenForms)
            {
                if (formulario.GetType() == typeof(FormMascota))
                {
                    Button boton = new Button();
                    boton = (Button)formulario.Controls["btnIngresarAtencion"];
                    boton.Enabled = false;
                    break;
                }
            }
        }

        //Validacion campos

        private bool validacion()
        {
            bool validado = true;

            //Validacion de que los datos mascota no sean nulos
            ////Validacion nombre mascota
            //if (this.txtAtencionNombreM.Text.Trim() == "")
            //{
            //    this.ErrorProviderAtencion.SetError(this.txtAtencionNombreM,
            //        "Ingrese datos desde formulario mascotas");
            //    validado = false;
            //}
            //else
            //{
            //    this.ErrorProviderAtencion.SetError(this.txtAtencionNombreM, "");
            //}

            ////Validacion Especie
            //if (this.txtAtencionEsp.Text.Trim() == "")
            //{
            //    this.ErrorProviderAtencion.SetError(this.txtAtencionEsp,
            //        "Ingrese datos desde formulario mascotas");
            //    validado = false;
            //}
            //else
            //{
            //    this.ErrorProviderAtencion.SetError(this.txtAtencionEsp, "");
            //}

            ////Validacion raza mascota
            //if (this.txtAtencionRaza.Text.Trim() == "")
            //{
            //    this.ErrorProviderAtencion.SetError(this.txtAtencionRaza,
            //        "Ingrese datos desde formulario mascotas");
            //    validado = false;
            //}
            //else
            //{
            //    this.ErrorProviderAtencion.SetError(this.txtAtencionRaza, "");
            //}

            ////Valida nombre duelo
            //if (this.txtAtencionNombreD.Text.Trim() == "")
            //{
            //    this.ErrorProviderAtencion.SetError(this.txtAtencionNombreD,
            //        "Ingrese datos desde formulario mascotas");
            //    validado = false;
            //}
            //else
            //{
            //    this.ErrorProviderAtencion.SetError(this.txtAtencionNombreD, "");
            //}

            ////Valida apellido paterno
            //if (this.txtAtencionApePat.Text.Trim() == "")
            //{
            //    this.ErrorProviderAtencion.SetError(this.txtAtencionApePat,
            //        "Ingrese datos desde formulario mascotas");
            //    validado = false;
            //}
            //else
            //{
            //    this.ErrorProviderAtencion.SetError(this.txtAtencionApePat, "");
            //}


            ////Valida apellido amterno
            //if (this.txtAtencionApeMat.Text.Trim() == "")
            //{
            //    this.ErrorProviderAtencion.SetError(this.txtAtencionApeMat,
            //        "Ingrese datos desde formulario mascotas");
            //    validado = false;
            //}
            //else
            //{
            //    this.ErrorProviderAtencion.SetError(this.txtAtencionApeMat, "");
            //}

            //Valida nombre veterinario
            if (this.txtNombreveterinarioAtencion.Text.Trim() == "")
            {
                this.ErrorProviderAtencion.SetError(this.txtNombreveterinarioAtencion,
                    "Debe tener relacionado un Veterinario");
                validado = false;
            }
            else
            {
                this.ErrorProviderAtencion.SetError(this.txtNombreveterinarioAtencion, "");
            }

            //Valida fecha 
            if (this.dtpFechaAtencion.Value > DateTime.Now)
            {
                this.ErrorProviderAtencion.SetError(this.dtpFechaAtencion, "Fecha no puede ser mayor o menor a la fecha de hoy");
                validado = false;
            }
            else
            {
                this.ErrorProviderAtencion.SetError(this.dtpFechaAtencion, "");
            }

            //Valida datosiagnostico
            if (this.rhtDiagnostico.Text.Trim() == "")
            {
                this.ErrorProviderAtencion.SetError(this.rhtDiagnostico,
                    "No puede estar vacio");
                validado = false;
            }
            else
            {
                this.ErrorProviderAtencion.SetError(this.rhtDiagnostico, "");
            }

            //Valida receta
            if (this.rhtReceta.Text.Trim() == "")
            {
                this.ErrorProviderAtencion.SetError(this.rhtReceta,
                    "No puede estar vacio");
                validado = false;
            }
            else
            {
                this.ErrorProviderAtencion.SetError(this.rhtReceta, "");
            }

            return validado;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscarVeterinario_Click(object sender, EventArgs e)
        {
            FormVeterinarios Veterinarios = new FormVeterinarios();
            if (Veterinarios.ShowDialog() == DialogResult.OK) {
                string nombre = Veterinarios.txtNombreVeterinario.Text;
                string apePaterno = Veterinarios.txtApellidoPaterno.Text;
                string apeMaterno = Veterinarios.txtApellidoMaterno.Text;
                this.txtNombreveterinarioAtencion.Text = nombre + " " + apePaterno + " " + apeMaterno;
            }
        }

        private void FormAtencion_FormClosed(object sender, FormClosedEventArgs e)
        {
            MenuStrip elMenu = new MenuStrip();
            elMenu = (MenuStrip)this.MdiParent.Controls["menuStripPrincipal"]; /*informacion de form1*/
            ToolStripMenuItem Opcion = new ToolStripMenuItem();
            Opcion = (ToolStripMenuItem)elMenu.Items["ingresoToolStripMenuItem"];
            Opcion.DropDownItems["atencionesToolStripMenuItem"].Enabled = true;

            ToolStrip elBoton = new ToolStrip();
            elBoton = (ToolStrip)this.MdiParent.Controls["toolStrip1"];
            elBoton.Items["toolStripAtencion"].Enabled = true;

            foreach (Form formulario in Application.OpenForms)
            {
                if (formulario.GetType() == typeof(FormMascota))
                {
                    Button boton = new Button();
                    boton = (Button)formulario.Controls["btnIngresarAtencion"];
                    boton.Enabled = true;
                    break;
                }
            }
        }

        private void btnAtencion_Click(object sender, EventArgs e)
        {
            if (validacion())
            {
                try
                {
                    ClaseAtencion Atencion = new ClaseAtencion(Convert.ToInt32(this.txtIdMascota.Text), Convert.ToInt32(this.txtIdVeterinario.Text),
                                                                this.dtpFechaAtencion.Value, this.rhtDiagnostico.Rtf, this.rhtReceta.Rtf);
                    MessageBox.Show("Registro : " + Atencion.Ingresar(Atencion));

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else
            { MessageBox.Show("Registro no ingresado, Datos erroneos", "Ingreso",MessageBoxButtons.OK,MessageBoxIcon.Error); }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (validacion())
            {
                try
                {
                    ClaseAtencion Atencion = new ClaseAtencion(Convert.ToInt32(this.txtIDAtencion.Text), Convert.ToInt32(this.txtIdMascota.Text), Convert.ToInt32(this.txtIdVeterinario.Text),
                                                                this.dtpFechaAtencion.Value, this.rhtDiagnostico.Rtf, this.rhtReceta.Rtf);
                    MessageBox.Show("Registro : " + Atencion.Modificar(Atencion));

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else
            { MessageBox.Show("Registro no modificado, Datos erroneos", "Ingreso", MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Esta seguro de que desea eliminar este registro?", "Eliminar",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    MessageBox.Show("Resultado: " + ClaseAtencion.Eliminar(Convert.ToInt32(this.txtIDAtencion.Text)));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void fuenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                cuadroTexto = (RichTextBox)this.ActiveControl;
                FontDialog DL = new FontDialog();
                if (DL.ShowDialog() == DialogResult.OK)
                {
                    cuadroTexto.SelectionFont = DL.Font;
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                cuadroTexto = (RichTextBox)this.ActiveControl;
                ColorDialog DL = new ColorDialog();
                if (DL.ShowDialog() == DialogResult.OK)
                {
                    cuadroTexto.SelectionColor = DL.Color;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
    }
}
