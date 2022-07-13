using TestApp;
using TestApp.Sorts;
using TestApp.Stack;
using TestApp.Trees;

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
        PostfixAndPrefix postfixAndPrefix = new PostfixAndPrefix("-+3*52*73");
        postfixAndPrefix.Evaluate();


    }
}





