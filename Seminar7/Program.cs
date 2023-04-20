// Случайными числами заполнить двумерный массив

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

// int[,] myArray = CreateRandom2dArray();
// Show2dArray(myArray);

// Task 1. Задайте двумерный массив размером M на N, каждый элемент
//  которого будет находиться по формуле Aij = i + j. 
// Выведите полученный массив на экран.

// int[,] CreateRandom2dArray()
// {
// Console.Write("Input a quantity of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a quantity of columns: ");
// int columns = Convert.ToInt32(Console.ReadLine());


//     int[,] array = new int[rows, columns];

//     for(int i = 0; i < rows; i++)
//         for(int j = 0; j < columns; j++)
//             array[i,j] = i + j;

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

// int[,] myArray = CreateRandom2dArray();
// Show2dArray(myArray);


// Task 2. Задайте двумерный массив. Найдите элементы, у которых 
// оба индекса четные, и замените эти элементы на их квадраты.

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

// void QuadrIndexArray(int[,] array)
// {
//     for(int i = 2; i < array.GetLength(0); i+=2)
//         for(int j = 2; j < array.GetLength(1); j+=2)
//             // if(i % 2 = 0 && j % 2 == 0)
//             array[i,j] = array[i,j] * array[i,j];

// }

// int[,] myArray = CreateRandom2dArray();
// Show2dArray(myArray);

// QuadrIndexArray(myArray);
// Show2dArray(myArray);


// Task 3. Задайте двумерный массив. Найдите сумму элементов,
// находящихся на главной диагонали.

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

// int SumIndexDiagonalArray(int[,] array)
// {
//     int sum = 0;
//     for(int i = 0; i < array.GetLength(0); i++)
//         sum = sum + array[i,i];
//     return sum;
// }

// int[,] myArray = CreateRandom2dArray();
// Show2dArray(myArray);

// int sum = SumIndexDiagonalArray(myArray);
// Console.WriteLine($"Sum of elements of generic diagonale: "+ sum);

// Task 4. Показать треугольник Паскаля. Степень увеличения задает
//  оператор. Вывести на экран равнобедренный трегольник со 
// значениями коэффициентов.

