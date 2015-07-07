using ClasesVeterinariaOtoño2015;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Veterinario_Otoño_2015
{
    public partial class FormParametros : Form
    {
        public FormParametros()
        {
            InitializeComponent();
            CargarGrillaEspecies();
            CargaComboEspecies();
        }

        private void CargaComboEspecies()
        {
            try
            {
                SqlConnection con = new SqlConnection();
                SqlCommand cmm = new SqlCommand();
                cmm = ClaseEspecie.llenaCombo();
                SqlDataReader lee = cmm.ExecuteReader();

                while (lee.Read())
                {
                    this.cmbEspecie.Items.Add(lee[0]);
                }

                ClaseConectar.Cerrar();
                lee.Close();

            }
            catch (Exception ex)
            {

            }
        }

        private void CargarGrillaEspecies() 
        {
            try 
            {
                SqlDataAdapter DA = new SqlDataAdapter();
                DA = ClaseEspecie.llenarGrilla();
                DataSet DS = new DataSet();
                DA.Fill(DS);
                this.dataGridEspecies.DataSource = DS.Tables[0];
                this.cmbEspecie.Items.Clear();
                CargaComboEspecies();
                
            }
            catch(Exception ex)
            {
            
            }
        }

        private void btnBuscarColor_Click(object sender, EventArgs e)
        {
            ColorDialog DLG = new ColorDialog();
            if (DLG.ShowDialog() == DialogResult.OK)
            {
                this.pictureColor.BackColor = DLG.Color;
                int rojo = pictureColor.BackColor.R;
                int verde = pictureColor.BackColor.G;
                int azul = pictureColor.BackColor.B;

                this.txtRojo.Text = Convert.ToString(rojo);
                this.txtVerde.Text = Convert.ToString(verde);
                this.txtAzul.Text = Convert.ToString(azul);
                this.txtDescripcionColor.Text = pictureColor.BackColor.Name;
                this.txtCodigoColor.Text = String.Format("{0:X}",rojo) + 
                                           String.Format("{0:X}",verde) +
                                           String.Format("{0:X}",azul);

            }
        }

        private void btnIngresarEspecie_Click(object sender, EventArgs e)
        {
            ClaseEspecie especie = new ClaseEspecie(this.txtDescripcionEspecie.Text);
            MessageBox.Show(especie.Ingresar(especie));
            CargarGrillaEspecies();
            
        }

        private void btnModificarEspecies_Click(object sender, EventArgs e)
        {
            ClaseEspecie especie = new ClaseEspecie(Convert.ToInt32(this.txtCodigoEspecie.Text) ,this.txtDescripcionEspecie.Text);
            MessageBox.Show(especie.Modificar(especie));
            CargarGrillaEspecies();
        }

        private void btnEliminarEspecies_Click(object sender, EventArgs e)
        {

            MessageBox.Show(" " + ClaseEspecie.Eliminar(Convert.ToInt32(this.txtCodigoEspecie.Text)));
            CargarGrillaEspecies();
        }

        private void dataGridEspecies_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int fila = this.dataGridEspecies.CurrentCell.RowIndex;//Debuelve la fila activa
                this.txtCodigoEspecie.Text = this.dataGridEspecies[0, fila].Value.ToString();
                this.txtDescripcionEspecie.Text = this.dataGridEspecies[1, fila].Value.ToString();

            }
            catch (Exception ex)
            {

            }
        }

        private void cmbEspecie_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.txtCodigoEspecie_Raza.Text = Convert.ToString(ClaseEspecie.ConsultaCodigo(this.cmbEspecie.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void llenaGrillaRaza()
        {
            try
            {
                SqlDataAdapter DA = new SqlDataAdapter();
                DA = ClaseRaza.llenagrilla(Convert.ToInt32(this.txtCodigoEspecie_Raza.Text));
                DataSet DS = new DataSet();
                DA.Fill(DS);
                this.dataGridRazas.DataSource = DS.Tables[0];


            }
            catch (Exception ex)
            {

            }

        }
    }
}
