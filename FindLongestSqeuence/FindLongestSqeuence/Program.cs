using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Find the longest positive sequece of numbers and print that back
 * 
 Answer: 5 6 7*/

namespace FindLongestSqeuence
{
    class Program
    {
        static string longestString;

        static void Main(string[] args)
        {
            int[] sequence = { 4, 3, 1, 2, 5, 6, 7, 4 };
            int[] longestSeq = { 0, 0, 0, 0, 0, 0, 0, 0 };

            int count, max;
            int arryLen = sequence.Length - 1;

            for(int i = 0; i < arryLen; i++)
            {
                
                if(sequence[i] == sequence[i+1]-1)
                {
                    longestSeq[i] = sequence[i]; 
                }
                if (sequence[i + 1] == sequence[i] + 1)
                {
                    longestSeq[i+1] = sequence[i+1];
                }
                Console.WriteLine(longestSeq[i]);

            }
                       
        }
    }

}

//        public static int[] FindSequence(int[] sequence)
//        {

//            int maxLen = sequence.Length;
//            int[] longestSequence = new int[8];
//            int[] tempArray = new int[10];
//            for(int i = 1; i < maxLen; i++)
//            {
//                if(sequence[i-1] == sequence[i]-1)
//                {

//                    Console.WriteLine(sequence[i-1]);
//                   longestString+= sequence[i-1].ToString();

//                    //longestSequence[1] = sequence[i+1];
//                    Console.WriteLine(sequence[i]-1);
//                    longestString += (sequence[i]-1).ToString();

//                }

//                Console.WriteLine(longestString);
//            }

//            return longestString;
//        }
//    }
//}
//public static int[] FindSequence(int[] sequence)
//{
//    int maxLen = sequence.Length;
//    int[] longestSequence = new int[8];
//    for (int i = 1; i < maxLen; i++)
//    {
//        if (sequence[i - 1] == sequence[i] - 1)
//        {

//            Console.WriteLine(sequence[i - 1]);

//            longestSequence[1] = sequence[i + 1];
//            Console.WriteLine(sequence[i]);
//        }

//    }

//    return longestSequence;
//}

//int[] sequence = { 4, 3, 1, 2, 5, 6, 7, 4 };

////Console.WriteLine("From these numbers " + sequence);
////Console.WriteLine("The longest sequence is: " + theReturn);

//int maxLen = sequence.Length;
//int[] longestSequence = new int[8];
//int[] tempArray = new int[10];
//            for (int i = 1; i<maxLen; i++)
//            {
//                if (sequence[i - 1] == sequence[i] - 1)
//                {

//                    Console.WriteLine(sequence[i - 1]);
//                    longestString += sequence[i - 1].ToString();

////longestSequence[1] = sequence[i+1];
//Console.WriteLine(sequence[i] - 1);
//                    longestString += (sequence[i] - 1).ToString();

//                }

//                Console.WriteLine(longestString);
//            }
//        }