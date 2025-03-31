using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введіть кількість співробітників:");
        if (!int.TryParse(Console.ReadLine(), out int n) || n <= 0)
        {
            Console.WriteLine("Некоректне значення кількості співробітників!");
            return;
        }

        // Встановлюємо межі для зросту та ваги
        int minHeight = 150, maxHeight = 200; // Зріст в сантиметрах
        int minWeight = 50, maxWeight = 100; // Вага в кілограмах

        // Масиви для зросту та ваги
        int[] heights = new int[n];
        int[] weights = new int[n];

        Random random = new Random();

        // Генеруємо значення зросту та ваги
        for (int i = 0; i < n; i++)
        {
            heights[i] = random.Next(minHeight, maxHeight + 1);
            weights[i] = random.Next(minWeight, maxWeight + 1);
        }

        // Сортуємо масиви за зростом (вага відповідно до зросту)
        Array.Sort(heights, weights);

        // Виводимо результати
        Console.WriteLine("Зріст (см) та вага (кг) співробітників після сортування:");
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Співробітник {i + 1}: Зріст = {heights[i]}, Вага = {weights[i]}");
        }
    }
}
