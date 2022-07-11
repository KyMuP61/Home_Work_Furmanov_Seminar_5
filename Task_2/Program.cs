/*

Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0

*/


int[] GetArray(int array)
{
    int[] arr = new int[array];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(1, 10);
    }
    return arr;
}


void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
}



void SumArray(int[]array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(i%2 == 1)
        sum+= array[i];        
    }
    Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях равна {sum}");
}   


Console.WriteLine("Введите число элементов массиива: ");
int arr = int.Parse(Console.ReadLine());
int[] array = GetArray(arr);
PrintArray(array);
Console.WriteLine();
SumArray(array);