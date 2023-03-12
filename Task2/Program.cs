// // Задача 32: Напишите программу замена 
// элементов массива: положительные элементы 
// замените на соответствующие отрицательные, 
// и наоборот.
// // [-4, -8, 8, 2] -> [4, 8, -8, -2]

// // Задача 33: Задайте массив. Напишите программу,
//  которая определяет, присутствует ли заданное число
//   в массиве.
// // 4; массив [6, 7, 19, 345, 3] -> нет
// // -3; массив [6, 7, 19, 345, -3] -> да



int [] Arr()
{
    int[] array = new int[4];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-4, 8);
               
    }
    return array;
}


// int[] arr = {-4, -8, 8, 2};


void NegaTiv( int[] array)
{
for (int i = 0; i < array.Length; i++)
{

    array[i]*=-1;
    
    Console.Write(array[i] + " ");

}

}


int[] array = Arr();
Console.WriteLine(String.Join(" ", array));
NegaTiv(array);




