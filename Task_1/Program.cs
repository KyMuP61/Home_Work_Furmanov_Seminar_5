/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2

*/


int[] GetArray(int array)
{

    int[] arr = new int[array];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(100, 1000);

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

void FindSimilarNumber(int[] array)
{
    int countEven = 0;
    int countOdd = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
            countEven++;

    }
    if (countEven == 0)
        Console.WriteLine($"В данном массиве - нет четных чисел");
    else
        Console.WriteLine($"Колличество четных элементов в массива равно {countEven}");
}



Console.WriteLine("Введите число элементов массиива: ");
int arr = int.Parse(Console.ReadLine());
int[] array = GetArray(arr);
PrintArray(array);
Console.WriteLine();
FindSimilarNumber(array);