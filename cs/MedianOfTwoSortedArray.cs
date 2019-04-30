public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        Func<int[], int, int, double>findMedian = (arr, i, j)
            => i == j ? arr[i] : 
            (i+j) % 2 == 0 ? arr[(i+j)/2] : (arr[(i+j)/2-1]+arr[(i+j)/2+1])/2.0;
        
        int s1 = 0;
        int e1 = nums1.Count-1;
        int s2 = 0;
        int e2 = nums2.Count-1;
        
        while(true)
        {
            var n1m = findMedian(nums1, s1, e1);
            var n2m = findMedian(nums2, s2, e2);
            if(n1m > n2m)
            {   
                e1 = (s1+e1)/2;
                s2 = (s2+e2)/2;
            }
        }
    }
    
    
}