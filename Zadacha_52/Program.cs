// Задайте двумерный массив из целых чисел. Найдите среднее 
// арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

#nullable disable

int[,] newArray = new int[5, 5];

int[,] CreateRandomArray(int[,] array)
{
    Random random = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(0, 10);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

void PrintArrayAverage(float[] col)
{
    Console.Write("Среднее арифметическое:");
    for (int i = 0; i < col.Length - 1; i++)
    {
        Console.Write($" {col[i]:N1};");
    }
    Console.Write($" {col[col.Length - 1]:N1}");
}

float[] FindAverage(int[,] array)
{

    float aveSum = 0;
    float[] tmpArray = new float[array.GetLength(0)];
    int index = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        float sum = 0;

        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        aveSum = sum / array.GetLength(1);
        tmpArray[index] = aveSum;
        index = index + 1;
    }
    return tmpArray;
}

int[,] x = CreateRandomArray(newArray);
PrintArray(x);
float[] result = FindAverage(x);
Console.WriteLine();
PrintArrayAverage(result);
