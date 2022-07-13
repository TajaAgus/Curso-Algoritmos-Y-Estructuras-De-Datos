using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp.Sorts
{
    public static class Swap
    {
        public static void SwapF(CListaLigada miLista, int i1, int i2)
        {
            int temp = miLista[i1];
            miLista[i1] = miLista[i2];
            miLista[i2] = temp;
        }
    }
}
