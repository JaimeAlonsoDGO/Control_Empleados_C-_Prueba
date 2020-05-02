using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; //Espacio de nombre para conectar con SQLServer
using MiBiblioteca; //Espacio de nombre que contiene los métodos comunes

namespace ControlEmpleados
{
    public partial class VentanaLogin : VentanaBase
    {
        public VentanaLogin()
        {
            InitializeComponent();
        }



        private void BtnIniciar_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = new DataSet(); //Creamos un data set
                string cmd = string.Format("EXEC Iniciar_Sesion '{0}','{1}'", TxtUsuario.Text.ToString().Trim(), TxtContra.Text.ToString().Trim()); //Creamos la cadena de consulta
                ds = Utilidades.Ejecutar(cmd); //Rellenando DataSet con el resultado de la consulta

                //Guardando Usuario y contraseña en variables para comparacion
                string usuario = ds.Tables[0].Rows[0]["Usuario"].ToString().Trim();
                string contra = ds.Tables[0].Rows[0]["Password"].ToString().Trim();
                
                //Comparando valores de los TextBox con los obtenidos mediante la consulta
                if(usuario == TxtUsuario.Text.Trim() && contra == TxtContra.Text.Trim())
                {
                    ContenedorPrincipal ConPrincipal = new ContenedorPrincipal(); //Creando instancia de ContenedorPrincipal
                    this.Hide(); //Ocultando ventana de login
                    ConPrincipal.Show(); //Mostrando instancia ContenedorPrincipal  
                }//IF
            }//TRY
            catch (Exception error)
            {
                MessageBox.Show("Usuario y/o contraseña incorresctos."); //Mensaje en caso de error
                //Limpiamos los TxtBox para reingresar datos
                TxtUsuario.Text = "";
                TxtContra.Text = "";
                //Focus en el campo usuario para empezar a teclear
                TxtUsuario.Focus();
            }//CATCH
        }//BtnIniciar Clic



        private void VentanaLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); //Para cerrar la app
        }
    }
}
