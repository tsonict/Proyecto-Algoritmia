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
    public partial class FormVenta : Form
    {
        private string arClientes;
        private string arProductos, nuevoP;
        private bool cExiste, pExiste, orden;
        private int idC, idP, sold;
        private double coste;

        public FormVenta(string path, string path2, bool ordenado)
        {
            InitializeComponent();
            arClientes = path;      //Ruta del archivo de clientes
            arProductos = path2;    //Ruta del archivo de productos
            cExiste = false;
            pExiste = false;
            orden = ordenado;       //Bandera booleana para verificar que esten en orden los archivos
        }

        //Bandera Booleana para asegurar una venta valida en MainForm
        public bool ventaValida() => cExiste && pExiste;

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //Si una cadena esta vacia o los archivos desordenados, no se hace nada

            if ((txtCln.Text == null || txtProd.Text == null))
            {
                MessageBox.Show("Registros no ordenados o falto llenar un campo","Error");
                this.DialogResult = DialogResult.Abort;
                this.Close();
            }

            //Se realizan ambas busquedas binarias

            string regCliente = Algoritmo.BusquedaBinaria(txtCln.Text, arClientes);
            string regProducto = Algoritmo.BusquedaBinaria(txtProd.Text, arProductos);

            if (regCliente != null && regProducto != null)
            {
                /* Si ambos registros fueron encontrados, se cambian las banderas booleanas
                 * y se asignan los ID para la escritura en MainForm
                 * */
                cExiste = true;
                pExiste = true;
                idC = Algoritmo.idRegistro(regCliente);
                idP = Algoritmo.idRegistro(regProducto);
                Producto vendido = new Producto(regProducto);
                sold = Convert.ToInt32(nudVentas.Value);
                coste = vendido.Precio * sold;
                vendido.Ventas += sold;

                nuevoP = vendido.registroProducto();
            }
            else
            {
                MessageBox.Show("Un ID no fue encontrado.", "Advertencia");
                this.DialogResult = DialogResult.Abort;
            }

            this.Close();
        }

        //Getters para tener la informacion en MainForm

        public int idCliente() => idC;

        public int idProducto() => idP;

        public int vendidos() => sold;

        public double costoT() => this.coste;

        public string productoActualizado() => nuevoP;
    }
}
