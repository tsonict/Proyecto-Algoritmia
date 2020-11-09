using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_ALGORITMIA
{
    /*
     * El proposito de esta clase es tener un lugar donde tener las implementaciones de los algoritmos que se vayan a realizar
     * y por sobre todo, poder llamarlos en cualquier parte del proyecto mediante el uso de los metodos estaticos
     * */

    class Algoritmo
    {
        public static int  idRegistro(string registro)
        {

            /*
             * En todos los registros, lo primero que esta es siempre el ID ya sea del cliente, producto, venta, etc
             * Atributo que use como llave primaria y criterio de ordenamiento
             * Esta funcion lee los caracteres que corresponden a esta llave primaria hasta que se topa con el delimitador "|"
             * y lo convierte en entero
             * */

            string nueva = "";
            foreach (char car in registro.ToCharArray())
            {
                if (car.Equals('|'))
                    break;
                else
                    nueva += car;
            }
            return Convert.ToInt32(nueva);
        }


        public static string BusquedaBinaria(string id, string path = null, List<string> reg = null)
        {
            string[] registros = (reg == null) ? System.IO.File.ReadAllLines(path) : reg.ToArray();

            int L = 0;
            int R = registros.Length - 1;
            int mitad, actual, buscado = Convert.ToInt32(id);

            while(L <= R)
            {
                mitad = L + (R - L) / 2;
                actual = idRegistro(registros[mitad]);

                if (actual == buscado) 
                    return registros[mitad];

                if (actual < buscado) 
                    L = mitad + 1;
                else 
                    R = mitad - 1;
            }
            return null;
        }


        /* Este es el Merge Sort que el compañero mandó al grupo de WhatsApp
         * Simplemente lo adapte para que funcione con los archivos
         * */

        public static List<string> MergeSort(List<string> original)
        {
            if (original.Count <= 1)  
                return original;

            List<string> izquierda = new List<string>();
            List<string> derecha = new List<string>();

            //Se divide el arreglo por la mitad
            int medio = original.Count / 2;
            for (int i = 0; i < medio; i++)
            {
                izquierda.Add(original[i]);
            }

            for (int i = medio; i < original.Count; i++)
            {
                derecha.Add(original[i]);
            }

            //Acciones recursivas
            izquierda = MergeSort(izquierda);
            derecha = MergeSort(derecha);
            return Merge(izquierda, derecha);
        }

        private static List<string> Merge(List<string> izquierda, List<string> derecha)
        {
            List<string> aFinal = new List<string>();

            //Mientras haya elementos que comparar
            while (izquierda.Count > 0 || derecha.Count > 0)
            {
                if (izquierda.Count > 0 && derecha.Count > 0)
                {
                    if (idRegistro(izquierda.First()) <= idRegistro(derecha.First()))
                    {
                        aFinal.Add(izquierda.First());
                        izquierda.Remove(izquierda.First());
                    }
                    else
                    {
                        aFinal.Add(derecha.First());
                        derecha.Remove(derecha.First());
                    }
                }
                else if (izquierda.Count > 0)
                {
                    aFinal.Add(izquierda.First());
                    izquierda.Remove(izquierda.First());
                }
                else if (derecha.Count > 0)
                {
                    aFinal.Add(derecha.First());
                    derecha.Remove(derecha.First());
                }
            }
            return aFinal;
        }
    }

}
