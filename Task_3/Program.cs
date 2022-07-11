/*

Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76

*/

double[] GetArray(int array)
{
     double [] arr = new double[array];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] =  rnd.Next(100, 900) + rnd.NextDouble() % 10 ;
    }
    return arr;
}


void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"[{array[i]}] ");
    }
}

void  FindDif(double[]array)
{
    double maxNumber = array[0];
    double minNumber = array[0];

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > maxNumber)
        maxNumber = array[i];
        if (array[i] < minNumber)
        minNumber = array[i];
    }
    Console.WriteLine($" Разница между максимаильным элементом массива и минимальным  равна {maxNumber-minNumber}");
}



double[] array = GetArray(10);
PrintArray(array);
Console.WriteLine();
FindDif(array);