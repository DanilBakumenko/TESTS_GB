﻿// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

string[] startArray = new string[10] { "1234", "1567", "-2", "computer science", "asd", "6", "qwerfd", "6713", "", "234" };

string[] RemoveValuesInArrayWithLengthGreaterThanThree(string[] array)
{
    string[] newArray = new string[0];
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length < 4)
        {
            count++;
            Array.Resize(ref newArray, count);
            newArray[count - 1] = array[i];
        }
    }
    return newArray;
}
void PrintArrayWithStrings(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

string[] newArray = RemoveValuesInArrayWithLengthGreaterThanThree(startArray);

PrintArrayWithStrings(newArray);