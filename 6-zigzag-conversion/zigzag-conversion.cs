public class Solution {
    public string Convert(string s, int numRows) {
        if (s.Length == 1)
    return s;
if (numRows == 1)
    return s;
if (numRows > s.Length)
    numRows = s.Length;
int traget = numRows - 2+numRows;
string tragetstring = "";

for(int i = 0; i < numRows; i++)
{
    int num1 = traget - i * 2;
    int num2 = traget - num1;
    int start = i;
    //Console.WriteLine(num1 + " " + num2);

    for (int j = 0; j < s.Length; j++)
    {
        if (num1 == 0)
        {
            tragetstring += s[start];
            start += num2;
            
        }else if (num2 == 0)
        {
            tragetstring += s[start];
            start += num1;
           
        }
        else
        {
            tragetstring += s[start];
            start += num1;
            if(start<s.Length)
            tragetstring += s[start];
            start += num2;
           
        }
        j = start - 1;
          
    }

}
return tragetstring;
    }
}