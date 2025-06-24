public class Solution {
    public int MostWordsFound(string[] sentences) {
         int x = sentences[0].Split(" ").Length;
 for(int i = 1; i < sentences.Length; i++)
 {
     int y = sentences[i].Split(" ").Length;
     if  (y> x)
     {
         x = y;
         
     }
     
 }
 return x;
    }
}