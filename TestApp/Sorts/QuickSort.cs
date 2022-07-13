namespace TestApp.Sorts
{
    public class QuickSort
    {
        CListaLigada miLista;
        int pInicio;
        int pFin;
        public QuickSort(CListaLigada list)
        {
            pInicio = 0;
            pFin = list.Cantidad() - 1;
            miLista = list;

        }
        public void Sort()
        {
            SortF(pInicio, pFin);
            miLista.Transversa();
        }
        private int Particion(int pInicio, int pFin)
        {
            int pivote = miLista[pFin];
            int iPivote = pInicio;

            for (int n = pInicio; n < pFin; n++)
            {
                if (miLista[n] <= pivote)
                {
                    Swap.SwapF(miLista, miLista[n], miLista[iPivote]);
                    iPivote++;
                }
            }
            Swap.SwapF(miLista, iPivote, pFin);

            return iPivote;
        }
        public void SortF(int pInicio, int pFin)
        {
            int iPivote = 0;

            //Caso Base 
            if (pInicio >= pFin)
                return;

            iPivote = Particion(pInicio, pFin);

            SortF(pInicio, iPivote - 1);
            SortF(iPivote + 1, pFin);
        }
    }
}
