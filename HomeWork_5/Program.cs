// HomeWork 5. 

// Task 1. Задача 34: Задайте массив заполненный случайными 
// положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.

// int[] CreateRandomArrey(int size, int minValue, int maxValue)
// {
//     int[] arrey = new int[size];

//     for(int i = 0; i < size; i++)
//         arrey[i] = new Random().Next(minValue, maxValue + 1);

//     return arrey;
// }

// void ShowArrey(int[] arrey)
// {
//     for(int i = 0; i < arrey.Length; i++)
//         Console.Write(arrey[i] + " ");
    
//     Console.WriteLine();
// }

// int QuantOfEvenNum(int[] arrey)
// {
//     int count = 0;
//     for(int i = 0; i < arrey.Length; i++)
//     {
//         if(arrey[i] % 2 == 0)
//             count++;
//     }
//     return count;
// }

// Console.Write("Input a size for arrey: ");
// int size = Convert.ToInt32(Console.ReadLine());


// int[] newArrey = CreateRandomArrey(size, 100, 1000);
// ShowArrey(newArrey);

// int result = QuantOfEvenNum(newArrey);
// Console.WriteLine($"Quantity Number of even in this arrey " + result);

// Task . Задача 36: Задайте одномерный массив, заполненный 
// случайными числами. Найдите сумму элементов, стоящих на 
// нечётных позициях.

// int[] CreateRandomArrey(int size, int minValue, int maxValue)
// {
//     int[] arrey = new int[size];

//     for(int i = 0; i < size; i++)
//         arrey[i] = new Random().Next(minValue, maxValue + 1);

//     return arrey;
// }

// void ShowArrey(int[] arrey)
// {
//     for(int i = 0; i < arrey.Length; i++)
//         Console.Write(arrey[i] + " ");
    
//     Console.WriteLine();
// }

// int SumOddNumber(int[] arrey)
// {
//     int sum = 0;
//     for(int i = 1; i < arrey.Length; i = i + 2)
//         sum = arrey[i] + sum;
        
//     return sum;
// }

// Console.Write("Input a size for arrey: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a min possible value: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a max possible value: ");
// int max = Convert.ToInt32(Console.ReadLine());


// int[] newArrey = CreateRandomArrey(size, min, max);
// ShowArrey(newArrey);

// int result = SumOddNumber(newArrey);
// Console.WriteLine($"Sum of Number of odd in this arrey " + result);


// Task 3. Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов
//  массива.


// double[] CreateRandomArreyDouble(int size, int minValue, int maxValue, int digitAfterPoint)
// {
//     double[] arrey = new double[size];

//     for(int i = 0; i < size; i++)
//         arrey[i] = Math.Round(new Random().Next(minValue, maxValue) + new Random().NextDouble(), digitAfterPoint);

//     return arrey;
// }

// void ShowArrey(double[] arrey)
// {
//     for(int i = 0; i < arrey.Length; i++)
//         Console.Write(arrey[i] + " ");
    
//     Console.WriteLine();
// }

// double DifOfNumber(double[] arrey)
// {
//     double minNum = arrey[0];
//     double maxNum = arrey[0];
//     for(int i = 1; i < arrey.Length; i++)
//     {
//         if(arrey[i] < minNum)
//             minNum = arrey[i];
//             if(arrey[i] > maxNum)
//                 maxNum = arrey[i];
//     }
//     double dif = maxNum - minNum;
  
//     return dif;
// }

// Console.Write("Input a size for arrey: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a min possible value: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a max possible value: ");
// int max = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a digit after point: ");
// int dig = Convert.ToInt32(Console.ReadLine());


// double[] newArrey = CreateRandomArreyDouble(size, min, max, dig);
// ShowArrey(newArrey);

// double result = DifOfNumber(newArrey);
// Console.WriteLine($"Difference of max Number and of min Number in this arrey " + result);

