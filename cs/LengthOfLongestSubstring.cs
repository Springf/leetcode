public class Solution {
    public int LengthOfLongestSubstring(string s) {
        var count = 0;
        var max = 0;
        Dictionary<char, bool> map = new Dictionary<char, bool>();
        foreach(var c in s)
        {
            if(map.ContainsKey(c))
            {
                if(count > max)
                    max = count;
                count = 0;
                map.Clear();
            }
            map[c] = true;
            count++;
        }
        return max > count ? max : count;
    }
}