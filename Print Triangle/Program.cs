namespace PrintingTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the height of the triangle:");

            if (int.TryParse(Console.ReadLine(), out int height))
            {
                PrintTriangle(height);
            }
            else
            {
                Console.WriteLine("Invalid input.Enter a valid integer.");
            }
        }

        static void PrintTriangle(int height)
        {
            for (int i = 1; i <= height; i++)
            {
                for (int j = 0; j < height - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < 2 * i - 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}