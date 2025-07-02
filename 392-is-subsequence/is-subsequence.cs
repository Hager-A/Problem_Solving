public class Solution {
    public bool IsSubsequence(string s, string t) {
        
  int x = -1;
 int z =0;

 for (int i = 0; i < s.Length; i++)
 {

      z = t.IndexOf(s[i],z);

     if (z > -1)
     {
         if (z > x)
         {
             x = z;
         } else
         {
             return false;
         }

     }
     else
     {
         return false;
     }
     z++;
     
 }
 return true;
    }
}