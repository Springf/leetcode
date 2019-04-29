public class Solution {
    public int LengthOfLongestSubstring(string s) {
        var start = 0;
        var max = 0;
        Dictionary<char, int> map = new Dictionary<char, int>();
        for(int i = 0; i < s.Length; i++)
        {
            if(map.ContainsKey(s[i]))
            {
                max = max < i - start ? i - start : max;
                start = map[s[i]] + 1 > start ? map[s[i]] + 1 : start;
            }
            
            map[s[i]] = i;
        }
        return max < s.Length - start ? s.Length - start : max;
    }
}