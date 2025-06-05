public class Solution {
    public string IntToRoman(int num) {
        // step1
        string x="";
while (num > 0)
{
    if (num >= 1000)
    {
        x += 'M';
        num -= 1000;
    }else if(num >= 900)
    {
        x += "CM";
        num -= 900;
    }
    else if (num >= 500)
    {
        x += 'D';
        num -= 500;
    } else if (num >= 400)
    {
        x += "CD";
        num -= 400;
    }
    else if (num >= 100)
    {
        x += 'C';
        num -= 100;
    } else if (num >= 90)
    {
        x += "XC";
        num -= 90;
    }
    else if (num >= 50)
    {
        x += 'L';
        num -= 50;

    }
    else if (num >= 40)
    {
        x += "XL";
        num -= 40;
    }
    else if (num >= 10)
    {
        x += 'X';
        num -= 10;
    }
    else if (num >= 9)
    {
        x += "IX";
        num -= 9;

    }
    else if (num >= 5)
    {
        x += 'V';
        num -= 5;
    }
    else if (num >= 4)
    {
        x += "IV";
        num -= 4;
    }
    else if (num >= 1)
    {
        x += 'I';
        num -= 1;
    }
}
return x;
    }
}