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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbFoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.administraciónEmpleadosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.puestoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Location = new System.Drawing.Point(367, 626);
            this.BtnAgregar.Size = new System.Drawing.Size(161, 32);
            this.BtnAgregar.TabIndex = 19;
            this.BtnAgregar.Text = "GUARDAR";
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(399, 7);
            this.label1.Size = new System.Drawing.Size(206, 24);
            this.label1.Text = "Datos de Empleado";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.label2.Location = new System.Drawing.Point(360, 77);
            this.label2.Size = new System.Drawing.Size(76, 18);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.label3.Location = new System.Drawing.Point(360, 45);
            this.label3.Size = new System.Drawing.Size(30, 18);
            // 
            // TxtID
            // 
            this.TxtID.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F);
            this.TxtID.Location = new System.Drawing.Point(526, 42);
            this.TxtID.Size = new System.Drawing.Size(220, 21);
            // 
            // TxtNombre
            // 
            this.TxtNombre.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F);
            this.TxtNombre.Location = new System.Drawing.Point(458, 74);
            this.TxtNombre.Size = new System.Drawing.Size(288, 21);
            this.TxtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // BtnSalir
            // 
            this.BtnSalir.Location = new System.Drawing.Point(544, 626);
            this.BtnSalir.Size = new System.Drawing.Size(161, 32);
            this.BtnSalir.TabIndex = 20;
            // 
            // BtnImagen
            // 
            this.BtnImagen.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnImagen.Location = new System.Drawing.Point(12, 241);
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
            this.BtnQuitar.Location = new System.Drawing.Point(143, 241);
            this.BtnQuitar.Name = "BtnQuitar";
            this.BtnQuitar.Size = new System.Drawing.Size(125, 25);
            this.BtnQuitar.TabIndex = 16;
            this.BtnQuitar.Text = "Quitar Imágen";
            this.BtnQuitar.UseVisualStyleBackColor = true;
            this.BtnQuitar.Click += new System.EventHandler(this.BtnQuitar_Click);
            // 
            // PbFoto
            // 
            this.PbFoto.ErrorImage = null;
            this.PbFoto.InitialImage = global::ControlEmpleados.Properties.Resources.user_add_12818;
            this.PbFoto.Location = new System.Drawing.Point(12, 12);
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
            this.label4.Location = new System.Drawing.Point(360, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "Apellido Paterno:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(360, 482);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "Teléfono:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(360, 401);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "Domicilio:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(363, 241);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(178, 18);
            this.label7.TabIndex = 12;
            this.label7.Text = "Lugar de Nacimiento:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(363, 318);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 18);
            this.label8.TabIndex = 13;
            this.label8.Text = "NSS:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(363, 356);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 18);
            this.label9.TabIndex = 14;
            this.label9.Text = "RFC:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(363, 275);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 18);
            this.label10.TabIndex = 15;
            this.label10.Text = "CURP:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(363, 179);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 18);
            this.label11.TabIndex = 16;
            this.label11.Text = "Estado Civil:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(360, 206);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(181, 18);
            this.label12.TabIndex = 17;
            this.label12.Text = "Fecha de Nacimiento:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(360, 143);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(147, 18);
            this.label13.TabIndex = 18;
            this.label13.Text = "Apellido Materno:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(360, 440);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(69, 18);
            this.label15.TabIndex = 20;
            this.label15.Text = "Correo:";
            // 
            // TxtLugarNac
            // 
            this.TxtLugarNac.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F);
            this.TxtLugarNac.Location = new System.Drawing.Point(549, 241);
            this.TxtLugarNac.Name = "TxtLugarNac";
            this.TxtLugarNac.Size = new System.Drawing.Size(197, 21);
            this.TxtLugarNac.SoloNumeros = false;
            this.TxtLugarNac.TabIndex = 6;
            this.TxtLugarNac.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtLugarNac.Validar = true;
            // 
            // TxtRfc
            // 
            this.TxtRfc.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F);
            this.TxtRfc.Location = new System.Drawing.Point(458, 356);
            this.TxtRfc.Name = "TxtRfc";
            this.TxtRfc.Size = new System.Drawing.Size(288, 21);
            this.TxtRfc.SoloNumeros = false;
            this.TxtRfc.TabIndex = 9;
            this.TxtRfc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtRfc.Validar = true;
            // 
            // TxtEstadoCivil
            // 
            this.TxtEstadoCivil.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F);
            this.TxtEstadoCivil.Location = new System.Drawing.Point(477, 176);
            this.TxtEstadoCivil.Name = "TxtEstadoCivil";
            this.TxtEstadoCivil.Size = new System.Drawing.Size(269, 21);
            this.TxtEstadoCivil.SoloNumeros = false;
            this.TxtEstadoCivil.TabIndex = 4;
            this.TxtEstadoCivil.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtEstadoCivil.Validar = true;
            // 
            // TxtApellidoMaterno
            // 
            this.TxtApellidoMaterno.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F);
            this.TxtApellidoMaterno.Location = new System.Drawing.Point(518, 143);
            this.TxtApellidoMaterno.Name = "TxtApellidoMaterno";
            this.TxtApellidoMaterno.Size = new System.Drawing.Size(228, 21);
            this.TxtApellidoMaterno.SoloNumeros = false;
            this.TxtApellidoMaterno.TabIndex = 3;
            this.TxtApellidoMaterno.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtApellidoMaterno.Validar = true;
            // 
            // TxtCorreo
            // 
            this.TxtCorreo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F);
            this.TxtCorreo.Location = new System.Drawing.Point(458, 440);
            this.TxtCorreo.Name = "TxtCorreo";
            this.TxtCorreo.Size = new System.Drawing.Size(288, 21);
            this.TxtCorreo.SoloNumeros = false;
            this.TxtCorreo.TabIndex = 11;
            this.TxtCorreo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtCorreo.Validar = true;
            // 
            // TxtDomicilio
            // 
            this.TxtDomicilio.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F);
            this.TxtDomicilio.Location = new System.Drawing.Point(458, 401);
            this.TxtDomicilio.Name = "TxtDomicilio";
            this.TxtDomicilio.Size = new System.Drawing.Size(288, 21);
            this.TxtDomicilio.SoloNumeros = false;
            this.TxtDomicilio.TabIndex = 10;
            this.TxtDomicilio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtDomicilio.Validar = true;
            // 
            // TxtNss
            // 
            this.TxtNss.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F);
            this.TxtNss.Location = new System.Drawing.Point(458, 318);
            this.TxtNss.Name = "TxtNss";
            this.TxtNss.Size = new System.Drawing.Size(288, 21);
            this.TxtNss.SoloNumeros = true;
            this.TxtNss.TabIndex = 8;
            this.TxtNss.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtNss.Validar = true;
            // 
            // TxtCurp
            // 
            this.TxtCurp.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F);
            this.TxtCurp.Location = new System.Drawing.Point(458, 275);
            this.TxtCurp.Name = "TxtCurp";
            this.TxtCurp.Size = new System.Drawing.Size(288, 21);
            this.TxtCurp.SoloNumeros = false;
            this.TxtCurp.TabIndex = 7;
            this.TxtCurp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtCurp.Validar = true;
            // 
            // TxtApellidoPaterno
            // 
            this.TxtApellidoPaterno.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F);
            this.TxtApellidoPaterno.Location = new System.Drawing.Point(510, 111);
            this.TxtApellidoPaterno.Name = "TxtApellidoPaterno";
            this.TxtApellidoPaterno.Size = new System.Drawing.Size(236, 21);
            this.TxtApellidoPaterno.SoloNumeros = false;
            this.TxtApellidoPaterno.TabIndex = 2;
            this.TxtApellidoPaterno.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 291);
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
            this.BtnAgregarCurso.Location = new System.Drawing.Point(12, 523);
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
            this.BtnQuitarCurso.Location = new System.Drawing.Point(143, 523);
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
            this.CbPuesto.Location = new System.Drawing.Point(496, 561);
            this.CbPuesto.Name = "CbPuesto";
            this.CbPuesto.Size = new System.Drawing.Size(250, 21);
            this.CbPuesto.TabIndex = 14;
            this.CbPuesto.ValueMember = "Nombre_Puesto";
            // 
            // DtFechaNac
            // 
            this.DtFechaNac.CustomFormat = "yyyy/mm/dd";
            this.DtFechaNac.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtFechaNac.Location = new System.Drawing.Point(644, 204);
            this.DtFechaNac.Name = "DtFechaNac";
            this.DtFechaNac.Size = new System.Drawing.Size(102, 20);
            this.DtFechaNac.TabIndex = 5;
            this.DtFechaNac.Value = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            // 
            // TxtTelefono
            // 
            this.TxtTelefono.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F);
            this.TxtTelefono.Location = new System.Drawing.Point(458, 482);
            this.TxtTelefono.Name = "TxtTelefono";
            this.TxtTelefono.Size = new System.Drawing.Size(288, 21);
            this.TxtTelefono.SoloNumeros = true;
            this.TxtTelefono.TabIndex = 12;
            this.TxtTelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtTelefono.Validar = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(363, 564);
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
            this.CbEstatus.Location = new System.Drawing.Point(458, 525);
            this.CbEstatus.Name = "CbEstatus";
            this.CbEstatus.Size = new System.Drawing.Size(288, 21);
            this.CbEstatus.TabIndex = 13;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.button1.Location = new System.Drawing.Point(190, 628);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 30);
            this.button1.TabIndex = 39;
            this.button1.Text = "EDITAR EXISTENTE";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.button2.Location = new System.Drawing.Point(13, 628);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(161, 30);
            this.button2.TabIndex = 40;
            this.button2.Text = "NUEVO";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(363, 528);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(74, 18);
            this.label16.TabIndex = 41;
            this.label16.Text = "Estatus:";
            // 
            // AgregarEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 671);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.CbEstatus);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
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
            this.MaximumSize = new System.Drawing.Size(802, 710);
            this.MinimumSize = new System.Drawing.Size(802, 710);
            this.Name = "AgregarEmpleado";
            this.Text = "AgregarEmpleado";
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
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.button2, 0);
            this.Controls.SetChildIndex(this.CbEstatus, 0);
            this.Controls.SetChildIndex(this.label14, 0);
            this.Controls.SetChildIndex(this.label16, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbFoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.administraciónEmpleadosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.puestoBindingSource)).EndInit();
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
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
    }
}