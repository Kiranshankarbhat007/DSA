using Arrays;

namespace DSAPatterns
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] nums = [2, 3, 1, 1, 1, 3,3,1];
            ArraysEasyProblems problem = new ArraysEasyProblems();
            int majorityElement = problem.MajorityElement(nums);
            Console.WriteLine($"The majority element present in array is {majorityElement}");
        }
    }
}
