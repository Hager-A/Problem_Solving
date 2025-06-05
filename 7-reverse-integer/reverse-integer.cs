public class Solution {
    public int Reverse(int x) {
       int dr = x < 0 ? -1 : 1;
       if (x == int.MinValue)
    return 0;
  x = Math.Abs(x);
  int reserve = 0;
  while (x > 0)
  {
     if (reserve > (int.MaxValue/10))

     return 0;

      reserve = reserve * 10 + (x % 10);

      x /= 10;
  }
  return reserve * dr;
    }
}