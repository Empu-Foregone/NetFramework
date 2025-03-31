using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the variant of the formula (1, 2, or 3):");
        int variant = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the value of x:");
        double x = double.Parse(Console.ReadLine());

        double z;
        switch (variant)
        {
            case 1:
                // Variant 1: z = sin^2(x)
                z = Math.Sin(x) * Math.Sin(x);
                Console.WriteLine($"z(x) = {z}");
                break;

            case 2:
                // Variant 2: z = log^2(x)
                if (x > 0)
                {
                    z = Math.Log(x) * Math.Log(x);
                    Console.WriteLine($"z(x) = {z}");
                }
                else
                {
                    Console.WriteLine("Error: For variant 2, x must be greater than 0.");
                }
                break;

            case 3:
                // Variant 3: z = 1 / cos(x^3)
                double cosineValue = Math.Cos(Math.Pow(x, 3));
                if (cosineValue != 0)
                {
                    z = 1 / cosineValue;
                    Console.WriteLine($"z(x) = {z}");
                }
                else
                {
                    Console.WriteLine("Error: For variant 3, cos(x^3) must not be 0.");
                }
                break;

            default:
                Console.WriteLine("Error: Invalid variant. Please enter 1, 2, or 3.");
                break;
        }
    }
}
