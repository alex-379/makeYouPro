double[] numbers = new double[] {1, 5, 9, 8, 6, 10, 4, 5, 7, 0};
double[] accum = new double[numbers.Length];
for (int i = 0; i < numbers.Length; i++)
{
    accum[i] = -1;
}
for (int i = 0; i < numbers.Length; i ++)
{
    if (numbers[i] % 2 == 0)
    {
        accum[i] = numbers[i];
    }
}
int countOdd = 0;
for (int i = 0; i < numbers.Length; i ++)
{
    if (accum[i] != -1)
    {
        countOdd++;
    }
}
double[] numbersOdd = new double[countOdd];
int j = 0;
for (int i=0; i < numbers.Length; i++)
{
    if (accum[i] != -1)
    {
        numbersOdd[j] = accum[i];
        j++;
    }
}
Console.WriteLine(numbersOdd.Length);
Console.WriteLine(numbersOdd[1]);


