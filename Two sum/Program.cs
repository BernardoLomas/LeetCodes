class Program
{
    static void Main()
    {
        int target;
        int [] nums = new int [4];

        Console.WriteLine($"Write the target: ");
        target = int.Parse(Console.ReadLine());

        for(int i = 0; i < nums.Length; i++)
        {
            Console.WriteLine($"Index {i} value: ");
            nums[i] = int.Parse(Console.ReadLine());
        }

    }
    public int[] TwoSum(int[] nums, int target)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == target)
                {
                    return new int[] { i, j };
                }
            }
        }

        return Array.Empty<int>();
    }
}
