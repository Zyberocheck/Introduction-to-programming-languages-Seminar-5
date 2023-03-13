// Задача 35: Задайте одномерный массив из 123 
// случайных чисел. Найдите количество элементов 
// массива, значения которых лежат в отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов.
//  В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5
// Задача 37: Найдите произведение пар чисел 
// в одномерном массиве. Парой считаем первый и 
// последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21




// void Poisk(int[] randarray)
// {
//     int count = 0;
//     for (int i = 0; i < randarray.Length; i++)
//     {
//         if (randarray[i] > 9 && randarray[i] < 100)
//         count++;
//     }
//     Console.WriteLine("Выводим " + count);
// }


// int [] randArray = Arr();
// Console.WriteLine(String.Join(", ", Arr()));
// Console.WriteLine();
// Poisk(Arr());

int [] Arr()
{
    int[] randarray = new int[6];
    for (int i = 0; i < randarray.Length; i++)
    {
        randarray[i] = new Random().Next(-150, 150);
               
    }
    return randarray;
}

int [] randArray = Arr();

int Mult(int[] randArray)
{
    int size = randArray.Length/2;
    if(randArray.Length%2==1)
       size+=1;
    int[] smallrandArray = new int[size];
    for (int i = 0; i < smallrandArray.Length; i++)
    {
        smallrandArray[i] = randArray[i] * randArray[randArray.Length-1-i];
    }
    if(size%2==0)
       smallrandArray[size-1] = randArray[randArray.Length/2];
    return smallrandArray;
}

Console.WriteLine(String.Join(" ", Arr()));
Console.WriteLine(String.Join(" ", Mult(randArray)));




