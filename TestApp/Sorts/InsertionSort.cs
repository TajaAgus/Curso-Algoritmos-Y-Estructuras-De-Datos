namespace TestApp.Sorts
{
    public static class InsertionSort
    {
        public static void Sort(CListaLigada miLista)
        {
            int cantidad = miLista.Cantidad();
            int posAgujero;

            for (int i = 1; i < cantidad; i++)
            {
                posAgujero = i;

                while (posAgujero > 0 && miLista[posAgujero] < miLista[posAgujero - 1])
                {
                    Swap.SwapF(miLista, posAgujero, posAgujero - 1);
                    posAgujero = posAgujero - 1;
                }
            }
            miLista.Transversa();
        }
    }
}
