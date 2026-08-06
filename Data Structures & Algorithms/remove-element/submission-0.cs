public class Solution {
    public int RemoveElement(int[] nums, int val) 
    {
        int count = 0;
        int[] tempNum = new int[nums.Length]; 
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != val)
            {
                nums[count] = nums[i];
                count++;
            }
        }
        return count;
    }
}