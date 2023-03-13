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





// int[] arr = {-4, -8, 8, 2};


// void NegaTiv( int[] array)
// {
// for (int i = 0; i < array.Length; i++)
// {

//     array[i]*=-1;
    
//     Console.Write(array[i] + " ");

// }

// }


// int[] array = Arr();
// Console.WriteLine(String.Join(" ", array));
// NegaTiv(array);



int [] Arr(int qwe)
{
    int[] array = new int[qwe];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(4, 8);
               
    }
    return array;
}
Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

bool HearPoint(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] == a)
        return true;   
    }
    return false;  
}

int[] array = Arr(6);
Console.WriteLine(String.Join(" ", array));
Console.WriteLine(HearPoint(array));