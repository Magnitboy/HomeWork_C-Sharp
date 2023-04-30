// Task 1. Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного 
// массива.

// int[,] CreateRandom2dArray()
// {
//     Console.Write("Input a quantity of rows: ");
//     int rows = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input a quantity of columns: ");
//     int columns = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input a min possible value: ");
//     int minValue = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input a max possible value: ");
//     int maxValue = Convert.ToInt32(Console.ReadLine());

//     int[,] array = new int[rows, columns];

//     for (int i = 0; i < rows; i++)
//         for (int j = 0; j < columns; j++)
//             array[i, j] = new Random().Next(minValue, maxValue + 1);

//     return array;
// }

// void Show2dArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             Console.Write(array[i, j] + " ");

//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// int[,] SortedMaxToMin(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int n = 0; n < array.GetLength(0); n++)
//         {
//             for (int j = 0; j < array.GetLength(1) - 1; j++)
//             {
//                 if (array[i, j] < array[i, j + 1])
//                 {
//                     int temp = array[i, j];
//                     array[i, j] = array[i, j + 1];
//                     array[i, j + 1] = temp;
//                 }
//             }
//         }
//     }
//     return array;
// }

// int[,] myArray = CreateRandom2dArray();
// Show2dArray(myArray);
// Show2dArray(SortedMaxToMin(myArray));


// Task 2. Задача 56: Задайте прямоугольный двумерный массив. Напишите 
// программу, которая будет находить строку с наименьшей суммой элементов.

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

// int[] SumNumbersRows(int[,] array)
// {
//     int[] indexsum = new int[array.GetLength(0)];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         indexsum[i] = 0;
//             for (int j = 0; j < array.GetLength(1); j++)
//             {
//                 indexsum[i] = indexsum[i] + array[i, j];
//             }
//     }return indexsum;

// }

// int SortedSumRows(int[] array)
// {
//     int row = 0;
//     int min = array[0];
//     for (int i = 1; i < array.Length; i++)
//     {
//         if (array[i] < min)
//         {
//             min = array[i];
//             row = i;
//         }
//     }
//     return row;
// }

// int[,] myArray = CreateRandom2dArray();
// Show2dArray(myArray);
// int myrow = SortedSumRows(SumNumbersRows(myArray));
// Console.WriteLine($" A row with the min sum of elements is " + (myrow + 1));


// Task 3. Задача 58: Задайте две матрицы. Напишите программу, которая 
// будет находить произведение двух матриц.

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
//             array[i,j] = new Random().Next(minValue, maxValue + 1);

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

// int[,] MultiplicTwoMatrix(int[,] array1, int[,] array2)
// {
//     int[,] multimatrix = new int[array1.GetLength(0), array2.GetLength(1)];
//     if (array1.GetLength(1) == array2.GetLength(0))
//     {
//         for (int i = 0; i < array1.GetLength(0); i++)
//             for (int j = 0; j < array2.GetLength(1); j++)
//             {
//                 multimatrix[i, j] = 0;
//                 for (int k = 0; k < array1.GetLength(1); k++)
//                     multimatrix[i, j] += (array1[i, k] * array2[k, j]);
//             }
//     }
//     return multimatrix;
// }

// int[,] myArray1 = CreateRandom2dArray();
// int[,] myArray2 = CreateRandom2dArray();
// Show2dArray(myArray1);
// Show2dArray(myArray2);

// Show2dArray(MultiplicTwoMatrix(myArray1, myArray2));


// Task 4. Задача 60. Сформируйте трёхмерный массив из неповторяющихся
//  двузначных чисел. Напишите программу, которая будет построчно выводить 
// массив, добавляя индексы каждого элемента.

// int[,,] CreateRandom3dArray()
// {
//     Console.Write("Input a quantity of rows: ");
//     int rows = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input a quantity of columns: ");
//     int columns = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input a quantity planes: ");
//     int planes = Convert.ToInt32(Console.ReadLine());

//     int[,,] array = new int[rows, columns, planes];
//     int n = 0;
//     for (int i = 0; i < rows; i++)
//         for (int j = 0; j < columns; j++)
//             for (int k = 0; k < planes; k++)
//             {
//                 array[i, j, k] = new Random().Next(10, 100);
//                 while(array[i, j, k] == n)
//                 {
//                     array[i, j, k] = new Random().Next(10, 100);
//                 }
//                 n = array[i, j, k];
//             }

//     return array;
// }

// void Show3dArrayIndexes(int[,,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//         {
//             for(int k = 0; k < array.GetLength(2); k++)
//             {
//                 Console.Write(array[i, j, k] + $"({i},{j},{k})");
//             }
//             Console.WriteLine();
//         }
//         // Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// int[,,] myArray = CreateRandom3dArray();
// Show3dArrayIndexes(myArray);

// Task 5. Задача 62. Напишите программу, которая заполнит спирально 
// массив 4 на 4.

int[,] CreateRandom2dArray()
{
    Console.Write("Input a quantity of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a quantity of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];

    int n = 1;
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = n;
            n++;
        }

    return array;
}

void Show2dArrayNatural(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            if(array[i, j] < 10)
            {
                Console.Write("0" + array[i, j] + " ");
            }
            else Console.Write(array[i, j] + " ");

        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] myArray = CreateRandom2dArray();
Show2dArrayNatural(myArray);


