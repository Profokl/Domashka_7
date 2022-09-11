// Напишите программу, которая на вход принимает число и ищет 
// в двумерном массиве, и возвращает индексы этого элемента или же указание, 
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 7 -> 0 , 2
// 5 -> 1 , 0
// 18 -> нет такого элемента

#nullable disable
Console.WriteLine("Введите искомое целое положительное число:");
bool isNumber = int.TryParse(Console.ReadLine(), out int find);
if (!isNumber || find < 0)
{
    Console.WriteLine("Вы ввели неправильное число.");
    return;
}

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

void PrintArrayFind(int[] col)
{
    Console.Write("Координаты числа:");
    for (int i = 0; i < col.Length - 1; i++)
    {
        Console.Write($"{col[i]}, ");
    }
    Console.Write(col[col.Length - 1]);
}

int[] FindNumber(int[,] array, int find)
{
    int[] tmpArray = new int[2];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == find)
            {
                tmpArray[0] = i;
                tmpArray[1] = j;
                goto End;
            }
        }
    }
End:
    return tmpArray;
}

int[,] x = CreateRandomArray(newArray);
PrintArray(x);
int[] result = FindNumber(x, find);
Console.WriteLine();
if (result[0] == 0 && result[1] == 0)
{
    Console.WriteLine("Нет такого числа");
    return;
}
PrintArrayFind(result);
