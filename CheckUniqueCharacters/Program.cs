using System;
using System.Collections.Generic;

namespace CheckUniqueCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kindly input your word if check if it has unique characters");
            string Input = Console.ReadLine();
            bool output = UniqueCharactersCheck(Input);
            Console.WriteLine(output);
        }

        public static bool UniqueCharactersCheck(string InputText)
        {
            Dictionary<char, int> d = new Dictionary<char, int>();

            foreach (char item in InputText)
            {
                if (d.ContainsKey(item))
                {
                    return false;
                }
                else
                {
                    d.Add(item, 1);
                }
            }
            return true;
        }
    }
}
