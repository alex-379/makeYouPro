using static ProjectArraysMultidimensional.OperationsWithArraysMultidimensional;

int[,] matrix = Generate(5,3,100,201);
Write(matrix, "Исходная матрица");

int minimum = GetMinElementArray(matrix, out int[] minIndex);
Write(minimum, "Минимальный элемент массива");
Write(minIndex, "Индекс минимального элемента массива");

int maximum = GetMaxElementArray(matrix, out int[] maxIndex);
Write(maximum, "Максимальный элемент массива");
Write(maxIndex, "Индекс максимального элемента массива");

int count = GetCountElementsMoreLeftAndDown(matrix);
Write(count, "Количество элементов массива, больше своих левого и нижнего соседа одновременно");