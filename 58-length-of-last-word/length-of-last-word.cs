public class Solution {
    public int LengthOfLastWord(string s) {
        string[] arr = s.Trim().Split(" ");
int x = arr[arr.Length - 1].Length;
return x;
    }
}