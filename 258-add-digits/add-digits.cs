public class Solution {
    public int AddDigits(int num) {
        //step1
          int x=0;
  string s = num.ToString();
  while (s.Length > 1)
  {
      x = 0;
      for(int i = 0; i <s.Length; i++)
      {
          x += int.Parse(s[i].ToString());
      }
      s = x.ToString();
  }
  x = int.Parse(s);
  return x;
    }
}