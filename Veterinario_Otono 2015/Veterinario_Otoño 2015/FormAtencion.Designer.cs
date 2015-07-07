namespace Veterinario_Otoño_2015
{
    partial class FormAtencion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAtencion));
            this.txtNombreveterinarioAtencion = new System.Windows.Forms.TextBox();
            this.btnBuscarVeterinario = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpFechaAtencion = new System.Windows.Forms.DateTimePicker();
            this.txtIDAtencion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rhtDiagnostico = new System.Windows.Forms.RichTextBox();
            this.rhtReceta = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dtgHistorial = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtAtencionRaza = new System.Windows.Forms.TextBox();
            this.txtAtencionEsp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAtencionApeMat = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdMascota = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAtencionApePat = new System.Windows.Forms.TextBox();
            this.txtAtencionNombreD = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAtencionNombreM = new System.Windows.Forms.TextBox();
            this.txtIdVeterinario = new System.Windows.Forms.TextBox();
            this.ErrorProviderAtencion = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnAtencion = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.formatoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fuenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dtgHistorial)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProviderAtencion)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNombreveterinarioAtencion
            // 
            this.txtNombreveterinarioAtencion.Location = new System.Drawing.Point(161, 144);
            this.txtNombreveterinarioAtencion.Name = "txtNombreveterinarioAtencion";
            this.txtNombreveterinarioAtencion.Size = new System.Drawing.Size(220, 20);
            this.txtNombreveterinarioAtencion.TabIndex = 55;
            // 
            // btnBuscarVeterinario
            // 
            this.btnBuscarVeterinario.Location = new System.Drawing.Point(122, 142);
            this.btnBuscarVeterinario.Name = "btnBuscarVeterinario";
            this.btnBuscarVeterinario.Size = new System.Drawing.Size(31, 23);
            this.btnBuscarVeterinario.TabIndex = 56;
            this.btnBuscarVeterinario.Text = ". . .";
            this.btnBuscarVeterinario.UseVisualStyleBackColor = true;
            this.btnBuscarVeterinario.Click += new System.EventHandler(this.btnBuscarVeterinario_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 57;
            this.label4.Text = "Buscar Veterinario";
            // 
            // dtpFechaAtencion
            // 
            this.dtpFechaAtencion.Location = new System.Drawing.Point(396, 144);
            this.dtpFechaAtencion.Name = "dtpFechaAtencion";
            this.dtpFechaAtencion.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaAtencion.TabIndex = 58;
            // 
            // txtIDAtencion
            // 
            this.txtIDAtencion.Location = new System.Drawing.Point(12, 170);
            this.txtIDAtencion.Name = "txtIDAtencion";
            this.txtIDAtencion.Size = new System.Drawing.Size(42, 20);
            this.txtIDAtencion.TabIndex = 59;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 60;
            this.label5.Text = "Diagnóstico";
            // 
            // rhtDiagnostico
            // 
            this.rhtDiagnostico.Location = new System.Drawing.Point(21, 223);
            this.rhtDiagnostico.Name = "rhtDiagnostico";
            this.rhtDiagnostico.Size = new System.Drawing.Size(570, 96);
            this.rhtDiagnostico.TabIndex = 63;
            this.rhtDiagnostico.Text = "";
            // 
            // rhtReceta
            // 
            this.rhtReceta.Location = new System.Drawing.Point(21, 347);
            this.rhtReceta.Name = "rhtReceta";
            this.rhtReceta.Size = new System.Drawing.Size(570, 96);
            this.rhtReceta.TabIndex = 65;
            this.rhtReceta.Text = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 331);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 64;
            this.label9.Text = "Receta";
            // 
            // dtgHistorial
            // 
            this.dtgHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgHistorial.Location = new System.Drawing.Point(662, 50);
            this.dtgHistorial.Name = "dtgHistorial";
            this.dtgHistorial.Size = new System.Drawing.Size(276, 269);
            this.dtgHistorial.TabIndex = 68;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(659, 34);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 13);
            this.label10.TabIndex = 69;
            this.label10.Text = "Atenciones Históricas";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txtAtencionRaza);
            this.panel1.Controls.Add(this.txtAtencionEsp);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtAtencionApeMat);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtIdMascota);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtAtencionApePat);
            this.panel1.Controls.Add(this.txtAtencionNombreD);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtAtencionNombreM);
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(638, 119);
            this.panel1.TabIndex = 0;
            // 
            // txtAtencionRaza
            // 
            this.txtAtencionRaza.Location = new System.Drawing.Point(451, 32);
            this.txtAtencionRaza.Name = "txtAtencionRaza";
            this.txtAtencionRaza.Size = new System.Drawing.Size(136, 20);
            this.txtAtencionRaza.TabIndex = 3;
            // 
            // txtAtencionEsp
            // 
            this.txtAtencionEsp.Location = new System.Drawing.Point(275, 32);
            this.txtAtencionEsp.Name = "txtAtencionEsp";
            this.txtAtencionEsp.Size = new System.Drawing.Size(136, 20);
            this.txtAtencionEsp.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(403, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 82;
            this.label2.Text = "Apellido Materno";
            // 
            // txtAtencionApeMat
            // 
            this.txtAtencionApeMat.Location = new System.Drawing.Point(403, 89);
            this.txtAtencionApeMat.Name = "txtAtencionApeMat";
            this.txtAtencionApeMat.Size = new System.Drawing.Size(208, 20);
            this.txtAtencionApeMat.TabIndex = 81;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(272, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 80;
            this.label1.Text = "Especie";
            // 
            // txtIdMascota
            // 
            this.txtIdMascota.Location = new System.Drawing.Point(225, 9);
            this.txtIdMascota.Name = "txtIdMascota";
            this.txtIdMascota.Size = new System.Drawing.Size(42, 20);
            this.txtIdMascota.TabIndex = 79;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(448, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 78;
            this.label8.Text = "Raza";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(183, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 13);
            this.label7.TabIndex = 77;
            this.label7.Text = "Apellido Paterno";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 13);
            this.label6.TabIndex = 76;
            this.label6.Text = "Nombre del Dueño";
            // 
            // txtAtencionApePat
            // 
            this.txtAtencionApePat.Location = new System.Drawing.Point(183, 89);
            this.txtAtencionApePat.Name = "txtAtencionApePat";
            this.txtAtencionApePat.Size = new System.Drawing.Size(208, 20);
            this.txtAtencionApePat.TabIndex = 75;
            // 
            // txtAtencionNombreD
            // 
            this.txtAtencionNombreD.Location = new System.Drawing.Point(31, 89);
            this.txtAtencionNombreD.Name = "txtAtencionNombreD";
            this.txtAtencionNombreD.Size = new System.Drawing.Size(146, 20);
            this.txtAtencionNombreD.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 13);
            this.label3.TabIndex = 73;
            this.label3.Text = "Nombre de la Mascota";
            // 
            // txtAtencionNombreM
            // 
            this.txtAtencionNombreM.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAtencionNombreM.Location = new System.Drawing.Point(31, 32);
            this.txtAtencionNombreM.Name = "txtAtencionNombreM";
            this.txtAtencionNombreM.Size = new System.Drawing.Size(236, 20);
            this.txtAtencionNombreM.TabIndex = 1;
            // 
            // txtIdVeterinario
            // 
            this.txtIdVeterinario.Location = new System.Drawing.Point(339, 170);
            this.txtIdVeterinario.Name = "txtIdVeterinario";
            this.txtIdVeterinario.Size = new System.Drawing.Size(42, 20);
            this.txtIdVeterinario.TabIndex = 71;
            this.txtIdVeterinario.Visible = false;
            // 
            // ErrorProviderAtencion
            // 
            this.ErrorProviderAtencion.ContainerControl = this;
            // 
            // btnVolver
            // 
            this.btnVolver.Image = global::Veterinario_Otoño_2015.Properties.Resources.back57;
            this.btnVolver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVolver.Location = new System.Drawing.Point(506, 449);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(85, 44);
            this.btnVolver.TabIndex = 67;
            this.btnVolver.Text = "Volver";
            this.btnVolver.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnAtencion
            // 
            this.btnAtencion.Image = global::Veterinario_Otoño_2015.Properties.Resources.configure1;
            this.btnAtencion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAtencion.Location = new System.Drawing.Point(21, 458);
            this.btnAtencion.Name = "btnAtencion";
            this.btnAtencion.Size = new System.Drawing.Size(132, 37);
            this.btnAtencion.TabIndex = 66;
            this.btnAtencion.Text = "Ingresar atención";
            this.btnAtencion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAtencion.UseVisualStyleBackColor = true;
            this.btnAtencion.Click += new System.EventHandler(this.btnAtencion_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.SystemColors.Control;
            this.btnModificar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnModificar.Image = global::Veterinario_Otoño_2015.Properties.Resources.shuffle11;
            this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificar.Location = new System.Drawing.Point(165, 458);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(116, 37);
            this.btnModificar.TabIndex = 73;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.SystemColors.Control;
            this.btnEliminar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnEliminar.Image = global::Veterinario_Otoño_2015.Properties.Resources.delete97;
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(287, 458);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(116, 37);
            this.btnEliminar.TabIndex = 72;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formatoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(953, 24);
            this.menuStrip1.TabIndex = 74;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // formatoToolStripMenuItem
            // 
            this.formatoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorToolStripMenuItem,
            this.fuenteToolStripMenuItem});
            this.formatoToolStripMenuItem.Name = "formatoToolStripMenuItem";
            this.formatoToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.formatoToolStripMenuItem.Text = "Formato";
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.colorToolStripMenuItem.Text = "Color";
            this.colorToolStripMenuItem.Click += new System.EventHandler(this.colorToolStripMenuItem_Click);
            // 
            // fuenteToolStripMenuItem
            // 
            this.fuenteToolStripMenuItem.Name = "fuenteToolStripMenuItem";
            this.fuenteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.fuenteToolStripMenuItem.Text = "Fuente";
            this.fuenteToolStripMenuItem.Click += new System.EventHandler(this.fuenteToolStripMenuItem_Click);
            // 
            // FormAtencion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 505);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.txtIdVeterinario);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dtgHistorial);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnAtencion);
            this.Controls.Add(this.rhtReceta);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.rhtDiagnostico);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtIDAtencion);
            this.Controls.Add(this.dtpFechaAtencion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnBuscarVeterinario);
            this.Controls.Add(this.txtNombreveterinarioAtencion);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormAtencion";
            this.Text = "Formulario de Atención";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormAtencion_FormClosed);
            this.Load += new System.EventHandler(this.FormAtencion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgHistorial)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProviderAtencion)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscarVeterinario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpFechaAtencion;
        private System.Windows.Forms.TextBox txtIDAtencion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox rhtDiagnostico;
        private System.Windows.Forms.RichTextBox rhtReceta;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnAtencion;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.DataGridView dtgHistorial;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdMascota;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIdVeterinario;
        private System.Windows.Forms.ErrorProvider ErrorProviderAtencion;
        public System.Windows.Forms.TextBox txtNombreveterinarioAtencion;
        public System.Windows.Forms.TextBox txtAtencionRaza;
        public System.Windows.Forms.TextBox txtAtencionEsp;
        public System.Windows.Forms.TextBox txtAtencionNombreM;
        public System.Windows.Forms.TextBox txtAtencionApeMat;
        public System.Windows.Forms.TextBox txtAtencionApePat;
        public System.Windows.Forms.TextBox txtAtencionNombreD;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem formatoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fuenteToolStripMenuItem;
    }
}