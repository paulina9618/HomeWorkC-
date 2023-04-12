// Задача 1. Напишите программу, которая принимает на вход число (A) и выдает сумму чисел от 1 до A.

// 7 -> 28
// 4 -> 10
// 8 -> 36

// int FindSum(int a)
// {
//     int sum = 0;
//     for(int current = 1; current <= a; current++)
//     {
//         sum = sum + current; // sum+=current;
//     }
//     return sum;
// }

// Console.WriteLine("Input A");
// int a = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(FindSum(a));


// Задача 4. Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.

// [1,0,1,1,0,1,0,0]

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
     int[] array = new int[size];
     for(int i = 0; i < size; i++)
     {
        array[i] = new Random().Next(minValue, maxValue + 1);
     }
     return array; 
}

void ShowArray (int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine("Input array size");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input minValue of array element");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input maxValue of array element");
int maxValue = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray(size, minValue, maxValue);

ShowArray(CreateRandomArray(size, minValue, maxValue));




