/*
    Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
    длина которых меньше, либо равна 3 символам. 
    Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
    При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
*/

string[] ArraySmallestThreeCharacters(string[] arr)
{
    int j = 0;
    string[] temparr = new string[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3 && arr[i] != string.Empty)
        {
            temparr[j] = arr[i];
            j++;
        }
    }

    string[] resultarr = new string[j];

    for (int i = 0; i < j; i++) resultarr[i] = temparr[i];
    return resultarr;
}
void PrintArray(string[] arr)
{
    Console.Write("[");
    if (arr.Length > 1)
    {
        for (int i = 0; i < arr.Length - 1; i++) Console.Write($"{arr[i]}, ");
    }
    Console.Write($"{arr[arr.Length - 1]}]");
}

Console.WriteLine("Введите строки с разным количеством символов!");
Console.WriteLine("Для разделения используйте пробел!");
Console.WriteLine("Когда захотите остановиться, нажмите Enter");
string[] result = ArraySmallestThreeCharacters(Console.ReadLine()!.Split(" "));

Console.WriteLine("Массив из строк, длина которых меньше трех символов:");
PrintArray(result);

