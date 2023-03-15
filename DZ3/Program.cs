// Задача 38: Задайте массив вещественных 
// чисел. Найдите разницу между максимальным и 
// минимальным элементов массива.
// [3 7 22 2 78] -> 76



double [] Arr()
{
    double [] randarray = new double [6];
    for (int i = 0; i < randarray.Length; i++)
    {
        randarray[i] = new Random().NextDouble();
        randarray[i] = Math.Round(randarray[i], 2);
               
    }
    return randarray;
}

double[] arraymm =Arr();

double Maxi(double[] arraymm)
{
    double max = arraymm[0];
    for (int i = 0; i < arraymm.Length; i++)
    {
        if (arraymm[i]>max)
        {
            max=arraymm[i];
        }
    }
    return max;
}

double Mini(double[] arraymm)
{
    double min = arraymm[0];
    for (int i = 0; i < arraymm.Length; i++)
    {
        if (arraymm[i]<min)
        {
            min=arraymm[i];
        }
    }
    return min;
}


double result = Math.Round(Maxi(arraymm) - Mini(arraymm), 2);

Console.WriteLine();
Console.WriteLine($"Наш массив: [{String.Join("; ", arraymm)}]");
Console.WriteLine();
Console.WriteLine($"Максимальное число в нем: {String.Join(" ", Maxi(arraymm))}");
Console.WriteLine();
Console.WriteLine($"Минимальное число в нем: {String.Join(" ", Mini(arraymm))}");
Console.WriteLine();
Console.WriteLine($"Разница между максимальным и минимальным числом: {result}"); // String.Join(" ", Maxi(arraymm) - Mini(arraymm))
Console.WriteLine();




