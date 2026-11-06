public class Solution {
    public int MinMoves(int[] nums) {
        int min = nums.Min();
int res = 0;
for(int i = 0; i < nums.Length; i++)
{
    res +=  nums[i] - min;

}
return res;
    }
}