// HomeWork 4.
// Task 1. Задача 25: Напишите цикл, который принимает на вход 
// два числа (A и B) и возводит число A в натуральную степень B.

// int DegreeNum(int num1, int num2)
// {
//          int deg = 1;
//          for(int i = 1; i <= num2; i++)
//                deg = deg * num1;
//          return deg;
// }
// Console.Write("Input the number you want to raise to a power A: ");
// int numA = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input for your number A degree B: ");
// int numB = Convert.ToInt32(Console.ReadLine());

// int degree = DegreeNum(numA, numB);
// Console.WriteLine($"Calculation result your number {numA} in a degree {numB} = {degree} ");



// Task 2. Задача 27: Напишите программу, которая принимает 
// на вход число и выдаёт сумму цифр в числе.

// int  SumDigitNumb(int num)
// {
//     int sum = 0;
//     while(num > 0)
//     {
//         sum = sum + num % 10;
//         num = num / 10;
//     }
//         return sum;
// }

// Console.Write("Input your number: ");
// int number = Convert.ToInt32(Console.ReadLine());

// int sumdignum = SumDigitNumb(number);
// Console.WriteLine($"Sum of digits of your number = {sumdignum} ");


// Task 3. Задача 29: Напишите программу, которая задаёт 
// массив из 8 элементов и выводит их на экран.

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

Console.Write("Input a size for arrey: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] newArrey = CreateRandomArrey(size, min, max);
ShowArrey(newArrey);