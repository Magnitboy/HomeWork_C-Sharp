// HomeWork 3.

// Task1. Задача 19. Напишите программу, которая принимает на вход пятизначное 
// число и проверяет, является ли оно палиндромом.

bool Palindrom(double digitnum, double num)
{
    double j = digitnum - 1;
    if(num / Math.Pow(10, j) >= 1 && num / Math.Pow(10, j) < 10)
    {
        while(j >= 1)
        {
            if(num > 10 && num / Math.Pow(10, j) == num % 10 )
            {
                num = num % Math.Pow(10, j) / 10;
                j = j - 2;  
            }   
            else
            {
                return false;
            }
        }
        return true;
    }
    else
    {
        Console.WriteLine("Enter the correct data!");
        return false;
    }
}


Console.Write("Input the number of digits of your number: ");
int digits = Convert.ToInt32(Console.ReadLine());
Console.Write("Input your number: ");
int number = Convert.ToInt32(Console.ReadLine());

bool answer = Palindrom(digits, number);

if(answer == true)
{
    Console.WriteLine("Yes!");
}
else Console.WriteLine("No!");


// Task 2. Задача 21. Напишите программу, которая принимает на вход координаты 
// двух точек и находит расстояние между ними в 3D пространстве.

// double DistPoint3D(int x1, int y1, int z1, int x2, int y2, int z2)
// {
//     int lenghtSegm1 = x2 - x1;
//     int lenghtSegm2 = y2 - y1;
//     int lenghtSegm3 = z2 - z1;
//     double lenght = Math.Round(Math.Sqrt(Math.Pow(lenghtSegm1, 2) + Math.Pow(lenghtSegm2, 2) + Math.Pow(lenghtSegm3, 2)), 2);
//     return lenght;
// }

// Console.Write("Input a coordinates of the point 1: x1 = ");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a coordinates of the point 1: y1 = ");
// int y1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a coordinates of the point 2: z1 = ");
// int z1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a coordinates of the point 2: x2 = ");
// int x2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a coordinates of the point 1: y2 = ");
// int y2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a coordinates of the point 2: z2 = ");
// int z2 = Convert.ToInt32(Console.ReadLine());

// double lenghtSeg = DistPoint3D(x1, y1, z1, x2, y2, z2);

// Console.WriteLine($"Lenght of the segment: {lenghtSeg}");


// Task 3. Задача 23. Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.

// void ThirdPowNumber(int num)
// {
//     int i = 1;
//     double thirdPow = 1;
//     if(num > 0)
//     {
//         while(i <= num)
//         {
//             thirdPow = Math.Pow(i, 3);
//             Console.WriteLine($" {i} => {thirdPow}");
//             i++;
//         }
//     }
//     else Console.WriteLine("Your number is not positive");
// }

// Console.Write("Input positive number: ");
// int number = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"A numbers in the third power from 1 to {number}: ");
// ThirdPowNumber(number);
