using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введіть кількість студентів:");
        if (!int.TryParse(Console.ReadLine(), out int n) || n <= 0)
        {
            Console.WriteLine("Некоректне значення кількості студентів!");
            return;
        }

        // Масив для зберігання балів
        int[] scores = new int[n];

        Console.WriteLine("Введіть бали студентів:");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Бали студента {i + 1}: ");
            if (!int.TryParse(Console.ReadLine(), out scores[i]))
            {
                Console.WriteLine("Некоректне значення, спробуйте ще раз.");
                i--; // Повторний ввід
            }
        }

        // Сортування масиву у порядку зменшення
        Array.Sort(scores);
        Array.Reverse(scores);

        // Виведення відсортованих балів
        Console.WriteLine("\nБали студентів після сортування у порядку зменшення:");
        foreach (var score in scores)
        {
            Console.WriteLine(score);
        }
    }
}
