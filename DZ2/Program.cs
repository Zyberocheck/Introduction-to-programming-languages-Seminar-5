// Задача 36: Задайте одномерный массив, 
// заполненный случайными числами. Найдите 
// сумму элементов, стоящих на нечётных 
// позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0



int [] Arr()
{
    int[] randarray = new int[7];
    for (int i = 0; i < randarray.Length; i++)
    {
        randarray[i] = new Random().Next(1, 20);
               
    }
    return randarray;
}


int SumNumber(int[]arrays)
{
    int sum = 0;
    for (int i = 0; i < arrays.Length; i++)
    {
        if(arrays[i] % 2 != 0)
        {
            sum+=arrays[i];
        }
    }
    return sum;
}


int[]arrays = Arr();
System.Console.WriteLine(String.Join(" ", arrays));
System.Console.WriteLine(String.Join(" ", SumNumber(arrays)));
