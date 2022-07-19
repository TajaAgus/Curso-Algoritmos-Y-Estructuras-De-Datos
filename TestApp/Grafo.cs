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

        public void AdicionarArista(int nodoIncio, int nodoFinal, int peso)
        {
            mAdyacencia[nodoIncio, nodoFinal] = peso;
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

        public int ObtenAdyacencia(int fila, int columna)
        {
            return mAdyacencia[fila, columna];
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

        public void TopologicalSort()
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

        public void ShortestPath(int i, int f)
        {
            int inicio = i;
            int final = f;
            int distancia = 0;
            int n = 0;
            int m = 0;

            // Columnas:
            // 0 - visitado
            // 1 - Distancia
            // 2 - Previo
            int[,] tabla = new int[nodos, 3];

            for (n = 0; n < nodos; n++)
            {
                tabla[n, 0] = 0;
                tabla[n, 1] = int.MaxValue;
                tabla[n, 2] = 0;
            }
            //Asignamos distancia 0 al valor del que comenzamos.
            tabla[inicio, 1] = 0;

            MostrarTabla(tabla);

            for (distancia = 0; distancia < nodos; distancia++)
            {
                for (n = 0; n < nodos; n++)
                {
                    if ((tabla[n, 0]==0) && (tabla[n,1]==distancia))
                    {
                        tabla[n, 0] = 1;

                        for (m = 0; m < nodos; m++)
                        {
                            if (ObtenAdyacencia(n, m) == 1)
                            {
                                if (tabla[m, 1] == int.MaxValue)
                                {
                                    tabla[m, 1] = distancia + 1;
                                    tabla[m, 2] = n;
                                }
                            }
                        }
                    }
                }
            }

            MostrarTabla(tabla);

            List<int> ruta = new List<int>();
            int nodo = final;

            while (nodo != inicio)
            {
                ruta.Add(nodo);
                nodo = tabla[nodo, 2];
            }
            ruta.Add(inicio);

            ruta.Reverse();

            foreach (int item in ruta)
                Console.Write("{0}->", item);

            Console.WriteLine();
        }

        public void Dijkstra(int i, int f)
        {
            int inicio = i;
            int final = f;
            int distancia = 0;
            int n = 0;
            int actual = 0;
            int columna = 0;

            // Columnas:
            // 0 - visitado
            // 1 - Distancia
            // 2 - Previo
            int[,] tabla = new int[nodos, 3];

            for (n = 0; n < nodos; n++)
            {
                tabla[n, 0] = 0;
                tabla[n, 1] = int.MaxValue;
                tabla[n, 2] = 0;
            }
            //Asignamos distancia 0 al valor del que comenzamos.
            tabla[inicio, 1] = 0;

            actual = inicio;

            do
            {
                tabla[actual, 0] = 1;

                for (columna = 0; columna < nodos; columna++)
                {
                    if (ObtenAdyacencia(actual, columna) != 0)
                    {
                        distancia = ObtenAdyacencia(actual, columna) + tabla[actual, 1];

                        if (distancia < tabla[columna, 1])
                        {
                            tabla[columna, 1] = distancia;
                            tabla[columna, 2] = actual;                        
                        }
                    }
                }

                int indiceMenor = -1;
                int distanciaMenor = int.MaxValue;

                for (int x = 0; x < nodos; x++)
                {
                    if (tabla[x, 1] < distanciaMenor && tabla[x, 0] == 0)
                    {
                        indiceMenor = x;
                        distanciaMenor = tabla[x, 1];
                    }
                }
                actual = indiceMenor;
            } while (actual != -1);

            MostrarTabla(tabla);

            List<int> ruta = new List<int>();
            int nodo = final;

            while (nodo != inicio)
            {
                ruta.Add(nodo);
                nodo = tabla[nodo, 2];
            }
            ruta.Add(inicio);

            ruta.Reverse();

            foreach (int item in ruta)
                Console.Write("{0}->", item);

            Console.WriteLine();
        }

        private static void MostrarTabla(int[,] tabla)
        {
            for (int n = 0; n < tabla.GetLength(0); n++)
            {
                Console.WriteLine("{0}-> {1}\t{2}\t{3}", n, tabla[n, 0], tabla[n, 1], tabla[n, 2]);
            }
            Console.WriteLine("----------");
        }
    }
}
