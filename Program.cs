// Задача: Написать программу, которая из имеющегося массива строк формирует 
// массив из строк, длина которых меньше либо равна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте 
// выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

int CountElements(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) count = count + 1;
    }
    return count;
}

string[] MainTask(string[] inputArray, int newArrLength)
{
    string[] outputArray = new string[newArrLength];
    int index = 0;
    for (int i = 0; i < inputArray.Length; i = i + 1)
    {
        if (inputArray[i].Length <= 3)
        {
            outputArray[index] = inputArray[i];
            index = index + 1;
        }
    }
    return outputArray;
}

string Print(string[] array)
{
    int length = array.Length;
    string output = String.Empty;
    for (int i = 0; i < length; i++)
    {
        output += ($"{array[i]}, ");
    }
    return output;
}

string[] inputArray = { "hello", "2", "world", ":-)" };
string input = Print(inputArray);
Console.WriteLine($"Исходный массив: [{input}]");
int outputArrayLength = CountElements(inputArray);
string[] outputArray = MainTask(inputArray, outputArrayLength);
string output = Print(outputArray);
Console.WriteLine($"Итоговый массив: [{output}]");