using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите размер массива:");
        int arraySize = ReadArraySize();
        Console.WriteLine("Введите элементы массива:");
        string[] inputArray = FillArray(arraySize);
        Console.WriteLine("Введённый массив:");
        PrintArray(inputArray);
        Console.WriteLine("Новый массив, в котором находятся элементы из первоначального массива, длина которых меньше, либо равна 3 символам:");
        int maxStringLength = 3;
        string[] newArray = FilterArray(inputArray, maxStringLength);
        PrintArray(newArray);
    }

    static int ReadArraySize()
    {
        while (true)
        {
            string input = Console.ReadLine()!;

            if (int.TryParse(input, out int arraySize) && arraySize > 0)
            {
                return arraySize;
            }
            else
            {
                Console.WriteLine("Введено некорректное значение. Пожалуйста, введите положительное целое число.");
            }
        }
    }

    static string[] FillArray(int size)
    {
        string[] array = new string[size];

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"Элемент {i + 1}: ");
            array[i] = Console.ReadLine()!;
        }
        return array;
    }

    static string[] FilterArray(string[] array, int maxStringLength)
    {
        int newSize = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i].Length <= maxStringLength)
            {
                newSize++;
            }
        }

        string[] newArray = new string[newSize];
        int index = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i].Length <= maxStringLength)
            {
                newArray[index] = array[i];
                index++;
            }
        }
        return newArray;
    }

    static void PrintArray(string[] array)
    {
        Console.Write("[");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i]);

            if (i < array.Length - 1)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine("]");
    }
}