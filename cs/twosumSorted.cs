public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        var i = 0;
        var j = numbers.Length - 1;

        while(true)
        {
            var sum = numbers[i] + numbers[j];
            if(sum == target)
                break;
            else if(sum > target)
                j--;
            else
                i++;
        }
        return new int[] {i+1,j+1};
    }
}