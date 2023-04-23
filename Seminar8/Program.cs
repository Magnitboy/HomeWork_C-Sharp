// Task 1. Задайте двумерный массив. Напишите программу, которая поменяет
//  местами первую и последнюю строку массива.

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

// void ChangeRows(int[,] array, int row1, int row2)
// {
//     if(row1 >= 0 && row1 < array.GetLength(0) &&
//         row2 >= 0 && row2 < array.GetLength(0) &&
//         row1 != row2)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//         {
//             int temp = array[row1, j];
//             array[row1, j] = array[row2, j];
//             array[row2, j] = temp;
//         }
//     }
//     else Console.WriteLine("Wrong roq numbers!");
// }

// int[,] myArray = CreateRandom2dArray();
// Show2dArray(myArray);

// Console.Write("Input a first row for change: ");
// int row1 = Convert.ToInt32(Console.ReadLine()) - 1;
// Console.Write("Input a second row for change: ");
// int row2 = Convert.ToInt32(Console.ReadLine()) - 1;

// ChangeRows(myArray, row1, row2);
// Show2dArray(myArray);

// Task 2. Задайте двумерный массив. Напишите программу, которая заменяет
//  строки на столбцы.

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

// void ChangeRowsColumns(int[,] array)
// {
//     if(array.GetLength(0) == array.GetLength(1))
//     {
//         for(int i = 0; i < array.GetLength(0); i++)
//         {
//             for(int j = 0; j < i; j++)
//             {
//                     int temp = array[i, j];
//                     array[i, j] = array[j, i];
//                     array[j, i] = temp;
//             }
//         }
//     }
//     else Console.WriteLine("Wrong a size array!");
// }

// int[,] myArray = CreateRandom2dArray();
// Show2dArray(myArray);

// ChangeRowsColumns(myArray);
// Show2dArray(myArray);


// Task 3. Из двумерного массива целых чисел удалить строку и столбец, 
// на пересечении которых расположен наименьший элемент.

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

int[] CoordinatesElement(int[,] array)
{
    int[] index = {0, 0};
    // int x = 0;
    // int y = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < array[index[0], index[1]])
            {
                index[0] = i;
                index[1] = j;
            }
        }
    }
    return index;
}

void ShowArrey(int[] arrey)
{
    for(int i = 0; i < arrey.Length; i++)
        Console.Write(arrey[i] + " ");
    
    Console.WriteLine();
}

int[,] DeleteRowColumn(int[,] array, int[] index)
{
    int[,] arrayResult = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];

    for(int i = 0, m = 0; i < array.GetLength(0); i++)
    {
        if(i != index[0])
        {
            for(int j = 0, n = 0; j < array.GetLength(1); j++)
            {
                if(j != index[1])
                {
                    arrayResult[m, n] = array[i, j];
                    n++;
                }
            }
            m++;
        }
    }
    return arrayResult;
}

int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);

int[] Coordin = CoordinatesElement(myArray);
ShowArrey(Coordin);
Console.WriteLine();
Show2dArray(DeleteRowColumn(myArray, Coordin));


