namespace ControlEmpleados
{
    partial class ConsultarEmpleados
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
            this.label1 = new System.Windows.Forms.Label();
            this.BtnActivos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnSeleccionar
            // 
            this.BtnSeleccionar.Size = new System.Drawing.Size(164, 33);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // BtnTodos
            // 
            this.BtnTodos.Location = new System.Drawing.Point(213, 495);
            this.BtnTodos.Size = new System.Drawing.Size(164, 33);
            this.BtnTodos.Click += new System.EventHandler(this.BtnTodos_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.Location = new System.Drawing.Point(596, 495);
            this.BtnSalir.Size = new System.Drawing.Size(164, 33);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Apellido:";
            // 
            // BtnActivos
            // 
            this.BtnActivos.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnActivos.Location = new System.Drawing.Point(401, 495);
            this.BtnActivos.Name = "BtnActivos";
            this.BtnActivos.Size = new System.Drawing.Size(164, 33);
            this.BtnActivos.TabIndex = 9;
            this.BtnActivos.Text = "MOSTRAR ACTIVOS";
            this.BtnActivos.UseVisualStyleBackColor = true;
            this.BtnActivos.Click += new System.EventHandler(this.BtnActivos_Click);
            // 
            // ConsultarEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 540);
            this.Controls.Add(this.BtnActivos);
            this.Controls.Add(this.label1);
            this.Name = "ConsultarEmpleados";
            this.Text = "Empleados Registrados";
            this.Controls.SetChildIndex(this.BtnNuevo, 0);
            this.Controls.SetChildIndex(this.BtnTodos, 0);
            this.Controls.SetChildIndex(this.BtnSalir, 0);
            this.Controls.SetChildIndex(this.BtnSeleccionar, 0);
            this.Controls.SetChildIndex(this.TxtBuscar, 0);
            this.Controls.SetChildIndex(this.BtnBuscar, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.BtnActivos, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnActivos;
    }
}