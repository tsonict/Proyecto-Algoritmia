using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using System.Diagnostics;

namespace PROYECTO_ALGORITMIA
{
    public partial class FormAVL : Form
    {
        private string pathPR, pathEn;
        private Arbol AVL;

        public FormAVL(string pathPR, string pathEN, string pathVE)
        {
            InitializeComponent();

            List<string> encuestas = new List<string>(System.IO.File.ReadAllLines(pathEN));
            List<string> ventas = new List<string>(System.IO.File.ReadAllLines(pathVE));
            List<string> productos = new List<string>(System.IO.File.ReadAllLines(pathPR));
            List<Nodo> nodos = new List<Nodo>();

            foreach (string encuesta in encuestas)
            {
                Encuesta en = new Encuesta(encuesta);
                Venta venta = new Venta(Algoritmo.BusquedaBinaria(en.idVenta.ToString(), null, ventas));
                Producto prod = new Producto(Algoritmo.BusquedaBinaria(venta.IdProducto.ToString(), null, productos));

                nodos.Add(new Nodo(en, prod));
            }

            Stopwatch sw = new Stopwatch();
            TimeSpan ts;
            AVL = new Arbol();

            sw.Start();

            foreach (Nodo node in nodos)
                AVL.insertaNodo(AVL.Raiz, node);

            sw.Stop();
            ts = sw.Elapsed;
            label1.Text = ts.Seconds.ToString();
        }

        private void FormAVL_Load(object sender, EventArgs e)
        {
            if(AVL.ContNodos == 0)
            {
                MessageBox.Show("No hay encuestas para tener nodos en el árbol."
                    , "Árbol vacío", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            AVL = null;
            this.Close();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            Stopwatch s = new Stopwatch();

            int grado = Convert.ToInt32(nud_Grado.Value);
            Nodo aux = new Nodo(AVL.Raiz);

            s.Start();
            Producto producto = AVL.Busqueda(aux, grado);
            s.Stop();

            TimeSpan timeSpan = s.Elapsed;
            label1.Text = timeSpan.TotalMilliseconds.ToString();

            if (producto != null)
                textBoxMostrar.Lines = producto.linesProducto();
            else
                MessageBox.Show("Ningun producto con ese grado fue encontrado"
                    ,"No encontrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }
    }
}
