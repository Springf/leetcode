public class Solution {
    public int Reverse(int x) {
       try{
           var sign = 1;
            if(x < 0)
            {
                sign = -1;
                x = -1 * x;
            }
            var s = x.ToString();
            var sb = new StringBuilder();
            foreach (char c in s)
            {
                sb.Insert(0, c);
            }
            
            return int.Parse(sb.ToString())*sign;
       }
       catch (Exception ex)
       {
           //Console.WriteLine(ex.Message);
           return 0;
       }
    }
}