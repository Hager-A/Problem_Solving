public class Solution {
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies) {
      int max = candies.Max();

var result = candies.Select(a => a + extraCandies >= max).ToList();

 return result;
    }
}