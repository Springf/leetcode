public class Solution {
    static Dictionary<Tuple<int,int>, bool> p = new Dictionary<Tuple<int,int>, bool>();
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
                    if(isPalindrome(s,i,i+j-1))
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
    
    private static bool isPalindrome(string s, int start, int end)
    {
        if(start >= end) return true;
        if(p[new Tuple<int,int> (start, end)])
            return true;
        p[new Tuple<int,int> (start, end)] = s[start] == s[end] && isPalindrome(start +1, end -1);
        return p[new Tuple<int,int> (start, end)];
    }
}