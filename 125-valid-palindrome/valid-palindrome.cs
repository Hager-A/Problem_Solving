using System.Text.RegularExpressions;

public class Solution {
    public bool IsPalindrome(string s) {
               string pattern = @"^[a-zA-Z0-9]+$";
       string reverse = "";
       string ss = "";
       for (int i = 0; i < s.Length; i++)
       {

           if (Regex.IsMatch(s[i].ToString(),pattern)){
           string x = s[i].ToString().ToLower();
               ss = ss + x;
               reverse = x + reverse;
       
           }

       }

       if (ss == reverse)
       {
           return true;
       }
       else
       {
           return false;
       }
    }
}