using System;
namespace PrintMedABC
{
    class Program
    {
        public static void Main(string[] args)
        {
            double A, B, C, hlp = 0;
            Console.WriteLine("Type value of A:");
            A = double.Parse(Console.ReadLine());
            Console.WriteLine("Type value of B:");
            B = double.Parse(Console.ReadLine());
            Console.WriteLine("Type value of C:");
            C = double.Parse(Console.ReadLine());
            Console.WriteLine("___________________");
            hlp = Srednee(A, B, C);
            if (hlp > 0)
                Console.WriteLine(hlp);
            else
                Console.WriteLine("ERROR");
            Console.ReadLine();
        }
        public static double Srednee(double n1, double n2, double n3)
        {
            double rs = 0, Mn = 0, Mx = 0;
            Mn = Math.Min(n1, Math.Min(n2, n3));
            Mx = Math.Max(n1, Math.Max(n2, n3));
            if (n1 == n2 || n2 == n3)
                rs = 0;
            else
            {
                if (n1 > Mn && n1 < Mx)
                    rs = n1;
                if (n2 > Mn && n2 < Mx)
                    rs = n2;
                if (n3 > Mn && n3 < Mx)
                    rs = n3;
            }

            return rs;
        }
    }
}