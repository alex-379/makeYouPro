using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectNumbers
{
    public static class OperationsWithNumbers
    {
        public static double ReadFromConsole()
        {
            Console.WriteLine("Введите число: ");
            string s = Console.ReadLine();
            double n = Convert.ToDouble(s);
            return (n);
        }

        public static void WriteResult(double res)
        {
            Console.WriteLine($"\nРезультат: {res}\n\n");
        }

        public static double ValueOfLinearEqution(double a, double b, double c)
        {
            double x = (c - b) / a;
            return (x);
        }

        public static double SumIfAMoreMultiplyIfEqualDifferenceIfBMore(double a, double b)
        {
            double result = 0;
            if (a > b) result = a + b;
            if (a == b) result = a * b;
            if (a < b) result = a - b;
            return (result);
        }
        public static string Number2DigitToString(int a)
        {
            string number = "Введённое число не двузначное";

            if (a >= 10 && a < 20)
            {
                switch (a)
                {
                    case 10:
                        number = "Десять";
                        break;
                    case 11:
                        number = "Одиннадцать";
                        break;
                    case 12:
                        number = "Двенадцать";
                        break;
                    case 13:
                        number = "Тринадцать";
                        break;
                    case 14:
                        number = "Четырнадцать";
                        break;
                    case 15:
                        number = "Пятнадцать";
                        break;
                    case 16:
                        number = "Шестнадцать";
                        break;
                    case 17:
                        number = "Семнадцать";
                        break;
                    case 18:
                        number = "Восемнадцать";
                        break;
                    case 19:
                        number = "Девятнадцать";
                        break;
                }
            }
            else
            {
                int digit1 = a % 10;
                int digit2 = a / 10;
                string letter1 = "";
                string letter2 = "";

                switch (digit1)
                {
                    case 2:
                        letter1 = "Двадцать";
                        break;
                    case 3:
                        letter1 = "Тридцать";
                        break;
                    case 4:
                        letter1 = "Сорок";
                        break;
                    case 5:
                        letter1 = "Пятьдесят";
                        break;
                    case 6:
                        letter1 = "Шестьдесят";
                        break;
                    case 7:
                        letter1 = "Семьдесят";
                        break;
                    case 8:
                        letter1 = "Восемьдесят";
                        break;
                    case 9:
                        letter1 = "Девяносто";
                        break;
                }

                switch (digit2)
                {
                    case 1:
                        letter2 = "один";
                        break;
                    case 2:
                        letter2 = "два";
                        break;
                    case 3:
                        letter2 = "три";
                        break;
                    case 4:
                        letter2 = "четыре";
                        break;
                    case 5:
                        letter2 = "пять";
                        break;
                    case 6:
                        letter2 = "шесть";
                        break;
                    case 7:
                        letter2 = "семь";
                        break;
                    case 8:
                        letter2 = "восемь";
                        break;
                    case 9:
                        letter2 = "девять";
                        break;
                }
                number = ($"{letter1 }{letter2}");
            }
            return (number);
        }
        /*public static bool CheckEnteringRange(double a)
        {
            if (0 <= a <= 10 || 20 <= a <= 30 || 40 <= a <= 50)
            {
                bool result = true;
            }
            else
            {
                result = falce;
            }
            return (result);
        }
        public static AddNumbersDivisibleBy7(int a, int b)
            for (int i = a; i <= b; i++)
            {
               int result = 0;
                if i % 7 == 0
                {
                result += i;
                }
}
return (result);
public static ReturnNumberOfRowFibbonachi (int n)
            */
    }
}
