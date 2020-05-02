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
    public partial class Consultas : VentanaBase
    {
        public Consultas()
        {
            InitializeComponent();
        }

        public DataSet MostrarRegistros (string tabla) //Metodo que crea la consulta de una tabla y llena un DataSet
        {
            string cmd = string.Format("SELECT * FROM " + tabla);
            DataSet DS = Utilidades.Ejecutar(cmd);
            TxtBuscar.Text = "";
            TxtBuscar.Focus();
            return DS;
        }// MostrarRegistros

        public DataSet MostrarActivos()
        {
            string cmd = "EXEC Mostrar_Activos";
            DataSet DS = Utilidades.Ejecutar(cmd);
            TxtBuscar.Text = "";
            TxtBuscar.Focus();
            return DS;
        }//MOSTRAR ACTIVOS

        private void BtnSeleccionar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0) //Validamos su nuestro DataGridView tiene o no registros
            {
                return;
            }//IF
            else
            {
                DialogResult = DialogResult.OK;
                Close();
            }//ELSE
        }//BtnSeleccionar Clic

        public Boolean Buscar(string proceso, string nombre)
        {
            if (string.IsNullOrEmpty(TxtBuscar.Text.Trim()) == false) //Validando si el txtBox no está vacio
            {
                string CMD = string.Format("EXEC {0} '{1}'", proceso, nombre);
                DataSet DS = Utilidades.Ejecutar(CMD);
                dataGridView1.DataSource = DS.Tables[0];
            }//if
            return true;
        }//Buscar
    }
}
