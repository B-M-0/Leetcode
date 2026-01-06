
public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int,int> numMap = new Dictionary<int,int>();

        int num = 0;
        for(int i =0;i < nums.Length; i++)
        {
            num = nums[i];
            int complement = target - num;
            if(numMap.ContainsKey(complement))
            {
                return [i,numMap[complement]];
            }
            if(!numMap.ContainsKey(num))
                numMap.Add(num,i); 
        }
        return null;
    }
}
