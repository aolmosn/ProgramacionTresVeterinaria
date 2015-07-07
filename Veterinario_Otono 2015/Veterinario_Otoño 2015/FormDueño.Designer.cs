namespace Veterinario_Otoño_2015
{
    partial class FormDueño
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDueño));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtIdCiudad = new System.Windows.Forms.TextBox();
            this.txtIdComuna = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtRegion = new System.Windows.Forms.TextBox();
            this.txtCiudad = new System.Windows.Forms.TextBox();
            this.txtCalleNumero = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbComuna = new System.Windows.Forms.ComboBox();
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtRut = new System.Windows.Forms.TextBox();
            this.txtIdDueño = new System.Windows.Forms.TextBox();
            this.dataGridDueños = new System.Windows.Forms.DataGridView();
            this.errorProviderDueño = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnIngresarMascota = new System.Windows.Forms.Button();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDueños)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDueño)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtIdCiudad);
            this.panel1.Controls.Add(this.txtIdComuna);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtRegion);
            this.panel1.Controls.Add(this.txtCiudad);
            this.panel1.Controls.Add(this.txtCalleNumero);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.cmbComuna);
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
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.txtRut);
            this.panel1.Controls.Add(this.txtIdDueño);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(564, 172);
            this.panel1.TabIndex = 5;
            // 
            // txtIdCiudad
            // 
            this.txtIdCiudad.Enabled = false;
            this.txtIdCiudad.Location = new System.Drawing.Point(465, 109);
            this.txtIdCiudad.Name = "txtIdCiudad";
            this.txtIdCiudad.Size = new System.Drawing.Size(24, 20);
            this.txtIdCiudad.TabIndex = 25;
            this.txtIdCiudad.TextChanged += new System.EventHandler(this.txtIdCiudad_TextChanged);
            // 
            // txtIdComuna
            // 
            this.txtIdComuna.Enabled = false;
            this.txtIdComuna.Location = new System.Drawing.Point(513, 56);
            this.txtIdComuna.Name = "txtIdComuna";
            this.txtIdComuna.Size = new System.Drawing.Size(25, 20);
            this.txtIdComuna.TabIndex = 24;
            this.txtIdComuna.TextChanged += new System.EventHandler(this.txtIdComuna_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(495, 119);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "REGION";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(323, 119);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "CIUDAD";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 119);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "CALLE Y NUMERO";
            // 
            // txtRegion
            // 
            this.txtRegion.Enabled = false;
            this.txtRegion.Location = new System.Drawing.Point(497, 135);
            this.txtRegion.Name = "txtRegion";
            this.txtRegion.Size = new System.Drawing.Size(47, 20);
            this.txtRegion.TabIndex = 20;
            // 
            // txtCiudad
            // 
            this.txtCiudad.Enabled = false;
            this.txtCiudad.Location = new System.Drawing.Point(326, 135);
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Size = new System.Drawing.Size(165, 20);
            this.txtCiudad.TabIndex = 10;
            // 
            // txtCalleNumero
            // 
            this.txtCalleNumero.Location = new System.Drawing.Point(9, 135);
            this.txtCalleNumero.Name = "txtCalleNumero";
            this.txtCalleNumero.Size = new System.Drawing.Size(299, 20);
            this.txtCalleNumero.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(383, 66);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "COMUNA";
            // 
            // cmbComuna
            // 
            this.cmbComuna.FormattingEnabled = true;
            this.cmbComuna.Items.AddRange(new object[] {
            "La Dehesa",
            "Lo Barnechea",
            "Macul",
            "Puente Alto",
            "Quinta Normal",
            "Qulicura",
            "Santiago Centro",
            "Vitacura"});
            this.cmbComuna.Location = new System.Drawing.Point(386, 82);
            this.cmbComuna.Name = "cmbComuna";
            this.cmbComuna.Size = new System.Drawing.Size(152, 21);
            this.cmbComuna.Sorted = true;
            this.cmbComuna.TabIndex = 7;
            this.cmbComuna.Text = "<<Elegir>>";
            this.cmbComuna.SelectedIndexChanged += new System.EventHandler(this.cmbComuna_SelectedIndexChanged);
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
            this.txtApellidoPaterno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // txtApellidoMaterno
            // 
            this.txtApellidoMaterno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtApellidoMaterno.Location = new System.Drawing.Point(407, 25);
            this.txtApellidoMaterno.Name = "txtApellidoMaterno";
            this.txtApellidoMaterno.Size = new System.Drawing.Size(131, 20);
            this.txtApellidoMaterno.TabIndex = 4;
            this.txtApellidoMaterno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // txtNombre
            // 
            this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombre.Location = new System.Drawing.Point(143, 25);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(119, 20);
            this.txtNombre.TabIndex = 2;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // txtRut
            // 
            this.txtRut.Location = new System.Drawing.Point(34, 25);
            this.txtRut.Name = "txtRut";
            this.txtRut.Size = new System.Drawing.Size(90, 20);
            this.txtRut.TabIndex = 1;
            this.txtRut.TextChanged += new System.EventHandler(this.txtRut_TextChanged);
            this.txtRut.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRut_KeyPress);
            // 
            // txtIdDueño
            // 
            this.txtIdDueño.Enabled = false;
            this.txtIdDueño.Location = new System.Drawing.Point(9, 25);
            this.txtIdDueño.Name = "txtIdDueño";
            this.txtIdDueño.Size = new System.Drawing.Size(19, 20);
            this.txtIdDueño.TabIndex = 0;
            // 
            // dataGridDueños
            // 
            this.dataGridDueños.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridDueños.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridDueños.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDueños.Location = new System.Drawing.Point(12, 251);
            this.dataGridDueños.Name = "dataGridDueños";
            this.dataGridDueños.Size = new System.Drawing.Size(564, 178);
            this.dataGridDueños.TabIndex = 7;
            // 
            // errorProviderDueño
            // 
            this.errorProviderDueño.BlinkRate = 500;
            this.errorProviderDueño.ContainerControl = this;
            // 
            // btnIngresarMascota
            // 
            this.btnIngresarMascota.BackColor = System.Drawing.SystemColors.Control;
            this.btnIngresarMascota.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnIngresarMascota.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnIngresarMascota.Image = global::Veterinario_Otoño_2015.Properties.Resources.entering1;
            this.btnIngresarMascota.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIngresarMascota.Location = new System.Drawing.Point(154, 202);
            this.btnIngresarMascota.Name = "btnIngresarMascota";
            this.btnIngresarMascota.Size = new System.Drawing.Size(126, 37);
            this.btnIngresarMascota.TabIndex = 6;
            this.btnIngresarMascota.Text = "Ingresar Mascota";
            this.btnIngresarMascota.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIngresarMascota.UseVisualStyleBackColor = false;
            this.btnIngresarMascota.Click += new System.EventHandler(this.btnIngresarMascota_Click);
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.SystemColors.Control;
            this.btnIngresar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnIngresar.Image = global::Veterinario_Otoño_2015.Properties.Resources.users81;
            this.btnIngresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIngresar.Location = new System.Drawing.Point(12, 202);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(116, 37);
            this.btnIngresar.TabIndex = 4;
            this.btnIngresar.Text = "Ingresar Dueño";
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
            this.btnModificar.Location = new System.Drawing.Point(306, 202);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(116, 37);
            this.btnModificar.TabIndex = 3;
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
            this.btnEliminar.Location = new System.Drawing.Point(448, 202);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(126, 37);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnVolver.Image = global::Veterinario_Otoño_2015.Properties.Resources.right;
            this.btnVolver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVolver.Location = new System.Drawing.Point(441, 452);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(116, 37);
            this.btnVolver.TabIndex = 1;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // FormDueño
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 520);
            this.Controls.Add(this.dataGridDueños);
            this.Controls.Add(this.btnIngresarMascota);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnVolver);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormDueño";
            this.Text = "Formulario del Dueño";
            this.Load += new System.EventHandler(this.FormDueño_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDueños)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDueño)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtApellidoPaterno;
        private System.Windows.Forms.TextBox txtApellidoMaterno;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtRut;
        private System.Windows.Forms.TextBox txtIdDueño;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtRegion;
        private System.Windows.Forms.TextBox txtCiudad;
        private System.Windows.Forms.TextBox txtCalleNumero;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbComuna;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdCiudad;
        private System.Windows.Forms.TextBox txtIdComuna;
        private System.Windows.Forms.Button btnIngresarMascota;
        private System.Windows.Forms.DataGridView dataGridDueños;
        private System.Windows.Forms.ErrorProvider errorProviderDueño;
    }
}