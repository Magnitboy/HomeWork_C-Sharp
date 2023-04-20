// Напишите программу, которая перевернёт одномерный массив
//  (последний элемент будет на первом месте, 
// а первый - на последнем и т.д.)

// void ReverseArray(int[] array)
// {
//     for (int left = 0, right = array.Length - 1; left < right; left++, right--)
//     {
//         int temp = array[left];
//         array[left] = array[right];
//         array[right] = temp;
//     }
// }

// int[] myArray = {1, 2, 3, 4, 5};

// ReverseArray(myArray);

// for(int i = 0; i < myArray.Length; i++)
//     Console.Write(myArray[i] + " ");


// Напишите программу, которая принимает на вход три числа и 
// проверяет, может ли существовать треугольник с сторонами 
// такой длины.

// bool Triangle( int a, int b, int c)
// {
//     if(a + b > c && b + c > a && a + c > b) return true;

//     return false;
// }

// Console.Write("Input a size for first side triangle: a = ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a size for first side triangle: b = ");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a size for first side triangle: c = ");
// int c = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(Triangle(a, b, c));

// Не используя рекурсию, выведите первые N чисел Фибоначчи. 
// Первые два числа Фибоначчи: 0 и 1.

// int[] NumbFibon(int size)
// {
//     int[] array = new int[size];

//     for (int i = 2; i < size; i++)
//     {
//         array[0] = 0;
//         array[1] = 1;
//         array[i] = array[i - 2] + array[i - 1];
//     }
//     return array;
// }

// void ShowArrey(int[] arrey)
// {
//     for(int i = 0; i < arrey.Length; i++)
//         Console.Write(arrey[i] + " ");
    
//     Console.WriteLine();
// }

// Console.Write("Input a size for number Finacci: ");
// int size = Convert.ToInt32(Console.ReadLine());

// ShowArrey(NumbFibon(size));



// Напишите программу, которая будет создавать копию заданного
//  массива с помощью поэлементного копирования.

int[] CopyArray(int[] myarray)
{
    int[] array = new int[myarray.Length];

    for (int i = 0; i < myarray.Length; i++)
    {
        array[i] = myarray[i] + 1;
    }
    return array;
}

void ShowArrey(int[] arrey)
{
    for(int i = 0; i < arrey.Length; i++)
        Console.Write(arrey[i] + " ");
    
    Console.WriteLine();
}

int[] mynewarray = {1, 2, 3, 4, 5, 6};

ShowArrey(CopyArray(mynewarray));

