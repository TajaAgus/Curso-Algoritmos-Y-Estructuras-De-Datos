using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    public class Heap
    {
        private int length;
        private int size;
        private int[] elements;

        public Heap(int length)
        {
            this.length = length;
            elements = new int[length];
        }

        public void Show()
        {
            for (int i = 0; i <= size; i++)
                Console.WriteLine("{0}, ", elements[i]);

            Console.WriteLine();
        }

        public bool IsFull()
        {
            if (size >= length) return true;
            else return false;
        }

        public void Insert(int value)
        {
            int i = 0;

            if (IsFull())
                return;
            else
            {
                for (i = size + 1; elements[i / 2] > value; i /= 2)
                {
                    elements[i] = elements[i / 2];
                }
                elements[i] = value;
                size++;
            }
        }

        public int DeleteMin()
        {
            int n = 0;
            int child = 0;
            int minorElement = 0;
            int lastElement = 0;

            if (size <= 0)
                return 0;

            minorElement = elements[1];
            lastElement = elements[size];
            size--;

            for (n = 1; n*2 <= size; n = child)
            {
                child = n * 2;
                if ( child != size && elements[child + 1] < elements[child])
                {
                    child++;
                }

                if (lastElement > elements[child])
                {
                    elements[n] = elements[child];
                }
                else break;
            }

            elements[n] = lastElement;

            return minorElement;
        }
    }
}
