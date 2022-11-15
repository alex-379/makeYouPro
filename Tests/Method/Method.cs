namespace Method
{
    internal class Method
    {
        private static void Main(string[] args)
        {
            WritePrivetToConsole3Times();
            Console.WriteLine();
            WritePrivetToConsole3Times();

            void WritePrivetToConsole3Times()
            {
                for (int i = 1; i <= 2; i++)
                {
                    Console.WriteLine("Hello");
                }
            }

            void Add(int a, int b)
            {
                Console.WriteLine();
                int c = a + b;
                Console.WriteLine(c);
            }
            Add(9, 8);
            Add(15687, 6846);
            int a = 10;
            Add(a, a);

            int Multiply(int a, int b)
            {
                int result = a * b;
                return result;
            }
            int q = Multiply(2, 3);
            Console.WriteLine(q);
        }
    }
}