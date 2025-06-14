public class Solution {
    public bool IsPalindrome(int x) {
        if (x < 0)
        {
            return false;
        }
        else {
            string y = new string(x.ToString().Reverse().ToArray());
            return y == x.ToString();
  }
    }
}