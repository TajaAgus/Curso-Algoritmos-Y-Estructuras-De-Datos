using TestApp;
using TestApp.Sorts;
using TestApp.Stack;
using TestApp.Trees;
using TestApp.Hash;

class Program
{
    static void Main(string[] args)
    {
        //Recursión
        //Console.WriteLine(Recursion.Factorial(11));
        //Console.WriteLine(Recursion.Fib(6));

        //Linked List
        //CListaLigada miLista = new CListaLigada();
        //miLista.Adicionar(2);
        //miLista.Adicionar(4);
        //miLista.Adicionar(3);
        //miLista.Adicionar(1);
        //miLista.Adicionar(4);
        //CListaLigada miLista2 = new CListaLigada();
        //miLista2.Adicionar(30);
        //miLista2.Adicionar(33);
        //miLista2.Adicionar(65);
        //miLista2.Adicionar(70);
        //miLista2.Adicionar(153);
        //miLista.Adicionar(7);
        //miLista.Adicionar(25);
        //miLista.Adicionar(70);
        //miLista.Adicionar(876);
        //miLista.Adicionar(9);
        //miLista.Transversa();
        //miLista2.Transversa();

        // SORTS

        //Bubble Sort
        //BubbleSort.Sort(miLista);

        //Insertion Sort
        //InsertionSort.Sort(miLista);

        //Selection Sort
        //SelectionSort.Sort(miLista);

        //Merge Sort
        //MergeSort.Merge(miLista, miLista2);
        //MergeSort.Sort(miLista);

        //Quick Sort
        //QuickSort quickSort = new QuickSort(miLista);
        //quickSort.Sort();

        //Stack
        //Stack stack = new Stack();
        //stack.Push(8);
        //stack.Push(45);
        //stack.Push(2);
        //stack.Push(16);
        //Console.WriteLine(stack.Pop());
        //Console.WriteLine(stack.Peek());
        //Stack stack2 = new Stack();
        //Console.WriteLine(stack2.Pop());
        //stack.Transversa();
        //BalanceDeSignos.Start();

        //Queue
        //Queue queue = new Queue();
        //queue.Enqueue(1);
        //queue.Enqueue(6);
        //queue.Enqueue(4);
        //queue.Enqueue(87);
        //queue.Enqueue(14);
        //Console.WriteLine(queue.Dequeue());
        //Console.WriteLine(queue.Peek());
        //queue.Transversa();

        //Trees

        //GenericTree
        //arbol = new GenericTree();
        //Nodo raiz = arbol.Insertar("a", null);
        //arbol.Insertar("b", raiz);
        //arbol.Insertar("c", raiz);
        //Nodo n = arbol.Insertar("d", raiz);
        //arbol.Insertar("h", n);
        //n = arbol.Insertar("e", raiz);
        //arbol.Insertar("i", n);
        //n = arbol.Insertar("j", n);
        //arbol.Insertar("p", n);
        //arbol.Insertar("q", n);
        //arbol.TransversaPreO(raiz);
        //Console.WriteLine("--------------");
        //arbol.TransversaPostO(raiz);
        //Nodo encontrado = arbol.Buscar("x", raiz);
        //if (encontrado != null)
        //    Console.WriteLine(encontrado.Dato);
        //else
        //    Console.WriteLine("No se encontro");
        //Console.WriteLine("--------------");
        //string donde = "";
        //string que = "";
        //Console.WriteLine("En donde deseas insertar?");
        //donde = Console.ReadLine();
        //Console.WriteLine("Que deseas insertar?");
        //que = Console.ReadLine();
        //Console.WriteLine("--------------");
        //Nodo encontrado = arbol.Buscar(donde, raiz);
        //arbol.Insertar(que, encontrado);
        //arbol.TransversaPreO(raiz);

        //BinaryTree
        //BinaryTree tree = new BinaryTree(6);
        //BTNode raiz = tree.Raiz;
        //tree.Insertar(5, raiz);
        //tree.Insertar(10, raiz);
        //tree.Insertar(14, raiz);
        //tree.Insertar(7, raiz);
        //tree.Insertar(9, raiz);
        //tree.Insertar(0, raiz);
        //tree.Insertar(2, raiz);
        //tree.Transversa(raiz);
        //Console.WriteLine(tree.EncuentraMaximo(raiz));
        //Console.WriteLine(tree.EncuentraMinimo(raiz));
        //tree.TransversaOrdenada(raiz);
        //BTNode temp = tree.EncuentraNodoMinimo(raiz);
        //Console.WriteLine();
        //Console.WriteLine(temp.Dato);
        //Console.WriteLine();
        //temp = tree.BuscarPadre(9, raiz);
        //Console.WriteLine(temp.Dato);
        //tree.Borrar(5, raiz);
        //tree.Transversa(raiz);

        //Prefix Y PostFix
        //PostfixAndPrefix postfixAndPrefix = new PostfixAndPrefix("1/2+4*5-7");
        //postfixAndPrefix.Evaluate();
        //postfixAndPrefix.InToPost();

        //Hash
        //HashSeparate table = new HashSeparate();
        //HashTable table = new HashTable(20);
        //table.Insert(57, "Hola");
        //table.Insert(57, "Hola");
        //table.Insert(57, "Hola");
        //table.Insert(45, "Manzana");
        //table.Insert(42, "Pera");
        //table.Insert(83, "Azul");
        //table.Insert(30, "Rojo");
        //table.Insert(94, "C#");
        //table.Insert(73, "C++");
        //table.Insert(97, "Saludos");
        //table.Insert(94, "dfghffd");
        //table.Insert(2, "Saluvfdgdfdos");
        //table.Insert(13, "Saluvfdgdfdos");
        //table.Insert(6, "Saluvfdgdfdos");
        //table.Show();

        //Heap
        //Heap heap = new Heap(13);
        //heap.Insert(2);
        //heap.Insert(5);
        //heap.Insert(8);
        //heap.Insert(13);
        //heap.Insert(1);
        //heap.Insert(9);
        //heap.Insert(7);
        //heap.Show();
        //Console.WriteLine("Minimo {0}", heap.DeleteMin());
        //heap.Show();
        //Console.WriteLine("Minimo {0}", heap.DeleteMin());
        //Console.WriteLine("Minimo {0}", heap.DeleteMin());
        //Console.WriteLine("Minimo {0}", heap.DeleteMin());
        //Console.WriteLine("Minimo {0}", heap.DeleteMin());
        //Console.WriteLine("Minimo {0}", heap.DeleteMin());
        //Console.WriteLine("Minimo {0}", heap.DeleteMin());
        //heap.Show();

        //Grafos
        //Grafo grafo = new Grafo(7);
        //grafo.AdicionarArista(0, 1);
        //grafo.AdicionarArista(0, 3);
        //grafo.AdicionarArista(1, 3);
        //grafo.AdicionarArista(1, 4);
        //grafo.AdicionarArista(2, 0);
        //grafo.AdicionarArista(2, 5);
        //grafo.AdicionarArista(3, 2);
        //grafo.AdicionarArista(3, 4);
        //grafo.AdicionarArista(3, 5);
        //grafo.AdicionarArista(3, 6);
        //grafo.AdicionarArista(4, 6);
        //grafo.AdicionarArista(6, 5);
        //grafo.MuestraAdyacencia();
        //grafo.CalcularIndegree();
        //grafo.MostrarIndegree();
        //grafo.TopologicalSort();
        //Console.WriteLine("--------------");
        //grafo.ShortestPath(2, 6);
        //grafo.AdicionarArista(0, 1, 2);
        //grafo.AdicionarArista(0, 3, 1);
        //grafo.AdicionarArista(1, 3, 3);
        //grafo.AdicionarArista(1, 4, 10);
        //grafo.AdicionarArista(2, 0, 4);
        //grafo.AdicionarArista(2, 5, 5);
        //grafo.AdicionarArista(3, 2, 2);
        //grafo.AdicionarArista(3, 4, 2);
        //grafo.AdicionarArista(3, 5, 8);
        //grafo.AdicionarArista(3, 6, 4);
        //grafo.AdicionarArista(4, 6, 6);
        //grafo.AdicionarArista(6, 5, 1);
        //grafo.MuestraAdyacencia();
        //grafo.Dijkstra(0, 5);
        
    }
}





