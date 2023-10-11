using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AyazPractice
{
    public class Interview_Practice
    {
        static void Main(string[] args)
        {
            string words = "Hello World";
            string reverseWords = ReverseWord(words);
            Console.WriteLine(reverseWords);
            Console.ReadKey();
        }
        static string ReverseWord(string sentence)
        {
            string[] words = sentence.Split(' ');
            StringBuilder reverseWords = new StringBuilder();
            for(int i=words.Length-1; i>=0; i--)
            {
                reverseWords.Append(words[i]);
                if(i>0)
                    reverseWords.Append(" ");
            }
            return reverseWords.ToString();
        }
        //static int[] RotateNumber(int[] numbers,int rotationNumber)
        //{
        //    int[] remaining = new int[numbers.Length-rotationNumber]; 
        //        Array.Copy(numbers, remaining, numbers.Length - rotationNumber);
        //    return remaining;
        //}
        //static int[] CheckTargetNumbers(int[] numbers,int target)
        //{
        //    int previousNumber = 0;
        //    foreach (int number in numbers)
        //    {
                
        //        if (previousNumber + number == target)
        //        {
        //            return new int[] { previousNumber, number };
        //        }
        //        previousNumber = number;
                
        //    }
        //    return null;
        //}
    }
}
