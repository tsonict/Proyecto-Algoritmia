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
        string entidadActual;

        public MainForm()
        {
            InitializeComponent();
            entidadActual = "";
        }
        
        //Para que los botones sepan que entidad modificar
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

        private void MainForm_Load(object sender, EventArgs e)
        {
            //Abrir el archivo ya creado en modo de escritura
            StreamWriter aClientes = new StreamWriter("Clientes.txt", true);

            //Nuestros bonitos factores RNG
            Random indice = new Random(Environment.TickCount);
            Random factorDecisivo = new Random(Environment.TickCount);
            int ID = 1;
            int num;

            //Nombres de clientes que serán elegios al azar
            string[] masculinos = {"Dante", "Pedro", "Jesus", "Beto", "Martin", "Luis", "Arturo", "Felipe", "Diego", "Brandon", "Carlos", "Kevin" };
            string[] femeninos = {"Diana", "Vanessa", "Erica", "Sara", "Aurora", "Sofia", "Fernanda", "Patricia", "Ana", "Rosa", "Denisse", "Paula" };

            //Llenar el Archivo con 200 clientes
            for(int i = 0; i < 200; i++)
            {
                //Generar un numero aleatorio al azar entre 1 y 10
                num = factorDecisivo.Next(1, 10);
                if(num % 2 == 0)
                {
                    //Si es par, creamos cliente masculino y se escribe
                    Cliente nuevo = new Cliente(ID++, masculinos[indice.Next(0,11)]);
                    aClientes.WriteLine(nuevo.registroCliente());
                }
                else
                {
                    //Impar, cliente femenino y es escrito
                    Cliente nuevoF = new Cliente(ID++, femeninos[indice.Next(0, 11)]);
                    aClientes.WriteLine(nuevoF.registroCliente());
                }
            }
        }
    }
}
