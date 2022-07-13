namespace TestApp
{
    public class CNodo
    {
        public int Dato { get; set; }
        internal CNodo Siguiente { get; set; }

        public override string ToString()
        {
            return String.Format("[{0}]", Dato);
        }
    }
    public class CListaLigada
    {
        private CNodo ancla;

        private CNodo trabajo;

        private CNodo trabajo2;

        public CListaLigada()
        {
            ancla = new CNodo();

            ancla.Siguiente = null;
        }

        public void Transversa()
        {
            trabajo = ancla;

            while (trabajo.Siguiente!=null)
            {
                trabajo = trabajo.Siguiente;

                int d = trabajo.Dato;

                Console.Write("{0}, ", d);
            }

            Console.WriteLine();
        }

        public void Adicionar(int pDato)
        {
            trabajo = ancla;

            while (trabajo.Siguiente!=null)
            {
                trabajo = trabajo.Siguiente;
            }

            CNodo temp = new CNodo();

            temp.Dato = pDato;

            temp.Siguiente = null;

            trabajo.Siguiente = temp;
        }

        public void Vaciar()
        {
            ancla.Siguiente = null;
        }

        public bool EstaVacio()
        {
            if (ancla.Siguiente == null)
                return true;
            else
                return false;
        }

        public CNodo Buscar(int pDato)
        {
            if (EstaVacio() == true)
                return null;

            trabajo2 = ancla;

            while (trabajo2.Siguiente!=null)
            {
                trabajo2 = trabajo2.Siguiente;

                if(trabajo2.Dato == pDato)
                    return trabajo2;
            }
            return null;
        }

        public int BuscarIndice(int pDato)
        {
            int n = -1;

            trabajo = ancla;

            while (trabajo.Siguiente != null)
            {
                trabajo = trabajo.Siguiente;
                n++;

                if(trabajo.Dato == pDato)
                    return n;
            }

            return -1;
        }

        public CNodo BuscarAnterior(int pDato)
        {
            trabajo2 = ancla;
            while (trabajo2.Siguiente != null && trabajo2.Siguiente.Dato != pDato)
                trabajo2 = trabajo2.Siguiente;

            return trabajo2;
        }
        public void Borrar(int pDato)
        {
            if (EstaVacio() == true)
                return;

            CNodo anterior = BuscarAnterior(pDato);

            CNodo encontrado = Buscar(pDato);

            if (encontrado == null)
                return;

            anterior.Siguiente = encontrado.Siguiente;
            encontrado.Siguiente = null;
        }

        public void Insertar(int pDonde, int pValor)
        {
            trabajo = Buscar(pDonde);

            if (trabajo == null)
                return;

            CNodo temp = new CNodo();
            temp.Dato = pValor;

            temp.Siguiente = trabajo.Siguiente;

            trabajo.Siguiente = temp;
        }

        public void InsertarAlInicio(int pDato)
        {
            if (ancla.Siguiente == null)
                return;

            CNodo temp = new CNodo();
            temp.Dato = pDato;

            temp.Siguiente = ancla.Siguiente;
            ancla.Siguiente = temp;
        }

        public CNodo ObtenPorIndice(int pIndice)
        {
            CNodo trabajo2 = null;
            int indice = -1;

            trabajo = ancla;

            while (trabajo.Siguiente!=null)
            {
                trabajo = trabajo.Siguiente;
                indice++;

                if (indice == pIndice)
                    trabajo2 = trabajo;
            }
            if (trabajo2 == null)
                return null;

            return trabajo2;
        }

        public int Cantidad()
        {
            trabajo = ancla;
            int n = 0;

            while (trabajo.Siguiente!=null)
            {
                trabajo = trabajo.Siguiente;
                n++;
            }

            return n;
        }

        //INDEXER
        public int this[int pIndice]
        {
            get
            {
                trabajo = ObtenPorIndice(pIndice);
                if (trabajo != null)
                    return trabajo.Dato;
                else 
                    return -1;
            }

            set
            {
                trabajo = ObtenPorIndice(pIndice);

                if (trabajo!=null)
                {
                    trabajo.Dato = value;
                }
            }
        }
    }
}
