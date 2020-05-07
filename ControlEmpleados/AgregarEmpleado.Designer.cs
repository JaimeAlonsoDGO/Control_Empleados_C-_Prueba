namespace ControlEmpleados
{
    partial class AgregarEmpleado
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BtnImagen = new System.Windows.Forms.Button();
            this.BtnQuitar = new System.Windows.Forms.Button();
            this.PbFoto = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.TxtLugarNac = new MiBiblioteca.ErrorTxtBox();
            this.TxtRfc = new MiBiblioteca.ErrorTxtBox();
            this.TxtEstadoCivil = new MiBiblioteca.ErrorTxtBox();
            this.TxtApellidoMaterno = new MiBiblioteca.ErrorTxtBox();
            this.TxtCorreo = new MiBiblioteca.ErrorTxtBox();
            this.TxtDomicilio = new MiBiblioteca.ErrorTxtBox();
            this.TxtNss = new MiBiblioteca.ErrorTxtBox();
            this.TxtCurp = new MiBiblioteca.ErrorTxtBox();
            this.TxtApellidoPaterno = new MiBiblioteca.ErrorTxtBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID_Curso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_Curso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnAgregarCurso = new System.Windows.Forms.Button();
            this.administraciónEmpleadosDataSet = new ControlEmpleados.AdministraciónEmpleadosDataSet();
            this.BtnQuitarCurso = new System.Windows.Forms.Button();
            this.puestoTableAdapter = new ControlEmpleados.AdministraciónEmpleadosDataSetTableAdapters.PuestoTableAdapter();
            this.puestoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CbPuesto = new System.Windows.Forms.ComboBox();
            this.DtFechaNac = new System.Windows.Forms.DateTimePicker();
            this.TxtTelefono = new MiBiblioteca.ErrorTxtBox();
            this.label14 = new System.Windows.Forms.Label();
            this.CbEstatus = new System.Windows.Forms.ComboBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.dgvPuestos = new System.Windows.Forms.DataGridView();
            this.FechaInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Puesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAgregarPuesto = new System.Windows.Forms.Button();
            this.btnQuitarPuesto = new System.Windows.Forms.Button();
            this.dgvIncidencias = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConceptoIncidencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnQuitarIncidencia = new System.Windows.Forms.Button();
            this.btnAgregarIncidencia = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbFoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.administraciónEmpleadosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.puestoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPuestos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIncidencias)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Location = new System.Drawing.Point(695, 626);
            this.BtnAgregar.Size = new System.Drawing.Size(161, 32);
            this.BtnAgregar.TabIndex = 19;
            this.BtnAgregar.Text = "GUARDAR";
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(115, 10);
            this.label1.Size = new System.Drawing.Size(206, 24);
            this.label1.Text = "Datos de Empleado";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.label2.Location = new System.Drawing.Point(21, 78);
            this.label2.Size = new System.Drawing.Size(76, 18);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.label3.Location = new System.Drawing.Point(24, 46);
            this.label3.Size = new System.Drawing.Size(30, 18);
            // 
            // TxtID
            // 
            this.TxtID.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F);
            this.TxtID.Location = new System.Drawing.Point(187, 43);
            this.TxtID.ReadOnly = true;
            this.TxtID.Size = new System.Drawing.Size(220, 21);
            this.TxtID.SoloNumeros = false;
            this.TxtID.TabStop = false;
            this.TxtID.Tag = "El ID se definirá automáticamente.";
            this.TxtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F);
            this.TxtNombre.Location = new System.Drawing.Point(119, 75);
            this.TxtNombre.Size = new System.Drawing.Size(288, 21);
            this.TxtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtnSalir
            // 
            this.BtnSalir.Location = new System.Drawing.Point(982, 626);
            this.BtnSalir.Size = new System.Drawing.Size(161, 32);
            this.BtnSalir.TabIndex = 20;
            // 
            // BtnImagen
            // 
            this.BtnImagen.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnImagen.Location = new System.Drawing.Point(471, 272);
            this.BtnImagen.Name = "BtnImagen";
            this.BtnImagen.Size = new System.Drawing.Size(125, 25);
            this.BtnImagen.TabIndex = 15;
            this.BtnImagen.Text = "Elegir Imágen";
            this.BtnImagen.UseVisualStyleBackColor = true;
            this.BtnImagen.Click += new System.EventHandler(this.BtnImagen_Click);
            // 
            // BtnQuitar
            // 
            this.BtnQuitar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnQuitar.Location = new System.Drawing.Point(602, 272);
            this.BtnQuitar.Name = "BtnQuitar";
            this.BtnQuitar.Size = new System.Drawing.Size(125, 25);
            this.BtnQuitar.TabIndex = 16;
            this.BtnQuitar.Text = "Quitar Imágen";
            this.BtnQuitar.UseVisualStyleBackColor = true;
            this.BtnQuitar.Click += new System.EventHandler(this.BtnQuitar_Click);
            // 
            // PbFoto
            // 
            this.PbFoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PbFoto.ErrorImage = null;
            this.PbFoto.InitialImage = global::ControlEmpleados.Properties.Resources.user_add_12818;
            this.PbFoto.Location = new System.Drawing.Point(471, 43);
            this.PbFoto.Name = "PbFoto";
            this.PbFoto.Size = new System.Drawing.Size(256, 215);
            this.PbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbFoto.TabIndex = 5;
            this.PbFoto.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "Apellido Paterno:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 483);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "Teléfono:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 402);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "Domicilio:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(21, 242);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(178, 18);
            this.label7.TabIndex = 12;
            this.label7.Text = "Lugar de Nacimiento:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(21, 319);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 18);
            this.label8.TabIndex = 13;
            this.label8.Text = "NSS:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(21, 357);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 18);
            this.label9.TabIndex = 14;
            this.label9.Text = "RFC:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(21, 275);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 18);
            this.label10.TabIndex = 15;
            this.label10.Text = "CURP:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(21, 180);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 18);
            this.label11.TabIndex = 16;
            this.label11.Text = "Estado Civil:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(21, 207);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(181, 18);
            this.label12.TabIndex = 17;
            this.label12.Text = "Fecha de Nacimiento:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(21, 144);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(147, 18);
            this.label13.TabIndex = 18;
            this.label13.Text = "Apellido Materno:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(21, 441);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(69, 18);
            this.label15.TabIndex = 20;
            this.label15.Text = "Correo:";
            // 
            // TxtLugarNac
            // 
            this.TxtLugarNac.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F);
            this.TxtLugarNac.Location = new System.Drawing.Point(210, 242);
            this.TxtLugarNac.Name = "TxtLugarNac";
            this.TxtLugarNac.Size = new System.Drawing.Size(197, 21);
            this.TxtLugarNac.SoloNumeros = false;
            this.TxtLugarNac.TabIndex = 6;
            this.TxtLugarNac.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtLugarNac.Validar = true;
            // 
            // TxtRfc
            // 
            this.TxtRfc.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F);
            this.TxtRfc.Location = new System.Drawing.Point(119, 357);
            this.TxtRfc.Name = "TxtRfc";
            this.TxtRfc.Size = new System.Drawing.Size(288, 21);
            this.TxtRfc.SoloNumeros = false;
            this.TxtRfc.TabIndex = 9;
            this.TxtRfc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtRfc.Validar = false;
            // 
            // TxtEstadoCivil
            // 
            this.TxtEstadoCivil.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F);
            this.TxtEstadoCivil.Location = new System.Drawing.Point(138, 177);
            this.TxtEstadoCivil.Name = "TxtEstadoCivil";
            this.TxtEstadoCivil.Size = new System.Drawing.Size(269, 21);
            this.TxtEstadoCivil.SoloNumeros = false;
            this.TxtEstadoCivil.TabIndex = 4;
            this.TxtEstadoCivil.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtEstadoCivil.Validar = true;
            // 
            // TxtApellidoMaterno
            // 
            this.TxtApellidoMaterno.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F);
            this.TxtApellidoMaterno.Location = new System.Drawing.Point(179, 144);
            this.TxtApellidoMaterno.Name = "TxtApellidoMaterno";
            this.TxtApellidoMaterno.Size = new System.Drawing.Size(228, 21);
            this.TxtApellidoMaterno.SoloNumeros = false;
            this.TxtApellidoMaterno.TabIndex = 3;
            this.TxtApellidoMaterno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtApellidoMaterno.Validar = true;
            // 
            // TxtCorreo
            // 
            this.TxtCorreo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F);
            this.TxtCorreo.Location = new System.Drawing.Point(119, 441);
            this.TxtCorreo.Name = "TxtCorreo";
            this.TxtCorreo.Size = new System.Drawing.Size(288, 21);
            this.TxtCorreo.SoloNumeros = false;
            this.TxtCorreo.TabIndex = 11;
            this.TxtCorreo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtCorreo.Validar = true;
            // 
            // TxtDomicilio
            // 
            this.TxtDomicilio.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F);
            this.TxtDomicilio.Location = new System.Drawing.Point(119, 402);
            this.TxtDomicilio.Name = "TxtDomicilio";
            this.TxtDomicilio.Size = new System.Drawing.Size(288, 21);
            this.TxtDomicilio.SoloNumeros = false;
            this.TxtDomicilio.TabIndex = 10;
            this.TxtDomicilio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtDomicilio.Validar = true;
            // 
            // TxtNss
            // 
            this.TxtNss.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F);
            this.TxtNss.Location = new System.Drawing.Point(119, 319);
            this.TxtNss.Name = "TxtNss";
            this.TxtNss.Size = new System.Drawing.Size(288, 21);
            this.TxtNss.SoloNumeros = true;
            this.TxtNss.TabIndex = 8;
            this.TxtNss.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtNss.Validar = false;
            // 
            // TxtCurp
            // 
            this.TxtCurp.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F);
            this.TxtCurp.Location = new System.Drawing.Point(119, 276);
            this.TxtCurp.Name = "TxtCurp";
            this.TxtCurp.Size = new System.Drawing.Size(288, 21);
            this.TxtCurp.SoloNumeros = false;
            this.TxtCurp.TabIndex = 7;
            this.TxtCurp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtCurp.Validar = true;
            // 
            // TxtApellidoPaterno
            // 
            this.TxtApellidoPaterno.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F);
            this.TxtApellidoPaterno.Location = new System.Drawing.Point(171, 112);
            this.TxtApellidoPaterno.Name = "TxtApellidoPaterno";
            this.TxtApellidoPaterno.Size = new System.Drawing.Size(236, 21);
            this.TxtApellidoPaterno.SoloNumeros = false;
            this.TxtApellidoPaterno.TabIndex = 2;
            this.TxtApellidoPaterno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtApellidoPaterno.Validar = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Curso,
            this.Nombre_Curso});
            this.dataGridView1.Location = new System.Drawing.Point(471, 321);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(256, 226);
            this.dataGridView1.TabIndex = 31;
            // 
            // ID_Curso
            // 
            this.ID_Curso.HeaderText = "ID";
            this.ID_Curso.Name = "ID_Curso";
            this.ID_Curso.ReadOnly = true;
            // 
            // Nombre_Curso
            // 
            this.Nombre_Curso.HeaderText = "Nombre";
            this.Nombre_Curso.Name = "Nombre_Curso";
            this.Nombre_Curso.ReadOnly = true;
            // 
            // BtnAgregarCurso
            // 
            this.BtnAgregarCurso.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F);
            this.BtnAgregarCurso.Location = new System.Drawing.Point(471, 553);
            this.BtnAgregarCurso.Name = "BtnAgregarCurso";
            this.BtnAgregarCurso.Size = new System.Drawing.Size(125, 27);
            this.BtnAgregarCurso.TabIndex = 17;
            this.BtnAgregarCurso.Text = "Agregar Curso";
            this.BtnAgregarCurso.UseVisualStyleBackColor = true;
            this.BtnAgregarCurso.Click += new System.EventHandler(this.BtnAgregarCurso_Click);
            // 
            // administraciónEmpleadosDataSet
            // 
            this.administraciónEmpleadosDataSet.DataSetName = "AdministraciónEmpleadosDataSet";
            this.administraciónEmpleadosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BtnQuitarCurso
            // 
            this.BtnQuitarCurso.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F);
            this.BtnQuitarCurso.Location = new System.Drawing.Point(602, 553);
            this.BtnQuitarCurso.Name = "BtnQuitarCurso";
            this.BtnQuitarCurso.Size = new System.Drawing.Size(125, 27);
            this.BtnQuitarCurso.TabIndex = 18;
            this.BtnQuitarCurso.Text = "Quitar Curso";
            this.BtnQuitarCurso.UseVisualStyleBackColor = true;
            this.BtnQuitarCurso.Click += new System.EventHandler(this.BtnQuitarCurso_Click);
            // 
            // puestoTableAdapter
            // 
            this.puestoTableAdapter.ClearBeforeFill = true;
            // 
            // puestoBindingSource
            // 
            this.puestoBindingSource.DataMember = "Puesto";
            this.puestoBindingSource.DataSource = this.administraciónEmpleadosDataSet;
            // 
            // CbPuesto
            // 
            this.CbPuesto.DataSource = this.puestoBindingSource;
            this.CbPuesto.DisplayMember = "Nombre_Puesto";
            this.CbPuesto.FormattingEnabled = true;
            this.CbPuesto.Location = new System.Drawing.Point(157, 562);
            this.CbPuesto.Name = "CbPuesto";
            this.CbPuesto.Size = new System.Drawing.Size(250, 21);
            this.CbPuesto.TabIndex = 14;
            this.CbPuesto.ValueMember = "Nombre_Puesto";
            // 
            // DtFechaNac
            // 
            this.DtFechaNac.CustomFormat = "yyyy/mm/dd";
            this.DtFechaNac.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtFechaNac.Location = new System.Drawing.Point(305, 205);
            this.DtFechaNac.Name = "DtFechaNac";
            this.DtFechaNac.Size = new System.Drawing.Size(102, 20);
            this.DtFechaNac.TabIndex = 5;
            this.DtFechaNac.Value = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            // 
            // TxtTelefono
            // 
            this.TxtTelefono.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F);
            this.TxtTelefono.Location = new System.Drawing.Point(119, 483);
            this.TxtTelefono.Name = "TxtTelefono";
            this.TxtTelefono.Size = new System.Drawing.Size(288, 21);
            this.TxtTelefono.SoloNumeros = true;
            this.TxtTelefono.TabIndex = 12;
            this.TxtTelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtTelefono.Validar = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(21, 562);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(125, 18);
            this.label14.TabIndex = 37;
            this.label14.Text = "Puesto Actual:";
            // 
            // CbEstatus
            // 
            this.CbEstatus.FormattingEnabled = true;
            this.CbEstatus.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.CbEstatus.Location = new System.Drawing.Point(119, 526);
            this.CbEstatus.Name = "CbEstatus";
            this.CbEstatus.Size = new System.Drawing.Size(288, 21);
            this.CbEstatus.TabIndex = 13;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.btnEditar.Location = new System.Drawing.Point(334, 628);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(161, 30);
            this.btnEditar.TabIndex = 39;
            this.btnEditar.Text = "EDITAR EXISTENTE";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.btnNuevo.Location = new System.Drawing.Point(157, 628);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(161, 30);
            this.btnNuevo.TabIndex = 40;
            this.btnNuevo.Text = "NUEVO";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.button2_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(21, 526);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(74, 18);
            this.label16.TabIndex = 41;
            this.label16.Text = "Estatus:";
            // 
            // dgvPuestos
            // 
            this.dgvPuestos.AllowUserToAddRows = false;
            this.dgvPuestos.AllowUserToDeleteRows = false;
            this.dgvPuestos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPuestos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FechaInicio,
            this.Puesto});
            this.dgvPuestos.Location = new System.Drawing.Point(779, 43);
            this.dgvPuestos.Name = "dgvPuestos";
            this.dgvPuestos.ReadOnly = true;
            this.dgvPuestos.RowHeadersVisible = false;
            this.dgvPuestos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPuestos.Size = new System.Drawing.Size(360, 215);
            this.dgvPuestos.TabIndex = 42;
            // 
            // FechaInicio
            // 
            dataGridViewCellStyle1.NullValue = null;
            this.FechaInicio.DefaultCellStyle = dataGridViewCellStyle1;
            this.FechaInicio.HeaderText = "ID";
            this.FechaInicio.Name = "FechaInicio";
            this.FechaInicio.ReadOnly = true;
            this.FechaInicio.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Puesto
            // 
            this.Puesto.HeaderText = "Puesto";
            this.Puesto.Name = "Puesto";
            this.Puesto.ReadOnly = true;
            this.Puesto.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Puesto.Width = 530;
            // 
            // btnAgregarPuesto
            // 
            this.btnAgregarPuesto.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarPuesto.Location = new System.Drawing.Point(834, 272);
            this.btnAgregarPuesto.Name = "btnAgregarPuesto";
            this.btnAgregarPuesto.Size = new System.Drawing.Size(125, 25);
            this.btnAgregarPuesto.TabIndex = 43;
            this.btnAgregarPuesto.Text = "Agregar Puesto";
            this.btnAgregarPuesto.UseVisualStyleBackColor = true;
            this.btnAgregarPuesto.Click += new System.EventHandler(this.btnAgregarPuesto_Click);
            // 
            // btnQuitarPuesto
            // 
            this.btnQuitarPuesto.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitarPuesto.Location = new System.Drawing.Point(982, 272);
            this.btnQuitarPuesto.Name = "btnQuitarPuesto";
            this.btnQuitarPuesto.Size = new System.Drawing.Size(125, 25);
            this.btnQuitarPuesto.TabIndex = 44;
            this.btnQuitarPuesto.Text = "Quitar Puesto";
            this.btnQuitarPuesto.UseVisualStyleBackColor = true;
            this.btnQuitarPuesto.Click += new System.EventHandler(this.btnQuitarPuesto_Click);
            // 
            // dgvIncidencias
            // 
            this.dgvIncidencias.AllowUserToAddRows = false;
            this.dgvIncidencias.AllowUserToDeleteRows = false;
            this.dgvIncidencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIncidencias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.ConceptoIncidencia});
            this.dgvIncidencias.Location = new System.Drawing.Point(779, 319);
            this.dgvIncidencias.Name = "dgvIncidencias";
            this.dgvIncidencias.ReadOnly = true;
            this.dgvIncidencias.RowHeadersVisible = false;
            this.dgvIncidencias.Size = new System.Drawing.Size(360, 228);
            this.dgvIncidencias.TabIndex = 45;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ConceptoIncidencia
            // 
            this.ConceptoIncidencia.HeaderText = "Concepto de la incidencia";
            this.ConceptoIncidencia.Name = "ConceptoIncidencia";
            this.ConceptoIncidencia.ReadOnly = true;
            this.ConceptoIncidencia.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ConceptoIncidencia.Width = 530;
            // 
            // btnQuitarIncidencia
            // 
            this.btnQuitarIncidencia.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitarIncidencia.Location = new System.Drawing.Point(982, 560);
            this.btnQuitarIncidencia.Name = "btnQuitarIncidencia";
            this.btnQuitarIncidencia.Size = new System.Drawing.Size(125, 25);
            this.btnQuitarIncidencia.TabIndex = 47;
            this.btnQuitarIncidencia.Text = "Quitar Incidencia";
            this.btnQuitarIncidencia.UseVisualStyleBackColor = true;
            // 
            // btnAgregarIncidencia
            // 
            this.btnAgregarIncidencia.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarIncidencia.Location = new System.Drawing.Point(834, 560);
            this.btnAgregarIncidencia.Name = "btnAgregarIncidencia";
            this.btnAgregarIncidencia.Size = new System.Drawing.Size(125, 25);
            this.btnAgregarIncidencia.TabIndex = 46;
            this.btnAgregarIncidencia.Text = "Agregar Incidencia";
            this.btnAgregarIncidencia.UseVisualStyleBackColor = true;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.btnImprimir.Location = new System.Drawing.Point(514, 627);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(161, 30);
            this.btnImprimir.TabIndex = 48;
            this.btnImprimir.Text = "IMPRIMIR REPORTE";
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // AgregarEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 671);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnQuitarIncidencia);
            this.Controls.Add(this.btnAgregarIncidencia);
            this.Controls.Add(this.dgvIncidencias);
            this.Controls.Add(this.btnQuitarPuesto);
            this.Controls.Add(this.btnAgregarPuesto);
            this.Controls.Add(this.dgvPuestos);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.CbEstatus);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.CbPuesto);
            this.Controls.Add(this.BtnQuitarCurso);
            this.Controls.Add(this.BtnAgregarCurso);
            this.Controls.Add(this.TxtTelefono);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.DtFechaNac);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.TxtCorreo);
            this.Controls.Add(this.TxtDomicilio);
            this.Controls.Add(this.TxtNss);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtCurp);
            this.Controls.Add(this.TxtRfc);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.BtnQuitar);
            this.Controls.Add(this.BtnImagen);
            this.Controls.Add(this.TxtApellidoPaterno);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtLugarNac);
            this.Controls.Add(this.TxtApellidoMaterno);
            this.Controls.Add(this.TxtEstadoCivil);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.PbFoto);
            this.MaximumSize = new System.Drawing.Size(1191, 710);
            this.MinimumSize = new System.Drawing.Size(1191, 710);
            this.Name = "AgregarEmpleado";
            this.Text = "Edición de Empleado";
            this.Load += new System.EventHandler(this.AgregarEmpleado_Load);
            this.Controls.SetChildIndex(this.PbFoto, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.TxtID, 0);
            this.Controls.SetChildIndex(this.TxtNombre, 0);
            this.Controls.SetChildIndex(this.label11, 0);
            this.Controls.SetChildIndex(this.label13, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.label12, 0);
            this.Controls.SetChildIndex(this.TxtEstadoCivil, 0);
            this.Controls.SetChildIndex(this.TxtApellidoMaterno, 0);
            this.Controls.SetChildIndex(this.TxtLugarNac, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.TxtApellidoPaterno, 0);
            this.Controls.SetChildIndex(this.BtnImagen, 0);
            this.Controls.SetChildIndex(this.BtnQuitar, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.TxtRfc, 0);
            this.Controls.SetChildIndex(this.TxtCurp, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.TxtNss, 0);
            this.Controls.SetChildIndex(this.TxtDomicilio, 0);
            this.Controls.SetChildIndex(this.TxtCorreo, 0);
            this.Controls.SetChildIndex(this.label15, 0);
            this.Controls.SetChildIndex(this.DtFechaNac, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.TxtTelefono, 0);
            this.Controls.SetChildIndex(this.BtnAgregarCurso, 0);
            this.Controls.SetChildIndex(this.BtnQuitarCurso, 0);
            this.Controls.SetChildIndex(this.CbPuesto, 0);
            this.Controls.SetChildIndex(this.BtnSalir, 0);
            this.Controls.SetChildIndex(this.BtnAgregar, 0);
            this.Controls.SetChildIndex(this.btnEditar, 0);
            this.Controls.SetChildIndex(this.btnNuevo, 0);
            this.Controls.SetChildIndex(this.CbEstatus, 0);
            this.Controls.SetChildIndex(this.label14, 0);
            this.Controls.SetChildIndex(this.label16, 0);
            this.Controls.SetChildIndex(this.dgvPuestos, 0);
            this.Controls.SetChildIndex(this.btnAgregarPuesto, 0);
            this.Controls.SetChildIndex(this.btnQuitarPuesto, 0);
            this.Controls.SetChildIndex(this.dgvIncidencias, 0);
            this.Controls.SetChildIndex(this.btnAgregarIncidencia, 0);
            this.Controls.SetChildIndex(this.btnQuitarIncidencia, 0);
            this.Controls.SetChildIndex(this.btnImprimir, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbFoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.administraciónEmpleadosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.puestoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPuestos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIncidencias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PbFoto;
        private System.Windows.Forms.Button BtnImagen;
        private System.Windows.Forms.Button BtnQuitar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private MiBiblioteca.ErrorTxtBox TxtRfc;
        private MiBiblioteca.ErrorTxtBox TxtNss;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnAgregarCurso;
        private AdministraciónEmpleadosDataSet administraciónEmpleadosDataSet;
        private System.Windows.Forms.Button BtnQuitarCurso;
        private AdministraciónEmpleadosDataSetTableAdapters.PuestoTableAdapter puestoTableAdapter;
        private System.Windows.Forms.BindingSource puestoBindingSource;
        private System.Windows.Forms.ComboBox CbPuesto;
        private System.Windows.Forms.DateTimePicker DtFechaNac;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox CbEstatus;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Curso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Curso;
        public MiBiblioteca.ErrorTxtBox TxtLugarNac;
        public MiBiblioteca.ErrorTxtBox TxtEstadoCivil;
        public MiBiblioteca.ErrorTxtBox TxtApellidoMaterno;
        public MiBiblioteca.ErrorTxtBox TxtCorreo;
        public MiBiblioteca.ErrorTxtBox TxtDomicilio;
        public MiBiblioteca.ErrorTxtBox TxtCurp;
        public MiBiblioteca.ErrorTxtBox TxtApellidoPaterno;
        public MiBiblioteca.ErrorTxtBox TxtTelefono;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataGridView dgvPuestos;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Puesto;
        private System.Windows.Forms.Button btnAgregarPuesto;
        private System.Windows.Forms.Button btnQuitarPuesto;
        private System.Windows.Forms.DataGridView dgvIncidencias;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConceptoIncidencia;
        private System.Windows.Forms.Button btnQuitarIncidencia;
        private System.Windows.Forms.Button btnAgregarIncidencia;
        private System.Windows.Forms.Button btnImprimir;
    }
}