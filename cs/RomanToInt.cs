public class Solution {
    public int RomanToInt(string s) {
        // Dictionary<char, int> dict = new Dictionary<char,int> 
        // {
        //     {'I', 1},
        //     {'V', 5},
        //     {'X', 10},
        //     {'L', 50},
        //     {'C', 100},
        //     {'D', 500},
        //     {'M', 1000}
        // };
        
        var r = 0;
        
        for(int i = 0; i < s.Length; i++)
        {
            var v = 0;
            switch(s[i])
            {
                case 'I':
                    v = 1;
                    if(i+1 < s.Length && (s[i+1] == 'V' || s[i+1] == 'X'))
                        v = -1;
                    break;
                case 'X':
                    v= 10;
                    if(i+1 < s.Length && (s[i+1] == 'L' || s[i+1] == 'C'))
                        v *= -1;
                    break;
                case 'C':
                    v = 100;
                    if(i+1 < s.Length && (s[i+1] == 'D' || s[i+1] == 'M'))
                        v *= -1;
                    break;
                case 'V':
                    v = 5;
                    break;
                case 'L':
                    v = 50;
                    break;
                case 'D':
                    v = 500;
                    break;
                case 'M':
                    v = 1000;
                    break;
                default:
                    break;
            }

            r += v;
        }
        
        return r;
    }
}