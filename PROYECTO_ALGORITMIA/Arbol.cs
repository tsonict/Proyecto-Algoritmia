using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace PROYECTO_ALGORITMIA
{
    class Arbol
    {
        private Nodo root;
        private int contNodos;

        public Arbol()
        {
            this.root = null;
            contNodos = 0;
        }

        public Producto Busqueda(Nodo Raiz, int grado)
        {
            if (Raiz == null)
                return null;
            else
            {
                if (grado == Raiz.Grado)
                    return Raiz.Producto;
                else if (grado < Raiz.Grado)
                    return Busqueda(Raiz.hijoIzquierdo, grado);
                else
                    return Busqueda(Raiz.hijoDerecho, grado);
            }

        }

        public void insertaNodo(Nodo Raiz, Nodo nuevo)
        {
            if (Raiz == null)
                this.root = nuevo;
            else
            {
                if (Raiz.Grado > nuevo.Grado)
                {
                    if (Raiz.hijoIzquierdo == null)
                    {
                        Raiz.hijoIzquierdo = nuevo;
                        contNodos++;
                    }
                    else
                        insertaNodo(Raiz.hijoIzquierdo, nuevo);
                }
                else
                {
                    if (Raiz.hijoDerecho == null)
                    {
                        Raiz.hijoDerecho = nuevo;
                        contNodos++;
                    }
                    else
                        insertaNodo(Raiz.hijoDerecho, nuevo);
                }
            }
        }

        public Nodo Raiz { get => this.root; }

        public int ContNodos { get => this.contNodos; }
    }

    class Nodo
    {
        private Nodo izq;
        private Nodo der;
        private Producto dato;
        private Encuesta dato2;

        public Nodo(Encuesta dato2, Producto dato)
        {
            izq = null;
            der = null;
            this.dato2 = dato2;
            this.dato = dato;
        }

        public Nodo(Nodo nodo)
        {
            izq = nodo.hijoIzquierdo;
            der = nodo.hijoDerecho;
            dato2 = nodo.Encuesta;
            dato = nodo.Producto;
        }

        public Nodo hijoIzquierdo { get => izq; set => izq = value; }

        public Nodo hijoDerecho { get => der; set => der = value; }

        public int Grado { get => dato2.G_satisfaccion; }

        public Producto Producto { get => this.dato; }

        public Encuesta Encuesta { get => this.dato2; }
    }
}
