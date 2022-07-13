namespace TestApp
{
    public class Queue
    {
        private CNodo ancla;

        private CNodo trabajo;

        public Queue()
        {
            ancla = new CNodo();

            ancla.Siguiente = null;
        }

        public void Enqueue(int dato)
        {
            trabajo = ancla;

            while (trabajo.Siguiente != null)
            {
                trabajo = trabajo.Siguiente;
            }

            CNodo temp = new CNodo();

            temp.Dato = dato;

            temp.Siguiente = null;

            trabajo.Siguiente = temp;
        }

        public int Dequeue()
        {
            int valor = 0;

            try
            {
                trabajo = ancla.Siguiente;
                valor = trabajo.Dato;

                ancla.Siguiente = trabajo.Siguiente;
                trabajo.Siguiente = null;

            }
            catch (Exception error)
            {
                Console.WriteLine("Stack vacio");
            }
            return valor;
        }

        public int Peek()
        {
            int valor = 0;

            try
            {
                trabajo = ancla.Siguiente;
                valor = trabajo.Dato;
            }
            catch
            {
                Console.WriteLine("Stack vacio");
            }
            return valor;
        }

        public void Transversa()
        {
            trabajo = ancla;

            while (trabajo.Siguiente != null)
            {
                trabajo = trabajo.Siguiente;
                int d = trabajo.Dato;

                Console.WriteLine("[{0}]", d);
            }
            Console.WriteLine();
        }
    }
}
