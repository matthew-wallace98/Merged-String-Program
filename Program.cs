using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merged_String_Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Assignment 1: Merge Strings
            Console.WriteLine("Assignment 1: Merge Strings");
            Console.WriteLine(MergeStrings("abc", "pqr"));
            Console.WriteLine(MergeStrings("ab", "pqrs"));
            Console.WriteLine();

            // Assignment 2: Sum of Digits
            Console.WriteLine("Assignment 2: Sum of Digits");
            Console.WriteLine(SumDigits(1234));
            Console.WriteLine();

            // Assignment 3: Find Substring
            Console.WriteLine("Assignment 3: Find Substring");
            Console.WriteLine(FindSubstring("this is a string", "is"));
            Console.WriteLine();

            // Assignment 4: Check for Duplicates
            Console.WriteLine("Assignment 4: Check for Duplicates");
            Console.WriteLine(ContainsDuplicate(new int[] { 1, 2, 3, 1 }));
            Console.WriteLine(ContainsDuplicate(new int[] { 1, 2, 3, 4 }));
            Console.WriteLine(ContainsDuplicate(new int[] { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 }));

            Console.ReadKey();
        }
        // Function to merge two strings in alternating order
        public static string MergeStrings(string word1, string word2)
        {
            // Create a StringBuilder to store the result
            var result = new StringBuilder();
            // Initialize two pointers to traverse both strings
            int i = 0, j = 0;
            // Loop until we reach the end of both strings
            while (i < word1.Length || j < word2.Length)
            {
                // If we haven't reached the end of word1, append the current character to the result
                if (i < word1.Length)
                    result.Append(word1[i++]);
                // If we haven't reached the end of word2, append the current character to the result
                if (j < word2.Length)
                    result.Append(word2[j++]);
            }
            // Return the merged string
            return result.ToString();
        }

        // Function to calculate the sum of the individual digits of a given number
        public static int SumDigits(int number)
        {
            // Initialize the sum to 0
            int sum = 0;
            // Loop until the number becomes 0
            while (number != 0)
            {
                // Add the last digit of the number to the sum
                sum += number % 10;
                // Remove the last digit from the number
                number /= 10;
            }
            // Return the sum of the digits
            return sum;
        }

        // Function to search the position of a substring within a string
        public static int FindSubstring(string str, string substr)
        {
            // Use the IndexOf method to find the position of the substring in the string
            // Add 1 to the result to make the position 1-indexed
            return str.IndexOf(substr) + 1;
        }

        // Function to check if any value appears at least twice in an array
        public static bool ContainsDuplicate(int[] nums)
        {
            // Create a HashSet to store the numbers
            var set = new HashSet<int>();
            // Traverse the array
            foreach (var num in nums)
            {
                // If the number is already in the set, it's a duplicate, so return true
                if (set.Contains(num))
                    return true;
                // Otherwise, add the number to the set
                set.Add(num);
            }
            // If we haven't found any duplicates, return false
            return false;
        }
    }
}
