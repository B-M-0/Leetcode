public class Solution {
    public int ClimbStairs(int n)
    {
        int[] nClimb = new int[n+1];
        nClimb[0] = 1;
        nClimb[1] = 2;
        for(int i = 2; i < n; i++)
        {
            nClimb[i] = nClimb[i-1] + nClimb[i-2]; 
        }
        return nClimb[n-1];
    }
}
