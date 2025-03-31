using System;

class Program
{
    static void Main()
    {
        // Масив імен учнів
        string[] names = { "Андрій", "Ольга", "Іван", "Марія", "Світлана" };

        // Масиви оцінок
        int[] mathScores = { 78, 85, 78, 92, 85 };
        int[] physicsScores = { 85, 88, 82, 89, 90 };

        Console.WriteLine("Список учнів і їхні оцінки:");
        PrintStudents(names, mathScores, physicsScores);

        // Сортування учнів
        SortStudents(names, mathScores, physicsScores);

        Console.WriteLine("\nСписок учнів після сортування за оцінками з математики та фізики:");
        PrintStudents(names, mathScores, physicsScores);
    }

    // Функція для виведення списку учнів
    static void PrintStudents(string[] names, int[] mathScores, int[] physicsScores)
    {
        for (int i = 0; i < names.Length; i++)
        {
            Console.WriteLine($"Ім'я: {names[i]}, Математика: {mathScores[i]}, Фізика: {physicsScores[i]}");
        }
    }

    // Функція для сортування учнів за оцінками
    static void SortStudents(string[] names, int[] mathScores, int[] physicsScores)
    {
        for (int i = 0; i < mathScores.Length - 1; i++)
        {
            for (int j = i + 1; j < mathScores.Length; j++)
            {
                // Сортування за математикою
                if (mathScores[i] > mathScores[j] || 
                    (mathScores[i] == mathScores[j] && physicsScores[i] > physicsScores[j]))
                {
                    // Обмін місцями для математичних оцінок
                    Swap(ref mathScores[i], ref mathScores[j]);

                    // Обмін місцями для фізичних оцінок
                    Swap(ref physicsScores[i], ref physicsScores[j]);

                    // Обмін місцями для імен
                    Swap(ref names[i], ref names[j]);
                }
            }
        }
    }

    // Функція для обміну значень між двома змінними
    static void Swap<T>(ref T a, ref T b)
    {
        T temp = a;
        a = b;
        b = temp;
    }
}
