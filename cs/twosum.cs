public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var sorted = (int[]) nums.Clone();
        Array.Sort(sorted);
        var i = 0;
        var j = nums.Length - 1;
        
        while(true)
        {
            var sum = sorted[i] + sorted[j];
            if(sum == target)
                break;
            else if(sum > target)
                j--;
            else
                i++;
        }
        
        
        var r1 = Array.IndexOf(nums, sorted[i]);
        var r2 = Array.IndexOf(nums, sorted[j]);
        if(r1 == r2)
            r2 = Array.IndexOf(nums, sorted[j], r1+1);
        return r1 > r2 ? new int[] {r2, r1} : new int[] {r1, r2};
        
    }
}