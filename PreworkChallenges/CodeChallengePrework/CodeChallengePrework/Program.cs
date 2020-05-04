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
}

 

    
