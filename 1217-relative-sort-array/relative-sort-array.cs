public class Solution {
    public int[] RelativeSortArray(int[] arr1, int[] arr2) {
         List<int> arr3 = new List<int>();
 for(int i = 0; i < arr2.Length; i++)
 {
     //arr3.Add(arr2[i]);
     var res = arr1.Where(a => a == arr2[i]).ToList();
     arr3.AddRange(res);


 }

 var x = arr1.OrderBy(a => a).Where(a => !arr2.Contains(a)).ToList();
 arr3.AddRange(x);
 
 return arr3.ToArray();
    }
}