// Задача 38: Задайте массив вещественных 
// чисел. Найдите разницу между максимальным и 
// минимальным элементов массива.
// [3 7 22 2 78] -> 76



int [] Arr()
{
    int[] randarray = new int[6];
    for (int i = 0; i < randarray.Length; i++)
    {
        randarray[i] = new Random().Next(1, 100);
               
    }
    return randarray;
}

int[] arraymm =Arr();

int Maxi(int[] arraymm)
{
    int max = arraymm[0];
    for (int i = 0; i < arraymm.Length; i++)
    {
        if (arraymm[i]>max)
        {
            max=arraymm[i];
        }
    }
    return max;
}

int Mini(int[] arraymm)
{
    int min = arraymm[0];
    for (int i = 0; i < arraymm.Length; i++)
    {
        if (arraymm[i]<min)
        {
            min=arraymm[i];
        }
    }
    return min;
}

Console.WriteLine($"Наш массив: [{String.Join(", ", arraymm)}]");
Console.WriteLine();
Console.WriteLine($"Максимальное число в нем: {String.Join(" ", Maxi(arraymm))}");
Console.WriteLine();
Console.WriteLine($"Минимальное число в нем: {String.Join(" ", Mini(arraymm))}");
Console.WriteLine();
Console.WriteLine($"Разница между максимальным и минимальным числом: {String.Join(" ", Maxi(arraymm) - Mini(arraymm))}");




