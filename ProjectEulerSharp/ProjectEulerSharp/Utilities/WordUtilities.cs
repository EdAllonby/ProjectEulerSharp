using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectEulerSharp.Utilities
{
    public static class WordUtilities
    {
        /// <summary>
        /// Find all permutations of a string
        /// </summary>
        /// <param name="word">string to find permutations for.</param>
        /// <returns>A list of permutations for the input string.</returns>
        public static IEnumerable<string> FindPermutations(string word)
        {
            if (word.Length == 1)
            {
                yield return word;
            }

            if (word.Length == 2)
            {
                char[] character = word.ToCharArray();
                var s = new string(new[] { character[1], character[0] });
                yield return word;
                yield return s;
                yield break;
            }

            IEnumerable<string> subsetPermutations = FindPermutations(word.Substring(1));
            char firstChar = word[0];

            foreach (string temp in subsetPermutations.Select(s => firstChar + s))
            {
                yield return temp;
                char[] chars = temp.ToCharArray();
                for (var i = 0; i < temp.Length - 1; i++)
                {
                    char t = chars[i];
                    chars[i] = chars[i + 1];
                    chars[i + 1] = t;
                    yield return new string(chars);
                }
            }
        }

        public static int LetterToAlphabetIndex(char letter)
        {
            if (letter < 'A' && letter > 'z')
            {
                throw new ArgumentException($"'{letter}' is not a letter.");
            }

            return char.ToUpper(letter) - 64;
        }
    }
}