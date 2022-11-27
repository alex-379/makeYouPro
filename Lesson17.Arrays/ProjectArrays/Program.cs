using static ProjectArrays.OperationsWithArrays;

int length = ReadLengthFromConsole();
double[] numbers = ReadArrayFromConsole(length);
WriteResult(numbers, "Исходный массив");

double numberMin = GetMinElementArray(numbers, out int indexMin);
WriteResult(numberMin, "Минимальный элемент массива");

double numberMax = GetMaxElementArray(numbers, out int indexMax);
WriteResult(numberMax, "Максимальный элемент массива");

WriteResult(indexMin, "Индекс минимального элемента массива");

WriteResult(indexMax, "Индекс максимального элемента массива");

double[] indexOdd = GetElementsArrayWithOddIndexes(numbers);
double sum = GetSumElementsArray(indexOdd);
WriteResult(sum, "Сумма элементов с нечётными индексами");

double[] numbersReverse = ReverseElementsArray(numbers);
WriteResult(numbersReverse, "Массив в обратном направлении");

GetOddElementsArray(numbers, out int countOdd);
WriteResult(countOdd, "Количество нечётных элементов массива");

double[] numbersSwap = SwapFirstAndSecondHalfArray(numbers);
WriteResult(numbersSwap, "Массив, в котором поменяны первая и вторая половины");