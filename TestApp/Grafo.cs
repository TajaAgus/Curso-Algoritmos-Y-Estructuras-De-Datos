using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    public class Grafo
    {
        int[,] mAdyacencia;
        int[] indegree;
        int nodos;

        public Grafo(int nodos)
        {
            this.nodos = nodos;
            mAdyacencia = new int[nodos, nodos];
            indegree = new int[nodos];
        }

        public void AdicionarArista(int nodoIncio, int nodoFinal)
        {
            mAdyacencia[nodoIncio, nodoFinal] = 1;
        }

        public void MuestraAdyacencia()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            for (int i = 0; i < nodos; i++)
                Console.Write("\t{0}", i);
            
            Console.WriteLine();

            for (int i = 0; i < nodos; i++)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(i);
                for (int j = 0; j < nodos; j++)
                {
                    Console.ForegroundColor = ConsoleColor.Green;

                    Console.Write("\t{0}", mAdyacencia[i,j]);
                }
                Console.WriteLine();
            }
            
        }
        public void CalcularIndegree()
        {
            for (int i = 0; i < nodos; i++)
            {
                for (int j = 0; j < nodos; j++)
                {
                    if (mAdyacencia[j, i] == 1)
                        indegree[i]++;
                }
            }
        }

        public void MostrarIndegree()
        {
            Console.ForegroundColor = ConsoleColor.White;
            for (int i = 0; i < nodos; i++)
                Console.WriteLine("Nodo: {0}, {1}", i, indegree[i]);
        }

        public int EncuentraI0()
        {
            bool encontrado = false;
            int n = 0;

            for (n = 0; n < nodos; n++)
            {
                if (indegree[n] == 0)
                {
                    encontrado = true;
                    break;
                }
            }

            if (encontrado) return n;
            else return -1;
        }

        public void DecrementarIndigree(int nodo)
        {
            indegree[nodo] = -1;

            for (int i = 0; i < nodos; i++)
            {
                if (mAdyacencia[nodo, i] == 1)
                    indegree[i]--;
            }
        }

        public void Sort()
        {
            int nodo = 0;
            Console.ForegroundColor = ConsoleColor.Cyan;
            do
            {
                nodo = EncuentraI0();

                if (nodo != -1)
                {
                    Console.Write("{0}-> ", nodo);

                    DecrementarIndigree(nodo);
                }

            } while (nodo != -1);

            Console.WriteLine();
        }
    }
}
