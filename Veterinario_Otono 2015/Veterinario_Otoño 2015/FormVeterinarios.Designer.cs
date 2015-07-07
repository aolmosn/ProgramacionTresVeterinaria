namespace Veterinario_Otoño_2015
{
    partial class FormVeterinarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVeterinarios));
            this.dataGridVeterinario = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtIdEspecialidad = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbEspecialidad = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtApellidoPaterno = new System.Windows.Forms.TextBox();
            this.txtApellidoMaterno = new System.Windows.Forms.TextBox();
            this.txtNombreVeterinario = new System.Windows.Forms.TextBox();
            this.txtRutVeterinario = new System.Windows.Forms.TextBox();
            this.txtIdVeterinario = new System.Windows.Forms.TextBox();
            this.btnIngresarFoto = new System.Windows.Forms.Button();
            this.errorProviderVeterinario = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureFotoVeterinario = new System.Windows.Forms.PictureBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVeterinario)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderVeterinario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFotoVeterinario)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridVeterinario
            // 
            this.dataGridVeterinario.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridVeterinario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridVeterinario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridVeterinario.Location = new System.Drawing.Point(12, 203);
            this.dataGridVeterinario.Name = "dataGridVeterinario";
            this.dataGridVeterinario.Size = new System.Drawing.Size(564, 226);
            this.dataGridVeterinario.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtIdEspecialidad);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.cmbEspecialidad);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.txtCelular);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtApellidoPaterno);
            this.panel1.Controls.Add(this.txtApellidoMaterno);
            this.panel1.Controls.Add(this.txtNombreVeterinario);
            this.panel1.Controls.Add(this.txtRutVeterinario);
            this.panel1.Controls.Add(this.txtIdVeterinario);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(564, 126);
            this.panel1.TabIndex = 12;
            // 
            // txtIdEspecialidad
            // 
            this.txtIdEspecialidad.Enabled = false;
            this.txtIdEspecialidad.Location = new System.Drawing.Point(513, 56);
            this.txtIdEspecialidad.Name = "txtIdEspecialidad";
            this.txtIdEspecialidad.Size = new System.Drawing.Size(25, 20);
            this.txtIdEspecialidad.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(383, 66);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "ESPECIALIDAD";
            // 
            // cmbEspecialidad
            // 
            this.cmbEspecialidad.FormattingEnabled = true;
            this.cmbEspecialidad.Items.AddRange(new object[] {
            "Anestecista",
            "Cirujano",
            "Medico"});
            this.cmbEspecialidad.Location = new System.Drawing.Point(386, 82);
            this.cmbEspecialidad.Name = "cmbEspecialidad";
            this.cmbEspecialidad.Size = new System.Drawing.Size(152, 21);
            this.cmbEspecialidad.Sorted = true;
            this.cmbEspecialidad.TabIndex = 7;
            this.cmbEspecialidad.Text = "<<Elegir>>";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(118, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "E-MAIL";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "CELULAR";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(130, 82);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(241, 20);
            this.txtEmail.TabIndex = 6;
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(11, 82);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(104, 20);
            this.txtCelular.TabIndex = 5;
            this.txtCelular.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCelular_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(404, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "APELLIDO MATERNO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(265, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "APELLIDO PATERNO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(127, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "NOMBRE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "RUT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "ID";
            // 
            // txtApellidoPaterno
            // 
            this.txtApellidoPaterno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtApellidoPaterno.Location = new System.Drawing.Point(280, 25);
            this.txtApellidoPaterno.Name = "txtApellidoPaterno";
            this.txtApellidoPaterno.Size = new System.Drawing.Size(112, 20);
            this.txtApellidoPaterno.TabIndex = 3;
            this.txtApellidoPaterno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreVeterinario_KeyPress);
            // 
            // txtApellidoMaterno
            // 
            this.txtApellidoMaterno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtApellidoMaterno.Location = new System.Drawing.Point(407, 25);
            this.txtApellidoMaterno.Name = "txtApellidoMaterno";
            this.txtApellidoMaterno.Size = new System.Drawing.Size(131, 20);
            this.txtApellidoMaterno.TabIndex = 4;
            this.txtApellidoMaterno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreVeterinario_KeyPress);
            // 
            // txtNombreVeterinario
            // 
            this.txtNombreVeterinario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombreVeterinario.Location = new System.Drawing.Point(148, 25);
            this.txtNombreVeterinario.Name = "txtNombreVeterinario";
            this.txtNombreVeterinario.Size = new System.Drawing.Size(114, 20);
            this.txtNombreVeterinario.TabIndex = 2;
            this.txtNombreVeterinario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreVeterinario_KeyPress);
            // 
            // txtRutVeterinario
            // 
            this.txtRutVeterinario.Location = new System.Drawing.Point(34, 25);
            this.txtRutVeterinario.Name = "txtRutVeterinario";
            this.txtRutVeterinario.Size = new System.Drawing.Size(90, 20);
            this.txtRutVeterinario.TabIndex = 1;
            this.txtRutVeterinario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRutVeterinario_KeyPress);
            // 
            // txtIdVeterinario
            // 
            this.txtIdVeterinario.Enabled = false;
            this.txtIdVeterinario.Location = new System.Drawing.Point(9, 25);
            this.txtIdVeterinario.Name = "txtIdVeterinario";
            this.txtIdVeterinario.Size = new System.Drawing.Size(19, 20);
            this.txtIdVeterinario.TabIndex = 0;
            // 
            // btnIngresarFoto
            // 
            this.btnIngresarFoto.Image = global::Veterinario_Otoño_2015.Properties.Resources.camera31;
            this.btnIngresarFoto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIngresarFoto.Location = new System.Drawing.Point(625, 251);
            this.btnIngresarFoto.Name = "btnIngresarFoto";
            this.btnIngresarFoto.Size = new System.Drawing.Size(188, 39);
            this.btnIngresarFoto.TabIndex = 30;
            this.btnIngresarFoto.Text = "Ingresar Foto Veterinario";
            this.btnIngresarFoto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIngresarFoto.UseVisualStyleBackColor = true;
            // 
            // errorProviderVeterinario
            // 
            this.errorProviderVeterinario.ContainerControl = this;
            // 
            // pictureFotoVeterinario
            // 
            this.pictureFotoVeterinario.BackgroundImage = global::Veterinario_Otoño_2015.Properties.Resources.users811;
            this.pictureFotoVeterinario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureFotoVeterinario.Location = new System.Drawing.Point(609, 12);
            this.pictureFotoVeterinario.Name = "pictureFotoVeterinario";
            this.pictureFotoVeterinario.Size = new System.Drawing.Size(262, 227);
            this.pictureFotoVeterinario.TabIndex = 15;
            this.pictureFotoVeterinario.TabStop = false;
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.SystemColors.Control;
            this.btnIngresar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnIngresar.Image = ((System.Drawing.Image)(resources.GetObject("btnIngresar.Image")));
            this.btnIngresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIngresar.Location = new System.Drawing.Point(12, 144);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(116, 37);
            this.btnIngresar.TabIndex = 11;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.SystemColors.Control;
            this.btnModificar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnModificar.Image = global::Veterinario_Otoño_2015.Properties.Resources.shuffle11;
            this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificar.Location = new System.Drawing.Point(231, 144);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(116, 37);
            this.btnModificar.TabIndex = 10;
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
            this.btnEliminar.Location = new System.Drawing.Point(450, 144);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(126, 37);
            this.btnEliminar.TabIndex = 9;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnVolver.Image = global::Veterinario_Otoño_2015.Properties.Resources.right;
            this.btnVolver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVolver.Location = new System.Drawing.Point(609, 392);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(116, 37);
            this.btnVolver.TabIndex = 8;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // FormVeterinarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 443);
            this.Controls.Add(this.btnIngresarFoto);
            this.Controls.Add(this.pictureFotoVeterinario);
            this.Controls.Add(this.dataGridVeterinario);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnVolver);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormVeterinarios";
            this.Text = "Mantenedor Medicos Veterinarios";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormVeterinarios_FormClosed);
            this.Load += new System.EventHandler(this.FormVeterinarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVeterinario)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderVeterinario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFotoVeterinario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridVeterinario;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtIdEspecialidad;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbEspecialidad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRutVeterinario;
        private System.Windows.Forms.TextBox txtIdVeterinario;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.PictureBox pictureFotoVeterinario;
        private System.Windows.Forms.Button btnIngresarFoto;
        private System.Windows.Forms.ErrorProvider errorProviderVeterinario;
        public System.Windows.Forms.TextBox txtApellidoPaterno;
        public System.Windows.Forms.TextBox txtApellidoMaterno;
        public System.Windows.Forms.TextBox txtNombreVeterinario;
    }
}