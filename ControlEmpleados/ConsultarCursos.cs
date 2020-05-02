using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiBiblioteca;

namespace ControlEmpleados
{
    public partial class ConsultarCursos : Consultas
    {
        public ConsultarCursos()
        {
            InitializeComponent();
        }

        private void ConsultarCursos_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = MostrarRegistros("Curso").Tables[0]; //Mostrando registros contenidos en la tabla Empleados

        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            Buscar("Buscar_Curso", TxtBuscar.Text.Trim());
        }

        private void BtnTodos_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = MostrarRegistros("Curso").Tables[0]; //Mostrando registros contenidos en la tabla Empleados
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            AgregarCurso AgCur = new AgregarCurso();
            AgCur.Show();
        }
    }
}
