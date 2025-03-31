using System;

class Program
{
    // Функція для введення масиву з клавіатури
    static int[] InputArray(string arrayName)
    {
        Console.WriteLine($"Введіть кількість елементів у масиві {arrayName}:");
        if (!int.TryParse(Console.ReadLine(), out int size) || size <= 0)
        {
            Console.WriteLine("Некоректний розмір масиву!");
            return new int[0];
        }

        int[] array = new int[size];
        Console.WriteLine($"Введіть елементи масиву {arrayName}:");
        for (int i = 0; i < size; i++)
        {
            Console.Write($"Елемент {i + 1}: ");
            if (!int.TryParse(Console.ReadLine(), out array[i]))
            {
                Console.WriteLine("Некоректне значення, спробуйте ще раз.");
                i--; // Повторний ввід
            }
        }
        return array;
    }

    // Функція для аналізу масиву
    static void AnalyzeArray(int[] array, string arrayName)
    {
        if (array.Length == 0)
        {
            Console.WriteLine($"Масив {arrayName} порожній, аналіз неможливий.");
            return;
        }

        int min = array[0];
        int max = array[0];
        int minIndex = 0;
        int maxIndex = 0;

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
                minIndex = i;
            }
            if (array[i] > max)
            {
                max = array[i];
                maxIndex = i;
            }
        }

        Console.WriteLine($"Масив {arrayName}: Найменший елемент = {min} (Індекс: {minIndex}), Найбільший елемент = {max} (Індекс: {maxIndex})");
    }

    static void Main()
    {
        // Введення трьох масивів
        int[] array1 = InputArray("1");
        int[] array2 = InputArray("2");
        int[] array3 = InputArray("3");

        // Аналіз трьох масивів
        AnalyzeArray(array1, "1");
        AnalyzeArray(array2, "2");
        AnalyzeArray(array3, "3");
    }
}
