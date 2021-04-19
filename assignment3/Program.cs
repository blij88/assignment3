using System;
using System.Collections.Generic;

namespace assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("give me a string");
            List<string> treeBuilder = CreateListOfChristmasStrings(Console.ReadLine()) ;
            for (int i = 0; i < treeBuilder.Count; i++)
            {
                if (i%2 ==0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
               Console.WriteLine(treeBuilder[i]);
            }

            Console.ReadLine();
        }

        private static List<string> CreateListOfChristmasStrings(string starterString)
        {
            if (starterString.Length < 5)
            {
            while(starterString.Length<14)
            {
                starterString += "~";
            }
            }
            char[] trunk = starterString.Substring(starterString.Length - 2).ToCharArray();
            char[] branches = starterString.Remove(starterString.Length - 2).ToCharArray();
            List<string> ChristmasStrings = new List<string>();
            Int16 branchwidth = 1;
            foreach (char character in branches)
            {
                string tempString = new string(character, branchwidth);
                tempString = tempString.PadLeft(tempString.Length/2+branches.Length);
                ChristmasStrings.Add(tempString);
                branchwidth += 2;
            }

            foreach (char character in trunk)
            {
                string tempString = new string(character, 3);
                tempString = tempString.PadLeft(branches.Length+1);
                ChristmasStrings.Add(tempString);
            }

            return ChristmasStrings;
        }
    }
}
