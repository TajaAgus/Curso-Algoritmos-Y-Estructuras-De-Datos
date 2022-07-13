namespace TestApp.Stack
{
    public class CNodoChar
    {
        public char Dato { get; set; }
        internal CNodoChar Siguiente { get; set; }

        public override string ToString()
        {
            return string.Format("[{0}]", Dato);
        }
    }
    public class StackChar
    {
        private CNodoChar ancla;

        private CNodoChar trabajo;

        public StackChar()
        {
            ancla = new CNodoChar();

            ancla.Siguiente = null;
        }

        public bool EmptyStack()
        {
            if (ancla.Siguiente == null) return true;
            else return false;
        }

        public void Push(char dato)
        {
            CNodoChar temp = new CNodoChar();
            temp.Dato = dato;

            temp.Siguiente = ancla.Siguiente;

            ancla.Siguiente = temp;
        }

        public char Pop()
        {
            char valor = '.';

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

        public char Peek()
        {
            char valor = '.';

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
                char d = trabajo.Dato;

                Console.WriteLine("[{0}]", d);
            }
        }
    }
}
