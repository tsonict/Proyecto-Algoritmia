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
    public partial class FormEncuesta : Form
    {
        private string arVentas;
        private bool orden;
        private int grado, idV;

        public FormEncuesta(string path, bool orden)
        {
            InitializeComponent();
            arVentas = path;
            this.orden = orden;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string regVenta = Algoritmo.BusquedaBinaria(textBox_Venta.Text, arVentas);
            if(regVenta != null)
            {
                idV = Algoritmo.idRegistro(regVenta);
                grado = Convert.ToInt32(numUD_grado.Value);
            }
            else
                this.DialogResult = DialogResult.Abort;
            
            this.Close();
        }

        public int idVenta() => idV;

        public int gradoS() => grado;
    }
}
