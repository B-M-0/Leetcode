public class Solution {
    public IList<IList<int>> Generate(int numRows) {
        List<List<int>> rows = new();
        rows.Add(new List<int>{1});

        for(int i = 1; i < numRows; i++)
        {   
            List<int> nums = new List<int>();
            nums.Add(1);
            for(int j = 1;j < i ;j++)
            {
                int x = rows[i-1][j-1] + rows[i-1][j]; 
                nums.Add(x);
            }
            nums.Add(1);
            rows.Add(nums);
        }
        return rows.Select(x =>(IList<int>)(x)).ToList();
    }
}
