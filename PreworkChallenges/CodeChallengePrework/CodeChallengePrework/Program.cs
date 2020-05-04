using System;

namespace CodeChallengePrework
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("***********SUM OF THE ROWS*************");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");
            TheMatrix();
            
        }
        private static void TheMatrix()
        {
            Console.WriteLine("How many rows?");
            int rows = int.Parse(Console.ReadLine());
            Console.WriteLine("How many columns?");
            int columns = int.Parse(Console.ReadLine());
            Console.WriteLine("\n()_()");
            Console.WriteLine("(*_*)");
            Console.WriteLine("(\")(\")\n");

            int[,] neo = new int[rows, columns];
            System.Random random = new System.Random();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    int filler = random.Next(3, 45);
                    neo[i, j] = filler;
                }
            }

            int[] output = new int[rows];
            int totals = 0;

            for (int m = 0; m < neo.GetLength(0); m++)
            {
                for (int n = 0; n < neo.GetLength(1); n++)
                {
                    totals += neo[m, n];
                    Console.Write(string.Format("{0} ", neo[m, n]));
                }
                Console.Write("\n\n");
                output[m] = totals;
            }
            Console.Write("Totals: ");
            Console.WriteLine(string.Join(",", output));
        }

    }
}



