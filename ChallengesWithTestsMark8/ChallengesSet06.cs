using System;
using System.Collections;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {





        //---------------------------------------------
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            throw new NotImplementedException();
        }//CollectionContainsWord





        //---------------------------------------------
        public bool IsPrimeNumber(int num)
        {
            throw new NotImplementedException();
        }//IsPrimeNumbe





        //---------------------------------------------
        public int IndexOfLastUniqueLetter(string str)
        {
            throw new NotImplementedException();
        }//IndexOfLastUniqueLet





        //---------------------------------------------
        public int MaxConsecutiveCount(int[] numbers)
        {
            throw new NotImplementedException();
        }//MaxConsecutiveC





        //---------------------------------------------
        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            if (elements == null || elements.Count == 0 || elements.Count < 4)
            {
                double[] empty = new double[0];
                return empty;
            }


            List<double> tmpList = new List<double>();

            for (int i = 0; i < elements.Count; i+=n)
            {
                tmpList.Add(elements[i]);

            }
            double[] myArray = tmpList.ToArray();

            return myArray;

        }//GetEveryNthElemen



    }//class
}//Namespace

