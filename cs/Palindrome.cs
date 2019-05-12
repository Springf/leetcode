public class Solution {
    public bool IsPalindrome(int x) {
        if(x < 10 && x >= 0)
            return true;
        if(x < 0)
            return false;
        if(x%10 == 0)
            return false;
        
        var r = 0;
        var y = x;
        
        while(x != 0)
        {
            r = r*10 + x%10;
            x /= 10;
            //if(r == x) return true;
        }
        
        return r == y;
    }
}