public class Solution {
    public int MaxArea(int[] height) {
                 int area = 0;
     int left = 0;
     int right = height.Length - 1;
     while (left < right)
     {
         int minheight = Math.Min(height[left], height[right]);
         int checkarea = minheight * Math.Abs(right - left);
         if (checkarea > area)
         {
             area = checkarea;
         }
         if (height[left] < height[right])
             left++;
         else
             right--;
     }


 

     return area;
    }
}