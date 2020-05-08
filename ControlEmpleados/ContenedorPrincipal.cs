using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlEmpleados
{
    public partial class ContenedorPrincipal : Form
    {
        public ContenedorPrincipal()
        {
            InitializeComponent();
        }

        private void ContenedorPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); //Para cerrar la app
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Preguntamos si desea salir, en caso de qu si cerramos
            if (MessageBox.Show("¿Desea salir?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void consultarEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarEmpleados ConEmpl = new ConsultarEmpleados(); //Creando instancia de ConsultarEmpleados
            ConEmpl.MdiParent = this; //la nueva instancia es parte del Contenedor Mdi
            ConEmpl.Show(); //Mostrando la ventana ConsultarEmpleados dentro del ContenedorPrincipal
        }//CONSULTAR EMPLEADOS CLIC

        private void consultarCursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarCursos ConCurs = new ConsultarCursos();
            ConCurs.MdiParent = this;
            ConCurs.Show();
        }//CONSUULTAR CURSOS CLIC

        private void consultarPuestosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarPuestos ConPues = new ConsultarPuestos();
            ConPues.MdiParent = this;
            ConPues.Show();
        }

        private void añadirCursoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarCurso AgCurso = new AgregarCurso();
            AgCurso.MdiParent = this;
            AgCurso.Show();
        }//AñadirCurso Menu

        private void añadirPuestoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarPuesto AgPuesto = new AgregarPuesto();
            AgPuesto.MdiParent = this;
            AgPuesto.Show();
        }

        private void crearEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarEmpleado AgEmpleado = new AgregarEmpleado();
            AgEmpleado.MdiParent = this;
            AgEmpleado.Show();
        }

        private void editarEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarEmpleado AgEmpleado = new AgregarEmpleado();
            AgEmpleado.MdiParent = this;
            AgEmpleado.Show();
            AgEmpleado.button1_Click(this, null);
        }

        private void agregarIncidenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroIncidencias RIncidencias = new RegistroIncidencias();
            RIncidencias.MdiParent = this;
            RIncidencias.Show();
        }
    }
}
