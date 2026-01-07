public class Solution {
    public string CountAndSay(int n) {
        string s = "1";
string targetstring = "1";
string st = "";
if (n == 1)
{
    return "1";
}
else
{
    for (int i = 1; i < n; i++)
    {
        char next = '1';
        int count = 0;
        //s = targetstring;
        st = "";
        targetstring = "";
        for (int j = 0; j < s.Length; j++)
        {
           
            while (j<s.Length &&   next == s[j])
            {
                count++;
                j++;
            }
            if (j == 0)
            {
                next = s[j];
                j = -1;
            }
            else
            {
                targetstring = count.ToString() + s[j - 1];
                count = 0;
            }
             
            if (j < s.Length && j>0)
            {
                next = s[j];
                j--;
               
            }

            st += targetstring;
        }
        s = st;
    }
    return s;
    }
}}