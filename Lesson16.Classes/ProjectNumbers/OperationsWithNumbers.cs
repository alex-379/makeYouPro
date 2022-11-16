﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectNumbers
{
    public static class OperationsWithNumbers
    {

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
            int digit1 = a % 10;
            int digit2 = a / 10;
            string letter1 = "";
            string letter2 = "";
            string number = "";
            
            if (number >= 10 && number < 20)
            {
                switch (number)
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
            break
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
                    number = ($"{letter1} {letter2}")
            }        
            return (number);
        }
    }
}
