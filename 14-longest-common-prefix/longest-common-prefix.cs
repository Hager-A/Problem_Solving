public class Solution {
    
    public string LongestCommonPrefix(string[] strs) {
        //step1
        string comman = "";
bool check = true;
int index = 0;
 for (int i = 0; i < strs.Length; i++)
 {
    
     if (strs[i].Length < strs[index].Length)
     {
         index = i;
     }
     

 }
for (int i = 0; i < strs[index].Length; i++)
{
    for (int j = 0; j < strs.Length; j++)
    {
        if (strs[0][i] != strs[j][i])
            check = false;



    }

    if (check)
        comman += strs[0][i];
    else
        break;




}
return comman;
    }
}