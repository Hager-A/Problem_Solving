public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int[] arr = new int[nums.Length];



int num = 1;
int indexzero = -1;
int numberzero = nums.Count(a => a == 0);
if (numberzero > 1)
{
    return arr;
}else if (numberzero == 1)
{
    indexzero = Array.IndexOf(nums, 0);

}



    for (int j = 0; j < nums.Length; j++)
    {
        if (nums[j]!=0)
            num *= nums[j];

    }
if (indexzero >= 0)
{
    arr[indexzero] = num;
    return arr;
}
else
{
    for (int i = 0; i < nums.Length; i++)
    {
        arr[i] = num / nums[i];


    }

}

  
return arr;
    }
}