using System;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Text.RegularExpressions;
using System.IO;
using System.Drawing;


namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {






        //---------------------------------------------
        public int AddEvenSubtractOdd(int[] numbers)
        {
            int tmpTtl = 0;

            foreach (int n in numbers)
            {
                if (n % 2 == 0)
                {
                    tmpTtl = tmpTtl + n;
                }
                else if (n % 2 != 0)
                {
                    tmpTtl = tmpTtl - n;
                }
            }
            return tmpTtl;
        }//AddEvenSubtractO







        //---------------------------------------------
        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            List<string> strList = new List<string>() { str1, str2, str3, str4 };
            int shortLen = 1000;
            foreach (string str in strList)
            {
                if (str.Length < shortLen)
                {
                    shortLen = str.Length;
                }
            }
            return shortLen;

        }//GetLengthOfShortestString







        //---------------------------------------------
        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            List<int> intList = new List<int>() { number1, number2, number3, number4 };
            int lowInt = 10000;
            foreach (int nbr in intList)
            {
                if (nbr < lowInt)
                {
                    lowInt = nbr;
                }
            }
            return lowInt;
        }//GetSmallestNumber







        //---------------------------------------------
        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            if (biz == null)
            {
                biz.Name = "TrueCoders";
            }
            else if (string.IsNullOrEmpty(biz.Name))
            {
                biz.Name = "TrueCoders";
            }
            else
            {
                biz.Name = "TrueCoders";
            }

        }//ChangeBusinessNameTo_True







        //---------------------------------------------
        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            if (sideLength1 == 0 || sideLength2 == 0 || sideLength3 == 0)
            {
                return false;
            }

            // Check all combinations to see if they satisfy the triangle equation.
            if (sideLength1 + sideLength2 > sideLength3 &&
                sideLength1 + sideLength3 > sideLength2 &&
                sideLength2 + sideLength3 > sideLength1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }






            //---------------------------------------------
            public bool IsStringANumber(string input)
        {
            string pattern = "[^0-9.\\-]";
            if (string.IsNullOrEmpty(input) || input == "")
            {
                return false;
            }
            else if (Regex.IsMatch(input, pattern))
            {
                return false;
            }
            else
            {
                return true;
            }
        }






        //---------------------------------------------
        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            int otherCnt = 0;
            int nullCnt = 0;
            double nullPercent = 0;
            bool answer = false;

            for (int i = 0; i < objs.Length; i++)
            {
                if (objs[i] == null)
                {
                    nullCnt++;
                }
                else if (objs[i] is string && string.IsNullOrEmpty((string)objs[i]))
                {
                    nullCnt++;
                }
                else
                {
                    otherCnt++;
                }
            }//for

            nullPercent = (double)nullCnt / (nullCnt + otherCnt);
            return nullPercent >= 0.51;

        }//MajorityOfElementsInArrayAreNull







        //---------------------------------------------
        public double AverageEvens(int[] numbers)
        {
            //Step #1 loop through array of numbers
            decimal tmpInt = 0;
            int tmpCnt = 0;
            if ( numbers == null)  //numbers.Length == 0 ||
            {
                return 0;
            }

            for (int i = 0; i < numbers.Length; i++)
            {

                if (numbers[i] == 0)
                {
                    return 0;
                }
                else if (numbers[i] % 2 == 0)
                {
                    tmpInt = tmpInt + numbers[i];
                    tmpCnt++;
                }//if
            }//for
            if (tmpCnt == 0)
            {
                return 0;
            }
            else
            {
                return (double)tmpInt / tmpCnt;
            }
        }//AverageEvens




        //---------------------------------------------
        public int Factorial(int number)
        {
            int factorialNbr = 1;
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            
            if (number == 0)
            {
                return 1;
            }


            for (int i = 1; i <= number; i++)
            {
                factorialNbr *= i;
            }
            return factorialNbr;
        }//Factorial





    }
}

