public class Solution {
    public int MyAtoi(string str) {
        if(String.IsNullOrWhiteSpace(str))
            return 0;
        
        var s = str.Trim();
        
        var negative = s[0] == '-';
        var index = s[0] == '-' || s[0] == '+' ? 1 : 0;
        
        int result = 0;
        
        try
        {
            for(; index < s.Length; index++)
            {
                int r = s[index] - '0';
                
                if(r > 9 || r < 0)
                    break;
                
                result = checked(result * 10 + r);
            }
            
            return negative ? result * -1: result;
        }
        catch 
        {
            return negative ? int.MinValue : int.MaxValue;
        }
    }
}