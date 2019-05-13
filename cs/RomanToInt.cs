public class Solution {
    public int RomanToInt(string s) {
        Dictionary<char, int> dict = new Dictionary<char,int> 
        {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };
        
        var r = 0;
        
        for(int i = 0; i < s.Length; i++)
        {
            var v = dict[s[i]];
            if(i+1 < s.Length)
            {
                switch(s[i])
                {
                    case 'I':
                        if(s[i+1] == 'V' || s[i+1] == 'X')
                            v *= -1;
                        break;
                    case 'X':
                        if(s[i+1] == 'L' || s[i+1] == 'C')
                            v *= -1;
                        break;
                    case 'C':
                        if(s[i+1] == 'D' || s[i+1] == 'M')
                            v *= -1;
                        break;
                    default:
                        break;
                }    
            }
            
            r += v;
        }
        
        return r;
    }
}