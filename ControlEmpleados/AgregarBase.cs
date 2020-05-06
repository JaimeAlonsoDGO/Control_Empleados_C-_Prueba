using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiBiblioteca;

namespace ControlEmpleados
{
    public partial class AgregarBase : VentanaBase
    {
        public AgregarBase()
        {
            InitializeComponent();
        }

        private void errorTxtBox1_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void errorTxtBox2_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        public void NuevoRegistro (string proceso, string id, string nombre)
        {
            if (Utilidades.ValidarFormulario(this, errorProvider1) == false)
            {
                //Creando cadena de consulta por medio del proceso almacenado Agregar_Curso
                string cmd = string.Format("EXEC {0} '{1}', '{2}'", proceso, id, nombre);
                Utilidades.Ejecutar(cmd);
                MessageBox.Show("Se guardó exitosamente");
                TxtID.Text = "";
                TxtNombre.Text = "";
            }
        }//NuevoRegistro

        public void GuardarPersonalesEmpleado (string id, string nombre, string paterno, string materno,string fecha, string civil, string curp, string rfc, string nss, string lugar, string domicilio, string telefono, string correo, string estatus )
        {
            if (Utilidades.ValidarFormulario(this, errorProvider1) == false)
            {
                //Creando cadena para la consulta
                string cmd = string.Format("EXEC Guardar_Datos_Empleado '{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}'", id, nombre, paterno, materno, fecha, civil, curp, rfc, nss, lugar, domicilio, telefono, correo, estatus);
                Utilidades.Ejecutar(cmd);
            }//IF
        }//GuardarPersonalesEmpleado

        public Boolean GuardarFoto (string urlFoto, string ID_Empleado) //Metodo para insertar la foto a la BD
        {
            string cmd = string.Format("EXEC Guardar_Foto '{0}','{1}'", urlFoto, ID_Empleado);
            Utilidades.Ejecutar(cmd);

            return true;
        }//GuardarFoto

        public DataSet BuscarFoto (string id_empleado)
        {
            string cmd = string.Format("EXEC ConsultaFotoEmpleado '{0}'", id_empleado);
            DataSet ds = Utilidades.Ejecutar(cmd);
            return ds;
        }//BuscarFoto

        public DataSet ObtenerCursos(string idEmpleado)
        {
            string cmd = string.Format("EXEC ObtenerCursosEmpleado '{0}'", idEmpleado);
            DataSet ds = Utilidades.Ejecutar(cmd);
            return ds;
        }//ObtenerCursos

        public void GuardarHistorialCursos(string curso, string empleado)
        {
            string cmd = string.Format("EXEC GuardarHistorialCursos '{0}', '{1}'", curso.Trim(), empleado.Trim());
            Utilidades.Ejecutar(cmd);
        }//GuardarHistorialCursos

        public void LimpiarTxtBox()
        {
            foreach(Control c in this.Controls)
            {
                if (c.GetType() == typeof(ErrorTxtBox))
                    c.Text = "";
            }//ForEach
        }//LimpiarTxtBox

    }
}
