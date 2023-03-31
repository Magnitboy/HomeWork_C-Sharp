// HomeWork2

// Task 1. Задача 10: Напишите программу, которая принимает на вход 
// трёхзначное число и на выходе показывает вторую цифру этого числа.

// int SecondDigits(int num)
// {
//     int tens = num / 10 % 10;
//     return tens;
// }

// Console.Write("Input a three-digit number: ");
// int yournum = Convert.ToInt32(Console.ReadLine());

// if(yournum / 100 < 9 && yournum / 100 > 1)
// {
//     Console.WriteLine(SecondDigits(yournum));
// }
// else
// {
//     Console.WriteLine("Your number is not three-digit!!!");
// }

// Task 2. Задача 13: Напишите программу, которая выводит третью 
// цифру заданного числа или сообщает, что третьей цифры нет.

// int ThirdDigit(int num)
// {
//     int threedig = num;
//         while(threedig > 999)
//     {
//         threedig = threedig / 10;
//     }
    
//     threedig = threedig % 10;

//     return threedig;
// }
    
// Console.Write("Input a your number: ");
// int yournum = Convert.ToInt32(Console.ReadLine());

// if(yournum < 100)
// {
//     Console.WriteLine("There is no third digit in your number!");
// }
// else
// {
//     Console.WriteLine(ThirdDigit(yournum));
// }



// Task 3. Задача 15: Напишите программу, которая принимает на вход 
// цифру, обозначающую день недели, и проверяет, является ли 
// этот день выходным.

// bool Weekend(int num)

// {
//     if(num > 5)
//     {
//         return true;
//     }
//     else
//     {
//         return false;
//     }
// }

// Console.Write("Input a number of Day of the Week: ");
// int numday = Convert.ToInt32(Console.ReadLine());

// if(numday > 7 || numday < 1)
// {
//     Console.WriteLine("The are only seven days in a week! Please, Input the correct number!");
// }
// else
// {
//     Console.WriteLine(Weekend(numday));
// }
