class Solution {
public:
    vector<int> twoSum(vector<int>& numbers, int target) {
      short left = 0;
      short right = numbers.size() -1;
      short temp;
      while (left != right)
      {
        temp = numbers[left] + numbers[right]; 
        if(temp == target)
        {
            return {left + 1, right + 1};
        }
        else if (temp > target)
            right--;
        else
            left++;
      }
      return {};
    }
};
