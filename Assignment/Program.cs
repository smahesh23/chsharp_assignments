using System;
using System.Linq;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        static void findMaxChar(string str)
        {
            int[] freq = new int[256];
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

        static void extractString(string str,string subStr)
        {


            int startIndex = str.IndexOf(subStr);

            if (startIndex >= 0)
            {
                int lengthToRemove = subStr.Length;
                int endIndex = startIndex + lengthToRemove;

                // Create a new string by excluding the substring
                string modifiedString = "";

                for (int i = 0; i < str.Length; i++)
                {
                    if (i < startIndex || i >= endIndex)
                    {
                        modifiedString += str[i];
                    }
                }

                Console.WriteLine(modifiedString);
            }
            

          





        }

        static void Main(string[] args)
        {
            findMaxChar("UnitedOnline");
            extractString("Learning C# is a great  fun","great");
        }
    }
}
