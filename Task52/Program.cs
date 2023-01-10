// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] FillArray(int m, int n)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(0, 10);
            Console.Write($"{array[i, j]}    ");
        }
        Console.WriteLine();
    }
    return array;
}

void AverageColumns(int[,] array)
{
    Console.Write("Среднее арифметическое каждого столбца:");
    for (int i = 0; i < array.GetLength(1); i++)
    {
        double countLine = 0;
        for (int j = 0; j < array.GetLength(0); j++)
        {
            countLine = countLine + array[j, i];
        }
        Console.Write(Math.Round(countLine / array.GetLength(0), 1) + ",   ");

    }
}

Console.Write("Введите число строк массива: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите число столбцов массива: ");
int n = int.Parse(Console.ReadLine());
AverageColumns(FillArray(m, n));


