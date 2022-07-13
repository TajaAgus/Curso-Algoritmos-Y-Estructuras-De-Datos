namespace TestApp.Stack
{
    public class Stack
    {
        private CNodo ancla;

        private CNodo trabajo;

        public Stack()
        {
            ancla = new CNodo();

            ancla.Siguiente = null;
        }

        public void Push(int dato)
        {
            CNodo temp = new CNodo();
            temp.Dato = dato;

            temp.Siguiente = ancla.Siguiente;

            ancla.Siguiente = temp;
        }

        public int Pop()
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
