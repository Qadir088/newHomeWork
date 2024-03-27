using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region
            //Console.WriteLine("Enter a word:");
            //string word = Console.ReadLine();

            //bool isPalindrome = IsPalindrome(word);

            //if (isPalindrome)
            //{
            //    Console.WriteLine($"'{word}' is a palindrome!");
            //}
            //else
            //{
            //    Console.WriteLine($"'{word}' is not a palindrome.");
            //}
            
            #endregion
            #region
            //Console.WriteLine("Enter a sentence:");
            //string input = Console.ReadLine();

            //var letterCount = 0;
            //foreach (char letter in input)
            //{
            //    if (char.IsLetter(letter))
            //    {
            //        char lowercaseLetter = char.ToLower(letter);
            //        if (letterCount.Contains(lowercaseLetter))
            //        {
            //            letterCount++;
            //        }
            //        else
            //        {
            //            letterCount= 1;
            //        }
            //    }
            //}

            //Console.WriteLine("Number of similar letters in the sentence:");

            //foreach (var letter in letterCount)
            //{
            //    Console.WriteLine($"'{letter.Value}");
            //}
            #endregion
            revText();
        }
        #region
        //static bool IsPalindrome(string word)
        //{
        //    int start = 0;
        //    int end = word.Length - 1;

        //    while (start < end)
        //    {
        //        if (word[start] != word[end])
        //        {
        //            return false;
        //        }
        //        start++;
        //        end--;
        //    }
        //    return true;
        //}
        #endregion
        static void revText()
        {
            string text = "Baku,Ganja,Sumgait";
            Console.WriteLine(text.Reverse());
        }
    }
}
