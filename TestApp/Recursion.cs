namespace TestApp
{
    public static class Recursion
    {
        //Factorial
        public static int Factorial(int n)
        {
            int r = 0;

            // Caso Inductivo
            if (n > 1)
                r = n * Factorial(n - 1);

            // Caso Base
            if (n == 1)
                r = 1;

            return r;
        }
        //Fibonacci
        public static int Fib(int n)
        {
            // 1,1,2,3,5,8,13
            // 0,1,2,3,4,5,6
            int r = 0;

            //Caso inductivo
            if(n > 1)
                r = Fib(n - 1) + Fib(n - 2);

            //Caso Base
            if (n <= 1)
                r = 1;

            return r;
        }
    }
}
