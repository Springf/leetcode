public class Solution {
    public string LongestPalindrome(string s) {
        if(string.IsNullOrWhiteSpace(s) || s.Length == 1)
            return s;
        for(int j = s.Length; j >=1 ; j--)
        {
            for(int i = 0; i < s.Length; i++)
            {
                if(i + j <= s.Length)
                {
                    //var ss = s.Substring(i,j);
                    if(isPalindrome(s,i,j))
                    {
                        return s.Substring(i,j);
                    }
                }
                else
                    break;
            }
        }
        return s;
    }
    
    private bool isPalindrome(string s, int start, int length)
    {
        for(int i = start; i < (start+length)/ 2; i++)
        {
            if(s[i] != s[start + length - 1 - i])
                return false;
        }
        return true;
    }
}