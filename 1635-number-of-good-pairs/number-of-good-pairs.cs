public class Solution {
    public int NumIdenticalPairs(int[] nums) {
        Dictionary<int, int> dic = new Dictionary<int,int>();
int res = 0;
for(int i = 0; i < nums.Length; i++)
{
    if (dic.ContainsKey(nums[i]))
    {
        dic[nums[i]] += 1;
    }
    else
    {
        dic[nums[i]] = 1;
    }
}

foreach(var n in dic.Values)
{
    res += (n * (n - 1)) / 2;
}

return res;
    }
}