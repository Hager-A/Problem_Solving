public class Solution {
    public int MyAtoi(string s) {
       
                 s = s.Trim();
            if (s.Length == 0)
            {
                return 0;
            }
            string trager = "0";
            char sign = '+';
            bool check = true;
            if (s[0] == '-')
            {

                string temp = s.Substring(1);
                s = temp;
                sign = '-';

            }else if (s[0] == '+')
            {
                string temp = s.Substring(1);
                s = temp;
                sign = '+';
            }

                char[] slist = s.ToCharArray();
          
           

                for (int i = 0; i < slist.Length; i++)
            {
                string c = slist[i].ToString();
                bool z = int.TryParse(c, out int result);
                if (z)
                {
                    if (slist[i] != '0')
                    {
                       
                        check = false;

                    }
                    if (!check)
                    {
                        trager += slist[i];

                    }
                    



                }
                else
                {
                    if (sign == '-')
                    {
                        if(trager.Length > 11)
                        {
                            return int.MinValue;
                        }
                        if (long.Parse(trager) <=int.MaxValue  )
                        {
                            return int.Parse(trager) * -1;

                        }
                       
                        else
                        {
                            return int.MinValue;
                        }

                    }
                    else
                    {
                        if (trager.Length > 11)
                        {
                            return int.MaxValue;
                        }
                        if (long.Parse(trager) < int.MaxValue)
                        {
                            return int.Parse(trager);
                        }
                        else
                        {
                            return int.MaxValue;
                        }

                    }

                }

                  
            }

            if (sign == '-')
            {
                if (trager.Length > 11)
                {
                    return int.MinValue;
                }
                if (long.Parse(trager) <= int.MaxValue )
                {
                    return int.Parse(trager) * -1;
                }
                else
                {
                    return int.MinValue;
                }
                
            }
            else
            {
                if (trager.Length > 11)
                {
                    return int.MaxValue;
                }
                if (long.Parse(trager) <= int.MaxValue)
                {
                    return int.Parse(trager) ;
                }
                else
                {
                    return int.MaxValue;
                }
               
            }

    }
}