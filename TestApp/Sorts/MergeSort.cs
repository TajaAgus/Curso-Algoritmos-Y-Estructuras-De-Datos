using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp.Sorts
{
    public static class MergeSort
    {
        public static CListaLigada Sort(CListaLigada miLista)
        {
            int cantidad = miLista.Cantidad();
            int n = 0;

            //Caso Base
            if (cantidad < 2)
                return miLista;

            int mitad = cantidad / 2;

            CListaLigada izquierda = new CListaLigada();
            CListaLigada derecha = new CListaLigada();

            for (n = 0; n < mitad; n++)
                izquierda.Adicionar(miLista[n]);

            for (n = mitad; n < cantidad; n++)
                derecha.Adicionar(miLista[n]);

            //Caso inductivo
            CListaLigada tempI = Sort(izquierda);
            CListaLigada tempD = Sort(derecha);

            //Parte final
            CListaLigada ordenada = Merge(tempI, tempD);
            ordenada.Transversa();
            return ordenada;
        }
        public static CListaLigada Merge(CListaLigada listI, CListaLigada listD)
        {
            CListaLigada unida = new CListaLigada();

            int indiceI = 0;
            int indiceD = 0;

            int cantI = listI.Cantidad();
            int cantD = listD.Cantidad();

            while (indiceI < cantI && indiceD < cantD)
            {
                if (listI[indiceI] <= listD[indiceD])
                {
                    unida.Adicionar(listI[indiceI]);
                    indiceI++;
                }
                else
                {
                    unida.Adicionar(listD[indiceD]);
                    indiceD++;
                }
            }

            while (indiceI<cantI)
            {
                unida.Adicionar(listI[indiceI]);
                indiceI++;
            }

            while (indiceD<cantD)
            {
                unida.Adicionar(listD[indiceD]);
                indiceD++;
            }
            return unida;
        }
    }
}
