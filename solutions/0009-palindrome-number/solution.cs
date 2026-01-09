public class Solution {
    public bool IsPalindrome(int x) {
        string a = x.ToString();
        bool output = true;
        for(int i =0; i < a.Length;i++ )
        {
            output = output && (a[i] == a[a.Length -1 - i]);
                
        }
        return output;
    }
}
