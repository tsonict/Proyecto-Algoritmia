using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_ALGORITMIA
{

    /* Consideraciones para mejor entendimiento:
     * 
     * 1. Todos los objetos usados para facilitar el ingreso, consulta y modificacion de la informacion.
     * 2. Las funciones registro<NombreObjeto> son para tener un formato de escritura en los archivos.
     * 3. Todos los constructores que construyen el objeto a partir de un registro funcionan de la misma forma, en
     *    la clase cliente se explica como funciona, el resto son lo mismo, pero con mas campos.
     * 4. Las funciones muestra<NombreObjeto> son para el boton mostrar.
     * 5. Los getters y setters estan hechos como C# permite, como propiedades.
     * 6. Como delimitador de campo se eligio el "|", como delimitador de registro es el salto de linea.
     * */

    class Cliente
    {
        private int id;
        private string nombre;
        
        //Construye a partir de datos de Formulario
        public Cliente(int ID, string nombre)
        {
            id = ID;
            this.nombre = nombre;
        }

        //Construye a partir de un registro en archivo
        public Cliente(string registro)
        {
            string campo = "";
            string[] campos = new string[2];
            int contCampo = 0;

            //Un for que recorre toda la cadena que constituye el registro leido desde el archivo
            foreach(char caracter in registro.ToCharArray())
            {
                //Si el caracter no es un delimitador
                if(caracter != '|')
                {
                    //Se agrega un caracter al string campo
                    campo += caracter;
                }
                else
                {
                    //Cuando se topa con un delimitador, cadena se agrega al arreglo para preservar la cadena que tiene al campo
                    campos[contCampo++] = campo;
                    campo = "";
                    //Se restaura el valor de campo para seguir leyendo los demas campos
                }
            }

            /* Como nosotros definimos como se escriben los registros, sabemos en que indice del arreglo esta cada campo
             * campos[0] = ID del cliente
             * campos[1] = Nombre del empleado
             * */

            this.id = Convert.ToInt32(campos[0]);
            this.nombre = campos[1];
        }

        //Ejemplo de getter/setter
        public int ID { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }

        //Para el archivo
        public String registroCliente()
        {
            return $"{this.id}|{this.nombre}|";
        }

        //Para el boton mostrar, es un arreglo porque los TextBox no aceptan el caracter "\n"
        public string[] linesCliente()
        {
            string[] lineas = { $"ID: {this.id}", $"Nombre: {this.nombre}" };
            return lineas;
        }
    }

    class Producto
    {
        private int id;
        private string nombre;
        private double precio;
        private int ventas;

        public Producto(int ID, string Nombre, double Precio)
        {
            id = ID;
            nombre = Nombre;
            precio = Precio;
            ventas = 0;
        }

        public Producto(string registro)
        {
            string campo = "";
            string[] campos = new string[4];
            int contCampos = 0;

            foreach (char caracter in registro.ToCharArray())
            {
                if (caracter != '|')
                {
                    campo += caracter;
                }
                else
                {
                    campos[contCampos++] = campo;
                    campo = "";
                }
            }
            this.id = Convert.ToInt32(campos[0]);
            this.nombre = campos[1];
            this.precio = Convert.ToDouble(campos[2]);
            this.ventas = Convert.ToInt32(campos[3]);
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public double Precio { get => precio; set => precio = value; }
        public int Ventas { get => ventas; set => ventas = value; }

        public string registroProducto()
        {
            return $"{id}|{nombre}|{precio}|{ventas}|";
        }

        public string[] linesProducto()
        {
            string[] lines = { $"ID: {this.id}", $"Nombre: {this.nombre}"
                    , $"Precio: {this.precio}", $"Cantidad de ventas: {this.ventas}" };
            return lines;
        }
    }

    class Venta
    {
        private int id;
        private Fecha fecha;
        private int idCliente;
        private int idProducto;
        private double costo;
        private int cantV;

        public Venta(int ID, Fecha date, int costumer, int Sold, double coste, int cant)
        {
            id = ID;
            fecha = date;
            idCliente = costumer;
            idProducto = Sold;
            costo = coste;
            cantV = cant;
        }

        public Venta(string registro)
        {
            string campo = "";
            string[] campos = new string[8];
            int contCampos = 0;


            foreach (char caracter in registro.ToCharArray())
            {
                if (caracter == '|' || caracter == '/')
                {
                    campos[contCampos++] = campo;
                    campo = "";
                }
                else
                {
                    campo += caracter;
                }
            }
            this.id = Convert.ToInt32(campos[0]);
            Fecha date = new Fecha(Convert.ToInt32(campos[1]), Convert.ToInt32(campos[2]), Convert.ToInt32(campos[3]));
            this.fecha = date;
            this.idCliente = Convert.ToInt32(campos[4]);
            this.idProducto = Convert.ToInt32(campos[5]);
            this.costo = Convert.ToDouble(campos[6]);
            this.cantV = Convert.ToInt32(campos[7]);
        }

        public int Id { get => id; set => id = value; }
        public Fecha Fecha { get => fecha; set => fecha = value; }
        public int IdCliente { get => idCliente; set => idCliente = value; }
        public int IdProducto { get => idProducto; set => idProducto = value; }

        public string registroVenta()
        {
            return $"{id}|{fecha.Dia}/{fecha.Mes}/{fecha.Anio}|{idCliente}|{idProducto}|{costo}|{cantV}|";
        }

        public string[] linesVenta()
        {
            string[] lines = {$"ID venta: {id}", $"Fecha: {fecha.Dia}/{fecha.Mes}/{fecha.Anio}", $"ID Cliente: {idCliente}", 
                $"ID producto: {idProducto}", $"Coste total: {costo}", $"Unidades vendidas: {cantV}"};

            return lines; 
        }
    }

    class Encuesta
    {
        private int venta;
        private int g_satisfaccion;

        public Encuesta(int idV, int sas)
        {
            venta = idV;
            this.g_satisfaccion = sas; 
        }

        public Encuesta(string registro)
        {
            string[] campos = new string[2];
            string campo = "";
            int contCampos = 0;

            foreach (char caracter in registro.ToCharArray())
            {
                if (caracter == '|' || caracter == '/')
                {
                    campos[contCampos++] = campo;
                    campo = "";
                }
                else
                {
                    campo += caracter;
                }
            }
            this.venta = Convert.ToInt32(campos[0]);
            this.g_satisfaccion = Convert.ToInt32(campos[1]);
        }

        public int G_satisfaccion { get => g_satisfaccion; set => g_satisfaccion = value; }

        public int idVenta { get => this.venta; }

        public string registroEncuesta()
        {
            return $"{venta}|{g_satisfaccion}|";
        }

        public string[] linesEncuesta()
        {
            string[] lines = { $"ID Venta: {venta}", $"Grado satisfaccion: {g_satisfaccion}" };
            return lines;
        }
    }

    class Fecha
    {
        private int dia;
        private int mes;
        private int anio;

        public Fecha(int dia, int mes, int anio)
        {
            this.dia = dia;
            this.mes = mes;
            this.anio = anio;
        }

        public int Dia { get => dia; set => dia = value; }
        public int Mes { get => mes; set => mes = value; }
        public int Anio { get => anio; set => anio = value; }


    }
}
