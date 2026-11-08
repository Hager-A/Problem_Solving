public class Solution {
    public bool UniqueOccurrences(int[] arr) {
        var res = arr.GroupBy(a => a).Select(a => a.Count());
        return res.Count() == res.Distinct().Count();  
    }
}