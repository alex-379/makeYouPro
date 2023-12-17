using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCalculator
{
    public static class Calculator
    {
        public static void AllMethods()
        { 
            int a = ReadFromConsole();
            int b = ReadFromConsole();
            int result = Add(a, b);
            WriteResult(result);
        }

        public static int ReadFromConsole()
        {
            Console.WriteLine("Введите число: ");
            string s = Console.ReadLine();
            int n = Convert.ToInt32(s);
            return (n);
        }

        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static void WriteResult(int res)
        {
            Console.WriteLine($"Результат: {res}");
        }
    }
}
