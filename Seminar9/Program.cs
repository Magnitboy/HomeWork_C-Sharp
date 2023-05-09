// Task 1. Задайте значение N. Напишите программу, которая выведет все 
// натуральные числа в промежутке от 1 до N.

// void ShowNums(int num)
// {
//     Console.Write(num + " ");
//     if(num > 1) ShowNums(num - 1);
//     Console.Write(num + " ");
// }

// ShowNums(5);

// Task 2. Напишите программу, которая будет принимать на вход число и 
// возвращать сумму его цифр.

// int SumOfDigitals(int num)
// {
//     if(num != 0) return SumOfDigitals(num / 10) + num % 10;
//     else return 0;
// }

// Console.WriteLine(SumOfDigitals(1357));


// Task 3. Задайте значения M и N. Напишите программу, которая выведет
//  все натуральные числа в промежутке от M до N.

// void ShowTwoNums(int m, int n)
// {
//     if(n >= 1 && m >= 1)
//     {
//         if(m > n)
//         {
//             Console.Write(m + " ");
//             ShowTwoNums(m - 1, n);
//         }

//         if (m < n)
//         {
//             ShowTwoNums(m, n - 1);
//             Console.Write(n + " ");
//         }

//         if(m == n)
//         Console.Write(n + " ");
//     }
//     else Console.Write("Your digits not natural");
// }

// ShowTwoNums(4, 7);

// Task 4. Напишите программу, которая на вход принимает два числа A и B, 
// и возводит число А в целую степень B.

// double MathDegree(int a, int b)
// {
//     if(b > 1) return (MathDegree(a, b - 1) * a);

//         else if(b < 0) return ((MathDegree(a, b + 1)) / a);

//             else if(b == 0) return 1;

//                 else return a;
// }

// Console.WriteLine(MathDegree(2, 0));
