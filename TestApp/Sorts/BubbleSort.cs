namespace TestApp.Sorts
{
    public static class BubbleSort
    {
        public static void Sort(CListaLigada miLista)
        {
            int cantidad = miLista.Cantidad();

            for (int m = 1; m < cantidad; m++)
            {
                for (int n = 0; n < cantidad - m; n++)
                {
                    if (miLista[n] > miLista[n + 1])
                        Swap.SwapF(miLista, n, n + 1);
                }
            }

            miLista.Transversa();
            
        }
    }
}
