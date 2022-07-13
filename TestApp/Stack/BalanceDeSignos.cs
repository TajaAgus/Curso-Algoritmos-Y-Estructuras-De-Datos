namespace TestApp.Stack
{
    public static class BalanceDeSignos
    {
        public static void Start()
        {
            char s = ' ';
            StackChar stack = new StackChar();

            Console.WriteLine("Dame la expresión a evaluar");
            string expresion = Console.ReadLine();

            foreach(char c in expresion)
            {
                if (c=='(' || c == '{' || c == '[')
                {
                    stack.Push(c);
                }

                if (c == ')' || c == '}' || c == ']')
                {
                    if (stack.EmptyStack())
                    {
                        Console.WriteLine("=== Exceso de simbolos de cierre ===");
                    }
                    else
                    {
                        s = stack.Pop();

                        if (s == '(' && c != ')')
                        {
                            Console.WriteLine("Se esperaba )");
                        }
                        if (s == '{' && c != '}')
                        {
                            Console.WriteLine("Se esperaba }");
                        }
                        if (s == '[' && c != ']')
                        {
                            Console.WriteLine("Se esperaba ]");
                        }
                    }
                }

            }
            if (stack.EmptyStack() == false)
            {
                Console.WriteLine("=== Exceso de simbolos de apertura ===");
            }


        }
    }
}
