using System;
using LetterCombinationDomain;

namespace LetterCombinationConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var str = "23";
            var result = SuperString.GetCombinationLetters(str);
            
            foreach (var item in result)
            {
                Console.Write($"{item} ");
            }
        }
    }
}
