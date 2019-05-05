public class Solution {
    public int Reverse(int x) {
       try{
           var y = x / 10;
           var r = x - y * 10;
           x = y;
           while(x!=0) 
           {
               y = x / 10;
               r = checked(r * 10 + x - y * 10);
               x = y;
           }
           return r;
       }
       catch (Exception ex)
       {
           //Console.WriteLine(ex.Message);
           return 0;
       }
    }
}