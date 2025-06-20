public class Solution {
    public string AddStrings(string num1, string num2) {
        //  return (long.Parse(num1) + long.Parse(num2)).ToString();
        StringBuilder result = new StringBuilder();
int i = num1.Length - 1, j = num2.Length - 1, carry = 0;

while (i >= 0 || j >= 0 || carry != 0)
{
    int digit1 = i >= 0 ? num1[i--] - '0' : 0;
    int digit2 = j >= 0 ? num2[j--] - '0' : 0;
    int sum = digit1 + digit2 + carry;
    result.Insert(0, sum % 10);
    carry = sum / 10;
}

return result.ToString();

    }
}