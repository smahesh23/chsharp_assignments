using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void findMaxChar(string str)
        {
            int[] freq = new int[128];
            int maxCount = int.MinValue;
            char maxChar = '\0';
            foreach (char ch in str)
            {
                freq[ch]++;
            }
            for (int index = 0; index < freq.Length; index++)
            {
                if (freq[index] > maxCount)
                {
                    maxChar = (char)index;
                    maxCount = freq[index];
                }
            }
            Console.WriteLine("Max Occuring Character :{0}, {1} times", maxChar, maxCount);
            Console.Write("Positions : ");
            for (int index = 0; index < str.Length; index++)
            {
                if (maxChar == str.ElementAt(index))
                {
                    Console.Write(index + 1 + " ");
                }
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            findMaxChar("UnitedOnline");
        }
    }
}
