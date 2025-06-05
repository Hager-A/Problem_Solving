public class Solution {
    public int RomanToInt(string s) {
            // step1
            int x=0;
            int num=0;
            for(int i = 0; i < s.Length; i++)
            {
                switch (s[i])
                {
                    case 'I':
                        if(i < s.Length-1)
                        {
                            if (s[i + 1] == 'V')
                            {
                                i++;
                                x = 4;
                            }
                            else if (s[i + 1] == 'X')
                            {
                                i++;
                                x = 9;
                            }
                            else
                                x = 1;
                        }
                        else
                        {
                            x = 1;
                        }

                            break;
                    case 'V':
                        x = 5;
                        break;
                    case 'X':
                        
                        if (i < s.Length - 1)
                        {
                            if (s[i + 1] == 'L')
                            {
                                i++;
                                x = 40;
                            }
                            else if (s[i + 1] == 'C')
                            {
                                i++;
                                x = 90;
                            }
                            else
                                x = 10;
                        }
                        else
                        {
                            x = 10;
                        }

                            break;
                    case 'L':
                        x = 50;
                        break;
                    case 'C':
                        if (i < s.Length - 1)
                        {
                            if (s[i + 1] == 'D')
                            {
                                i++;
                                x = 400;
                            }
                            else if (s[i + 1] == 'M')
                            {
                                i++;
                                x = 900;
                            }
                            else
                                x = 100;
                        }
                        else
                        {
                            x = 100;
                        }

                            break;
                    case 'D':
                        x = 500;
                        break;
                    case 'M':
                        x = 1000;
                        break;


                }
                num += x;
            }
           
            return num;
    }
}