using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenges_20160803
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter values as comma seperated");
            string input = Console.ReadLine();

            string[] arr = input.Split(',');
            int[] values = new int[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                values[i] = int.Parse(arr[i]);
            }

            string message = IsPassed(values) ? "Passed" : "Failed";

            Console.WriteLine(message);

            Console.ReadKey();
        }

        private static bool IsPassed(int[] arr)
        {
            for (int i = 0, j = i + 2; i < arr.Length; i++)
            {
                int leftSum = FindSum(arr, 0, i + 1);
                int rightSum = 0;

                if (i + 1 < arr.Length)
                {
                    rightSum += FindSum(arr, i + 2, arr.Length);
                }

                if (leftSum == rightSum)
                {
                    return true;
                }
            }

            return false;
        }

        private static int FindSum(int[] arr, int start, int end)
        {
            int sum = 0;

            for (int i = start; i < end; i++)
            {
                sum += arr[i];
            }

            return sum;
        }
    }
}
