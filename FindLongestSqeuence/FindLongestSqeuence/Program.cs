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
            int maxLen = numbers.Length, counterA = 0, counterB = 0;
            string longestSequence = "";
            for (int i = 0; i < maxLen-1; i++)
            {
                if (Convert.ToInt32(numbers[i+1]) == Convert.ToInt32(numbers[i])-1)
                {
                    counterA++;
                    longestSequence += numbers[i];
                    Console.WriteLine(numbers[i]);

                    if (!(i-1 <= -1))
                    {
                        if (Convert.ToInt32(longestSequence[i]) == Convert.ToInt32(numbers[i - 1])+1)
                        {
                            longestSequence += numbers[i];
                        }
                    }
                }
                
                //if(Convert.ToInt32(numbers[i])!= Convert.ToInt32(numbers[i+1]))
                //{
                //    counterA = 0;
                //    if(counterA == 0)
                //    {
                //        longestSequence = "";
                //    }
                //}
               
               
            }

            return longestSequence;
        }
    }
}
