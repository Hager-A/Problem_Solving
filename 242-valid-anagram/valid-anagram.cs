public class Solution {
    public bool IsAnagram(string s, string t) {
        s = new string(s.ToCharArray().OrderBy(c => c).ToArray());
t = new string(t.ToCharArray().OrderBy(c => c).ToArray());
if (s == t)
{
    return true;
}
else
{
    return false;
}
    }
}