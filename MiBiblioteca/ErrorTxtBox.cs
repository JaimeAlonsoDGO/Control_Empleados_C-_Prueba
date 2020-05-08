using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiBiblioteca
{
    public partial class ErrorTxtBox : TextBox
    {
        public ErrorTxtBox()
        {
            InitializeComponent();
        }

        public Boolean Validar //Propiedad para validar campos vacios
        {
            set;
            get;
        }//Validar

        public Boolean SoloNumeros //Validamos que solo sean numeros
        {
            set;
            get;
        }//SoloNumeros

        public Boolean MaximoPermitido
        {
            set;
            get;
        }//MaximoPermitido
    }
}
