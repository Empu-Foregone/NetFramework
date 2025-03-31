using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Оберіть варіант формули: A, B або C");
        string formulaVariant = Console.ReadLine();

        Console.WriteLine("Введіть значення x:");
        if (!double.TryParse(Console.ReadLine(), out double x))
        {
            Console.WriteLine("Невірне значення x!");
            return;
        }

        double z;
        switch (formulaVariant.ToUpper())
        {
            case "A":
                if (x < 0 || Math.Sin(x) < 0)
                {
                    Console.WriteLine("Умова не виконується: x має бути >= 0, sin(x) >= 0.");
                }
                else
                {
                    z = Math.Sqrt(Math.Sin(x));
                    Console.WriteLine($"z(x) = {z}");
                }
                break;

            case "B":
                if (Math.Cos(x) == 0)
                {
                    Console.WriteLine("Умова не виконується: cos(x) не може бути дорівнювати 0.");
                }
                else
                {
                    z = 1 / Math.Cos(x);
                    Console.WriteLine($"z(x) = {z}");
                }
                break;

            case "C":
                if (Math.Tan(x) == 0 || Math.Abs(Math.Tan(x)) < double.Epsilon)
                {
                    Console.WriteLine("Умова не виконується: tan(x) не може бути дорівнювати 0.");
                }
                else
                {
                    z = Math.Log(Math.Abs(Math.Tan(x)));
                    Console.WriteLine($"z(x) = {z}");
                }
                break;

            default:
                Console.WriteLine("Невірний варіант формули.");
                break;
        }
    }
}
