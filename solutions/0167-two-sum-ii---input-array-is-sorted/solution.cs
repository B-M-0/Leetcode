public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int left = 0;
        int right = numbers.Length -1;
        int temp;
        while(left != right)
        {
            temp = numbers[left] + numbers[right];
            if(temp == target)
                return [left + 1,right + 1];
            else if(temp > target)
                right--;
            else left ++;
        }
        return null;
    }
}
