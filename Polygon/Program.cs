namespace Tests
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintPolygon(-5);
            Console.WriteLine();
            PrintPolygon(1);
            Console.WriteLine();
            PrintPolygon(2);
            Console.WriteLine();
            PrintPolygon(3);
            Console.WriteLine();
            PrintPolygon(4);
            Console.WriteLine();
            PrintPolygon(5);
            Console.WriteLine();
            PrintPolygon(6);
            Console.WriteLine();
        }

        static void PrintPolygon(int n)
        {
            if (n < 1)
            {
                Console.WriteLine("Please give a number more than 0");
                return;
            }
                

            for (int i = 1; i <= n; i++)
            {
                for (int j = 0; j < n - i; j++)
                {
                    Console.Write(' ');
                }

                for (int j = 0; j < i * 2 - 1; j++)
                {
                    Console.Write('*');
                }

                Console.WriteLine();
            }

            int y = 3;
            for (int i = n + 1; i < n * 2; i++)
            {
                for (int j = 0; j < i - n; j++)
                {
                    Console.Write(' ');
                }

                for (int j = 0; j < n * 2 - y; j++)
                {
                    Console.Write('*');
                }

                y += 2;
                Console.WriteLine();
            }
        }
    }
}