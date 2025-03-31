using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Оберіть формулу: alfa, beta, або gamma");
        string formulaVariant = Console.ReadLine();

        Console.WriteLine("Введіть значення x:");
        if (!double.TryParse(Console.ReadLine(), out double x))
        {
            Console.WriteLine("Невірне значення x!");
            return;
        }

        Console.WriteLine("Введіть значення a:");
        if (!double.TryParse(Console.ReadLine(), out double a))
        {
            Console.WriteLine("Невірне значення a!");
            return;
        }

        double z;
        switch (formulaVariant.ToLower())
        {
            case "alfa":
                if (a + Math.Sin(x) < 0)
                {
                    Console.WriteLine("Умова не виконується: a + sin(x) повинно бути >= 0.");
                }
                else
                {
                    z = Math.Sqrt(a + Math.Sin(x));
                    Console.WriteLine($"z(x) = {z}");
                }
                break;

            case "beta":
                if (Math.Sin(a * x) < 0)
                {
                    Console.WriteLine("Умова не виконується: sin(a * x) повинно бути >= 0.");
                }
                else
                {
                    z = Math.Sqrt(Math.Sin(a * x));
                    Console.WriteLine($"z(x) = {z}");
                }
                break;

            case "gamma":
                if (a - x <= 0)
                {
                    Console.WriteLine("Умова не виконується: a - x повинно бути > 0.");
                }
                else
                {
                    z = Math.Log(a - x);
                    Console.WriteLine($"z(x) = {z}");
                }
                break;

            default:
                Console.WriteLine("Невірний варіант формули.");
                break;
        }
    }
}
