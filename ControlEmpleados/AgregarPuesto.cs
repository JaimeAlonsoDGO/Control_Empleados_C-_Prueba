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
    public partial class AgregarPuesto : AgregarBase
    {
        public AgregarPuesto()
        {
            InitializeComponent();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            NuevoRegistro("AgregarPuesto", TxtID.Text.Trim(), TxtNombre.Text.Trim());
        }//BtnAgregar Clic
    }
}
