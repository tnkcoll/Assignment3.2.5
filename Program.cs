namespace Assignment3._2._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 5, 3 };
            int target = 5;

            PrintItems(nums, target);
            
        }

        public static int GetIndex(int[] nums, int target) 
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == target) return i;
            }
            return -1;
        }

        public static void PrintItems(int[] nums, int target)
        {
            for(int i = 0;i < nums.Length;i++)
            {
                Console.Write($"{nums[i]} ");
            }
            Console.WriteLine();
            Console.WriteLine($"The target value to find is {target}");
            Console.WriteLine($"The index is {GetIndex(nums, target)}");
        }
    }
}
