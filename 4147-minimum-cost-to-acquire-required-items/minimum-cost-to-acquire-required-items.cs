public class Solution {
    public long MinimumCost(int cost1, int cost2, int costBoth, int need1, int need2) {
        long cost = 0;
        if (need1 != need2)
        {
        if (need1 < need2)
        {
            cost = ((long)need2 - need1) * cost2;

        }
        else if (need1 > need2)
        {
            cost = ((long)need1 - need2) * cost1;

        }
        return Math.Min(Math.Min((long)cost1 * need1 + (long)cost2 * need2, (long)Math.Max(need1, need2) * costBoth), (long)Math.Min(need1, need2) * costBoth + cost);

        }



        return Math.Min(((long)cost1 * need1 + (long)cost2 * need2), (long)Math.Max(need1, need2) * costBoth);
        }
}   