public class Solution {
    public int UniqueMorseRepresentations(string[] words) {
          string[] code = [".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--.."];
  List<string> res = [];
  for(int i = 0; i < words.Length; i++)
  {
      string s = "";
      var x = words[i].Select(a => char.ToLower(a) - 'a' );
      var y = x.Select(a => code[a]);
     res.Add( string.Join("", y));


  }

  return res.Distinct().Count();
    }
}