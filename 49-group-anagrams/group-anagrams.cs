public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        return strs
            .GroupBy(a => new string(a.OrderBy(ch => ch).ToArray()))
            .Select(a => (IList<string>)a.ToList())
            .ToList();
    }
}