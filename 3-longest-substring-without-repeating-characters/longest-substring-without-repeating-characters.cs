public class Solution {
    public int LengthOfLongestSubstring(string s) {
          int find = 0;
  string sub = "";
  int sublength = 0;
  for(int i = 0; i < s.Length; i++)
  {
      int x= sub.IndexOf(s[i]);
      if (x == -1)
      {
          sub += s[i];
          
      }
      else
      {
          //if(sublength<sub.Length)
          //     sublength = sub.Length;
          sub = "";
          //i--;
          i = s.IndexOf(s[i], find)+1;
          find = i;
          sub += s[i];

      }
      if (sublength < sub.Length)
          sublength = sub.Length;
      if (i == s.Length-1)
      {
          return sublength;
      }

  }

  return sublength;
    }
}