// Задайте двумерный массив размером m×n, заполненный 
// случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
#nullable disable
Console.WriteLine("Введите количество строк массива:");
bool isNumberA = int.TryParse(Console.ReadLine(), out int a);

Console.WriteLine("введите количество столбцов массива:");
bool isNumberB = int.TryParse(Console.ReadLine(), out int b);
if (!isNumberA || !isNumberB || a <= 0 || b <= 0)
{
    Console.WriteLine("Введите целое положительное число");
    return;
}

double[,] CreateRandomArray(int m, int n)
{
    double[,] array = new double[m, n];

    Random random = new Random();

    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(-100, 100) + random.NextDouble();
        }
    }

    return array;
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]:N2} ");
        }
        Console.WriteLine();
    }
}


double[,] result = CreateRandomArray(a, b);
PrintArray(result);