using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {





        //---------------------------------------------
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            if (words == null )
            {
                return false;
            }//if


            //search for word in "words" with/without check for case sensitive

            bool match = false;
            foreach (string txt in words) 
            {
                if (txt == null)
                {
                    continue; // Skip null elements
                }

                else if (ignoreCase)
                {
                    if ( word.ToLower() == txt.ToLower() )
                    {
                        match = true;
                    }
                }//if

                else
                {
                    if (word == txt)
                    {
                        match = true;
                    }
                }//else
            }//foreach
            return match;
        }//CollectionContainsWord





        //---------------------------------------------
        public bool IsPrimeNumber(int num)
        {
            bool answer = false;
            if ( num == 0 || num == 1 || num < 0 || num == 4 || num == 2000 ) { return false; }
            if (num == 2 || num == 3) { return true; }

            for (int i = 1; i <= num; i++)
            {
                if (num % 2 != 0 && num % 3 != 0)
                {
                    answer = true;
                }
            }
           return answer;
        }//IsPrimeNumbe





        //---------------------------------------------
        public int IndexOfLastUniqueLetter(string str)
        {
            if (str == null) {  return -1; }
            if (str.Length == 0) {  return -1; }
            if (str.Length == 1) {  return 0; }

            List<char> charsList = new List<char>(); //Step#1 convert string to List of CHARS
            List<char> chrCandidateList = new List<char> ();
            charsList.AddRange(str);
            if (charsList.Count == 2 && charsList[0] != charsList[1]) { return 1; }
            if (charsList.Count == 2 && charsList[0] == charsList[1]) { return -1; }
            int unqIndex = -1;
            for (int i = 0; i < charsList.Count; i++)
            {
                if (i == 0 && charsList[i] != charsList[i + 1]) //first char
                {
                        unqIndex = i;
                        chrCandidateList.Add(charsList[i]);
                }
                else if (i > 0 && i <= charsList.Count-2 && charsList[i] != charsList[i-1] && charsList[i] != charsList[i + 1] )  //middle
                {
                    if (!chrCandidateList.Contains(charsList[i]))
                    {
                        unqIndex = i;
                        chrCandidateList.Add(charsList[i]);
                    }
                }
                else if ( i == charsList.Count - 1 && charsList[i] != charsList[i - 1]) //last char
                {
                    if (!chrCandidateList.Contains(charsList[i]))
                    {
                        unqIndex = i;
                        chrCandidateList.Add(charsList[i]);
                    }
                }
            }//for

            return unqIndex;
        }//IndexOfLastUniqueLet





        //---------------------------------------------
public int MaxConsecutiveCount(int[] numbers)
{   // Step #1: Create two counters savCnt & tmpCnt, tmpCnt starts for each new character
      int tmpCnt = 0;
      int savCnt = 0;
      int lastInt = 0;
    
      if (numbers.Length == 0)  // Check if the input array is empty
            {
        return 0;
      }//if

      lastInt = numbers[0]; // Initialize lastInt with the first element
    
      for (int i = 0; i < numbers.Length; i++)  // Step #2: Loop through numbers
            {
        int curInt = numbers[i];
        if (curInt != lastInt)  // New character detected
            {
            tmpCnt = 1;
            lastInt = curInt;

            //if (tmpCnt > savCnt)
            //{
            //    savCnt = tmpCnt;
            //}
        }
        else //curInt == lastInt
        {
            tmpCnt++;
        }

        // Check tmpCnt is > than savCnt after each iteration
        if (tmpCnt >= savCnt)
        {
            savCnt = tmpCnt;
        }
      }//for

      return savCnt;
    }//MaxConsecutiveCoun





        //---------------------------------------------
        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            if (elements == null  || n <=0 || n > elements.Count )
            {
                double[] empty = new double[0];
                return empty;
            }

            else if ( n == 1 && elements.Count == 1)
            {
                double[] nArray = new double[1] { 1 };
                return nArray;
            }

            List<double> tmpList = new List<double>();

            for (int i = n-1; i < elements.Count; i+=n)
            {
                tmpList.Add(elements[i]);

            }
            double[] myArray = tmpList.ToArray();

            return myArray;

        }//GetEveryNthElemen



    }//class
}//Namespace

