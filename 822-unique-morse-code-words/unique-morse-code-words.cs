public class Solution {
    public int UniqueMorseRepresentations(string[] words) {
          string[] code = [".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--.."];
        return words
            .Select(word => word.Select(ch => char.ToLower(ch) - 'a'))
            .Select(a => string.Join("", a.Select(index => code[index])))
            .Distinct().Count();
    }
}