using System;

namespace StringNumber_Manipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter some numbers for me(seperated by commas).");

            var input = Console.ReadLine();

            Console.WriteLine("Would you like those to be squared (y/n)");

            var userInput = Console.ReadLine();
            var splitInput = input.Split(',');
            int total = 0;
            if (userInput == "n")
            {
                for (int idx = 0; idx < splitInput.Length; idx++)
                {
                    var newNum = int.Parse(splitInput[idx]);
                    if (idx == 0)
                    {
                        total = newNum;
                    }
                    else
                    {
                        total = newNum * total;
                    }
                }
                Console.Write(total);
            }
            else
            {
                int arrLength = splitInput.Length;
                int[] newArr = new int[arrLength];
                for (int idx = 0; idx < splitInput.Length; idx++)
                {
                    var newNum = int.Parse(splitInput[idx]);
                    newArr[idx] = newNum * newNum;
                }
                Console.WriteLine(String.Join(",",newArr));
            }

            Console.ReadLine();
        }
    }
}
