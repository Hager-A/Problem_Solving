public class Solution {
    public int MaximumWealth(int[][] accounts) {
        int high = accounts.Select(a => a.Sum()).Max();
        return high;
    }
}