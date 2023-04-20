// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

int PositivNumb(int num)
{
     int current = 0;
     if(num > 0) current++;
     return current;
}

var n = 1;
int mycurrent = 0;

while(n == 1)
{
    Console.Write("Input your number: ");
    int num = Convert.ToInt32(Console.ReadLine());
    mycurrent = PositivNumb(num) + mycurrent;
    Console.WriteLine($"You input {mycurrent} number > 0. You want input another number? Yes = 1, no = 0");
    n = Convert.ToInt32(Console.ReadLine());
}
Console.Write($"You input {mycurrent} number > 0.");


Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


double[] EquationLine(double ratio, double constant)
{
    double[] linearray = new double[2];
    linearray[0] = ratio;
    linearray[1] = constant;
    return linearray;
}

double[] Intersectpoint (double[] linearray1, double[] linearray2)
{
    double x = (linearray1[1] - linearray2[1]) / (linearray1[0] - linearray2[0]);
    double y = linearray1[0] * x + linearray1[1];

    double[] coordlinearray = new double[2];
    coordlinearray[0] = x;
    coordlinearray[1] = y;
    return coordlinearray;
}

void ShowArrey(double[] arrey)
{
    for(int i = 0; i < arrey.Length; i++)
        Console.Write(arrey[i] + " ");
    
    Console.WriteLine();
}

Console.Write("Input a ratio for first line: k1 = ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a constante for first line: b1 = ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a ratio for second line: k2 = ");
double k2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a constante for second line: b2 = ");
double b2 = Convert.ToInt32(Console.ReadLine());

double[] setDataLine1 = EquationLine(k1, b1);
double[] setDataLine2 = EquationLine(k2, b2);

ShowArrey(Intersectpoint(setDataLine1, setDataLine2));
Console.WriteLine($"This lines intersect at a point whit coordinates (x, y) = ");




