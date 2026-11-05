public class Solution {
    public int MaximumWealth(int[][] accounts) {
        int max = 0;
for(int i = 0; i < accounts.Length; i++)
{
    int account = accounts[i].Sum();
    if (account > max)
    {
        max = account;
    }

}
return max;
    }
}