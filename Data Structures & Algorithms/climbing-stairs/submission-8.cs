public class Solution {
    private Dictionary<int, int> memo = new Dictionary<int, int>();

    public int ClimbStairs(int n) 
    {
        if(n <= 2)
        {
            return n;
        }

        if (memo.ContainsKey(n))
        {
            return memo[n];
        }

        memo[n] = ClimbStairs(n-2) + ClimbStairs(n-1);
        return memo[n];        
    }
}
