namespace Veterinario_Otoño_2015
{
    partial class FormParametros
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageEspecies = new System.Windows.Forms.TabPage();
            this.btnIngresarEspecie = new System.Windows.Forms.Button();
            this.btnModificarEspecies = new System.Windows.Forms.Button();
            this.btnEliminarEspecies = new System.Windows.Forms.Button();
            this.dataGridEspecies = new System.Windows.Forms.DataGridView();
            this.txtDescripcionEspecie = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodigoEspecie = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageRazas = new System.Windows.Forms.TabPage();
            this.txtCodigoEspecie_Raza = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbEspecie = new System.Windows.Forms.ComboBox();
            this.dataGridRazas = new System.Windows.Forms.DataGridView();
            this.txtDescripcionRaza = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCodigoRaza = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnIngresarRaza = new System.Windows.Forms.Button();
            this.btnModificarRaza = new System.Windows.Forms.Button();
            this.btnEliminarRaza = new System.Windows.Forms.Button();
            this.tabPageColores = new System.Windows.Forms.TabPage();
            this.dataGridColor = new System.Windows.Forms.DataGridView();
            this.btnIngresarColor = new System.Windows.Forms.Button();
            this.btnModificarColor = new System.Windows.Forms.Button();
            this.btnEliminarColor = new System.Windows.Forms.Button();
            this.btnBuscarColor = new System.Windows.Forms.Button();
            this.pictureColor = new System.Windows.Forms.PictureBox();
            this.txtRojo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtVerde = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAzul = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDescripcionColor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCodigoColor = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPageEspecies.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEspecies)).BeginInit();
            this.tabPageRazas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRazas)).BeginInit();
            this.tabPageColores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureColor)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageEspecies);
            this.tabControl1.Controls.Add(this.tabPageRazas);
            this.tabControl1.Controls.Add(this.tabPageColores);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(933, 539);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageEspecies
            // 
            this.tabPageEspecies.Controls.Add(this.btnIngresarEspecie);
            this.tabPageEspecies.Controls.Add(this.btnModificarEspecies);
            this.tabPageEspecies.Controls.Add(this.btnEliminarEspecies);
            this.tabPageEspecies.Controls.Add(this.dataGridEspecies);
            this.tabPageEspecies.Controls.Add(this.txtDescripcionEspecie);
            this.tabPageEspecies.Controls.Add(this.label2);
            this.tabPageEspecies.Controls.Add(this.txtCodigoEspecie);
            this.tabPageEspecies.Controls.Add(this.label1);
            this.tabPageEspecies.Location = new System.Drawing.Point(4, 22);
            this.tabPageEspecies.Name = "tabPageEspecies";
            this.tabPageEspecies.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEspecies.Size = new System.Drawing.Size(925, 513);
            this.tabPageEspecies.TabIndex = 0;
            this.tabPageEspecies.Text = "Especies";
            this.tabPageEspecies.UseVisualStyleBackColor = true;
            // 
            // btnIngresarEspecie
            // 
            this.btnIngresarEspecie.BackColor = System.Drawing.SystemColors.Control;
            this.btnIngresarEspecie.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnIngresarEspecie.Image = global::Veterinario_Otoño_2015.Properties.Resources.entering1;
            this.btnIngresarEspecie.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIngresarEspecie.Location = new System.Drawing.Point(39, 415);
            this.btnIngresarEspecie.Name = "btnIngresarEspecie";
            this.btnIngresarEspecie.Size = new System.Drawing.Size(116, 37);
            this.btnIngresarEspecie.TabIndex = 36;
            this.btnIngresarEspecie.Text = "Ingresar";
            this.btnIngresarEspecie.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIngresarEspecie.UseVisualStyleBackColor = false;
            this.btnIngresarEspecie.Click += new System.EventHandler(this.btnIngresarEspecie_Click);
            // 
            // btnModificarEspecies
            // 
            this.btnModificarEspecies.BackColor = System.Drawing.SystemColors.Control;
            this.btnModificarEspecies.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnModificarEspecies.Image = global::Veterinario_Otoño_2015.Properties.Resources.shuffle11;
            this.btnModificarEspecies.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificarEspecies.Location = new System.Drawing.Point(269, 415);
            this.btnModificarEspecies.Name = "btnModificarEspecies";
            this.btnModificarEspecies.Size = new System.Drawing.Size(116, 37);
            this.btnModificarEspecies.TabIndex = 35;
            this.btnModificarEspecies.Text = "Modificar";
            this.btnModificarEspecies.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificarEspecies.UseVisualStyleBackColor = false;
            this.btnModificarEspecies.Click += new System.EventHandler(this.btnModificarEspecies_Click);
            // 
            // btnEliminarEspecies
            // 
            this.btnEliminarEspecies.BackColor = System.Drawing.SystemColors.Control;
            this.btnEliminarEspecies.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnEliminarEspecies.Image = global::Veterinario_Otoño_2015.Properties.Resources.delete97;
            this.btnEliminarEspecies.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarEspecies.Location = new System.Drawing.Point(462, 415);
            this.btnEliminarEspecies.Name = "btnEliminarEspecies";
            this.btnEliminarEspecies.Size = new System.Drawing.Size(126, 37);
            this.btnEliminarEspecies.TabIndex = 34;
            this.btnEliminarEspecies.Text = "Eliminar";
            this.btnEliminarEspecies.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminarEspecies.UseVisualStyleBackColor = false;
            this.btnEliminarEspecies.Click += new System.EventHandler(this.btnEliminarEspecies_Click);
            // 
            // dataGridEspecies
            // 
            this.dataGridEspecies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridEspecies.Location = new System.Drawing.Point(269, 15);
            this.dataGridEspecies.Name = "dataGridEspecies";
            this.dataGridEspecies.Size = new System.Drawing.Size(319, 370);
            this.dataGridEspecies.TabIndex = 4;
            this.dataGridEspecies.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridEspecies_CellEnter);
            // 
            // txtDescripcionEspecie
            // 
            this.txtDescripcionEspecie.Location = new System.Drawing.Point(39, 114);
            this.txtDescripcionEspecie.Name = "txtDescripcionEspecie";
            this.txtDescripcionEspecie.Size = new System.Drawing.Size(203, 20);
            this.txtDescripcionEspecie.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descripcion";
            // 
            // txtCodigoEspecie
            // 
            this.txtCodigoEspecie.Location = new System.Drawing.Point(39, 52);
            this.txtCodigoEspecie.Name = "txtCodigoEspecie";
            this.txtCodigoEspecie.Size = new System.Drawing.Size(32, 20);
            this.txtCodigoEspecie.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo";
            // 
            // tabPageRazas
            // 
            this.tabPageRazas.Controls.Add(this.txtCodigoEspecie_Raza);
            this.tabPageRazas.Controls.Add(this.label5);
            this.tabPageRazas.Controls.Add(this.cmbEspecie);
            this.tabPageRazas.Controls.Add(this.dataGridRazas);
            this.tabPageRazas.Controls.Add(this.txtDescripcionRaza);
            this.tabPageRazas.Controls.Add(this.label3);
            this.tabPageRazas.Controls.Add(this.txtCodigoRaza);
            this.tabPageRazas.Controls.Add(this.label4);
            this.tabPageRazas.Controls.Add(this.btnIngresarRaza);
            this.tabPageRazas.Controls.Add(this.btnModificarRaza);
            this.tabPageRazas.Controls.Add(this.btnEliminarRaza);
            this.tabPageRazas.Location = new System.Drawing.Point(4, 22);
            this.tabPageRazas.Name = "tabPageRazas";
            this.tabPageRazas.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRazas.Size = new System.Drawing.Size(925, 513);
            this.tabPageRazas.TabIndex = 1;
            this.tabPageRazas.Text = "Razas";
            this.tabPageRazas.UseVisualStyleBackColor = true;
            // 
            // txtCodigoEspecie_Raza
            // 
            this.txtCodigoEspecie_Raza.Location = new System.Drawing.Point(211, 46);
            this.txtCodigoEspecie_Raza.Name = "txtCodigoEspecie_Raza";
            this.txtCodigoEspecie_Raza.Size = new System.Drawing.Size(27, 20);
            this.txtCodigoEspecie_Raza.TabIndex = 47;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(208, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 46;
            this.label5.Text = "Codigo";
            // 
            // cmbEspecie
            // 
            this.cmbEspecie.FormattingEnabled = true;
            this.cmbEspecie.Location = new System.Drawing.Point(35, 81);
            this.cmbEspecie.Name = "cmbEspecie";
            this.cmbEspecie.Size = new System.Drawing.Size(203, 21);
            this.cmbEspecie.TabIndex = 45;
            this.cmbEspecie.SelectedIndexChanged += new System.EventHandler(this.cmbEspecie_SelectedIndexChanged);
            // 
            // dataGridRazas
            // 
            this.dataGridRazas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridRazas.Location = new System.Drawing.Point(265, 17);
            this.dataGridRazas.Name = "dataGridRazas";
            this.dataGridRazas.Size = new System.Drawing.Size(319, 370);
            this.dataGridRazas.TabIndex = 41;
            // 
            // txtDescripcionRaza
            // 
            this.txtDescripcionRaza.Location = new System.Drawing.Point(35, 215);
            this.txtDescripcionRaza.Name = "txtDescripcionRaza";
            this.txtDescripcionRaza.Size = new System.Drawing.Size(203, 20);
            this.txtDescripcionRaza.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "Descripcion";
            // 
            // txtCodigoRaza
            // 
            this.txtCodigoRaza.Location = new System.Drawing.Point(35, 146);
            this.txtCodigoRaza.Name = "txtCodigoRaza";
            this.txtCodigoRaza.Size = new System.Drawing.Size(32, 20);
            this.txtCodigoRaza.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "Codigo";
            // 
            // btnIngresarRaza
            // 
            this.btnIngresarRaza.BackColor = System.Drawing.SystemColors.Control;
            this.btnIngresarRaza.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnIngresarRaza.Image = global::Veterinario_Otoño_2015.Properties.Resources.entering1;
            this.btnIngresarRaza.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIngresarRaza.Location = new System.Drawing.Point(35, 417);
            this.btnIngresarRaza.Name = "btnIngresarRaza";
            this.btnIngresarRaza.Size = new System.Drawing.Size(116, 37);
            this.btnIngresarRaza.TabIndex = 44;
            this.btnIngresarRaza.Text = "Ingresar";
            this.btnIngresarRaza.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIngresarRaza.UseVisualStyleBackColor = false;
            // 
            // btnModificarRaza
            // 
            this.btnModificarRaza.BackColor = System.Drawing.SystemColors.Control;
            this.btnModificarRaza.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnModificarRaza.Image = global::Veterinario_Otoño_2015.Properties.Resources.shuffle11;
            this.btnModificarRaza.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificarRaza.Location = new System.Drawing.Point(246, 417);
            this.btnModificarRaza.Name = "btnModificarRaza";
            this.btnModificarRaza.Size = new System.Drawing.Size(116, 37);
            this.btnModificarRaza.TabIndex = 43;
            this.btnModificarRaza.Text = "Modificar";
            this.btnModificarRaza.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificarRaza.UseVisualStyleBackColor = false;
            // 
            // btnEliminarRaza
            // 
            this.btnEliminarRaza.BackColor = System.Drawing.SystemColors.Control;
            this.btnEliminarRaza.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnEliminarRaza.Image = global::Veterinario_Otoño_2015.Properties.Resources.delete97;
            this.btnEliminarRaza.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarRaza.Location = new System.Drawing.Point(457, 417);
            this.btnEliminarRaza.Name = "btnEliminarRaza";
            this.btnEliminarRaza.Size = new System.Drawing.Size(126, 37);
            this.btnEliminarRaza.TabIndex = 42;
            this.btnEliminarRaza.Text = "Eliminar";
            this.btnEliminarRaza.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminarRaza.UseVisualStyleBackColor = false;
            // 
            // tabPageColores
            // 
            this.tabPageColores.Controls.Add(this.dataGridColor);
            this.tabPageColores.Controls.Add(this.btnIngresarColor);
            this.tabPageColores.Controls.Add(this.btnModificarColor);
            this.tabPageColores.Controls.Add(this.btnEliminarColor);
            this.tabPageColores.Controls.Add(this.btnBuscarColor);
            this.tabPageColores.Controls.Add(this.pictureColor);
            this.tabPageColores.Controls.Add(this.txtRojo);
            this.tabPageColores.Controls.Add(this.label10);
            this.tabPageColores.Controls.Add(this.txtVerde);
            this.tabPageColores.Controls.Add(this.label9);
            this.tabPageColores.Controls.Add(this.txtAzul);
            this.tabPageColores.Controls.Add(this.label8);
            this.tabPageColores.Controls.Add(this.txtDescripcionColor);
            this.tabPageColores.Controls.Add(this.label6);
            this.tabPageColores.Controls.Add(this.txtCodigoColor);
            this.tabPageColores.Controls.Add(this.label7);
            this.tabPageColores.Location = new System.Drawing.Point(4, 22);
            this.tabPageColores.Name = "tabPageColores";
            this.tabPageColores.Size = new System.Drawing.Size(925, 513);
            this.tabPageColores.TabIndex = 2;
            this.tabPageColores.Text = "Colores";
            this.tabPageColores.UseVisualStyleBackColor = true;
            // 
            // dataGridColor
            // 
            this.dataGridColor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridColor.Location = new System.Drawing.Point(22, 360);
            this.dataGridColor.Name = "dataGridColor";
            this.dataGridColor.Size = new System.Drawing.Size(883, 145);
            this.dataGridColor.TabIndex = 56;
            // 
            // btnIngresarColor
            // 
            this.btnIngresarColor.BackColor = System.Drawing.SystemColors.Control;
            this.btnIngresarColor.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnIngresarColor.Image = global::Veterinario_Otoño_2015.Properties.Resources.entering1;
            this.btnIngresarColor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIngresarColor.Location = new System.Drawing.Point(22, 301);
            this.btnIngresarColor.Name = "btnIngresarColor";
            this.btnIngresarColor.Size = new System.Drawing.Size(116, 37);
            this.btnIngresarColor.TabIndex = 55;
            this.btnIngresarColor.Text = "Ingresar";
            this.btnIngresarColor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIngresarColor.UseVisualStyleBackColor = false;
            // 
            // btnModificarColor
            // 
            this.btnModificarColor.BackColor = System.Drawing.SystemColors.Control;
            this.btnModificarColor.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnModificarColor.Image = global::Veterinario_Otoño_2015.Properties.Resources.shuffle11;
            this.btnModificarColor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificarColor.Location = new System.Drawing.Point(190, 301);
            this.btnModificarColor.Name = "btnModificarColor";
            this.btnModificarColor.Size = new System.Drawing.Size(116, 37);
            this.btnModificarColor.TabIndex = 54;
            this.btnModificarColor.Text = "Modificar";
            this.btnModificarColor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificarColor.UseVisualStyleBackColor = false;
            // 
            // btnEliminarColor
            // 
            this.btnEliminarColor.BackColor = System.Drawing.SystemColors.Control;
            this.btnEliminarColor.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnEliminarColor.Image = global::Veterinario_Otoño_2015.Properties.Resources.delete97;
            this.btnEliminarColor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarColor.Location = new System.Drawing.Point(358, 301);
            this.btnEliminarColor.Name = "btnEliminarColor";
            this.btnEliminarColor.Size = new System.Drawing.Size(126, 37);
            this.btnEliminarColor.TabIndex = 53;
            this.btnEliminarColor.Text = "Eliminar";
            this.btnEliminarColor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminarColor.UseVisualStyleBackColor = false;
            // 
            // btnBuscarColor
            // 
            this.btnBuscarColor.Location = new System.Drawing.Point(391, 233);
            this.btnBuscarColor.Name = "btnBuscarColor";
            this.btnBuscarColor.Size = new System.Drawing.Size(446, 35);
            this.btnBuscarColor.TabIndex = 52;
            this.btnBuscarColor.Text = "Buscar Color";
            this.btnBuscarColor.UseVisualStyleBackColor = true;
            this.btnBuscarColor.Click += new System.EventHandler(this.btnBuscarColor_Click);
            // 
            // pictureColor
            // 
            this.pictureColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureColor.Location = new System.Drawing.Point(391, 14);
            this.pictureColor.Name = "pictureColor";
            this.pictureColor.Size = new System.Drawing.Size(446, 190);
            this.pictureColor.TabIndex = 51;
            this.pictureColor.TabStop = false;
            // 
            // txtRojo
            // 
            this.txtRojo.Location = new System.Drawing.Point(22, 168);
            this.txtRojo.Name = "txtRojo";
            this.txtRojo.Size = new System.Drawing.Size(32, 20);
            this.txtRojo.TabIndex = 50;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 138);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 13);
            this.label10.TabIndex = 49;
            this.label10.Text = "Rojo";
            // 
            // txtVerde
            // 
            this.txtVerde.Location = new System.Drawing.Point(78, 168);
            this.txtVerde.Name = "txtVerde";
            this.txtVerde.Size = new System.Drawing.Size(32, 20);
            this.txtVerde.TabIndex = 48;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(75, 138);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 47;
            this.label9.Text = "Verde";
            // 
            // txtAzul
            // 
            this.txtAzul.Location = new System.Drawing.Point(132, 168);
            this.txtAzul.Name = "txtAzul";
            this.txtAzul.Size = new System.Drawing.Size(32, 20);
            this.txtAzul.TabIndex = 46;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(129, 138);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 13);
            this.label8.TabIndex = 45;
            this.label8.Text = "Azul";
            // 
            // txtDescripcionColor
            // 
            this.txtDescripcionColor.Location = new System.Drawing.Point(17, 103);
            this.txtDescripcionColor.Name = "txtDescripcionColor";
            this.txtDescripcionColor.Size = new System.Drawing.Size(284, 20);
            this.txtDescripcionColor.TabIndex = 44;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 43;
            this.label6.Text = "Descripcion";
            // 
            // txtCodigoColor
            // 
            this.txtCodigoColor.Location = new System.Drawing.Point(17, 44);
            this.txtCodigoColor.Name = "txtCodigoColor";
            this.txtCodigoColor.Size = new System.Drawing.Size(113, 20);
            this.txtCodigoColor.TabIndex = 42;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 41;
            this.label7.Text = "Codigo";
            // 
            // FormParametros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 539);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormParametros";
            this.Text = "Mantenciones";
            this.tabControl1.ResumeLayout(false);
            this.tabPageEspecies.ResumeLayout(false);
            this.tabPageEspecies.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEspecies)).EndInit();
            this.tabPageRazas.ResumeLayout(false);
            this.tabPageRazas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRazas)).EndInit();
            this.tabPageColores.ResumeLayout(false);
            this.tabPageColores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureColor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageEspecies;
        private System.Windows.Forms.DataGridView dataGridEspecies;
        private System.Windows.Forms.TextBox txtDescripcionEspecie;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodigoEspecie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPageRazas;
        private System.Windows.Forms.TabPage tabPageColores;
        private System.Windows.Forms.Button btnIngresarEspecie;
        private System.Windows.Forms.Button btnModificarEspecies;
        private System.Windows.Forms.Button btnEliminarEspecies;
        private System.Windows.Forms.TextBox txtCodigoEspecie_Raza;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbEspecie;
        private System.Windows.Forms.Button btnIngresarRaza;
        private System.Windows.Forms.Button btnModificarRaza;
        private System.Windows.Forms.Button btnEliminarRaza;
        private System.Windows.Forms.DataGridView dataGridRazas;
        private System.Windows.Forms.TextBox txtDescripcionRaza;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCodigoRaza;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridColor;
        private System.Windows.Forms.Button btnIngresarColor;
        private System.Windows.Forms.Button btnModificarColor;
        private System.Windows.Forms.Button btnEliminarColor;
        private System.Windows.Forms.Button btnBuscarColor;
        private System.Windows.Forms.PictureBox pictureColor;
        private System.Windows.Forms.TextBox txtRojo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtVerde;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtAzul;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDescripcionColor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCodigoColor;
        private System.Windows.Forms.Label label7;
    }
}