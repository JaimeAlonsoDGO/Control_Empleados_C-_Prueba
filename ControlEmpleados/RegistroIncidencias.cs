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
    public partial class RegistroIncidencias : AgregarBase
    {
        public RegistroIncidencias()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ConsultarEmpleados ConEmpl = new ConsultarEmpleados();
            ConEmpl.ShowDialog();        

            TxtID.Text = ConEmpl.dataGridView1.Rows[ConEmpl.dataGridView1.CurrentRow.Index].Cells[0].Value.ToString().Trim();
            TxtNombre.Text = ConEmpl.dataGridView1.Rows[ConEmpl.dataGridView1.CurrentRow.Index].Cells[1].Value.ToString().Trim();
            txtPaterno.Text = ConEmpl.dataGridView1.Rows[ConEmpl.dataGridView1.CurrentRow.Index].Cells[2].Value.ToString().Trim();
            txtMaterno.Text = ConEmpl.dataGridView1.Rows[ConEmpl.dataGridView1.CurrentRow.Index].Cells[3].Value.ToString().Trim();
            txtIncidencia.Text = DateTime.Now.ToString().Trim();
            txtDescripcion.Focus();
        }//btnBuscar CLIC

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (Utilidades.ValidarFormulario(this, errorProvider1) == false)
            {
                try
                {
                    AgregarIncidencia(TxtID.Text.ToString().Trim(), txtIncidencia.Text.ToString().Trim(), txtDescripcion.Text.ToString().Trim());
                    MessageBox.Show("Guardado exitosamente.");
                    LimpiarTxtBox();
                    btnBuscar.Focus();
                }//TRY
                catch(Exception error)
                {
                    MessageBox.Show("No se pudo guardar");
                }
            }//IF
        }//BtnAgrregar CLIC
    }
}
