// Задача 1. Задайте двумерный массив размером m х n, заполненный случайными вещественными числами.

// Задача 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Задача 3. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Обкатка на практике Switch/Bool/inwork

Console.WriteLine("Инициализация программы");
int ReadInt(string argName)
{
    Console.Write($"Введите {argName}:");
    int number = 0;
    while (!int.TryParse(Console.ReadLine(), out number))
    {
        Console.WriteLine("Вы ввели не число, введите число!!!");
    }
    return number;
}

double[,] CreateTDimArray(int firstLen, int secondLen)
{
    double[,] result = new double[firstLen, secondLen];
    Random rnd = new Random();
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = Math.Round(rnd.NextDouble() * 10, 1);
        }
    }
    return result;
}

void PrintDoubleArray(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}

void PrintIntArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"\t{matrix[i, j]}");
        }
        Console.WriteLine();
    }
}

int Random()
{
    Random random = new Random();
    int number = random.Next(2, 8);
    return number;
}

void GetArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);//[1; 10)
        }
    }
}

void FindElem(int[,] array)
{
    int i = ReadInt("i");
    int j = ReadInt("j");
    bool search = false;

    while (!search == true)
        if (i > array.GetLength(0) - 1 || j > array.GetLength(1) - 1)
        {
            Console.WriteLine("такого элемента нет, попробуйте еще раз!");
            i = ReadInt("i");
            j = ReadInt("j");
        }
        else
        {
            Console.WriteLine($"элемент = {array[i, j]}");
            search = true;
        }
}

double[] SumMidColumn(int[,] array)
{
    double[] sum = new double[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum[j] += array[i, j];
        }
    }
    for (int j = 0; j < array.GetLength(1); j++)
    {
        sum[j] = Math.Round(sum[j] / array.GetLength(0), 1);
    }
    return sum;
}

void PrintArray(double[] summ)
{
    Console.WriteLine("");
    Console.Write($"Среднее арифметическое = ");
    for (int j = 0; j < summ.Length; j++)
    {
        Console.Write($"\t{summ[j]}");
    }
    
}

void Task1()
{
    Console.WriteLine("Задайте двумерный массив размером m х n, заполненный случайными вещественными числами.");
    double[,] array = CreateTDimArray(ReadInt("First Len"), ReadInt("Second Len"));
    PrintDoubleArray(array);
}

void Task2()
{
    Console.WriteLine("Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.");
    int[,] array = new int[Random(), Random()];
    GetArray(array);
    PrintIntArray(array);
    FindElem(array);
}

void Task3()
{
    Console.WriteLine("Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.");
    int[,] array = new int[Random(), Random()];
    GetArray(array);
    PrintIntArray(array);
    double[] summ = SumMidColumn(array);
    PrintArray(summ);
}

bool inWork = true;

while (inWork)
{
    Console.Write("Выбери задачу: ");
    if (int.TryParse(Console.ReadLine(), out int i))
    {
        switch (i)
        {
            case 1:
                {
                    Task1();
                    break;
                }
            case 2:
                {
                    Task2();
                    break;
                }
            case 3:
                {
                    Task3();
                    break;
                }
            case -1: inWork = false; break;
        }
    }
}

Console.WriteLine("Программа завершила работу");