using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_ALGORITMIA
{
    public partial class FormCliente : Form
    {
        private string nombre;

        public FormCliente()
        {
            InitializeComponent();
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            //Si se ingresa una cadena vacia, no se escribira nada

            if (textBox_Nombre.Text == null)
                this.DialogResult = DialogResult.Abort;
            else
                this.nombre = textBox_Nombre.Text;

            this.Close();
        }

        //Getter para tener el nombre ingresado en MainFiorm

        public string getNombre() => this.nombre;
        
    }
}
