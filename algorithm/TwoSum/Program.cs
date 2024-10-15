using System.Diagnostics;
using System.Runtime.Intrinsics.X86;

namespace TwoSum
{
    public class Program
    {
        public int[] TwoSum(int[] nums, int target)
        {
            int[] result = new int[2];
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if ( nums[i] + nums[j] == target )
                    {
                        result[0] = i;
                        result[1] = j;
                        return result;
                    }
                }
            }
            return result;
        }

        static void Main(string[] args)
        {
            /* 
             * Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
             * You may assume that each input would have exactly one solution, and you may not use the same element twice.
             * You can return the answer in any order.
             * Example 1:
                Input: nums = [2,7,11,15], target = 9
                Output: [0,1]
                Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].
            */

            //input array numbers and target


            Program program = new Program();
            int[] nums = new int[] { 3, 2, 4 };
            int[] result = program.TwoSum(nums, 6);
            Console.WriteLine(result[0] == 0 && result[1] == 0 ? "No pair is valid" : $"[{result[0]}, {result[1]}]");

        }
    }
}
