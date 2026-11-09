public class Solution {
    public string[] SortPeople(string[] names, int[] heights) {
         var orderheight = heights.OrderByDescending(x => x).ToArray();
 List<string> newnames = [];
 for(int i = 0; i < names.Length; i++)
 {
    
     newnames.Add(names[Array.IndexOf(heights, orderheight[i])]);
 }
 return newnames.ToArray();
    }
}