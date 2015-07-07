using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Veterinario_Otoño_2015
{
    public partial class FormAcceso : Form
    {
        public int intento = 0;
        public FormAcceso()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            intento += 1;
            if (this.txtContraseña.Text == "1234" && intento < 3)
            {
                Form1 menu = new Form1();
                menu.Show();
                this.Hide(); /*oculta no cierra*/
            }
            else if (intento == 3) Application.Exit();
            else
             {
                 MessageBox.Show("Clave erronea", "INGRESO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
             }
            
            
        }
    }
}
