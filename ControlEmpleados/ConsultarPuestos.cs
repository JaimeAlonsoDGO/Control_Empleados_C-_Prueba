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
    public partial class ConsultarPuestos : Consultas
    {
        public ConsultarPuestos()
        {
            InitializeComponent();
        }

        private void ConsultarPuestos_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = MostrarRegistros("Puesto").Tables[0]; //Mostrando registros contenidos en la tabla Empleados

        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            Buscar("Buscar_Puesto", TxtBuscar.Text.Trim());
        }

        private void BtnTodos_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = MostrarRegistros("Puesto").Tables[0]; //Mostrando registros contenidos en la tabla Empleados
        }//BtnTodos Clic

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            AgregarPuesto AgPuesto = new AgregarPuesto();
            AgPuesto.Show();
        }//BtnNuevo Clic
    }
}
