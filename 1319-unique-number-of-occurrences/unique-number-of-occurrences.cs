public class Solution {
    public bool UniqueOccurrences(int[] arr) {
          Dictionary<int, int> dic = new Dictionary<int, int>();
  for(int i = 0; i < arr.Length; i++)
  {
      if (dic.ContainsKey(arr[i]))
      {
          dic[arr[i]] += 1;
      }
      else
      {
          dic[arr[i]] = 1;

      }
  }

  int[] res = dic.Values.ToArray();
  return res.Length == res.Distinct().Count();

    }
}