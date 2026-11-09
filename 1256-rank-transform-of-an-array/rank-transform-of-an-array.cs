public class Solution {
    public int[] ArrayRankTransform(int[] arr) {
        var rank = arr.Distinct().OrderBy(a=>a).ToArray();
        return arr.Select(a=>Array.IndexOf(rank,a)+1).ToArray();
    }
}