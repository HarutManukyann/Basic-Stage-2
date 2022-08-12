using System;

namespace Basic_Stage_2
{
     
    class Program
    {
        public static string[] solution(string[] inputArray)
        {
            int n = inputArray.Length;
            int k = 0;
            int max = 0;
            
            int temp = inputArray[0].Length;
            if (n == 1)
            {
                return inputArray;
            }
            for (int i = 1; i < n; i++)
            {
                if (temp >= inputArray[i].Length)
                {
                    max++;
                }
                else
                {
                    max = 0;
                    temp = inputArray[i].Length;
                    i--;
                }

            }
            string[] str = new string[max];
            for (int t = 0; t < n; t++)
            {
                if (inputArray[t].Length >= temp)
                {
                    str[k] = inputArray[t];
                    k++;
                }
            }
            return str;

        }
        static void Main(string[] args)
        {
          //  string[] arr = new string[5] { "aab", "aa", "das", "kll", "as" };
          //  Console.WriteLine(solution(arr));
        }
    }
}
