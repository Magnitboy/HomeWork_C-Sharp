// Task 1. Задача 64: Задайте значение N. Напишите программу, которая 
// выведет все натуральные числа в промежутке от N до 1. Выполнить 
// с помощью рекурсии.

// void ShowNaturalNums(int n)
// {
//     Console.Write(n + " ");
//     if(n > 1) ShowNaturalNums(n - 1);
// }

//     Console.Write("Input a your number: N = ");
//     int n = Convert.ToInt32(Console.ReadLine());

// ShowNaturalNums(n);


// Task 2. Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// int SumNaturalNums(int m, int n)
// {
//     if(n > 1 && m > 1 && m < n) return SumNaturalNums(m + 1, n) + m;
//         if(n > 1 && m > 1 && m > n) return SumNaturalNums(m - 1, n) + m;
//             if(n > 1 && m > 1 && m == n) return m;
//         else return 0;
// }

//     Console.Write("Input a your first number: M = ");
//     int m = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input a your second number: N = ");
//     int n = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"Сумма натуральных чисел от M до N = {SumNaturalNums(m, n)}");


// Task 3. Задача 68: Напишите программу вычисления функции Аккермана 
// с помощью рекурсии. Даны два неотрицательных числа m и n.

int FunctionAck(int m, int n)
{
  if (m == 0) return n + 1;
  else if (n == 0) return FunctionAck(m - 1, 1);
  else return FunctionAck(m - 1, FunctionAck(m, n - 1));
}

Console.Write("Input a your first number for functoin Ackermann: M = ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a your second number for functoin Ackermann: N = ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Функция Аккермана = {FunctionAck(m, n)}");

