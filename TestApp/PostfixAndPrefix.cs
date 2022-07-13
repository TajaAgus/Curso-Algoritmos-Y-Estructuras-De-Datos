namespace TestApp.Stack;
public class PostfixAndPrefix
{
    Stack stack = new Stack();

    int n = 0;
    int a = 0;
    int b = 0;
    int r = 0;
    string expresion;
    char caracter = ' ';
    public PostfixAndPrefix(string data)
    {
        expresion = data;
    }

    
    

    public void Evaluate()
    {
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

}

