namespace ControlEmpleados
{
    partial class RegistroIncidencias
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
            this.lblPaterno = new System.Windows.Forms.Label();
            this.lblMaterno = new System.Windows.Forms.Label();
            this.txtMaterno = new MiBiblioteca.ErrorTxtBox();
            this.txtPaterno = new MiBiblioteca.ErrorTxtBox();
            this.txtIncidencia = new MiBiblioteca.ErrorTxtBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDescripcion = new MiBiblioteca.ErrorTxtBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Location = new System.Drawing.Point(323, 519);
            this.BtnAgregar.Size = new System.Drawing.Size(202, 32);
            this.BtnAgregar.Text = "GUARDAR";
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(419, 20);
            this.label1.Size = new System.Drawing.Size(306, 24);
            this.label1.Text = "REGISTRO DE INCIDENCIAS";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(303, 100);
            this.label2.Size = new System.Drawing.Size(76, 18);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(95, 100);
            this.label3.Size = new System.Drawing.Size(30, 18);
            // 
            // TxtID
            // 
            this.TxtID.Location = new System.Drawing.Point(12, 133);
            this.TxtID.ReadOnly = true;
            this.TxtID.Size = new System.Drawing.Size(202, 23);
            this.TxtID.SoloNumeros = false;
            this.TxtID.TabIndex = 22;
            this.TxtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(242, 133);
            this.TxtNombre.ReadOnly = true;
            this.TxtNombre.Size = new System.Drawing.Size(202, 23);
            this.TxtNombre.TabIndex = 13;
            this.TxtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtnSalir
            // 
            this.BtnSalir.Location = new System.Drawing.Point(565, 519);
            this.BtnSalir.Size = new System.Drawing.Size(202, 32);
            // 
            // lblPaterno
            // 
            this.lblPaterno.AutoSize = true;
            this.lblPaterno.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaterno.Location = new System.Drawing.Point(497, 100);
            this.lblPaterno.Name = "lblPaterno";
            this.lblPaterno.Size = new System.Drawing.Size(145, 18);
            this.lblPaterno.TabIndex = 3;
            this.lblPaterno.Text = "Apellido Paterno:";
            // 
            // lblMaterno
            // 
            this.lblMaterno.AutoSize = true;
            this.lblMaterno.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaterno.Location = new System.Drawing.Point(720, 100);
            this.lblMaterno.Name = "lblMaterno";
            this.lblMaterno.Size = new System.Drawing.Size(147, 18);
            this.lblMaterno.TabIndex = 4;
            this.lblMaterno.Text = "Apellido Materno:";
            // 
            // txtMaterno
            // 
            this.txtMaterno.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaterno.Location = new System.Drawing.Point(696, 132);
            this.txtMaterno.Name = "txtMaterno";
            this.txtMaterno.ReadOnly = true;
            this.txtMaterno.Size = new System.Drawing.Size(202, 23);
            this.txtMaterno.SoloNumeros = false;
            this.txtMaterno.TabIndex = 6;
            this.txtMaterno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMaterno.Validar = true;
            // 
            // txtPaterno
            // 
            this.txtPaterno.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaterno.Location = new System.Drawing.Point(470, 132);
            this.txtPaterno.Name = "txtPaterno";
            this.txtPaterno.ReadOnly = true;
            this.txtPaterno.Size = new System.Drawing.Size(202, 23);
            this.txtPaterno.SoloNumeros = false;
            this.txtPaterno.TabIndex = 8;
            this.txtPaterno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPaterno.Validar = true;
            // 
            // txtIncidencia
            // 
            this.txtIncidencia.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIncidencia.Location = new System.Drawing.Point(409, 215);
            this.txtIncidencia.Name = "txtIncidencia";
            this.txtIncidencia.ReadOnly = true;
            this.txtIncidencia.Size = new System.Drawing.Size(274, 23);
            this.txtIncidencia.SoloNumeros = false;
            this.txtIncidencia.TabIndex = 9;
            this.txtIncidencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtIncidencia.Validar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(495, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "Incidencia:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.AcceptsReturn = true;
            this.txtDescripcion.AcceptsTab = true;
            this.txtDescripcion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(109, 301);
            this.txtDescripcion.MaxLength = 200;
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescripcion.Size = new System.Drawing.Size(868, 164);
            this.txtDescripcion.SoloNumeros = false;
            this.txtDescripcion.TabIndex = 1;
            this.txtDescripcion.Validar = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(495, 263);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 18);
            this.label6.TabIndex = 12;
            this.label6.Text = "Descripción:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(924, 132);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(114, 23);
            this.btnBuscar.TabIndex = 0;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // RegistroIncidencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 589);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtIncidencia);
            this.Controls.Add(this.txtPaterno);
            this.Controls.Add(this.txtMaterno);
            this.Controls.Add(this.lblMaterno);
            this.Controls.Add(this.lblPaterno);
            this.MaximumSize = new System.Drawing.Size(1111, 628);
            this.MinimumSize = new System.Drawing.Size(1111, 628);
            this.Name = "RegistroIncidencias";
            this.Text = "RegistroIncidencias";
            this.Controls.SetChildIndex(this.BtnAgregar, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.TxtID, 0);
            this.Controls.SetChildIndex(this.TxtNombre, 0);
            this.Controls.SetChildIndex(this.lblPaterno, 0);
            this.Controls.SetChildIndex(this.lblMaterno, 0);
            this.Controls.SetChildIndex(this.txtMaterno, 0);
            this.Controls.SetChildIndex(this.txtPaterno, 0);
            this.Controls.SetChildIndex(this.txtIncidencia, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.txtDescripcion, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.BtnSalir, 0);
            this.Controls.SetChildIndex(this.btnBuscar, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private MiBiblioteca.ErrorTxtBox txtDescripcion;
        private System.Windows.Forms.Label label5;
        private MiBiblioteca.ErrorTxtBox txtIncidencia;
        private MiBiblioteca.ErrorTxtBox txtPaterno;
        private MiBiblioteca.ErrorTxtBox txtMaterno;
        private System.Windows.Forms.Label lblMaterno;
        private System.Windows.Forms.Label lblPaterno;
        private System.Windows.Forms.Button btnBuscar;
    }
}