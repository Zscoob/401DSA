using System;

namespace CodeChallengePrework
{
    class Program
    {
        static void Main(string[] args)
        {
            PerfectSequence();
        }
        public static void PerfectSequence()
        {

            Console.WriteLine("Provide numbers for your array");
            int arrLength = int.Parse(Console.ReadLine());
            int inputSum = 0;
            int inputProduct = 1;
            int[] userInput = new int[arrLength];
            for (int i = 0; i < arrLength; i++)
            {
                Console.WriteLine("Please enter another number");
                userInput[i] = int.Parse(Console.ReadLine());
            }

            foreach (int number in userInput)
            {               
                inputProduct *= number;
                inputSum += number;
            }
       
            if (inputSum > 0 && inputSum == inputProduct)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}


 

    
