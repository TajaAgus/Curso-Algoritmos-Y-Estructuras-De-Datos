using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp.Trees
{
    public class Nodo
    {
        public string Dato { get; set; }
        public Nodo Hijo { get; set; }
        public Nodo Hermano { get; set; }

        public Nodo()
        {
            Dato = "";
            Hijo = null;
            Hermano = null;

        }
    }
    public class GenericTree
    {
        private Nodo raiz;
        private Nodo trabajo;
        private int i = 0;

        public GenericTree()
        {
            raiz = new Nodo();
        }

        public Nodo Insertar(string dato, Nodo nodo)
        {
            if (nodo == null)
            {
                raiz = new Nodo();
                raiz.Dato = dato;

                raiz.Hijo = null;

                raiz.Hermano = null;

                return raiz;
            }

            if (nodo.Hijo == null)
            {
                Nodo temp = new Nodo();
                temp.Dato = dato;

                nodo.Hijo = temp;

                return temp;
            }
            else
            {
                trabajo = nodo.Hijo;

                while (trabajo.Hermano != null)
                {
                    trabajo = trabajo.Hermano;
                }

                Nodo temp = new Nodo();

                temp.Dato = dato;

                trabajo.Hermano = temp;

                return temp;
            }
        }
        public void TransversaPreO(Nodo nodo)
        {
            //Caso base
            if (nodo == null)
                return;

            for (int n = 0; n < i; n++)
                Console.Write(" ");

            Console.WriteLine(nodo.Dato);

            //Caso inductivo
            if (nodo.Hijo != null)
            {
                i++;
                TransversaPreO(nodo.Hijo);
                i--;
            }

            //Caso inductivo
            if (nodo.Hermano != null)
                TransversaPreO(nodo.Hermano);
        }
        public void TransversaPostO(Nodo nodo)
        {
            //Caso base
            if (nodo == null)
                return;

            //Caso inductivo
            if (nodo.Hijo != null)
            {
                i++;
                TransversaPostO(nodo.Hijo);
                i--;
            }

            //Caso inductivo
            if (nodo.Hermano != null)
                TransversaPostO(nodo.Hermano);

            for (int n = 0; n < i; n++)
                Console.Write(" ");

            Console.WriteLine(nodo.Dato);
        }
        public Nodo Buscar(string dato, Nodo nodo)
        {
            Nodo encontrado = null;

            if (nodo == null)
                return encontrado;

            //Caso Base
            if (nodo.Dato.CompareTo(dato) == 0)
            {
                encontrado = nodo;
                return encontrado;
            }

            if (nodo.Hijo != null)
            {
                encontrado = Buscar(dato, nodo.Hijo);

                if (encontrado != null)
                    return encontrado;
            }

            if (nodo.Hermano != null)
            {
                encontrado = Buscar(dato, nodo.Hermano);

                if (encontrado != null)
                    return encontrado;
            }

            return encontrado;
        }
    }
}
