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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //private void btnSalir_Click(object sender, EventArgs e)
        //{
           // if(MessageBox.Show("QUERES SALIR? CHEE","SALIR",MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes) //mensaje en pantalla
            //{
               // Application.Exit(); //cerrar la aplicacion
            //}
            
        //}

        //private void btnDueños_Click(object sender, EventArgs e)
        //{
            //FormDueño dueño = new FormDueño();
            //dueño.Show();      //PUEDE ESTAR EN OTRAS VENTANAS Y ABRIR MUCHAS A LA VEZ
            //dueño.ShowDialoge(); //EVITAR QUE SALGA DE LA VENTANA
        //}

        //private void btnParametros_Click(object sender, EventArgs e)
        //{
            //FormParametros parametros = new FormParametros();
            //parametros.Show();
        //}

        private void dueñosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDueño dueño = new FormDueño();
            dueño.MdiParent = this; //abre el formulario dentro del otro(una sola ventana)
            dueño.Show();
            this.dueñosToolStripMenuItem.Enabled = false;
            this.toolStripBtnDueños.Enabled = false;
            
            dueño.FormClosed += delegate //mensajes "haga esto cuando ocurra tal cosa"
            {
                this.dueñosToolStripMenuItem.Enabled = true;
                this.toolStripBtnDueños.Enabled = true;
            };

        }

        //Abriendo formulario de Atenci'on.
        private void atencionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAtencion atencion = new FormAtencion();
            atencion.MdiParent = this;
            atencion.Show();
            this.atencionesToolStripMenuItem.Enabled = false;
            this.toolStripAtencion.Enabled = false;
            atencion.FormClosed += delegate
            {
                this.atencionesToolStripMenuItem.Enabled = true;
                this.toolStripAtencion.Enabled = true;
            };

        }

        private void mascotaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            
            FormMascota mascota = new FormMascota();
            mascota.MdiParent = this; //abre el formulario dentro del otro(una sola ventana)
            mascota.Show();
            this.mascotaToolStripMenuItem.Enabled = false;
            this.toolStripBtnMascotas.Enabled = false;

            mascota.FormClosed += delegate
            {
                this.mascotaToolStripMenuItem.Enabled = true;
                this.toolStripBtnMascotas.Enabled = true;
            };  

        }

        private void mantencionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormParametros parametros = new FormParametros();
            parametros.MdiParent = this;
            parametros.Show();
           
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Deseas Salir?", "SALIR", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) //mensaje en pantalla
            {
                Application.Exit(); //cerrar la aplicacion
            }
        }
        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Deseas Salir?", "SALIR", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) //mensaje en pantalla
            {
                Application.Exit(); //cerrar la aplicacion
            }

        }
        private void acerdaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAcercaDe acercade = new FormAcercaDe();
            acercade.ShowDialog();

        }

        private void ayudaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            String Dir = System.IO.Path.GetDirectoryName(
                System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);
            //MessageBox.Show(Dir);
            String DirCompleta = System.IO.Path.Combine(Dir, "Ayuda.pdf");
            this.helpProvider1.HelpNamespace = DirCompleta.Remove(0, 6);

            
            Help.ShowHelp(this, this.helpProvider1.HelpNamespace);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.ShowBalloonTip(200);
        }

        private void veterinarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormVeterinarios veterinarios = new FormVeterinarios();
            veterinarios.MdiParent = this;
            veterinarios.Show();
            this.veterinarioToolStripMenuItem.Enabled = false;
            veterinarios.FormClosed += delegate
            {
                this.veterinarioToolStripMenuItem.Enabled = true;
            };
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();  /*cierra alicacion y no la deja tomada al cerrarla*/

        }

        private void toolStripSeparator3_Click(object sender, EventArgs e)
        {

        }


    }
}
