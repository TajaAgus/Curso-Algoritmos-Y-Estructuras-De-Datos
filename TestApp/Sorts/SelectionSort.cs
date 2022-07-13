namespace TestApp.Sorts
{
    public static class SelectionSort
    {
        public static void Sort(CListaLigada miLista)
        {
            int iMin;
            int c = miLista.Cantidad();

            for (int i = 0; i < c -1; i++)
            {
                iMin = i;
                for (int j = 0 + i; j < c; j++)
                {
                    if (miLista[j] < miLista[iMin])
                        iMin = j;
                }
                Swap.SwapF(miLista, iMin, i);
            }
            miLista.Transversa();
        }
    }
}
