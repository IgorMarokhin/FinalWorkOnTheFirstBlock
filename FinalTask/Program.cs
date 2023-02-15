// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина
// которых меньше или равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо
// задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.
//
// Примеры:
//
// ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
//
// ["1234", "1567", "-2", "computer science"] -> ["-2"]
// 
// ["Russia", "Denmark", "Kazan"] -> []

string[] array = { "hello", "1632", "13", "my", "5101", "18", "dear", "4151", "41", "friend" };
Console.Write($"[{String.Join(", ", array)}]");

string[] arrayThreeChar = FindThreeCharElement(array);

Console.WriteLine($" -> [{String.Join(", ", arrayThreeChar)}]");

/////////////////////////////////////////////

string[] FindThreeCharElement(string[] array)
{
    string[] result = new string[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            result[i] = array[i];
        }
    }
    result = result.Where(x => x != null).ToArray();
    return result;
}