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
    public partial class FormProducto : Form
    {
        private string nombre;
        private double precio;

        public FormProducto()
        {
            InitializeComponent();
        }

        //Un mensaje que proporciona informacion
        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El IDE del producto se genera al azar.\nPreferible " +
                "indicar el precio del producto con decimales.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            /* El Try Catch valida que el formato este bien
             * Con bien se refiere a que el Nombre no este vacio y no haya caracteres alfabeticos en el precio
             * */
            try
            {
                nombre = textBox_Nombre.Text;
                if (nombre == null)
                    throw new FormatException();
                precio = Convert.ToDouble(textBox_Precio.Text);
                this.Close();
            }
            catch(FormatException)
            {
                MessageBox.Show("Error de formato.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.Abort;
            }
        }

        //Getters para tener la informacion generada aqui en la MainForm

        public string getNombre() => this.nombre;

        public double getPrecio() => this.precio;
    }
}
