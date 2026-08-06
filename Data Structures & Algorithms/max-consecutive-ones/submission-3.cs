public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) 
    {
        int counter = 0;
        int max = 0;
        foreach (int num in nums)
        {
            if (num == 1)
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