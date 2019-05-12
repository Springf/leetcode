public class Solution {
    public bool IsPalindrome(int x) {
        if(x < 10 && x >= 0)
            return true;
        
        var xs = x.ToString();
        
        for(int i = 0; i < xs.Length/2; i++)
        {
            if(xs[i] != xs[xs.Length - i - 1])
                return false;
        }
        
        return true;
    }
}