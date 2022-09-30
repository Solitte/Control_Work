// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.

string[] InputArray()
{
    Console.WriteLine("Input size of the array");
    int size = Convert.ToInt32(Console.ReadLine());
    string[] array = new string[size];
    Console.WriteLine($"Input elements of array: ");
    for (int i = 0; i<size; i++)
    {
        Console.Write($"{i} - ");
        array[i] = Console.ReadLine();
    }
    return array;
}

void PrintArray(string[] array)
{
    for (int i = 0; i<array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();    
}
