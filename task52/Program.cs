// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце. 
// Поиск среднее арифметического в отдельном методе.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// Задайте двумерный массив. Найдите элементы у которых оба индекса нечетные и замените эти элементы на их квадраты

Console.WriteLine("Введите количество задаваемого массива строк - m");
bool isParsedM = int.TryParse(Console.ReadLine(), out int m);

Console.WriteLine("Введите количество столбцов задаваемого массива - n");
bool isParsedN = int.TryParse(Console.ReadLine(), out int n);

if(!isParsedM || !isParsedN)
{
    Console.WriteLine("Ошибочный ввод! Не цифра! ПереВВедите!");
    return;
}

int[,] array = CreateRandom2DArray(m, n);
Console.WriteLine("Сгенерированный исходный массив:");
Print2DArray(array);
Console.WriteLine();
double[] arithmeancolumn = ArithmeticMeanOfColumn(array);
Console.WriteLine("Массив среднего арифметического столбцов исходного массива:");
PrintArray(arithmeancolumn);
Console.WriteLine();

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
void PrintArray (double [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

double[] ArithmeticMeanOfColumn (int [,] array)
{
    double[] arithmean = new double[n];
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            
            sum += array[i, j];
        }
        arithmean[j] = sum / m;
    }
    return arithmean;
}