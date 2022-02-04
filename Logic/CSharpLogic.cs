using System;
using System.Collections.Generic;
using System.Linq;

namespace Logic
{
    public class CSharpLogic
    {

        /// <summary>
        /// Takes a decimal for the unit price and an int for number of units sold and returns a
        /// discounted sales total based on the quantity sold: 
        /// if greater than 99 units are sold, apply a 15% discount to the total price
        /// if greater than 49 units are sold, apply a 10% discount 10% to the total price; 
        /// if fewer than 50 units are sold, do not apply a discount to the price. 
        /// For example, if the unit price was 1.00 and the quantity sold was 100, the method
        /// should return 85.00 for the total sales amount.
        /// </summary>
        /// <param name="unitPrice">the unit price per item</param>
        /// <param name="unitAmount">the quanity being purchased</param>
        /// <returns>decimal of the discount to be applied</returns>
        public decimal GetDiscount(decimal unitPrice, int unitAmount)
        {
            decimal uP = unitPrice;
            int uA = unitAmount;
            decimal totalPrice = uA * uP;

            if (uA > 99)
            {
                totalPrice *= .85m;
            }
            else if (uA > 49 && uA <= 99)
            {
                totalPrice *= .9m;
            }

            return Math.Round(totalPrice, 2, MidpointRounding.AwayFromZero);
        }

        /// <summary>
        /// This method takes an int representing a percentile score and should return the appropriate
        /// letter grade. 
        /// If the score is at least 90, return 'A'
        /// If the score is at least 80, but less than 90, return 'B'
        /// If the score is at least 70, but less than 80, return 'C'
        /// If the score is at least 60, but less than 70, return 'D'
        /// If the score is below 60, return 'F'.
        /// </summary>
        /// <param name="score">Percentile score</param>
        /// <returns>char of the letter grade</returns>
        public char GetGrade(int score)
        {
            char grade = 'F';

            if (score > 89)
            {
                grade = 'A';
            }
            else if (score > 79 && score < 90)
            {
                grade = 'B';
            }
            else if (score > 69 && score < 80)
            {
                grade = 'C';
            }
            else if (score > 59 && score < 70)
            {
                grade = 'D';
            }

            return grade;
        }


        /// <summary>
        /// This method should take a List of strings, remove all the elements
        /// containing an even number of letters, and return the result. For example, if given a
        /// List of "Cat", "Dog", "Bird", the method should return a List containing only "Cat" and
        // "Dog".
        /// </summary>
        /// <param name="a">Input list of strings</param>
        /// <returns>list of strings</returns>
        public List<string> RemoveEvenLength(List<string> a)
        {
            List<string> list1 = a;

            foreach (var d in list1.ToArray())
            {
                if (d.Length % 2 == 0)
                {
                    list1.Remove(d);
                }
            }
            return list1;
        }

        /// <summary>
        /// This method should take a double array, numbers, and return a new array containing the square of
        /// each element in numbers.
        /// </summary>
        /// <param name="numbers">Input array</param>
        /// <returns>double array</returns>
        public double[] PowerArray(double[] numbers)
        {
            double[] array1 = new double[numbers.Length];
            for (int x = 0; x < numbers.Length; x++)
            {
                array1[x] = Math.Round(Math.Pow(numbers[x], 2), 2);
            }

            return array1;
        }

        /// <summary>
        /// This method should take an int array, numbers, and return the index of the element with the greatest value.
        /// If there the array is empty, return -1
        /// </summary>
        /// <param name="numbers">Input array</param>
        /// <returns>int index of max</returns>
        public int IndexOfMax(int[] numbers)
        {
            if (numbers.Length != 0)
            {
                int max = numbers[0];
                for (int x = 0; x < numbers.Length; x++)
                {
                    if (numbers[x] > max)
                    {
                        max = numbers[x];
                    }
                }
                return Array.IndexOf(numbers, max);
            }

            return -1;
        }


        /// <summary>
        /// This method should take a List of ints, numbers, and returns true if all elements in the
        /// array are divisible by the given int, divisor.
        /// </summary>
        /// <param name="numbers">Input List<int></param>
        /// <param name="divisor">divisor</param>
        /// <returns>bool of true/false</returns>
        public bool IsDivisibleBy(List<int> numbers, int divisor)
        {
            bool result = numbers.TrueForAll(x => x % divisor == 0);
            return result;
        }


        /// <summary>
        /// A word is "abecedarian" if its letters appear in alphabetical order--the word 'biopsy'
        /// for example. This method should take String s and return true if it is abecedarian.
        /// </summary>
        /// <param name="s">Input string</param>
        /// <returns>bool</returns>
        public bool IsAbecedarian(string s)
        {
            char[] chars2 = s.ToLower().ToCharArray();
            Array.Sort(chars2);

            if (!chars2.SequenceEqual(s.ToLower().ToCharArray()))
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// This method should take 2 strings and return true if they are anagrams of each other.
        /// For example, "stop" is an anagram for "pots".
        /// </summary>
        /// <param name="s1">Input string one</param>
        /// <param name="s2">Input string two</param>
        /// <returns>bool</returns>
        public bool AreAnagrams(string s1, string s2)
        {
            char[] chars = s1.ToLower().ToCharArray();
            char[] chars2 = s2.ToLower().ToCharArray();
            Array.Sort(chars);
            Array.Sort(chars2);

            if (!chars.SequenceEqual(chars2))
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// This method should take a String and return the number of unique characters. For example, if
        /// the method is given "noon", it should return a value of 2.
        /// </summary>
        /// <param name="s">Input string</param>
        /// <returns>int count of unique chars</returns>
        public int CountUniqueCharacters(string s)
        {
            return s.ToLower().ToCharArray().Distinct().ToArray().Length;
        }


        /// <summary>
        /// This method should take a string and return true if it is a palindrome, i.e. it is spelled the 
        /// same forwards and backwards. For example, the words "racecar" and "madam" are palindromes.
        /// </summary>
        /// <param name="s">Input string</param>
        /// <returns>bool of true/false</returns>
        public bool IsPalindrome(string s)
        {
            char[] chars = s.ToCharArray().Take(s.Length / 2).ToArray();
            char[] chars2 = s.ToCharArray().Skip((s.Length / 2) + 1).Reverse().ToArray();

            if (!chars.SequenceEqual(chars2))
            {
                return false;
            }
            return true;
        }


        /// <summary>
        /// This method should take a string and return a dictionary which is a map of characters to a list of
        /// their indices in a string (i.e., which characters occur where in a string). For example for the
        /// string "Hello World", the map would look something like: d=[10], o=[4, 7], r=[8], W=[6], H=[0], l=[2, 3, 9], e=[1], ' '=[5].
        /// </summary>
        /// <param name="s">Input string</param>
        /// <returns>Dictionary<string, List<int>></returns>
        public Dictionary<string, List<int>> ConcordanceForString(string s)
        {
            Dictionary<string, List<int>> map = new Dictionary<string, List<int>>();
            foreach (var d in s.ToArray())
            {
                List<int> list1 = new List<int>();
                for (int i = 0; i < s.Length; i++)
                {
                    if (s[i] == d)
                    {
                        list1.Add(i);
                    }
                }
                if (!map.ContainsKey(d.ToString()))
                {
                    map.Add(d.ToString(), list1);
                }
            }
            return map;
        }
    }
}
