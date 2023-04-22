// Task 1. Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.

// int[,] CreateRandomint2dArray()
// {
// Console.Write("Input a quantity of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a quantity of columns: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a min possible value: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a max possible value: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

//     int[,] array = new int[rows, columns];

//     for(int i = 0; i < rows; i++)
//         for(int j = 0; j < columns; j++)
//             array[i,j] = Math.Round(new Random().Next(minValue, maxValue) 
//             + new Random().Nextint(), 1);
//     return array;
// }

// void Show2dArray(int[,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//             Console.Write(array[i,j] + "   ");

//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// int[,] myArray = CreateRandomint2dArray();
// Show2dArray(myArray);


// Task 2. Задача 50. Напишите программу, которая на вход 
// принимает позиции элемента в двумерном массиве, и возвращает 
// значение этого элемента или же указание, что такого элемента нет.

// int[,] CreateRandom2dArray()
// {
// Console.Write("Input a quantity of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a quantity of columns: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a min possible value: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a max possible value: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

//     int[,] array = new int[rows, columns];

//     for(int i = 0; i < rows; i++)
//         for(int j = 0; j < columns; j++)
//             array[i,j] = new Random().Next(minValue, maxValue +1);

//     return array;
// }

// void Show2dArray(int[,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//             Console.Write(array[i,j] + " ");

//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// void NumberFromArray(int[,] array, int positionRows, int positionColumns)
// {
//     if(positionRows <= array.GetLength(0) && positionColumns <= array.GetLength(1))
//     {
//         int num = array[positionRows, positionColumns];
//         Console.Write($"Your number from array: " + num);
//     }

//     else Console.Write("The are no numbers with specified indexes in this array!");
// }

// int[,] myArray = CreateRandom2dArray();
// Show2dArray(myArray);

// Console.Write("Input a position of rows: ");
// int posrows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a position of columns: ");
// int poscolumns = Convert.ToInt32(Console.ReadLine());

// NumberFromArray(myArray, posrows, poscolumns);



// Task 3. Задача 52. Задайте двумерный массив из целых чисел.
//  Найдите среднее арифметическое элементов в каждом столбце.

int[,] CreateRandom2dArray()
{
Console.Write("Input a quantity of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a quantity of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];

    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            array[i,j] = new Random().Next(minValue, maxValue +1);

    return array;
}

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");

        Console.WriteLine();
    }
    Console.WriteLine();
}


double[] ArithmeticMeanColumns(int[,] array2d)
{
    double[] array = new double[array2d.GetLength(1)];
    for(int i = 0; i < array2d.GetLength(1); i++)
    {
        double sum = 0;
        for(int j = 0; j < array2d.GetLength(0); j++)
        {
            sum = sum + array2d[j, i];
        }
        array[i] = Math.Round((sum / array2d.GetLength(0)), 2);
    }
    return array;
}

void ShowArrey(double[] arrey)
{
    for(int i = 0; i < arrey.Length; i++)
        Console.Write(arrey[i] + " ");
    
    Console.WriteLine();
}

int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);

ShowArrey(ArithmeticMeanColumns(myArray));

