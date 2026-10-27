public class Solution {
    public int MaxProfit(int[] prices) {
        int minm = prices[0];
int diff = 0;
int best = 0;
for(int i = 0; i < prices.Count(); i++)
{
    if (minm > prices[i])
    {
        minm = prices[i];
        //best = 0;
    }

    diff = prices[i] - minm;
    if (diff > best)
    {
        best = diff;
    }

}
return best;
    }
}