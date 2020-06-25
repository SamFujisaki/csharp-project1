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
                //numArray.SetValue(Convert.ToInt32(random.Next()), counter);
                numArray[counter] = random.Next();
            }

            //Array.Sort(numArray);
            // TODO: sort array without using the library function
            for (int counter = 0; counter < numArray.Length - 1; counter++)
            {
                if (numArray[counter] < numArray[counter + 1])
                {
                }
                else if (numArray[counter] > numArray[counter + 1])
                {
                    // TODO: https://discordapp.com/channels/526544713193619467/668269769446653972/725814558094262273
                    //Console.WriteLine($"{numArray[counter]} is smaller than {numArray[counter + 1]}");
                    int temp = 0;
                    temp = numArray[counter];
                    numArray[counter] = numArray[counter + 1];
                    numArray[counter + 1] = temp;
                }
            }

            for (int counter = 0; counter < numArray.Length; counter++)
            {
                Console.WriteLine(numArray[counter]);
            }
        }
    }
}