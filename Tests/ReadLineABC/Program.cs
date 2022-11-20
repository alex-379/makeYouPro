using System;
using System.Linq;
using System.Threading;

namespace ReadLineABC
{
    class Program
    {
        private static void Main(string[] args)
        {
            int[] ABCArr = new int[3];
            bool isEven = false;
            for (int i = 0; i < ABCArr.Length; i++)
            {
                Console.Write("Введите число {0} : ", i);
                if (((ABCArr[i] = Convert.ToInt32(Console.ReadLine())) % 2 == 0) && isEven == false)
                    isEven = true;
            }
            Array.Sort(ABCArr);
            if (ABCArr[1] == ABCArr[0] || ABCArr[1] == ABCArr[2])
                Console.WriteLine("Невозможно определить максимальный/минимальный элемент");
            else
            {
                if (isEven)
                    Console.WriteLine("Максимальное значение = {0}", ABCArr.Max());
                else
                    Console.WriteLine("Минимальное значение = {0}", ABCArr.Min());
            }
        }
    }
}