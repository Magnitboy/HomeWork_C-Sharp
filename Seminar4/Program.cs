// Seminar 4.

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


