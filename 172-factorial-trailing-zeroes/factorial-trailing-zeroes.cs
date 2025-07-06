public class Solution {
    public int TrailingZeroes(int n) {
       int x = 5;
 int num = 0;
 for(int i = 0; i < n; i++)
 {
     num += n / x;

     if (n > x)
     {
         x *= 5;
     }
     else
     {
         break;
     }

 }
 
 return num;
    }
}