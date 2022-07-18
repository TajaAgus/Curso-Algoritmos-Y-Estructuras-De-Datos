using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp.Hash
{
    public class HashTable
    {
        private Cell[] table;
        private int length;
        private int inserted;
        public HashTable(int pLength)
        {
            length = pLength;
            inserted = 0;
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
                    inserted++;
                }
                else a++;
            }

            if (inserted >= ((double) length*0.7))
            {
                Console.WriteLine("--Es necesario hacer rehash, {0} de {1} ocupados", inserted, length);
                ReHash();
            }
        }
        public int ClosePrime(int value)
        {
            int prime = 0;
            bool isPrime = true;

            while (prime == 0)
            {
                isPrime = true;
                for (int i = 2; i < value; i++)
                {
                    if (value % i == 0)
                    {
                        isPrime = false;
                        value++;
                        break;
                    }
                }
                if (isPrime)
                    prime = value;
            }
            return value;
        }

        public void ReHash()
        {
            int newLength = ClosePrime(length * 2);
            int previousLength = length;
            int key = 0;
            string value = "";

            int a = 0;
            int index = 0;
            bool occupied = false;

            Console.WriteLine("Ahora la tabla sera de {0} esapcios", newLength);

            Cell[] temp = new Cell[newLength];

            for (int i = 0; i < newLength; i++)
                temp[i] = new Cell();

            length = newLength;

            for (int i = 0; i < previousLength; i++)
            {
                if (table[i].State==state.occupied)
                {
                    key = table[i].Key;
                    value = table[i].Value;

                    occupied = false;

                    while (occupied == false)
                    {
                        index = HashF(key, a);

                        if (temp[index].State == state.empty)
                        {
                            occupied = true;
                            temp[index].Key = key;
                            temp[index].Value = value;
                            temp[index].State = state.occupied;
                            inserted++;

                        }
                        else a++;
                    }
                }
            }
            table = (Cell[]) temp.Clone();
        }
    }
}
