// Seminar 3. 

// Task 1. Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y).

// void ShowRange(int quadrant)
// {
//     if(quadrant == 1) Console.WriteLine("x > 0 and y > 0");
//     else if(quadrant == 2) Console.WriteLine("x < 0 and y > 0");
//     else if(quadrant == 3) Console.WriteLine("x < 0 and y < 0");
//     else if(quadrant == 4) Console.WriteLine("x > 0 and y < 0");
//     else Console.WriteLine("Quadrant doesnt exist!");
// }

// Console.Write("Input a number of quadrant: ");
// int quadNum = Convert.ToInt32(Console.ReadLine());

// ShowRange(quadNum);


// Task 2. Напишите программу, которая принимает на вход координаты 
// точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, 
// в которой находится эта точка.

// void NumberQuad(int x, int y)
// {
//     if(x > 0 && y > 0) Console.WriteLine("Your Quadrant = 1");
//     if(x < 0 && y > 0) Console.WriteLine("Your Quadrant = 2");
//     if(x < 0 && y < 0) Console.WriteLine("Your Quadrant = 3");
//     if(x > 0 && y < 0) Console.WriteLine("Your Quadrant = 4");
//     Console.WriteLine("Quadrant doesnt exist!");
// }

// Console.Write("Input a coordinates of the point: x = ");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a coordinates of the point: y = ");
// int y = Convert.ToInt32(Console.ReadLine());
// NumberQuad(x, y);




// Task 3. Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 2D пространстве.

// double DistancePoint(int x1, int y1, int x2, int y2)
// {
//     int lenghtSegm1 = x2 - x1;
//     int lenghtSegm2 = y2 - y1;
//     double lenght = Math.Round(Math.Sqrt(Math.Pow(lenghtSegm1, 2) + Math.Pow(lenghtSegm2, 2)), 2);
//     return lenght;
// }

// Console.Write("Input a coordinates of the point 1: x1 = ");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a coordinates of the point 1: y1 = ");
// int y1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a coordinates of the point 2: x2 = ");
// int x2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a coordinates of the point 2: y2 = ");
// int y2 = Convert.ToInt32(Console.ReadLine());

// double lenghtSeg = DistancePoint(x1, y1, x2, y2);

// Console.WriteLine($"Lenght of the segment: {lenghtSeg}");



// Task 4. Напишите программу, которая принимает на вход число (N) и выдаёт 
// таблицу квадратов чисел от 1 до N.

// void QuadNumber(int num)
// {
//     int i = 1;
//     double quad = 1;
//     if(num > 0)
//     {
//         while(i <= num)
//         {
//             quad = Math.Pow(i, 2);
//             Console.WriteLine($" {i} {quad}");
//             i++;
//         }
//     }
//     else Console.WriteLine("Your number is not positive");
// }

// Console.Write("Input positive number: ");
// int number = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"Quadrantes of numbers from {number} to 1: ");
// QuadNumber(number);


