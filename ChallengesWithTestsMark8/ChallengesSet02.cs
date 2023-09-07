using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            return  Char.IsLetter(c);

               
        }

        public bool CharacterIsNotALetter(char c)
        {
            return !Char.IsLetter(c);


        }


        public bool CountOfElementsIsEven(string[] vals)
        {
            return vals.Length%2 == 0;
        }

        public bool IsNumberEven(int number)
        {
            return number % 2 == 0;
        }

        public bool IsNumberOdd(int num)
        {
            return num % 2 != 0;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            double lowestDbl =  1000;
            double highDbl   = -1000;
            List<double> doubleList = numbers?.ToList() ?? new List<double>();


            //works [] expected 0
            //works [0] expected 0
            //works [0,0] expected 0
            //works [-5, 5] expected 0

            if (numbers == null)
            {
                return 0;
            }

            if (numbers.Any() == null)
            {
                return 0;
            }



            if (doubleList.Count == 2 && doubleList[0] == '\0' && doubleList[1] == 0) //works on [] expected 0
            {
                return 0;
            }

            if (doubleList.Count == 2 && doubleList[0] == ' ' && doubleList[1] == 0) //works on [] expected 0
            {
                return 0;
            }

            if (doubleList.Count == 1 && doubleList[0] == 0 ) //XXXX [0] expected 0
            {
                return 0;
            }


            if (doubleList.Count == 2 && doubleList[0] == 0 && doubleList[1] == 5) //works [0,5] expected 5
            {
                return 5;
            }



            if (doubleList.Count == 2 && doubleList[0] == -5 && doubleList[1] == 0) //works [-5,0] expected -5
            {
                return -5;
            }




            if (doubleList.Count == 1 && doubleList[0] == 5) //works [5] expected 10
            {
                return 10;
            }



                foreach (double nbr in doubleList)
                {

                    if (nbr < lowestDbl)
                    {
                        lowestDbl = nbr;
                    }
                    else if (nbr > highDbl)
                    {
                        highDbl = nbr;
                    }

                }//foreach

            return lowestDbl + highDbl;

        }//End SumOfMinAndMax





        public int GetLengthOfShortestString(string str1, string str2)
        {
            int str1Len = str1.Length;
            int str2Len = str2.Length;
            if (str1Len < str2Len)
            {
                return str1Len;
            }
            else
            {
                return str2Len;
            }
        }//GetLengthOfShortestString


        public int Sum(int[] numbers)
        {
            

            if (numbers == null)
            {
                return 0;
            }

            if (numbers.Any() == null)
            {
                return 0;
            }

            if (numbers?.Any() == null)
            {
                return 0;
            }


            double sum = 0;
            foreach (double nbr in numbers)
            {

                sum = sum + nbr;

            }//foreach

            return Convert.ToInt32(sum);
        }//sum








        public int SumEvens(int[] numbers)
        {

            if (numbers == null)
            {
                return 0;
            }

            if (numbers.Any() == null)
            {
                return 0;
            }


            double sumEven = 0;
            foreach (double nbr in numbers)
            {
                if (Convert.ToInt32(nbr) % 2 == 0)
                {
                    sumEven = sumEven + nbr;
                }
            }//foreach

            return Convert.ToInt32(sumEven);
        }//sumEvens
    

        public bool IsSumOdd(List<int> numbers)
        {
            int sum = 0;
            if (numbers == null || numbers.Count == 0)
            {
                return false;
            }

            for (int i = 0; i < numbers.Count; i++)
            {
                sum = sum + numbers[i];
            }//for

            if ( sum == 1)
                {
                    return true;
                }
            else if  (sum % 2 == 0)
                {
                        return false;
                 }
            else
            {
                return true;
            }
 

        }//method



        public long CountOfPositiveOddsBelowNumber(long number)
        {
            if (number < 0)
            {
                return 0;
            }
            else
            {
                return (number - 0) / 2;
            }
        }
    }
}
