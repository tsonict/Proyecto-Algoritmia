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
    public partial class MainForm : Form
    {
        private string entidadActual;

        //Macro para tener a mano siempre la ruta del archivo
        private const string ruta = @"C:\Carpeta-Archivos-Proyecto-Equipo7";

        //Macros para los archivos de texto en forma de arreglo
        private string[] archivos = { Path.Combine(ruta, "Clientes.txt"), Path.Combine(ruta, "Productos.txt"),
            Path.Combine(ruta, "Ventas.txt"), Path.Combine(ruta, "Encuestas.txt") };
        private bool orden;

        public MainForm()
        {
            InitializeComponent();
            entidadActual = "";
            orden = false;
        }

        private string EntidadActual()
        {
            if (rB_Cliente.Checked == true)
                return "Cliente";
            else if (rB_Prod.Checked == true)
                return "Producto";
            else if (rB_Venta.Checked == true)
                return "Venta";
            else
                return "Encuesta";
        }

        //Esto ocurre cada vez que se inicia el programa
        private void MainForm_Load(object sender, EventArgs e)
        {
            //Bandera Booleana
            bool creados = false; 

            foreach(string nombres in archivos)
            {   //Verifica que absolutamente todos los archivos existan
                if (File.Exists(Path.Combine(ruta, nombres)))
                    creados = true;
            }

            if(!creados)
            {
                //Si no existe ninguno, los crea todos en una carpeta distintiva en el Disco C
                Directory.CreateDirectory(ruta);
                foreach(string archivo in archivos)
                {
                    string arc = Path.Combine(ruta, archivo);
                    FileStream a = File.Create(arc);
                    a.Close();
                }
            }
        }

        //Función del botón Capturar
        private void btn_Capturar_Click(object sender, EventArgs e)
        {
            //Se obtiene la entidad que se quiere hacer un nuevo registro
            entidadActual = EntidadActual();
            StreamWriter escritura;

            //Con un Switch hacemos los casos según la entidad elegida
            switch (entidadActual)
            {

                /*
                 * En todos los casos se repite lo mismo.
                 * Se abre un formulario dedicado a recopilar la informacion, se crea una instancia de la entidad en cuestion
                 * Y se escribe su infomracion en su archivo correspondiente
                 * */

                case "Cliente":
                {
                    FormCliente form = new FormCliente();
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        Random aleatorio = new Random(Environment.TickCount);
                        Cliente nuevo = new Cliente(aleatorio.Next(1000, 9999), form.getNombre());

                        escritura = new StreamWriter(archivos[0], true);
                        escritura.WriteLine(nuevo.registroCliente());
                        escritura.Close();
                    }
                    else
                        return;
                    break;
                }
                case "Producto":
                 {
                    FormProducto form = new FormProducto();
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        Random aleatorio = new Random(Environment.TickCount);
                        Producto nuevo = new Producto(aleatorio.Next(10000, 99999), form.getNombre(), form.getPrecio());

                        escritura = new StreamWriter(archivos[1], true);
                        escritura.WriteLine(nuevo.registroProducto());
                        escritura.Close();
                    }
                    else
                        return;
                    break;
                 }
                case "Venta": 
                {
                    FormVenta form = new FormVenta(archivos[0], archivos[1], orden);
                    if(form.ShowDialog() == DialogResult.OK && form.ventaValida())
                    {
                        Random aleatorio = new Random(Environment.TickCount);
                        DateTime today = DateTime.Now;
                        Fecha fecha = new Fecha(today.Day, today.Month, today.Year);
                        Venta nuevo = new Venta(aleatorio.Next(10000, 99999), fecha, form.idCliente(), form.idProducto(), form.costoT(), form.vendidos());

                        escritura = new StreamWriter(archivos[2], true);
                        escritura.WriteLine(nuevo.registroVenta());
                        escritura.Close();
                        actualizarProducto(archivos[1], form.productoActualizado());
                    }
                    break;
                }
                case "Encuesta":
                {
                    FormEncuesta form = new FormEncuesta(archivos[2], true);
                    if(form.ShowDialog() == DialogResult.OK)
                    {
                        Encuesta nuevo = new Encuesta(form.idVenta(), form.gradoS());

                        escritura = new StreamWriter(archivos[3], true);
                        escritura.WriteLine(nuevo.registroEncuesta());
                        escritura.Close();
                    }
                    break;
                }
            }

            orden = false;
        }

        private void btn_Orden_Click(object sender, EventArgs e)
        {
            ordenarArchivos();
            MessageBox.Show("Todos los archivos han sido ordenados.", "Orden", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btn_Mostrar_Click(object sender, EventArgs e)
        {
            entidadActual = EntidadActual();
            FormMostrar ventana;
            switch (entidadActual)
            {
                case "Cliente":
                    {
                        ventana = new FormMostrar(archivos[0], 0);
                        ventana.Show();
                        break;
                    }
                case "Producto":
                    {
                        ventana = new FormMostrar(archivos[1], 1);
                        ventana.Show();
                        break;
                    }
                case "Venta":
                    {
                        ventana = new FormMostrar(archivos[2], 2);
                        ventana.Show();
                        break;
                    }
                case "Encuesta":
                    {
                        ventana = new FormMostrar(archivos[3], 3);
                        ventana.Show();
                        break;
                    }
            }
        }

        private void btn_Modificar_Click(object sender, EventArgs e)

        {
            string entidad = EntidadActual();
            FormModificar form;

            switch (entidad)
            {
                case "Cliente":
                    form = new FormModificar(archivos[0], entidad);
                    form.Show();
                    break;

                case "Producto":
                    form = new FormModificar(archivos[1], entidad);
                    form.Show();
                    break;

                case "Venta":
                    form = new FormModificar(archivos[2], entidad, archivos[0], archivos[1]);
                    form.Show();
                    break;

                case "Encuesta":
                    form = new FormModificar(archivos[3], entidad);
                    form.Show();
                    break;
            }


        }

        private void btn_AVL_Click(object sender, EventArgs e)
        {
            FormAVL form = new FormAVL(archivos[1], archivos[3], archivos[2]);
            form.Show();
        }
        

        private void ordenarArchivos()
        {
            //Cambiamos la bandera booleana a True
            orden = true;
            //Con un bucle nos aseguramos de ordenar todos los archivos
            foreach (string archivo in archivos)
            {
                //Convertimos todas las lineas del registro en un List
                List<string> registros = new List<string>(File.ReadAllLines(archivo));
                if (registros.Count == 0)
                    continue;

                /*
                 * Si la lista tiene 0 elementos, significa que esta vacio y se salta al siguiente
                 * Caso contrario, aplica el ordenamiento a la lista y reescribira entero el archivo 
                 * a partir de la lista ordenada
                 * */

                registros = Algoritmo.MergeSort(registros);
                File.WriteAllLines(archivo, registros.ToArray());
            }
        }

        private void actualizarProducto(string path, string nuevoP)
        {
            List<string> registros = new List<string>(File.ReadAllLines(path));
            string registroViejo = Algoritmo.BusquedaBinaria(Algoritmo.idRegistro(nuevoP).ToString(), path);

            registros.Remove(registroViejo);
            registros.Add(nuevoP);

            registros = Algoritmo.MergeSort(registros);

            File.WriteAllLines(path, registros.ToArray());
        }

    }
}
