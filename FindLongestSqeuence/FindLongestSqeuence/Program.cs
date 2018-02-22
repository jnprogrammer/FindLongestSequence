using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindLongestSqeuence
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a series of Numebers");
            string sequence = Console.ReadLine();
            var theReturn = FindSequence(sequence);

            Console.WriteLine(theReturn);
        }

        public static string FindSequence(string numbers)
        {

            int[] numArry = new int[numbers.Length];
            int[] sequenceArry = new int[numbers.Length];
            int counter = 0;
            string longestString = "!#";
            for (int i = 0; i < numbers.Length; i++)
            {
                numArry[i] = Convert.ToInt32(numbers.Substring(i, 1));
            }

            for(int i =0; i < numArry.Length; i++)
            {

                int firstNum = numArry[i], nextNum = numArry[i + 1];
                if (i > numArry.Length)
                    break;
                if (nextNum == firstNum + 1)
                {
                    counter++;
                    sequenceArry[i] = firstNum;
                    sequenceArry[i + 1] = nextNum;
                }
                else
                {
                    counter = 0;

                }
            }
          
            return longestString;
        }
    }
}
