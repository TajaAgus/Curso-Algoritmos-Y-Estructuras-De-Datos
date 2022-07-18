namespace TestApp.Hash
{
    public class HashSeparate
    {
        private static int length = 23;

        private static CLinkedList[] table;

        public HashSeparate()
        {
            table = new CLinkedList[length];
            for (int n = 0; n < length; n++)
            {
                table[n] = new CLinkedList();
            }
            Show();
            Console.WriteLine("----------");
        }

        public void Show()
        {
            for (int n = 0; n < length; n++)
            {
                Console.Write("({0})", n);
                table[n].Display();
                Console.WriteLine();
            }
        }

        public static int Hashf(int key)
        {
            int index = key % length;
            return index;
        }

        public void Insert(int key, string value)
        {
            int index = Hashf(key);

            table[index].Add(key, value);
        }
    }
}
