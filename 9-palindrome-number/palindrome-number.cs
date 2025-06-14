public class Solution {
    public bool IsPalindrome(int x) {
        string y = new string(x.ToString().Reverse().ToArray());
        return y==x.ToString();
    }
}