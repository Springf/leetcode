public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        if(strs.Length == 0)
            return "";
        if(strs.Length == 1)
            return strs[0];
        
        int i = 0;
        bool done = false;
        while(!done)
        {
            if(i < strs[0].Length)
            {
                var c = strs[0][i];
                foreach(var s in strs)
                {
                    if(i == s.Length || c != s[i])
                    {
                        done = true;
                        break;
                    }
                }
            }
            else
                done = true;
            i++;
        }
        
        if(i == 0)
            return "";
        return strs[0].Substring(0, i-1);
    }
}