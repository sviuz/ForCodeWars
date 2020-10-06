using System;
using System.Linq;

namespace ForCodeWars
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(rowSumOddNumbers(2));
        }
        //            1
        //         3     5
        //       7     9    11
        //   13    15    17    19
        //21    23    25    27    29
        public static long rowSumOddNumbers(long n)
        {
            long res = 0;
            int counter = 1;
            for (int k = 1; k <= n; k++)
            {
                res += counter;
                for (int j= 1; j<=n;j++)
                {

                    counter += 2;
                    res += counter;

                }
            }
            return res;
        }

        /// Can you find the needle in the haystack?
        /// Write a function findNeedle() that takes an array full of junk but containing one "needle"
        /// After your function finds the needle it should return a message(as a string) that says:
        /// "found the needle at position " plus the index it found the needle, so:
        /// find_needle(['hay', 'junk', 'hay', 'hay', 'moreJunk', 'needle', 'randomJunk'])
        /// should return "found the needle at position 5"

        public static string FindNeedle(object[] haystack)//fount index of the 'needle' word
        {
            return $"found the needle at position {Array.IndexOf(haystack, "needle")}";
        }

        public static bool ValidatePin(string pin)//переписать
        {
            bool result = false;
            int[] newArr = new int[pin.Length];
            for (int k = 0; k < pin.Length; k++)
            {
                newArr[k] = Convert.ToInt32(pin[k].ToString());
            }

            if (newArr.Length == 4 || newArr.Length == 6)
            {
                
                for (int i = 0; i <= 9; i++)
                {
                    for (int j = 0; j < newArr.Length; j++)
                    {
                        if (newArr[j] ==i)
                        {
                            
                            result = true;
                        }
                    }
                }
                return result;
            }
            else
            {
                return false;
            }


            //try
            //{
            //    int.Parse(pin);
            //    if (pin.Length == 4 || pin.Length == 6)
            //        return true;
            //    else
            //        return false;
            //}
            //catch (Exception)
            //{

            //    throw new Exception();
            //}
        }


        public static int MakeNegative(int number)
        {
            if (number>=0)
            {
                return number - number * 2;
            }
            else
            {
                return number;
            }
        }

        /// <summary>
        /// Your task is to make a 
        /// function that can take any
        /// non-negative integer as an argument 
        /// and return it with its digits in 
        /// descending order. Essentially,
        /// rearrange the digits to create 
        /// the highest possible number.
        /// Examples:
        /// Input: 42145 Output: 54421
        public static int DescendingOrder(int num)
        {
            var newNum = num.ToString().ToArray();
            Array.Sort(newNum);
            Array.Reverse(newNum);
            return Convert.ToInt32(string.Join("",newNum));
        }

        // <summary>
        // Your goal in this kata is to implement a difference function, 
        // which subtracts one list from another and returns the result.
        // 
        //It should remove all values from list a, which are present in list b.
        //Kata.ArrayDiff(new int[] {1, 2}, new int[] {1}) => new int[] {2}
        //
        // If a value is present in b, all of its occurrences must be removed from the other:
        // Kata.ArrayDiff(new int[] {1, 2, 2, 2, 3}, new int[] {2}) => new int[] {1, 3}
        // </summary>

        public static int[] ArrayDiff(int[] a, int[] b)//Переделать!!!
        {
            int count = 0;
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < b.Length; j++)
                {
                    if (a[i] != b[j])
                    {
                        count++;
                    }
                }
            }
            int[] arr = new int[count];
            int h = 0;
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < b.Length; j++)
                {
                    if (a[i]!=b[j])
                    {
                        arr[h] = a[i];
                        h++;
                    }
                }
            }
            return arr;
        }

        public static int summation(int num)
        {
            int result = 0;
            int count = num;
            for (int i = 0; i < count; i++)
            {
                result += num;
                num--;
            }
            return result;
        }


        public static bool XO(string input)
        {
            bool result = false;
            int o = 0, x = 0;

            if (input != null)
            {
                var array = input.ToCharArray();
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i]=='o' || array[i] == 'O')
                        o++;
                    if (array[i] == 'x' || array[i] == 'X')
                        x++;
                }
            }
            if (o == x)
                result = true;
            else
                result = false;

            return result;
        }
    }
}
