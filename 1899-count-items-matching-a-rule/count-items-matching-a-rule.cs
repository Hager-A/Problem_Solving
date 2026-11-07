public class Solution {
    public int CountMatches(IList<IList<string>> items, string ruleKey, string ruleValue) {
          int index = 0;
  if (ruleKey == "type")
  {
      index = 0;
  }else if (ruleKey == "color")
  {
      index = 1;

  }
  else
  {
      index = 2;

  }
  int count = 0;
  for(int i = 0; i < items.Count; i++)
  {
      if (items[i][index]== ruleValue)
      {
          count++;
      }
  }
  return count;
    }
}