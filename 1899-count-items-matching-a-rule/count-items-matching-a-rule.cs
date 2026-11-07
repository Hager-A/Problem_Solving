public class Solution {
    public int CountMatches(IList<IList<string>> items, string ruleKey, string ruleValue) {
        int index = ruleKey == "type" ? 0 : ruleKey == "color" ? 1 : 2; 
        return items.Count(a => a[index] == ruleValue);
    }
}