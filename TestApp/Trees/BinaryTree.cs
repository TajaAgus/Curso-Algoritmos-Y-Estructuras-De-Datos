namespace TestApp.Trees
{
    public class BTNode
    {
        public int Dato { get; set; }
        internal BTNode Izq { get; set; }
        internal BTNode Der { get; set; }

        public BTNode()
        {
            Dato = 0;
            Der = null;
            Izq = null;
        }

    }
    public class BinaryTree
    {
        private BTNode trabajo;

        private int i = 0;

        public BinaryTree(int dato)
        {
            Raiz = new BTNode();
            Raiz.Dato = dato;
        }

        internal BTNode Raiz { get; set; }

        public BTNode Insertar(int dato, BTNode nodo)
        {
            BTNode temp = null;

            //Caso Base
            if (nodo == null)
            {
                temp = new BTNode();
                temp.Dato = dato;

                return temp;
            }

            //Caso inductivo
            if (dato < nodo.Dato)
            {
                nodo.Izq = Insertar(dato, nodo.Izq);
            }
            if (dato > nodo.Dato)
            {
                nodo.Der = Insertar(dato, nodo.Der);
            }
            
            return nodo;
        }

        public void Transversa(BTNode nodo) //PreOrder R -> I -> D
        {
            //Caso Base
            if(nodo == null)
                return;

            for (int n = 0; n < i; n++)
                Console.Write(" ");

            Console.WriteLine(nodo.Dato);

            if (nodo.Izq != null)
            {
                i++;
                Console.Write("I ");
                Transversa(nodo.Izq);
                i--;
            }
            if (nodo.Der != null)
            {
                i++;
                Console.Write("D ");
                Transversa(nodo.Der);
                i--;
            }
        }

        public int EncuentraMinimo(BTNode nodo)
        {
            if (nodo == null)
                return 0;

            trabajo = nodo;
            int minimo = trabajo.Dato;

            while (trabajo.Izq != null)
            {
                trabajo = trabajo.Izq;
                minimo = trabajo.Dato;
            }

            return minimo;
        }

        public BTNode EncuentraNodoMinimo(BTNode nodo)
        {
            if (nodo == null)
                return null;

            trabajo = nodo;
            int minimo = trabajo.Dato;

            while (trabajo.Izq != null)
            {
                trabajo = trabajo.Izq;
                minimo = trabajo.Dato;
            }

            return trabajo;
        }

        public int EncuentraMaximo(BTNode nodo)
        {
            if (nodo == null)
                return 0;

            trabajo = nodo;
            int maximo = trabajo.Dato;

            while (trabajo.Der != null)
            {
                trabajo = trabajo.Der;
                maximo = trabajo.Dato;
            }

            return maximo;
        }
        
        public void TransversaOrdenada(BTNode nodo)
        {
            if (nodo == null)
                return;

            if (nodo.Izq != null)
            {
                i++;
                TransversaOrdenada(nodo.Izq);
                i--;
            }

            Console.Write("{0}, ", nodo.Dato);

            if (nodo.Der != null)
            {
                i++;
                TransversaOrdenada(nodo.Der);
                i--;
            }
        }

        public BTNode BuscarPadre(int dato, BTNode nodo)
        {
            BTNode temp = null;

            if (nodo == null)
                return null;

            if (nodo.Izq != null)
                if(nodo.Izq.Dato == dato)
                    return nodo;

            if (nodo.Der != null)
                if (nodo.Der.Dato == dato)
                    return nodo;

            if (nodo.Izq != null && dato < nodo.Dato)
                temp = BuscarPadre(dato, nodo.Izq);

            if (nodo.Der != null && dato > nodo.Dato)
                temp = BuscarPadre(dato, nodo.Der);

            return temp;
        }
        public BTNode Borrar(int dato, BTNode nodo)
        {
            if (nodo == null)
                return nodo;

            else if (dato < nodo.Dato)
            {
                Borrar(dato, nodo.Izq);
            }
            else if (dato > nodo.Dato)
            {
                Borrar(dato, nodo.Der);
            }
            else
            {
                if (nodo.Izq == null && nodo.Der == null)
                {
                    nodo = null;
                    return nodo;
                }
                else if (nodo.Izq == null)
                {
                    trabajo = BuscarPadre(dato, Raiz);
                    if (trabajo.Dato > dato)
                    {
                        trabajo.Izq = nodo.Der;
                        nodo = null;
                    }
                    else
                    {
                        trabajo.Der = nodo.Der;
                        nodo = null;
                    }
                    return nodo;
                }
                else if (nodo.Der == null)
                {
                    trabajo = BuscarPadre(dato, Raiz);
                    trabajo.Izq = nodo.Izq;
                    return nodo;
                }
                else
                {
                    BTNode minimo = EncuentraNodoMinimo(nodo.Der);
                    nodo.Dato = minimo.Dato;
                    nodo.Der = Borrar(minimo.Dato, nodo.Der);
                    return nodo;
                }
            }
            return nodo;
        }
    }


}
