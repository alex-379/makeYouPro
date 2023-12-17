using static ProjectArrays.OperationsWithArrays;

int length = ReadLengthFromConsole();
double[] numbers = ReadArrayFromConsole(length);
Write(numbers, "Исходный массив");

double numberMin = GetMinElementArray(numbers, out int indexMin);
Write(numberMin, "Минимальный элемент массива");

double numberMax = GetMaxElementArray(numbers, out int indexMax);
Write(numberMax, "Максимальный элемент массива");

Write(indexMin, "Индекс минимального элемента массива");

Write(indexMax, "Индекс максимального элемента массива");

double[] indexOdd = GetElementsArrayWithOddIndexes(numbers);
double sum = GetSumElementsArray(indexOdd);
Write(sum, "Сумма элементов с нечётными индексами");

double[] numbersReverse = ReverseElementsArray(numbers);
Write(numbersReverse, "Массив в обратном направлении");

GetOddElementsArray(numbers, out int countOdd);
Write(countOdd, "Количество нечётных элементов массива");

double[] numbersSwap = SwapFirstAndSecondHalfArray(numbers);
Write(numbersSwap, "Массив, в котором поменяны первая и вторая половины");

numbers = Generate(10, -10, 20);
Write(numbers, "Исходный массив");
double[] numbersSort = SortBubbleUp(numbers);
Write(numbersSort, "Массив, сортированный по возрастанию методом пузырьковой сортировки");

numbersSort = SortInsertDown(numbers);
Write(numbersSort, "Массив, сортированный по убыванию методом вставок");