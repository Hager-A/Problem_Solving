public class Solution {
    public char FindTheDifference(string s, string t) {
        Dictionary<char, int> dic = new Dictionary<char, int>();
for (int i = 0; i < t.Length; i++)
{
    if (dic.ContainsKey(t[i]))
    {
        dic[t[i]] += 1;

    }
    else
    {
        dic[t[i]] = 1;
    }
}

for (int i = 0; i < s.Length; i++)
{
    if (dic.ContainsKey(s[i]))
    {
        dic[s[i]] -= 1;
    }
}
char res =new char();
foreach (var i in dic)
{
    if (i.Value != 0)
    {
        res = i.Key;
    }

}
return res;
    }
}