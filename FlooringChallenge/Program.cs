using System;

class Program
{
    const int COST_PER_HOUR = 86;
    const int AVG_FT_SQUARE = 20;

    static void Main(string[] args)
    {
        int roomForm;
        double flooringArea = 0;

        Console.WriteLine("Welcome to our flooring coverage service!");

        do
        {
            Console.WriteLine("Select number for the room shape:");
            Console.WriteLine("1. Square or Rectangle");
            Console.WriteLine("2. Triangle");
            Console.WriteLine("3. Circle");
            Console.WriteLine("4. Exit");
            roomForm = Convert.ToInt32(Console.ReadLine());

            switch (roomForm)
            {
                case 1: // Square or Rectangle
                    Console.WriteLine("Enter width:");
                    double width = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter length:");
                    double length = Convert.ToInt32(Console.ReadLine());

                    flooringArea = width * length;
                    break;

                case 2: // Triangle
                    Console.WriteLine("Enter width:");
                    width = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter length:");
                    length = Convert.ToInt32(Console.ReadLine());

                    flooringArea = width * length * 0.5;
                    break;

                case 3: // Circle
                    Console.WriteLine("Enter radius:");
                    double radius = Convert.ToInt32(Console.ReadLine());

                    flooringArea = Math.PI * Math.Pow(radius, 2);
                    break;

                case 4:
                    Console.WriteLine("Thanks for choosing or services!");
                    return;

                default:
                    Console.WriteLine("Option not available; try again");
                    Console.WriteLine();
                    break;
            }
        }
        while (roomForm <= 0 || roomForm > 4);

        Console.WriteLine("Enter cost per unit:");
        double costPerUnit = Convert.ToInt32(Console.ReadLine());

        // Area Calculation
        double flooringAreaCost = flooringArea * costPerUnit;
        double laborCost = (flooringArea / AVG_FT_SQUARE) * COST_PER_HOUR;
        double totalCost = flooringAreaCost + laborCost;
        Console.WriteLine($"The total flooring cost is: {totalCost}");
        Console.WriteLine("Thanks for choosing or services!");
    }
}
