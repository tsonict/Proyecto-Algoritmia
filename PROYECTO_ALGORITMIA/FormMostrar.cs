using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PROYECTO_ALGORITMIA
{
    public partial class FormMostrar : Form
    {
        private int tipo;
        private string path;
        private List<string> registros;

        //Path es la ruta del archivo cuyos registros se van a mostrar y tipo una bandera para saber que tipo de registeo mostrar
        public FormMostrar(string path, int tipo)
        {
            InitializeComponent();
            this.path = path;
            //Toma todos los registros y los guarda en un arreglo
            registros = new List<string>(File.ReadAllLines(path));
            this.tipo = tipo;
        }

        //Cada vez que se arrastre el scroll se mostrará un registro
        private void Deslizadora_Scroll(object sender, ScrollEventArgs e)
        {
            string mostrado = registros[Deslizadora.Value];
            Mostrar(mostrado);
        }

        private void Mostrar(string registro)
        {
            switch (tipo)
            {
                case 0:
                    {
                        Cliente mostrado = new Cliente(registro);
                        textMostrar.Lines = mostrado.linesCliente();
                        break;
                    }
                case 1:
                    {
                        Producto mostrado = new Producto(registro);
                        textMostrar.Lines = mostrado.linesProducto();
                        break;
                    }
                case 2:
                    {
                        Venta mostrado = new Venta(registro);
                        textMostrar.Lines = mostrado.linesVenta();
                        break;
                    }
                case 3:
                    {
                        Encuesta mostrado = new Encuesta(registro);
                        textMostrar.Lines = mostrado.linesEncuesta();
                        break;
                    }
            }

        }

        private void FormMostrar_Load(object sender, EventArgs e)
        {
            if (registros.Count > 0)
            {
                Deslizadora.Minimum = 0;
                Deslizadora.Maximum = registros.Count - 1;
                Deslizadora.Value = 0;
                Mostrar(registros[0]);
            }
            else
            {
                MessageBox.Show("No hay registros que mostrar", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string buscado = Algoritmo.BusquedaBinaria(textBuscar.Text, path);
            if (buscado != null)
                Mostrar(buscado);
            else
                return;
        }
    }
}
