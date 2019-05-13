public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        if(strs.Length == 0)
            return "";
        if(strs.Length == 1)
            return strs[0];
        
       for(int i = 0; i < strs[0].Length; i++)
       {
            var c = strs[0][i];
            for(int j = 1; j< strs.Length; j++)
            {
                var s = strs[j];
                if(i == s.Length || c != s[i])
                {
                   return strs[0].Substring(0, i);  
                }
            }   
       }
        return strs[0];
    }
}