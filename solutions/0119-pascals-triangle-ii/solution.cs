public class Solution {
    public IList<int> GetRow(int rowIndex) {
      List<int> row = new List<int>();
      row.Add(1);
      if(rowIndex == 0)
        return row;
      row.Add(1);
      if(rowIndex == 1)
        return row;
    
        for(int i = 2; i < rowIndex +1 ;i++)
        {
            List<int> temp = new();
            temp.Add(1);
            for(int j =0; j < row.Count() -1;j++)
                temp.Add(row[j]+ row[j+1]);
            temp.Add(1);
            row = temp;
        }
        return row;
        
    }
}
