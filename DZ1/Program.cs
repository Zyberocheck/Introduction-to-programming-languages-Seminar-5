// Задача 34: Задайте массив заполненный 
// случайными положительными трёхзначными 
// числами. Напишите программу, которая 
// покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// Задача 36: Задайте одномерный массив, 
// заполненный случайными числами. Найдите 
// сумму элементов, стоящих на нечётных 
// позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// Задача 38: Задайте массив вещественных 
// чисел. Найдите разницу между максимальным и 
// минимальным элементов массива.
// [3 7 22 2 78] -> 76


int [] Arr()
{
    int[] randarray = new int[20];
    for (int i = 0; i < randarray.Length; i++)
    {
        randarray[i] = new Random().Next(100, 1000);
               
    }
    return randarray;
}

int Shet(int[] randarray)
{
    int count = 0;
    for (int i = 0; i < randarray.Length; i++)
    {
        if(randarray[i] %2 == 0)
        count++;
    }
    return count;
}

int [] shetar = Arr();
Console.WriteLine(String.Join(" ", shetar));
Console.WriteLine(Shet(shetar));


