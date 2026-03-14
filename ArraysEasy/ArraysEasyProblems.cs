using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public class ArraysEasyProblems
    {
        //Return mejority element in array
        //[1,2,5,2,2,8,2]
        //return 2
        public int MajorityElement(int[] nums)
        {
            Dictionary<int, int> counter = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (counter.ContainsKey(nums[i]))
                {
                    counter[nums[i]]++;
                }
                else
                {
                    counter.Add(nums[i], 1);
                }
            }
            int maxKey = counter.Aggregate((x, y) => x.Value > y.Value ? x : y).Key;
            int maxCount = counter[maxKey];

            if (maxCount >= nums.Length / 2)
            {
                return maxKey;
            }
            else
            {
                Console.WriteLine("No majority element");
                Console.ReadLine();
                return -1;
            }
        }

    }
}
