using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            Console.Write("Enter the length of your array: ");
            input = Console.ReadLine();
            int arrayLength = Convert.ToInt32(input);
            Console.WriteLine($"Array length is: {arrayLength}");

            var random = new Random();
            int[] numArray = new int[arrayLength];

            for (int counter = 0; counter < numArray.Length; counter++)
            {
                numArray[counter] = random.Next();
            }

            for (int counter = 0; counter < numArray.Length - 1; counter++)
            {
                for (int i = counter + 1; i < numArray.Length; i++)
                {
                    if (numArray[counter] > numArray[i])
                    {
                        int temp = numArray[counter];
                        numArray[counter] = numArray[i];
                        numArray[i] = temp;
                    }
                }
            }

            for (int counter = 0; counter < numArray.Length; counter++)
            {
                Console.WriteLine(numArray[counter]);
            }
        }
    }
}