using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data; //Espacio de nombre para usar DataSet
using System.Data.SqlClient; //Espacio de nombre para la conexion
using System.Windows.Forms; //Espacio de nombre para configurar los ErrorTxtBox

namespace MiBiblioteca
{
    public class Utilidades
    {
        public static DataSet Ejecutar (string cmd) //Método para realizar la conexion y ejecutar las consultas SQL, recibe de parametro una cadena string, que contiene la instruccion SQL
        {

            //Creando la cadena de conexión con la información de nuestro servidor
            SqlConnection Con = new SqlConnection("Data Source=.;Initial Catalog=AdministraciónEmpleados;Integrated Security=True");
            Con.Open();//Abrimos la conexión

            DataSet DS = new DataSet(); //Creando instancia de DataSet
            SqlDataAdapter DP = new SqlDataAdapter(cmd, Con); //Adaptador SQL que recibe como parametros nuestra cadena string y la conexion creada

            DP.Fill(DS); //Realiza el llenado de nuestro DataSet con el resultado de nuestra consulta

            Con.Close(); //Cerramos la conexion
            return DS; // Devolvemos el DataSet ya llenado
        }//Ejecutar


        public static Boolean ValidarFormulario(Control Objeto, ErrorProvider ErrorProvider) //Metodo para validar que los ErrorTxtBox n estén vacios en campos obligatorios
        {
            Boolean HayErrores = false; // variable de control

            //Estructura para recorrer cada item en el formulario
            foreach (Control Item in Objeto.Controls)
            {
                if (Item is ErrorTxtBox) //Si el objeto es un ErrorTxtBox
                {
                    ErrorTxtBox Obj = (ErrorTxtBox)Item; //Instanciamos un ErrorTxtBox
                    if (Obj.Validar == true) //Si está activada la propiedad Validar
                    {
                        if (String.IsNullOrEmpty(Obj.Text.Trim())) //Si el texto del ErrorTxtBox es nulo o vacio
                        {
                            ErrorProvider.SetError(Obj, "Campo Obligatorio"); //Utilizando ErrorProvider para mencionar que el campo vacio es obligatorio
                            HayErrores = true; //Cambiamos el valor de nuestra variable a true
                        }
                    }//IF

                    if (Obj.SoloNumeros == true) //Validando propiedad SoloNumeros
                    {
                        int contador = 0; //Variable de control

                        foreach (char letra in Obj.Text.Trim()) //Recorriendo letra por letra
                        {
                            if(char.IsLetter(Obj.Text.Trim(), contador) == true) //Si caracter es letra
                            {
                                HayErrores = true;
                                ErrorProvider.SetError(Obj, "Solo números"); //Imprimimos el error al haber localizado una letra en la cadena
                                break;
                            }
                            contador++;
                        } //ForEach

                    }//IF Solo numeros

                    if(Obj.MaximoPermitido == true) //Validand propiedad MaximoPermitido
                    {
                        if (Obj.Text.Length > 200)
                            HayErrores = true;
                        ErrorProvider.SetError(Obj, "Se deben ingresar menos de 200 caracteres");

                    }//IF
                }//IF
            }//ForEach
            return HayErrores; //Devolvemos nuestra variable
        }//Validar formulario

    }//Utilidades
}//Biblioteca
