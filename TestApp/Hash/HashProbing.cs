using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp.Hash
{
    enum state
    {
        empty, occupied, erased
    }

    public class Cell
    {
        public int Key { get; set; }
        public string Value { get; set; }

        internal state State { get; set; }

        public Cell()
        {
            Key = 0;
            Value = "";
            State = state.empty;
        }
    }
    public class HashProbing
    {
        private Cell[] table;
        private int length;
        public HashProbing()
        {
            length = 45;
            table = new Cell[length];
            for (int i = 0; i < length; i++)
                table[i] = new Cell();
            Show();
        }
        public void Show()
        {
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine("{0} [{1}, {2}]", i, table[i].Key, table[i].Value);
            }
        }

        private int HashF(int key, int attempt)
        {
            // Lineal probing
            //int index = (key + attempt) % length;

            // Quadratic probing
            int index = (key + attempt * attempt) % length;
            return index;
        }

        public void Insert(int key, string value)
        {
            int a = 0;
            int index = 0;
            bool occupied = false;

            while (occupied == false)
            {
                index = HashF(key, a);

                if (table[index].State == state.empty)
                {
                    occupied = true;
                    table[index].Key = key;
                    table[index].Value = value;
                    table[index].State = state.occupied;
                }
                else a++;
            }

        }
    }
}
