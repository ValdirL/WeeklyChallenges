using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            /*if (char.IsLetter(c))
                return true;
            else
                return false;*/
            return char.IsLetter(c);
            
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            /*if (vals.Length % 2 == 0)
                return true;
            else
                return false;*/
            return vals.Length % 2 == 0;     
        }

        public bool IsNumberEven(int number)
        {
            /*if (number % 2 == 0)
                return true;
            else
                return false;*/
            return number % 2 == 0;
        }

        public bool IsNumberOdd(int num)
        {
            /*if (num % 2 != 0)
                return true;
            else
                return false;*/
            return num % 2 != 0;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            /*My fist guess:
            return numbers.Min() + numbers.Max();*/
            return numbers == null || numbers.Count() == 0 ? 0 : numbers.Min() + numbers.Max();
                            
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            /*if ((str1 == null) || (str2 == null))
                return 0;
            else if (str1.Length < str2.Length)
                return str1.Length;
            else
            {
                return str2.Length;
            }*/

            /* My first guess:
            return string.CompareOrdinal(str1, str2);*/
            return (str1.Length < str2.Length) ? str1.Length : str2.Length;
            
        }

        public int Sum(int[] numbers)
        {
            /*int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;*/
            //My first guess:
            //return numbers == null || numbers.Count() == 0 ? 0 : numbers.Sum();
            return numbers == null ? 0 : numbers.Sum();
        }

        public int SumEvens(int[] numbers)
        {
            /* int answer = 0;
             if (numbers == null)
             {
                 return 0;
             }
             for (int i = 0; i < numbers.Length; i++)
             {
                 if (numbers[i] % 2 == 0)
                 { 
                     answer += numbers[i];
                 }
             }*/
            return numbers != null || numbers.Length == 0 ? 0 : numbers.Where(x => x % 2 == 0).Sum();

           
        }

        public bool IsSumOdd(List<int> numbers)
        {
            /*int sum = 0;
            if (numbers != null && numbers.Count != 0)
            {
                for (int i = 0; i < numbers.Count; i++)
                { 
                    sum += numbers[i];
                }
            }
            return sum % 2 == 0 ? false : true;*/

            return numbers != null && numbers.Count != 0 && numbers.Sum() % 2 != 0;
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            return number <= 0 ? 0 : number / 2;
        }
    }
}
