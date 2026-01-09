public class Solution {
   
    public int[] CountBits(int n) {
        int[] ans = new int[n+1];
        for(int i= 0 ; i < n+1; i++ )
        {
            int sum = 0;
            int num = i;
            while(num != 0)
            {
                sum += num % 2;
                num = num/2;
            }
            ans[i] = sum;
        }
        return ans;
    }
}
