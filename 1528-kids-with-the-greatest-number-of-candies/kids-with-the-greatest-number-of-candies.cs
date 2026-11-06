public class Solution {
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies) {
        List<bool> result = [];
int max = candies.Max();
for(int i = 0; i < candies.Length; i++)
{
    if (candies[i] + extraCandies >= max)
    {
        result.Add(true);
    }
    else
    {
        result.Add(false);
    }
}
return result;
    }
}