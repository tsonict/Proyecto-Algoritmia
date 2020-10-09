using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_ALGORITMIA
{
    class Cliente
    {
        private int id;
        private string nombre;

        public Cliente(int ID, string nombre)
        {
            id = ID;
            this.nombre = nombre;
        }

        public int ID { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }

        public String registroCliente()
        {
            return $"{this.id}|{this.nombre}";
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


    }

    class Venta
    {
        private int id;
        private Fecha fecha;
        private Cliente cliente;
        private Producto producto;

        public Venta(int ID, Fecha date, Cliente costumer, Producto Sold)
        {
            id = ID;
            fecha = date;
            cliente = costumer;
            producto = Sold;
        }
    }

    class Encuesta
    {
        private Venta venta;
        private int g_satisfaccion;

        public Encuesta(Venta sell, int sas)
        {
            venta = sell;
            this.g_satisfaccion = sas; 
        }
    }

    class Fecha
    {
        private int dia;
        private int mes;
        private int anio;

        public Fecha()
        {
            Random dia = new Random(Environment.TickCount);
            Random mes = new Random(Environment.TickCount-1);

            this.mes = mes.Next(1, 12);
            if (this.mes == 2)
                this.dia = dia.Next(1, 28);
            else if (this.mes == 1 || this.mes == 3 || this.mes == 5 || this.mes == 7 || this.mes == 8 || this.mes == 10 || this.mes == 12)
                this.dia = dia.Next(1, 31);
            else
                this.dia = dia.Next(1, 30);

            this.anio = 2020;
        }

        public Fecha(int dia, int mes, int anio)
        {
            this.dia = dia;
            this.mes = mes;
            this.anio = anio;
        }
    }
}
