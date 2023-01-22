// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

/*
int[] CreateRandArray(int size)
{   
    int[] array = new int[size];
    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

int CheckNumb(int[] array)
{   
    int count = 0;
    for(int i = 0; i < array.Length; i++)
        if(array[i] % 2 == 0) count++;
    return count;
}

Console.Write("Enter a length of array: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreateRandArray(size);
ShowArray(newArray);
Console.Write($"Number of even numbers - {CheckNumb(newArray)}");
*/


// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

/*
int[] CreateRandArray(int size)
{   
    int[] array = new int[size];
    for(int i = 0; i < size; i++)
    {   
        Console.Write("Enter number: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

void SumValue(int[] array)
{   
    int sum = 0;
    for(int i = 1; i < array.Length; i += 2)
        sum += array[i];
    Console.Write($"Sum of even elements is {sum}");
}

Console.Write("Enter a length of array: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreateRandArray(size);
ShowArray(newArray);
SumValue(newArray);
*/


// Задача 38: Задайте массив вещественных (double) чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] CreateRandDoubleArr(int size)
{   
    double[] array = new double[size];
    for(int i = 0; i < size; i++)
        array[i] = Math.Round(new Random().Next(0, 100) + new Random().NextDouble(), 2);
    return array;
}

void ShowArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

void MinMax(double[] array)
{
    double min = array[0];
    double max = array[1];
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > max) max = array[i];
        else if (array[i] < min) min = array[i];
    }
    Console.WriteLine($"Минимальное число: {min}");
    Console.WriteLine($"Минимальное число: {max}");
    Console.WriteLine($"Разница между максимальным и минимальным числами: {max-min}");
}

Console.Write("Enter a length of array: ");
int size = Convert.ToInt32(Console.ReadLine());

double[] newArray = CreateRandDoubleArr(size);
ShowArray(newArray);
MinMax(newArray);