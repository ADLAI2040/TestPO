using System;
using System.Text;

namespace Main
{
    public class Class1
    {
        public static void Main(string[] args)
        {

        }

        //////////////////////////////////////////////////////
        // 1.1
        public static void Merge(int[] array, int lowIndex, int middleIndex, int highIndex)
        {
            var left = lowIndex;
            var right = middleIndex + 1;
            var tempArray = new int[highIndex - lowIndex + 1];
            var index = 0;

            while ((left <= middleIndex) && (right <= highIndex))
            {
                if (array[left] < array[right])
                {
                    tempArray[index] = array[left];
                    left++;
                }
                else
                {
                    tempArray[index] = array[right];
                    right++;
                }

                index++;
            }

            for (var i = left; i <= middleIndex; i++)
            {
                tempArray[index] = array[i];
                index++;
            }

            for (var i = right; i <= highIndex; i++)
            {
                tempArray[index] = array[i];
                index++;
            }

            for (var i = 0; i < tempArray.Length; i++)
            {
                array[lowIndex + i] = tempArray[i];
            }
        }
        public static int[] MergeSort(int[] array, int lowIndex, int highIndex)
        {
            if (lowIndex < highIndex)
            {
                var middleIndex = (lowIndex + highIndex) / 2;
                MergeSort(array, lowIndex, middleIndex);
                MergeSort(array, middleIndex + 1, highIndex);
                Merge(array, lowIndex, middleIndex, highIndex);
            }

            return array;
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //1.2
        public static bool checkStrPalindrome(string str)
        {
            bool palindromed = true;

            int lowIndex = 0;
            int highIndex = str.Length - 1;

            while (lowIndex < highIndex)
            {
                if (str[lowIndex] != str[highIndex])
                {
                    palindromed = false;
                    break;
                }
                lowIndex++;
                highIndex--;
            };

            return palindromed;
        }

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //1.3
        public static int factorialOfNumber(int num)
        {
            if (num >= 0 && num <= 13)
            {
                int result = 1;

                for (int count = num; count != 0; count--)
                {
                    result = result * count;
                };

                return result;
            }
            else
            {
                return -1;
                // throw new Exception("Out of range");
            }
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //1.4

        public static int numFibonacciAtPosition(int position)
        {

            int numFibonacci = 1;
            int prevNumFibonacci = 0;
            int nextNumFibonacci;

            if (position <= 0)
            {
                return 0;
            }

            if (position == 1)
            {
                return prevNumFibonacci;
            };

            if (position == 2)
            {
                return numFibonacci;
            };

            for (int thisPosition = 3; thisPosition <= position; thisPosition++)
            {
                nextNumFibonacci = numFibonacci + prevNumFibonacci;
                prevNumFibonacci = numFibonacci;
                numFibonacci = nextNumFibonacci;
            };

            return numFibonacci;
        }

        /////////////////////
        //1.5

        public static bool findWordInStr(string str, string word)
        {
            if (str == "" || word == "")
            {
                return false;
            }

            for (int indexStr = 0; indexStr < str.Length; indexStr++)
            {
                if (str[indexStr] == word[0])
                {
                    for (int indexWord = 0, indexChkStr = indexStr; ; indexWord++, indexChkStr++)
                    {
                        if (indexWord == word.Length)
                        {
                            return true;
                        };

                        if (str[indexChkStr] != word[indexWord])
                        {
                            indexStr = indexChkStr;
                            break;
                        };
                    }
                }

            };

            return false;
        }

        /////////////////////
        //1.6

        public static bool chkNumIsSimple(int num)
        {
            if (num == 2 || num == 3)
            {
                return true;
            };

            if ((num % 2 == 0) || (num % 3 == 0) || num == 0 || num == 1 || num < 0)
            {
                return false;
            };

            for (int del = 5, growth = 2; (del * del) <= num; del = del + growth, growth = 6 - growth)
            {
                if (num % del == 0)
                {
                    return false;
                };
            };

            return true;
        }

        /////////////////////
        //1.7

        public static int reverseNum(string num)
        {
            char[] charNum = num.ToCharArray();
            string tempNum = "-";
            int resultNum;

            Console.WriteLine(charNum);

            for (int index = charNum.Length - 1; index >= 0; index--)
            {
                tempNum += charNum[index];
            }

            Console.WriteLine(tempNum);

            for (int index = charNum.Length - 1; index > 0 && charNum[index] == '0'; index--)
            {
                tempNum = tempNum.Remove(1, 1);
            }

            if (charNum[0] != '-')
            {
                tempNum = tempNum.Remove(0, 1);
            }
            else
            {
                tempNum = tempNum.Remove(tempNum.Length - 1, 1);
            }

            if (Int32.TryParse(tempNum, out int result))
            {
                resultNum = Convert.ToInt32(tempNum);
                return resultNum;
            }
            else
            {
                return 0;
            }

        }
        ///////////////
        /// 1.8
        public static string numToRoman(int num)
        {
            if (num < 0)
            {
                return "Num is negative, please write positive num";
            };

            if (num == 0)
            {
                return "N";
            };

            int[] Arabic = new int[] { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
            string[] Roman = new string[] { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };

            StringBuilder str = new StringBuilder();

            for (int index = 0; index < 13; index++)
            {
                while (num >= Arabic[index])
                {
                    num -= Arabic[index];
                    str.Append(Roman[index]);
                }
            }

            return str.ToString();
        }
    }
}
