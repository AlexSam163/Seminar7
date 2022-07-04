/*Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
 m = 3, n = 4.
 0,5 7 -2 -0,2
 1 -3,3 8 -9,9
 8 7,8 -7,1 9*/


Console.Write("Введите значение m: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите значение n: ");
int n = int.Parse(Console.ReadLine());

Console.WriteLine();

double[,] array = new double[m, n];

void randArrayDouble(double[,] array)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().NextDouble() * 20 - 10;
        }
    }
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            double Number = Math.Round(array[i, j], 1);
            Console.Write(Number + " ");
        }
        Console.WriteLine();
    }
}

randArrayDouble(array);
PrintArray(array);

/*Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет*/

int m = Input("m");
int n = Input("n");
double[,] array = new double[m, n];

FillArray(array);
PrintArray(array);
Console.WriteLine();

int numberRow = NumberPosition("numberRow");
int numberColumn = NumberPosition("numberColumn");

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        if (numberColumn >= 0 && numberRow >= 0 && numberRow == i && numberColumn == j)
        {
            Console.WriteLine($"{array[numberRow, numberColumn]}");
        }    
    }
        if (numberColumn >= 0 && numberRow >= 0 && numberRow >= m || numberColumn >= n)
        {
            Console.WriteLine("такого числа в массиве нет");
            break;
        }
}

void PrintArray(double[,] matrix)
{
    for (int rows = 0; rows < matrix.GetLength(0); rows++)
    {
        for (int columns = 0; columns < matrix.GetLength(1); columns++)
        {
            Console.Write($"{matrix[rows, columns]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(double[,] matrix)
{
    for (int rows = 0; rows < matrix.GetLength(0); rows++)
    {
        for (int columns = 0; columns < matrix.GetLength(1); columns++)
        {
            matrix[rows, columns] = new Random().Next(1, 11);
        }
    }
}

int Input(string numberName)
{
    Console.Write($"Введите значение для {numberName}: ");
    return Convert.ToInt32(Console.ReadLine());
}

int NumberPosition(string numberPosition)
{
    Console.Write($"Введите значение для {numberPosition}: ");
    return Convert.ToInt32(Console.ReadLine());
}


/*Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3 */

int m = Input("m");
int n = Input("n");

double[,] array = new double[m, n];

FillArray(array);
PrintArray(array);
Console.WriteLine();
Console.Write("Среднее арифметическое каждого столбца равно: ");   

for (int i = 0; i < m; i++)
{
    double average = 0;
    for (int j = 0; j < n; j++)
    {
        average += array[j, i];
    }
    Console.Write(Math.Round(average / m, 2) + "; ");   
}

void PrintArray(double[,] matrix)
{
    for (int rows = 0; rows < matrix.GetLength(0); rows++)
    {
        for (int columns = 0; columns < matrix.GetLength(1); columns++)
        {
            Console.Write($"{matrix[rows, columns]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(double[,] matrix)
{
    for (int rows = 0; rows < matrix.GetLength(0); rows++)
    {
        for (int columns = 0; columns < matrix.GetLength(1); columns++)
        {
            matrix[rows, columns] = new Random().Next(1, 11);
        }
    }
}

int Input(string numberName)
{
    Console.Write($"Введите значение для {numberName}: ");
    return Convert.ToInt32(Console.ReadLine());
}




