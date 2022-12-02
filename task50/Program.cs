// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 1 , 7 -> такого числа в массиве нет
// 1 , 1 -> 9

Console.WriteLine("Введите количество строк - m");
bool isParsedM = int.TryParse(Console.ReadLine(), out int m);

Console.WriteLine("Введите количество столбцов - n");
bool isParsedN = int.TryParse(Console.ReadLine(), out int n);

Console.WriteLine("Введите номер строки искомого элемента - i");
bool isParsedI = int.TryParse(Console.ReadLine(), out int i);

Console.WriteLine("Введите номер столбца искомого элемента - j");
bool isParsedJ = int.TryParse(Console.ReadLine(), out int j);


if(!isParsedM || !isParsedN || !isParsedI || !isParsedJ)
{
    Console.WriteLine("Ошибочный ввод! Не цифра! ПереВВедите!");
    return;
}

int[,] array = CreateRandom2DArray(m, n);
Console.WriteLine();
Print2DArray(array);
Console.WriteLine();

if (i > array.GetLength(0) || j > array.GetLength(1))
{
    Console.WriteLine("такого элемента в данном массиве нет");
    Console.WriteLine();
}
else
{
    Console.WriteLine($"значение элемента {i} строки и {j} столбца равно {array[i-1,j-1]}");
    Console.WriteLine();
}

int[,] CreateRandom2DArray(int m, int n)
{
    int[,] array = new int[m, n];

    Random random = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(1, 9);
        }
    }
    return array;
}

void Print2DArray (int [,] array)
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

