public class Solution {
    public void MoveZeroes(int[] nums) {
        if (nums.Contains(0))
{
    var  Newnums = nums.Where(a => a != 0).Concat(nums.Where(a=>a==0)).ToArray();
    Array.Copy(Newnums, nums, nums.Count());

}
    }
}