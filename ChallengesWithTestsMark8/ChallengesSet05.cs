using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Xml.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            if (startNumber == 0)
            {
                return n;
            }

            for (int i = startNumber+1; i < 1000; i++)
            {
                if ( i%n == 0 )
                {
                    return i;
                }//if
            }//For

            return -1;
        }//GetNextNumberDivisibleB





        //---------------------------------------------
        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            for (int i = 0; i < businesses.Length; i++)
            {
                if (businesses[i].TotalRevenue == 0)
                {
                    businesses[i].Name = "CLOSED";
                }
            }
        }//ChangeNamesOfBusinessesWithNoRevenueTo_C





        //---------------------------------------------
        public bool IsAscendingOrder(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return false;
            }

            if (numbers.Length == 1) { return true; }

            bool ascend = true;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (i < numbers.Length - 1)
                {
                    if (numbers[i] > numbers[i + 1])
                    {
                        ascend = false;
                    }
                }
            }//for
            return ascend;
        }// IsAscendingOrder





        //---------------------------------------------
        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0 )
            {
                return 0;
            }

            int sumElement = 0;
            for (int i = 0;i<numbers.Length;i++)
            {
                if (Math.Abs(numbers[i])%2 == 0 && i < numbers.Length -1)
                {
                     sumElement = sumElement + numbers[i + 1];
                }//inner if

            }//for
 
            return sumElement;

        }//SumElementsThatFollowAnEve





        //---------------------------------------------
        public string TurnWordsIntoSentence(string[] words)
        {
            if (words == null || words.Length == 0 )
            {
                double[] empty = new double[0];
                return "";
            }

            if (words[0] == " " && words[1] == " ")
            {
                return "";
            }
            string sentEnce = "";
            string tmpStr = "";
            for (int i = 0;i<words.Length;i++)
            {
                if (words[i] != "" && words[i] != " " && words[i] != "  ")
                {
                    if (i < words.Length - 1)
                    {
                        sentEnce += words[i].Trim() + " ";
                    }
                    else
                    {
                        sentEnce += words[i].Trim();
                    }
                }

            }//for
            return sentEnce + ".";
        }//TurnWordsIntoSentenc





        //---------------------------------------------
        public double[] GetEveryFourthElement(List<double> elements)
        {
            if (elements == null || elements.Count == 0 || elements.Count < 4)
            {
                double[] empty = new double[0]; 
                return empty;
            }

            List<double> resultList = new List<double>();

            for (int i = 3; i < elements.Count; i += 4)
            {
                resultList.Add(elements[i]);
            }

            double[] resultsArray = resultList.ToArray();
            return resultsArray;
        }






        //---------------------------------------------
        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            if (nums.Length < 2) // There must be at least two elements to find a pair
            {
                return false; 
            }

            HashSet<int> seen = new HashSet<int>();

            foreach (int num in nums)
            {
                int complement = targetNumber - num;

                if (seen.Contains(complement)) // Found a pair that sums to the target number
                {
                    return true; 
                }

                seen.Add(num);
            }

            return false; // No pair found.
        }//TwoDifferentElementsInArrayCanSumToTargetNumber



    }//class
}//Namespace
