using System;

namespace CodeChallengePrework
{
    class Program
    {
        static void Main(string[] args)
        {
            LeapYearCalc();
        }
        private static void LeapYearCalc()
            {
           
            Console.Write("Input an year : ");
            int year = int.Parse(Console.ReadLine());

            if ((year % 400) == 0)
                Console.WriteLine("{0} is a leap year.", year);
            else if ((year % 100) == 0)
                Console.WriteLine("{0} is not a leap year.", year);
            else if ((year % 4) == 0)
                Console.WriteLine("{0} is a leap year.", year);
            else
                Console.WriteLine("{0} is not a leap year.", year);
        }
    }


    /*
    static void Main(string[] args)
    {
       ArrayMaxResult();
    }
    private static void ArrayMaxResult()
    {
        int[] newArray = new int[5];
        for (int i = 0; i < newArray.Length; i++)
        {
            Console.WriteLine("Pick a number between 1 and 10");

            int userInput = int.Parse(Console.ReadLine());

            if (userInput < 1 || userInput > 10)
            {
                Console.WriteLine("Number not within limits");
                i--;
            }
            else
            {
                newArray[i] = userInput;
            }
        }

        Console.WriteLine(string.Join(", ", newArray));

        Console.WriteLine("Choose one of your numbers");

        int userChoice = int.Parse(Console.ReadLine());
        int counter = 0;
        foreach (int number in newArray)
        {
            if (userChoice == number)
            {
                counter++;
            }
        }
        int score = userChoice * counter;

        Console.WriteLine($"Score: {score}");
    */
}

    
