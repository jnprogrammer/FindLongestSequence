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
            string sequence = "43125674";
            var theReturn = FindSequence(sequence);
            Console.WriteLine("From these numbers " + sequence);
            Console.WriteLine("The longest sequence is: " + theReturn);
        }

        public static string FindSequence(string numbers)
        {
            int tmpLen = 0, maxLen = numbers.Length;

            string longestSequence = "";

            for(int i = 0; i < maxLen; i++)
            {
                Console.WriteLine("This is i " + i);
                tmpLen++;
                if(tmpLen > maxLen-1)
                {
                    break;
                }
                if(Convert.ToInt32(numbers[i]) < Convert.ToInt32(numbers[i+1]) && (Convert.ToInt32(numbers[i+1] )) == Convert.ToInt32(numbers[i])+1)
                {                  
                    longestSequence += numbers[i];
                    Console.WriteLine("This is a number from the numbers array" + numbers[i]);
                    Console.WriteLine(longestSequence);
                }
            }
            return longestSequence;
        }
    }
}
