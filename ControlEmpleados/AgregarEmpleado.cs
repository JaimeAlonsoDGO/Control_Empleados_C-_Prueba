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
    public partial class AgregarEmpleado : AgregarBase
    {
        public AgregarEmpleado()
        {
            InitializeComponent();
        }

        private void AgregarEmpleado_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'administraciónEmpleadosDataSet.Puesto' Puede moverla o quitarla según sea necesario.
            this.puestoTableAdapter.Fill(this.administraciónEmpleadosDataSet.Puesto);

        }

        public static string imagen; //Variable pública que almacena la URL de la fotografía
        private void BtnImagen_Click(object sender, EventArgs e)
        {
            //Metodo para seleccionar una imágen
            try
            {
                if(openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    imagen = openFileDialog1.FileName;
                    PbFoto.Image = Image.FromFile(imagen);
                }
            }//try
            catch (Exception error)
            {
                MessageBox.Show("El archivo no es un tipo de imágen compatible.");
            }//Catch
        }//BtnImagen Clic

        private void BtnQuitar_Click(object sender, EventArgs e)
        {
            PbFoto.Image = null;
            imagen = "";
        }//BtnQuitar Imagen

        public static int con_fila = 0; //Variable para contar filas en DataGridView Cursos

        private void BtnAgregarCurso_Click(object sender, EventArgs e)
        {
            Boolean existe = false;
            ConsultarCursos ConCur = new ConsultarCursos(); //Creando instancia de Ventana Consultar Cursos
            ConCur.ShowDialog(); //Indicando que es una ventana de tipo Dialogo
            string ID_Curso = ConCur.dataGridView1.Rows[ConCur.dataGridView1.CurrentRow.Index].Cells[0].Value.ToString().Trim(); //Almacenando el ID btenido de la seleccion
            string Nombre_Curso = ConCur.dataGridView1.Rows[ConCur.dataGridView1.CurrentRow.Index].Cells[1].Value.ToString().Trim(); //ahora almacenando nombre de ccurso
            if (con_fila != 0) //Validndo si no hay registros
            {
                foreach (DataGridViewRow fila in dataGridView1.Rows) //recorriendo cada fila en el DataGridView
                {
                    if (fila.Cells[0].Value.ToString() == ID_Curso)
                    {
                        MessageBox.Show("Ya se ha ingresado el curso " + Nombre_Curso + " anteriormente.");
                        existe = true;
                        break;
                    }
                }//ForEach
            }//IF               
            if(existe == false)
            {
                dataGridView1.Rows.Add(ID_Curso.Trim(), Nombre_Curso.Trim()); //Añadiendo valores al DataGridView
                BtnAgregar.Focus(); //Haciendo focus en el boton para agregar un curso nuevo
                con_fila++;
            }//If
        }//BtnAgregarCursos Clic

        private void BtnQuitarCurso_Click(object sender, EventArgs e)
        {
            if (con_fila > 0) //Validamos que ya existan registros
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index); //Eliminamos la selección actual
                con_fila--; //Disminuimos el contador de filas
            }
        }//BtnQuitar Curso Clic

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (Utilidades.ValidarFormulario(this, errorProvider1) == false)
            {
                //Camvbiando a char lo seleccionado en el ComboBox del Estatus
                char estatus = '0';
                if (CbEstatus.Text.Trim() == "Activo")
                    estatus = '1';
                //Cambiando a string lo seleccionado en el DateTimePicker
                string fecha = DtFechaNac.Value.ToString("yyyy/MM/dd");
                try
                {
                    //Ejecutando Proceso almacenado para guardar Datos Personales
                    GuardarPersonalesEmpleado(TxtID.Text.Trim(), TxtNombre.Text.Trim(), TxtApellidoPaterno.Text.Trim(), TxtApellidoMaterno.Text.Trim(), fecha, TxtEstadoCivil.Text.Trim(), TxtCurp.Text.Trim(), TxtRfc.Text.Trim(), TxtNss.Text.Trim(), TxtLugarNac.Text.Trim(), TxtDomicilio.Text.Trim(), TxtTelefono.Text.Trim(), TxtCorreo.Text.Trim(), estatus.ToString().Trim());
                    //Ejecutando Proceso almacenado para guardar Foto
                    GuardarFoto(imagen, TxtID.Text.Trim());
                    MessageBox.Show("Guardado exitosamente.");
                    LimpiarTxtBox(); //Limpiamos los txtbox
                    dataGridView1.Columns.Clear(); //Limpiamos el DataGridView
                    PbFoto.Image = null; //Limpiamos la foto                    
                }//Try
                catch (Exception error)
                {
                    MessageBox.Show("ERROR: " + error.Message);
                }//catch
            }//if                
        }//BtnAgregar Empleado

        private void button2_Click(object sender, EventArgs e)
        {      
            LimpiarTxtBox();
            dataGridView1.Columns.Clear(); //Limpiamos el DataGridView
            PbFoto.Image = null; //Limpiamos la foto  
        }//BtnNuevo

        private void button1_Click(object sender, EventArgs e)
        {
            // Creando oinstancia de vista ConsultarEmpleados
            ConsultarEmpleados ConEmpl = new ConsultarEmpleados();
            ConEmpl.ShowDialog();

            //Almacenando ID del empleado, fecha de nacimienoto y estatus, en una variable, a partir de nuestra consulta realizada
            string id_empleado = ConEmpl.dataGridView1.Rows[ConEmpl.dataGridView1.CurrentRow.Index].Cells[0].Value.ToString().Trim();
            string estatus = ConEmpl.dataGridView1.Rows[ConEmpl.dataGridView1.CurrentRow.Index].Cells[13].Value.ToString().Trim();

            //Asignando valores a nuestro formulario DATOS GENERALES
            TxtID.Text = id_empleado;
            TxtNombre.Text = ConEmpl.dataGridView1.Rows[ConEmpl.dataGridView1.CurrentRow.Index].Cells[1].Value.ToString().Trim();
            TxtApellidoPaterno.Text = ConEmpl.dataGridView1.Rows[ConEmpl.dataGridView1.CurrentRow.Index].Cells[2].Value.ToString().Trim();
            TxtApellidoMaterno.Text = ConEmpl.dataGridView1.Rows[ConEmpl.dataGridView1.CurrentRow.Index].Cells[3].Value.ToString().Trim();
            DtFechaNac.Text = ConEmpl.dataGridView1.Rows[ConEmpl.dataGridView1.CurrentRow.Index].Cells[4].Value.ToString().Trim();
            TxtEstadoCivil.Text = ConEmpl.dataGridView1.Rows[ConEmpl.dataGridView1.CurrentRow.Index].Cells[5].Value.ToString().Trim();
            TxtCurp.Text = ConEmpl.dataGridView1.Rows[ConEmpl.dataGridView1.CurrentRow.Index].Cells[6].Value.ToString().Trim();
            TxtRfc.Text = ConEmpl.dataGridView1.Rows[ConEmpl.dataGridView1.CurrentRow.Index].Cells[7].Value.ToString().Trim();
            TxtNss.Text = ConEmpl.dataGridView1.Rows[ConEmpl.dataGridView1.CurrentRow.Index].Cells[8].Value.ToString().Trim();
            TxtLugarNac.Text = ConEmpl.dataGridView1.Rows[ConEmpl.dataGridView1.CurrentRow.Index].Cells[9].Value.ToString().Trim(); ;
            TxtDomicilio.Text = ConEmpl.dataGridView1.Rows[ConEmpl.dataGridView1.CurrentRow.Index].Cells[10].Value.ToString().Trim();
            TxtTelefono.Text = ConEmpl.dataGridView1.Rows[ConEmpl.dataGridView1.CurrentRow.Index].Cells[11].Value.ToString().Trim();
            TxtCorreo.Text = ConEmpl.dataGridView1.Rows[ConEmpl.dataGridView1.CurrentRow.Index].Cells[12].Value.ToString().Trim();
            if (estatus == "True") { CbEstatus.Text = "Activo"; }
            else { CbEstatus.Text = "Inactivo"; }

            //Asignando fotografía
            DataSet ds = BuscarFoto(id_empleado.ToString().Trim()); //Obteniendo un DataSet con la posible ruta de la imagen, usando el proceso almacenado en nuestra BD

            try
            {
                string urlFoto = ds.Tables[0].Rows[0][0].ToString().Trim();
                PbFoto.Image = Image.FromFile(urlFoto);
            }//TRY 
            catch(Exception error)
            {
                MessageBox.Show("El empleado no tiene asignada una fotografía.");
            }//catch

        } // EditarExistente
    }
}
