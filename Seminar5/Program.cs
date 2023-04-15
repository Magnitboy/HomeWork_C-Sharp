// Task 1. Напишите программу замена элементов массива: 
// положительные элементы замените на соответствующие 
// отрицательные, и наоборот.

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

// int[] ChangeNegatElem(int[] arrey)
// {
//     for(int i = 0; i < arrey.Length; i++)
//         arrey[i] *= -1;
//     return arrey;
// }

// Console.Write("Input a size for arrey: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a min possible value: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a max possible value: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] newArrey = CreateRandomArrey(size, min, max);
// ShowArrey(newArrey);

// int[] result = ChangeNegatElem(newArrey);
// Console.WriteLine($"New arrey is ");
// ShowArrey(result);



// Task 2. Напишите программу, которая определяет, 
// присутствует ли заданное число в массиве.

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

// bool NumInArrey(int[] arrey, int num)
// {
//     for(int i = 0; i < arrey.Length; i++)
//         if(arrey[i] == num)
//             return true;
//     return false;
// }

// Console.Write("Input a size for arrey: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a min possible value: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a max possible value: ");
// int max = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input your number: ");
// int num = Convert.ToInt32(Console.ReadLine());

// int[] newArrey = CreateRandomArrey(size, min, max);
// ShowArrey(newArrey);

// bool result = NumInArrey(newArrey, num);
// Console.WriteLine($"Your number in this arrey " + result);



// Task 3. Задайте одномерный массив из m случайных чисел. 
// Найдите количество элементов массива, значения которых 
// лежат в отрезке [a,b].

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

// int NumInYourArrey(int[] arrey, int numA, int numB)
// {
//     int count = 0;
//     for(int i = 0; i < arrey.Length; i++)
//     {
//         if(arrey[i] >= numA && arrey[i] <= numB)
//             count++;
//     }
//     return count;
// }

// Console.Write("Input a size for arrey: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a min possible value: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a max possible value: ");
// int max = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input your number A: ");
// int numA = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input your number B: ");
// int numB = Convert.ToInt32(Console.ReadLine());

// int[] newArrey = CreateRandomArrey(size, min, max);
// ShowArrey(newArrey);

// int result = NumInYourArrey(newArrey, numA, numB);
// Console.WriteLine($"Quantity Number in this arrey " + result);


// Task 4. Найдите произведение пар чисел в одномерном 
// массиве. Парой считаем первый и последний элемент, второй 
// и предпоследний и т.д. Результат запишите в новом массиве.
// 1 5 6 4 2

int[] CreateRandomArrey(int size, int minValue, int maxValue)
{
    int[] arrey = new int[size];

    for(int i = 0; i < size; i++)
        arrey[i] = new Random().Next(minValue, maxValue + 1);

    return arrey;
}

void ShowArrey(int[] arrey)
{
    for(int i = 0; i < arrey.Length; i++)
        Console.Write(arrey[i] + " ");
    
    Console.WriteLine();
}

int[] MultiplicPairsNumArrey(int[] arrey)
{
    int[] newArrey = new int[arrey.Length / 2];
    for(int i = 0; i < newArrey.Length; i++)
        newArrey[i] = arrey[i] * arrey[arrey.Length - 1 - i];

    return newArrey;
}

Console.Write("Input a size for arrey: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());


int[] newArrey = CreateRandomArrey(size, min, max);
ShowArrey(newArrey);

int[] result = MultiplicPairsNumArrey(newArrey);
ShowArrey(result);
