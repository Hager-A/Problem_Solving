public class Solution {
    public bool IsHappy(int n) {
        
        if (n == 1)
{
    return true;
}
else if (n == 0)
{
    return false;
}
List<int> FinalRes = new List<int>();
List<int> res = new List<int>();

do
{
  
    FinalRes.Add(res.Sum(a => a * a));
    res.Clear();
    while (n > 0)
    {
        res.Add(n % 10);
        n = n / 10;

    }

    n = res.Sum(a => a * a);
} while (!FinalRes.Contains(n));

if (n == 1)
{
    return true;
}


return false;

    }
}