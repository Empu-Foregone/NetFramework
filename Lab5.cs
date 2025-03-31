using System;

class Television
{
    public string Name { get; set; } // Назва (марка)
    public bool IsColor { get; set; } // Кольоровий чи чорно-білий
    public int ScreenSize { get; set; } // Розмір екрану по діагоналі
    public int ChannelCount { get; set; } // Кількість каналів
    public decimal Price { get; set; } // Ціна

    public override string ToString()
    {
        return $"Марка: {Name}, Тип: {(IsColor ? "Кольоровий" : "Чорно-білий")}, Розмір екрана: {ScreenSize} см, Кількість каналів: {ChannelCount}, Ціна: {Price} грн.";
    }
}

class Program
{
    static void Main()
    {
        // Масив телевізорів
        Television[] televisions = new Television[]
        {
            new Television { Name = "Samsung", IsColor = true, ScreenSize = 42, ChannelCount = 120, Price = 12000 },
            new Television { Name = "LG", IsColor = true, ScreenSize = 50, ChannelCount = 140, Price = 15000 },
            new Television { Name = "Sony", IsColor = true, ScreenSize = 55, ChannelCount = 150, Price = 20000 },
            new Television { Name = "Electron", IsColor = false, ScreenSize = 32, ChannelCount = 60, Price = 6000 },
            new Television { Name = "Panasonic", IsColor = true, ScreenSize = 40, ChannelCount = 100, Price = 10000 }
        };

        // Введення критеріїв фільтрації
        Console.WriteLine("Введіть максимальну суму грошей:");
        if (!decimal.TryParse(Console.ReadLine(), out decimal maxPrice))
        {
            Console.WriteLine("Некоректна сума!");
            return;
        }

        Console.WriteLine("Введіть мінімальний розмір екрану по діагоналі (см):");
        if (!int.TryParse(Console.ReadLine(), out int minScreenSize))
        {
            Console.WriteLine("Некоректний розмір екрану!");
            return;
        }

        // Фільтрація даних
        Console.WriteLine("\nДоступні телевізори:");
        foreach (var tv in televisions)
        {
            if (tv.Price <= maxPrice && tv.ScreenSize >= minScreenSize)
            {
                Console.WriteLine(tv);
            }
        }
    }
}
