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
    public partial class FormModificar : Form
    {
        private Cliente modC;
        private Producto modP;
        private Venta modV;
        private Encuesta modE;
        private List<string> registros, regC, regP;
        string path, entidad, regActual;


        public FormModificar(string path, string entidad, string arC = null, string arP = null)
        {
            InitializeComponent();
            labelAviso.Text = "";
            this.path = path;
            this.entidad = entidad;
            registros = new List<string>(System.IO.File.ReadAllLines(path));

            if(entidad == "Cliente")
            {
                lEntidad.Text = $"Modificando registros de: {entidad}";
                textBoxNombre.Enabled = true;
            }
            else if(entidad == "Producto")
            {
                lEntidad.Text = $"Modificando registros de: {entidad}";
                textBoxNombre.Enabled = true;
                textBoxPrecio.Enabled = true;
            }
            else if(entidad == "Venta")
            {
                lEntidad.Text = $"Modificando registros de: {entidad}";
                nudDIA.Enabled = true;
                nudMes.Enabled = true;
                nudAnio.Enabled = true;
                textBoxIDC.Enabled = true;
                textBoxIDP.Enabled = true;
                regP = new List<string>(System.IO.File.ReadAllLines(arP));
                regC = new List<string>(System.IO.File.ReadAllLines(arC));
            }
            else
            {
                lEntidad.Text = $"Modificando registros de: {entidad}";
                nudGS.Enabled = true;
            }

        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            string reg = Algoritmo.BusquedaBinaria(textBoxID.Text, path);
            regActual = reg;
            if (reg == null) return;

            switch (entidad)
            {
                case "Cliente":
                    modC = new Cliente(reg);
                    textBoxNombre.Text = modC.Nombre;
                    break;
                case "Producto":
                    modP = new Producto(reg);
                    textBoxNombre.Text = modP.Nombre;
                    textBoxPrecio.Text = modP.Precio.ToString();
                    break;
                case "Venta":
                    modV = new Venta(reg);
                    nudDIA.Value = Convert.ToDecimal(modV.Fecha.Dia);
                    nudMes.Value = Convert.ToDecimal(modV.Fecha.Mes);
                    nudAnio.Value = Convert.ToDecimal(modV.Fecha.Anio);
                    textBoxIDC.Text = modV.IdCliente.ToString();
                    textBoxIDP.Text = modV.IdProducto.ToString();
                    break;
                case "Encuesta":
                    modE = new Encuesta(reg);
                    nudGS.Value = Convert.ToDecimal(modE.G_satisfaccion);
                    break;
            }

            labelAviso.Text = "Puede usar esta casilla para modificar el ID";
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            string nuevo = "";
            switch(entidad)
            {
                case "Cliente":
                    modC.Nombre = textBoxNombre.Text;
                    modC.ID = Convert.ToInt32(textBoxID.Text);
                    nuevo = modC.registroCliente();
                    break;

                case "Producto":
                    modP.Id = Convert.ToInt32(textBoxID.Text);
                    modP.Nombre = textBoxNombre.Text;
                    modP.Precio = Convert.ToDouble(textBoxPrecio.Text);
                    nuevo = modP.registroProducto();
                    break;

                case "Venta":
                    modV.Id = Convert.ToInt32(textBoxID.Text);
                    modV.Fecha.Dia = Convert.ToInt32(nudDIA.Value);
                    modV.Fecha.Mes = Convert.ToInt32(nudMes.Value);
                    modV.Fecha.Anio = Convert.ToInt32(nudAnio.Value);

                    string cliente = Algoritmo.BusquedaBinaria(textBoxIDC.Text, null, regC);
                    string producto = Algoritmo.BusquedaBinaria(textBoxIDP.Text, null, regP);

                    if(cliente != null && producto != null)
                    {
                        modV.IdCliente = Convert.ToInt32(textBoxIDC.Text);
                        modV.IdProducto = Convert.ToInt32(textBoxIDP.Text);
                    }
                    else
                    {
                        MessageBox.Show("ID de cliente o producto no encontrado.", 
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    nuevo = modV.registroVenta();
                    break;

                case "Encuesta":
                    modE.G_satisfaccion = Convert.ToInt32(nudGS.Value);
                    nuevo = modE.registroEncuesta();
                    break;
            }

            registros.Remove(regActual);
            registros.Add(nuevo);

            registros = Algoritmo.MergeSort(registros);

            System.IO.File.WriteAllLines(path, registros.ToArray());

        }
    }
}
