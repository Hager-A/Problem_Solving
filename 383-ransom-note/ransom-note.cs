public class Solution {
    public bool CanConstruct(string ransomNote, string magazine) {
        
            Dictionary<char, int> disctionary =new Dictionary<char, int>();


            for (int i = 0; i < magazine.Length; i++)
            {
                if (disctionary.ContainsKey(magazine[i]))
                {
                    disctionary[magazine[i]] += 1;
                }
                else
                {
                    disctionary[magazine[i]] = 1;
                }

            }

            for(int i = 0; i < ransomNote.Length; i++)
            {
                if (disctionary.ContainsKey(ransomNote[i])&& disctionary[ransomNote[i]] >0)
                {
                    disctionary[ransomNote[i]] -= 1;
                }
                else
                {
                    return false;

                }
            }
            return true;
    }
}