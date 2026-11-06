public class Solution {
    public int[] RunningSum(int[] nums) {
        List<int> arr = [];
int addnumber = 0;
for(int i = 0; i < nums.Length; i++)
{
    addnumber += nums[i];
    arr.Add(addnumber);

}
return arr.ToArray();
    }
}