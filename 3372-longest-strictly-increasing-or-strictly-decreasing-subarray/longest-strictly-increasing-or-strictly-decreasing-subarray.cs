public class Solution {
    public int LongestMonotonicSubarray(int[] nums) {
        int countIncreasingSubarray = 1;
        int countDecreasingSubarray = 1;
            
        List<int> subarrylength = [1];
        for(int i = 0; i < nums.Length-1; i++)
        {
        if (nums[i] > nums[i + 1])
        {
        if (countIncreasingSubarray > 1)
        {
            subarrylength.Add(countIncreasingSubarray);
            countIncreasingSubarray = 1;
        }
        countDecreasingSubarray++;

        }
        else if (nums[i] < nums[i + 1])
        {
        if (countDecreasingSubarray > 1)
        {
            subarrylength.Add(countDecreasingSubarray);
            countDecreasingSubarray = 1;
        }
        countIncreasingSubarray++;
        }
        else
        {
        if (countIncreasingSubarray > 1)
        {
            subarrylength.Add(countIncreasingSubarray);
            countIncreasingSubarray = 1;
        }
        if (countDecreasingSubarray > 1)
        {
            subarrylength.Add(countDecreasingSubarray);
            countDecreasingSubarray = 1;
        }

        }

        }

        if (countIncreasingSubarray > 1)
        {
            subarrylength.Add(countIncreasingSubarray);
            countIncreasingSubarray = 1;
        }
        if (countDecreasingSubarray > 1)
        {
            subarrylength.Add(countDecreasingSubarray);
            countDecreasingSubarray = 1;
        }
        return subarrylength.Max();
    }
}