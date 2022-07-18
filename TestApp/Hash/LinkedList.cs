namespace TestApp.Hash
{
    public class Node
    {
        public int Key { get; set; }
        public string Value { get; set; }
        public Node Next { get; set; }

        public override string ToString()
        {
            return String.Format("[{0}, {1}]", Key, Value);
        }

    }
    public class CLinkedList
    {
        private Node header;

        private Node pointer;

        private Node pointer2;

        public CLinkedList()
        {
            header = new Node();

            header.Next = null;
        }

        public void Display()
        {
            pointer = header;

            while (pointer.Next != null)
            {
                pointer = pointer.Next;

                Console.Write("{0}-> ", pointer);
            }
        }

        public void Add(int key, string value)
        {
            pointer = header;

            while (pointer.Next != null)
            {
                pointer = pointer.Next;
            }

            Node temp = new Node();

            temp.Key = key;

            temp.Value = value;

            temp.Next = null;

            pointer.Next = temp;
        }

        public void Empty()
        {
            header.Next = null;
        }

        public bool IsEmpty()
        {
            if (header.Next == null)
                return true;
            else
                return false;
        }

        public Node Search(int key)
        {
            if (IsEmpty() == true)
                return null;

            pointer2 = header;

            while (pointer2.Next != null)
            {
                pointer2 = pointer2.Next;

                if (pointer2.Key == key)
                    return pointer2;
            }
            return null;
        }

        public int SearchIndex(int key)
        {
            int n = -1;

            pointer = header;

            while (pointer.Next != null)
            {
                pointer = pointer.Next;
                n++;

                if (pointer.Key == key)
                    return n;
            }

            return -1;
        }

        public Node FindPrevious(int key)
        {
            pointer2 = header;
            while (pointer2.Next != null && pointer2.Next.Key != key)
                pointer2 = pointer2.Next;

            return pointer2;
        }
        public void Borrar(int key)
        {
            if (IsEmpty() == true)
                return;

            Node previous = FindPrevious(key);

            Node found = Search(key);

            if (found == null)
                return;

            previous.Next = found.Next;
            found.Next = null;
        }

        public void Insert(int index, int key, string value)
        {
            pointer = Search(index);

            if (pointer == null)
                return;

            Node temp = new Node();
            temp.Key = key;
            temp.Value = value;

            temp.Next = pointer.Next;

            pointer.Next = temp;
        }

        public void InsertAtStart(int key, string value)
        {
            if (header.Next == null)
                return;

            Node temp = new Node();
            temp.Key = key;
            temp.Value = value;

            temp.Next = header.Next;
            header.Next = temp;
        }

        public Node GetByIndex(int index)
        {
            Node pointer2 = null;
            int i = -1;

            pointer = header;

            while (pointer.Next != null)
            {
                pointer = pointer.Next;
                i++;

                if (i == i)
                    pointer2 = pointer;
            }
            if (pointer2 == null)
                return null;

            return pointer2;
        }

        public int Length()
        {
            pointer = header;
            int n = 0;

            while (pointer.Next != null)
            {
                pointer = pointer.Next;
                n++;
            }

            return n;
        }

        //INDEXER
        public int this[int index]
        {
            get
            {
                pointer = GetByIndex(index);
                if (pointer != null)
                    return pointer.Key;
                else
                    return -1;
            }

            set
            {
                pointer = GetByIndex(index);

                if (pointer != null)
                {
                    pointer.Key = value;
                }
            }
        }
    }
}

