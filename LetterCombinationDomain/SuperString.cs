using System.Collections.Generic;
using System.Linq;

namespace LetterCombinationDomain
{
    public class SuperString
    {
        /// <summary>Returns a combination of letters for a number in a telephone</summary>
        /// <param name="str">String of numbers</param>
        /// <returns>List of strings</returns>
        public static IEnumerable<string> GetCombinationLetters(string str)
        {
            if (string.IsNullOrEmpty(str)) return new List<string>();

            var numbers = new string[10]
            {
                "",
                "",
                "abc",
                "def",
                "ghi",
                "jkl",
                "mno",
                "pqrs",
                "tuv",
                "wxyz"
            };

            if (str.Length == 1)
            {
                return numbers[str[0] - '0']
                    .Select(x => x.ToString());
            }

            var result = new List<string>();

            CombineLettersRecursive(0, str, numbers, result, "");

            return result;
        }

        /// <summary>Add the elements to an existing list of strings in a recursive fashion</summary>
        /// <param name="index">Current index of operation</param>
        /// <param name="str">String of numbers</param>
        /// <param name="numbers">Letters that correspond to each number</param>
        /// <param name="result">Resulting list</param>
        /// <param name="current">Current string of operation</param>
        private static void CombineLettersRecursive
        (
            int index,
            string str,
            string[] numbers,
            List<string> result,
            string current
        )
        {
            if (index == str.Length)
            {
                result.Add(current);
                return;
            }

            string letters = numbers[str[index] - '0'];

            for (int i = 0; i < letters.Length; i++)
            {
                CombineLettersRecursive(index + 1, str, numbers, result, current + letters[i]);
            }
        }
    }
}