namespace ControlEmpleados
{
    partial class ContenedorPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContenedorPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuBtnSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.accionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearEmpleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarEmpleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarEmpleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarEmpleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cursosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.añadirCursoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarCursosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.puestosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.añadirPuestoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarPuestosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.incidenciasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarIncidenciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.accionesToolStripMenuItem,
            this.incidenciasToolStripMenuItem,
            this.puestosToolStripMenuItem,
            this.cursosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(805, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuBtnSalir});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // MenuBtnSalir
            // 
            this.MenuBtnSalir.Name = "MenuBtnSalir";
            this.MenuBtnSalir.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.MenuBtnSalir.Size = new System.Drawing.Size(138, 22);
            this.MenuBtnSalir.Text = "Salir";
            this.MenuBtnSalir.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // accionesToolStripMenuItem
            // 
            this.accionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearEmpleadoToolStripMenuItem,
            this.consultarEmpleadosToolStripMenuItem,
            this.editarEmpleadoToolStripMenuItem,
            this.eliminarEmpleadoToolStripMenuItem});
            this.accionesToolStripMenuItem.Name = "accionesToolStripMenuItem";
            this.accionesToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.accionesToolStripMenuItem.Text = "Empleados";
            // 
            // crearEmpleadoToolStripMenuItem
            // 
            this.crearEmpleadoToolStripMenuItem.Name = "crearEmpleadoToolStripMenuItem";
            this.crearEmpleadoToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.crearEmpleadoToolStripMenuItem.Text = "Crear Empleado";
            this.crearEmpleadoToolStripMenuItem.Click += new System.EventHandler(this.crearEmpleadoToolStripMenuItem_Click);
            // 
            // consultarEmpleadosToolStripMenuItem
            // 
            this.consultarEmpleadosToolStripMenuItem.Name = "consultarEmpleadosToolStripMenuItem";
            this.consultarEmpleadosToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.consultarEmpleadosToolStripMenuItem.Text = "Consultar Empleados";
            this.consultarEmpleadosToolStripMenuItem.Click += new System.EventHandler(this.consultarEmpleadosToolStripMenuItem_Click);
            // 
            // editarEmpleadoToolStripMenuItem
            // 
            this.editarEmpleadoToolStripMenuItem.Name = "editarEmpleadoToolStripMenuItem";
            this.editarEmpleadoToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.editarEmpleadoToolStripMenuItem.Text = "Editar Empleado";
            this.editarEmpleadoToolStripMenuItem.Click += new System.EventHandler(this.editarEmpleadoToolStripMenuItem_Click);
            // 
            // eliminarEmpleadoToolStripMenuItem
            // 
            this.eliminarEmpleadoToolStripMenuItem.Name = "eliminarEmpleadoToolStripMenuItem";
            this.eliminarEmpleadoToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.eliminarEmpleadoToolStripMenuItem.Text = "Eliminar Empleado";
            // 
            // cursosToolStripMenuItem
            // 
            this.cursosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.añadirCursoToolStripMenuItem,
            this.consultarCursosToolStripMenuItem});
            this.cursosToolStripMenuItem.Name = "cursosToolStripMenuItem";
            this.cursosToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.cursosToolStripMenuItem.Text = "Cursos";
            // 
            // añadirCursoToolStripMenuItem
            // 
            this.añadirCursoToolStripMenuItem.Name = "añadirCursoToolStripMenuItem";
            this.añadirCursoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.añadirCursoToolStripMenuItem.Text = "Añadir Curso";
            this.añadirCursoToolStripMenuItem.Click += new System.EventHandler(this.añadirCursoToolStripMenuItem_Click);
            // 
            // consultarCursosToolStripMenuItem
            // 
            this.consultarCursosToolStripMenuItem.Name = "consultarCursosToolStripMenuItem";
            this.consultarCursosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.consultarCursosToolStripMenuItem.Text = "Consultar Cursos";
            this.consultarCursosToolStripMenuItem.Click += new System.EventHandler(this.consultarCursosToolStripMenuItem_Click);
            // 
            // puestosToolStripMenuItem
            // 
            this.puestosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.añadirPuestoToolStripMenuItem,
            this.consultarPuestosToolStripMenuItem});
            this.puestosToolStripMenuItem.Name = "puestosToolStripMenuItem";
            this.puestosToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.puestosToolStripMenuItem.Text = "Puestos";
            // 
            // añadirPuestoToolStripMenuItem
            // 
            this.añadirPuestoToolStripMenuItem.Name = "añadirPuestoToolStripMenuItem";
            this.añadirPuestoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.añadirPuestoToolStripMenuItem.Text = "Añadir Puesto";
            this.añadirPuestoToolStripMenuItem.Click += new System.EventHandler(this.añadirPuestoToolStripMenuItem_Click);
            // 
            // consultarPuestosToolStripMenuItem
            // 
            this.consultarPuestosToolStripMenuItem.Name = "consultarPuestosToolStripMenuItem";
            this.consultarPuestosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.consultarPuestosToolStripMenuItem.Text = "Consultar Puestos";
            this.consultarPuestosToolStripMenuItem.Click += new System.EventHandler(this.consultarPuestosToolStripMenuItem_Click);
            // 
            // incidenciasToolStripMenuItem
            // 
            this.incidenciasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarIncidenciaToolStripMenuItem});
            this.incidenciasToolStripMenuItem.Name = "incidenciasToolStripMenuItem";
            this.incidenciasToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.incidenciasToolStripMenuItem.Text = "Incidencias";
            // 
            // agregarIncidenciaToolStripMenuItem
            // 
            this.agregarIncidenciaToolStripMenuItem.Name = "agregarIncidenciaToolStripMenuItem";
            this.agregarIncidenciaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.agregarIncidenciaToolStripMenuItem.Text = "Agregar Incidencia";
            this.agregarIncidenciaToolStripMenuItem.Click += new System.EventHandler(this.agregarIncidenciaToolStripMenuItem_Click);
            // 
            // ContenedorPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 558);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ContenedorPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ContenedorPrincipal";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ContenedorPrincipal_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuBtnSalir;
        private System.Windows.Forms.ToolStripMenuItem accionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearEmpleadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarEmpleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarEmpleadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cursosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem añadirCursoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarCursosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem puestosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem añadirPuestoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarPuestosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarEmpleadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem incidenciasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarIncidenciaToolStripMenuItem;
    }
}