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
    public partial class RegistroIncidencias : VentanaBase
    {
        public RegistroIncidencias()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConsultarEmpleados ConEmpl = new ConsultarEmpleados();
            ConEmpl.ShowDialog();

            txtID.Text = ConEmpl.dataGridView1.Rows[ConEmpl.dataGridView1.CurrentRow.Index].Cells[0].Value.ToString().Trim();
            txtNombre.Text = ConEmpl.dataGridView1.Rows[ConEmpl.dataGridView1.CurrentRow.Index].Cells[1].Value.ToString().Trim();
            txtPaterno.Text = ConEmpl.dataGridView1.Rows[ConEmpl.dataGridView1.CurrentRow.Index].Cells[2].Value.ToString().Trim();
            txtMaterno.Text = ConEmpl.dataGridView1.Rows[ConEmpl.dataGridView1.CurrentRow.Index].Cells[3].Value.ToString().Trim();
        }
    }
}
