public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
     //insert;
        int p1=0;
        int p2=0;
        int[] newArray = new int[nums1.Length + nums2.Length];
        for(int i = 0; i < newArray.Length;i++)
        {
            if( p2 == nums2.Length && p1 != nums1.Length)
            {
                newArray[i] = nums1[p1];
                p1++;
            }
            else if (p1 == nums1.Length && p2 != nums2.Length)
            {
                newArray[i] = nums2[p2];
                p2++;
            }
            else if( nums1[p1] < nums2[p2])
            {
                newArray[i] = nums1[p1];
                p1++;
            }
            else
            {
                newArray[i] = nums2[p2];
                p2++;
            }
        }
        if(newArray.Length == 1)
            return newArray[0];
        else if(newArray.Length %  2 ==0)
            return ((double)newArray[newArray.Length/2 - 1] + (double)newArray[newArray.Length/2]) /2;
        else 
            return newArray[newArray.Length/2];
    }
}
