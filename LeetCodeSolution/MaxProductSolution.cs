namespace LeetCodeSolution;

public class MaxProductSolution
{
    public int MaxProduct(int[] nums)
    {
        if (nums.Length == 0) return 0;
        
        int maxProduct = nums[0];
        int minProduct = nums[0];
        int result = nums[0];
        
        for (int i = 1; i < nums.Length; i++) {
            if (nums[i] < 0) {
                int temp = maxProduct;
                maxProduct = minProduct;
                minProduct = temp;
            }
            
            maxProduct = Math.Max(nums[i], maxProduct * nums[i]);
            minProduct = Math.Min(nums[i], minProduct * nums[i]);
            
            result = Math.Max(result, maxProduct);
        }
        
        return result;
    }
}