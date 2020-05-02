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
    public partial class ConsultarEmpleados : Consultas
    {
        public ConsultarEmpleados()
        {
            InitializeComponent();
        }

        private void BtnActivos_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = MostrarActivos().Tables[0];
        }//MOSTRAR EMPLEADOS ACTIVOS

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            Buscar("Buscar_Empleado", TxtBuscar.Text.Trim());
        }//BtnBUSCAR CLIC

        private void BtnTodos_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = MostrarRegistros("Empleado").Tables[0]; //Mostrando registros contenidos en la tabla Empleados
        }
    }
}
