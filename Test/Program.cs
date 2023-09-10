// Написать программу, которая из имеющегося массива строк формирует 
// новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте 
// выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

// Примеры: [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]

// [“1234”, “1567”, “-2”, “computer science”] → [“-2”] [“Russia”,

// “Denmark”, “Kazan”] → []


void FilterMassive(string[] startMassive, string[] filterMassive)
{
    int count = 0;
    for (int i = 0; i < startMassive.Length; i++)
    {
        if (startMassive[i].Length <= 3)
        {
            filterMassive[count] = startMassive[i];
            count++;
        }
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }

    Console.WriteLine();
}

Console.Clear();
string[] startMassive = new string[] { "Hello", "2", "world", ":-)", "1234", "1567", "-2", "computer science" };
string[] filterMassive = new string[startMassive.Length];
FilterMassive(startMassive, filterMassive);
Console.Write($"[{String.Join(",", startMassive)}] -> ");
PrintArray(filterMassive);
