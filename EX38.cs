//Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

using static Library38;
using static System.Console;
{
    int[] ar = CreateArray(5);
    Fill(ar);
    Console.WriteLine(Print(ar));
    int max = ar.Max();  
    int min = ar.Min();
    int diff = 0;

diff = max - min;
Console.WriteLine("Max: " + max);
Console.WriteLine("Min: " + min);
Console.WriteLine("Разность между min и max: " + diff);
}


