namespace TestApp.Stack;
public class PostfixAndPrefix
{
    string expresion;
    char caracter = ' ';
    public PostfixAndPrefix(string data)
    {
        expresion = data;
    }

    public void Evaluate()
    {
        int n = 0;
        int a = 0;
        int b = 0;
        int r = 0;
        Stack stack = new Stack();
        for (n = expresion.Length - 1; n >= 0; n--)
        {
            caracter = expresion[n];

            if (caracter>='0' && caracter<='9')
            {
                stack.Push(Convert.ToInt32(caracter.ToString()));
            }
            else
            {
                a = stack.Pop();
                b = stack.Pop();

                if (caracter == '+')
                {
                    r = a + b;
                    stack.Push(r);
                }
                if (caracter == '-')
                {
                    r = a - b;
                    stack.Push(r);
                }
                if (caracter == '*')
                {
                    r = a * b;
                    stack.Push(r);
                }
                if (caracter == '/')
                {
                    r = a / b;
                    stack.Push(r);
                }
            }
        }

        stack.Transversa();
    }

    public void InToPost()
    {
        StackChar s = new StackChar();
        string res = "";

        for (int n = 0; n < expresion.Length; n++)
        {
            if (expresion[n]>='0' && expresion[n]<='9')
                res += expresion[n];
            else
            {
                while (!s.EmptyStack() && MayorPrecedencia(s.Peek(), expresion[n]))
                    res += s.Pop();

                s.Push(expresion[n]);
            }
        }

        while (!s.EmptyStack())
            res += s.Pop();

        Console.WriteLine("{0} en  postfix es {1}", expresion, res);
    }

    private static bool MayorPrecedencia(char a, char b)
    {
        bool resultado = true;

        if (a == '*' || b == '/')
            resultado = true;

        if (a == '+')
        {
            if (b == '*' || b == '/')
                resultado = false;
            else resultado = true;
        }

        if (a == '-')
            resultado = false;

        return resultado;
    }

}

