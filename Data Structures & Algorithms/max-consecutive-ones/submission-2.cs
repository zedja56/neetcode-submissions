public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) 
    {
        int counter = 0;
        int max = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == 1)
            {
                counter ++;
            }
            else
            {
                counter = 0;
            }
            max = Math.Max(max, counter);
        }

        return max;    
    }
}