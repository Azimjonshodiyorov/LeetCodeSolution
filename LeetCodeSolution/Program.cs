namespace LeetCodeSolution;

public class Program
{
    public static void Main(string[] args)
    {
        int[] nums = { 1, 9, 3, 5, 6, 4, 8, 7 };
        nums = BubbleSort.Sort(nums);
        foreach (var item in nums)
        {
            Console.WriteLine(item);
        }

    }
}