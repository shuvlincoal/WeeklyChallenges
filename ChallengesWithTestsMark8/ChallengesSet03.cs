using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text.RegularExpressions;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {

            bool answer = false;
            for (int i = 0; i < vals.Length; i++)
                if (vals[i] == false) { 
                    answer = true;
                  }//if
   
            return answer;
        }





        //---FINISHED-------------------------------------------------------------
        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            int i = 0;
            int sumOdds = 0;
            bool oddOdds = false;
            if (numbers == null)
            {
                return false;
            }

            foreach (int tmpIntCur in numbers)
            {
                if (tmpIntCur % 2 != 0)
                {
                    sumOdds = sumOdds + tmpIntCur;
                }

            }//foreach
            if (sumOdds%2 != 0)
            {
                oddOdds = true;
            }
            return oddOdds;
        }//IsSumOfOddsOdd






        //----------------------------------------------------------------
        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            //Step #1 convert strting to char array
            char[] charArray = password.ToCharArray();
            
            //Step #2 set up other variables
            bool upper = false;
            bool lower = false;
            bool nbr   = false;
            string pattern = "[0-9]";

            //Step #3 loop through the array and test each char 
            for (int i = 0; i < password.Length; i++)
            {
                if (Char.IsLower(password[i]))
                {
                    lower = true;
                }
                if (Char.IsUpper(password[i]))
                {
                    upper = true;
                }
                if (Regex.IsMatch(password[i].ToString(), pattern))
                {
                    nbr   = true;
                }

            }//for

            if (lower && upper && nbr) {
                 return true; 
            }
            else { 
                 return false; 
            }

        }//PasswordContainsUpperLowerAndNumber




        //---FINISHED----------------------------------------------------------
        public char GetFirstLetterOfString(string val)
        {
            char[] charArray = val.ToCharArray();
            return charArray[0];
        }





        //---FINISHED------------------------------------------------------
        public char GetLastLetterOfString(string val)
        {
            char[] charArray = val.ToCharArray();
            return charArray[val.Length-1];

        }//GetLastLetterOfString







        //---FINISHED-------------------------------------------------------------
        public decimal Divide(decimal dividend, decimal divisor)
        {
            decimal answer = 0;
            if (divisor == 0)
            {
                return 0;
            }

            answer = dividend / divisor;
            return answer;

        }//Divide





        //---FINISHED-----------------------------------------------------------
        public int LastMinusFirst(int[] nums)
        {
            int lastMinusFirst = 0;

            lastMinusFirst = nums[nums.Length - 1] - nums[0];
        
            return  lastMinusFirst;
        }//LastMinusFirst



        //---FINISHED-----------------------------------------------------
        public int[] GetOddsBelow100()
        {
            //Step #1 create list to receive odd numbers
            List<int> oddList = new List<int>();

            //Step #2 Loop though 100 and test each number for odd, and add to oddList if is
            for (int i=0; i< 100; i++)
            {
                if (i % 2 != 0)
                {
                    oddList.Add(i);
                }
            }//for1

            //Step #3 Create an array length equal to oddList
            int[] arrayOddInt = new int[oddList.Count];

            //Step #4 loop through oddList and put it in 
            for(int i=0; i<oddList.Count; i++)
                 { arrayOddInt[i] = oddList[i];
            }//for2

            return arrayOddInt;
        }//GetOddsBelow100





        //---void return??-------------------------------------------------------------
        public void ChangeAllElementsToUppercase(string[] words) 
        {
            if ( words.Length == 0 )
            {
                string[] emptyStr = new string[0];
            }

            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }

        }//ChangeAllElementsToUppercase


    }//Class
}//Namespace
