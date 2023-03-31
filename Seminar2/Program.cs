// Seminar 2
// Task 1. Напишите программу, которая выводит случайное трехзначное число
//  и удаляет вторую цифру этого числа.

// int CutNumber(int num)
// {
//     int hundreds = num / 100;
//     int units = num % 10;

//     int result = hundreds * 10 + units;
//     return result;
// }

// int randNumber = new Random().Next(100, 1000);
// int newNumber = CutNumber(randNumber);

// Console.WriteLine($"New version of {randNumber} is {newNumber}");


// Task 2. Напишите программу, которая выводит случайное число 
//  из отрезка [10, 99] и показывает наибольшую цифру числа.

// int MaxDigit(int num)
// {
//     int tens = num / 10;
//     int units = num % 10;
//     int result = tens;
//     if(tens < units)
//     {
//         result = units;
//     }
//     return result;
// }

// int randNumber = new Random().Next(10, 100);
// int newNumber = MaxDigit(randNumber);

// Console.WriteLine($"max Digits of {randNumber} is {newNumber}");


// Task 3. Напишите программу, которая принимает на вход число
//  и проверяет, кратно ли оно одновременно a и b.

// bool Multiplicity(int num, int a, int b)
// {
//     if(num % a == 0 && num % b == 0)
//    {
//         return true;
//    }
//    else
//    {
//         return false;
//    }
// }

// Console.Write("Input a Basic number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a first divider: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a second divider: ");
// int b = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(Multiplicity(num, a, b));


// Task 4. Напишите программу, которая принимает на вход два числа
//  и проверяет, является ли одно число квадратом другого.

// bool Quadrant(int num1, int num2)
// {
//     if(num1 * num1 == num2 || num2 * num2 == num1)
//     {
//         return true;
//     }
//     else
//     {
//         return false;
//     }
// }

// Console.Write("Input a first number: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a second number: ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(Quadrant(num1, num2));



