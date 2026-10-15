namespace LeetCodeSolution;

public class Program
{
    public static void Main(string[] args)
    {
        //int[] nums = { 1, 9, 3, 5, 6, 4, 8, 7 };
        //nums = BubbleSort.SortOne(nums);
        //foreach (var item in nums)
        //{
        //    Console.WriteLine(item);
        //}

        int[] nums = [3, 2, 4];
        int target = 6;
        var result = TwoSum.TwoSum1(nums, target);
        Console.WriteLine($"Indices: [{result[0]}, {result[1]}]");

    }
}