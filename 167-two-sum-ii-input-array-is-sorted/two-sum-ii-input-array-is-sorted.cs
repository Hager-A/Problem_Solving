public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
         int[] x = new int[2];
 
 for(int i = 0; i < numbers.Length; i++)
 {
     int res = target - numbers[i];
     int y = Array.IndexOf(numbers, res,i+1);
     if (y >= 0)
     {
         x[0] = i+1;
         x[1] = y+1;
         break;
     }
 }
 return x;
    }
}