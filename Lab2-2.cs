using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the variant of the formula (1 for A, 2 for B, 3 for C):");
        int variant = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the value of x (in radians):");
        double x = double.Parse(Console.ReadLine());

        double z;
        switch (variant)
        {
            case 1: // A: z = sqrt(tan(x))
                if (Math.Tan(x) >= 0)
                {
                    z = Math.Sqrt(Math.Tan(x));
                    Console.WriteLine($"z(x) = {z}");
                }
                else
                {
                    Console.WriteLine("Error: For A), tan(x) must be non-negative.");
                }
                break;

            case 2: // B: z = 1 / tan(x)
                if (Math.Tan(x) != 0)
                {
                    z = 1 / Math.Tan(x);
                    Console.WriteLine($"z(x) = {z}");
                }
                else
                {
                    Console.WriteLine("Error: For B), tan(x) must not be 0.");
                }
                break;

            case 3: // C: z = ln(tan(x))
                if (Math.Tan(x) > 0)
                {
                    z = Math.Log(Math.Tan(x));
                    Console.WriteLine($"z(x) = {z}");
                }
                else
                {
                    Console.WriteLine("Error: For C), tan(x) must be positive.");
                }
                break;

            default:
                Console.WriteLine("Error: Invalid variant. Please enter 1, 2, or 3.");
                break;
        }
    }
}
