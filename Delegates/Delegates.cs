using System;

namespace Project4
{
    class Delegates
    {
        delegate void PrintWordsDelegate(string[] words);

        static void Main(string[] args)
        {
            string[] words = new string[5];
            string[] original = new string[5];

            // Prompt the user to enter five words
            for (int i = 0; i < words.Length; i++)
            {
                Console.Write($"Enter word {i + 1}: ");
                words[i] = Console.ReadLine()!;
            }

            PrintWordsDelegate printDelegate = null!;

            // Assign the first method to the delegate
            printDelegate += AlphabetizeWords;

            // Assign the second method to the delegate
            printDelegate += ReverseWords;

            // Assign the third method to the delegate
            printDelegate += (words) =>
            {
                Console.Write("ORIGINAL: ");
                Console.WriteLine(string.Join(", ", words));
            };

            // Invoke the delegate
            printDelegate(words);
        }

        static void AlphabetizeWords(string[] words)
        {
            var sorted = words.OrderBy(w => w);
            Console.Write("ALPHABETIZED: ");
            Console.WriteLine(string.Join(", ", sorted));
        }

        static void ReverseWords(string[] words)
        {
            var r_sorted = words.OrderBy(w => w);
            r_sorted.Reverse();
            /*for (int i = 0; i < words.Length; i++)
            {
                char[] charArray = sorted.ToCharArray();
                Array.Reverse(charArray);
                words[i] = new string(charArray);
            }*/

            Console.Write("REVERSED: ");
            Console.WriteLine(string.Join(", ", r_sorted));
        }
    }
}

