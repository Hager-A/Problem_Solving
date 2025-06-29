public class Solution {
    public int TitleToNumber(string columnTitle) {
                    int x = 0;
            int rem = 0;
           
            for(int i = 0; i < columnTitle.Length; i++)
            {
             
                //x = 1;
                switch (columnTitle[i])
                {
                    case 'A':rem = 1; break;
                    case 'B': rem = 2; break;
                    case 'C': rem = 3; break;
                    case 'D':  rem = 4; break;
                    case 'E':  rem = 5; break;
                    case 'F':  rem = 6; break;
                    case 'G': rem = 7; break;
                    case 'H':rem = 8; break;
                    case 'I':  rem = 9; break;
                    case 'J': rem = 10; break;
                    case 'K':  rem = 11; break;
                    case 'L':  rem = 12; break;
                    case 'M':  rem = 13; break;
                    case 'N': rem = 14; break;
                    case 'O': rem = 15; break;
                    case 'P':  rem = 16; break;
                    case 'Q': rem = 17; break;
                    case 'R': rem = 18; break;
                    case 'S': rem = 19; break;
                    case 'T':  rem = 20; break;
                    case 'U':  rem = 21; break;
                    case 'V':  rem = 22; break;
                    case 'W': rem = 23; break;
                    case 'X':  rem = 24; break;
                    case 'Y': rem = 25; break;
                    case 'Z':  rem = 26; break;
                }

                x = x * 26 + rem ;
                //if(i>=1)
                //x = x*26+x;
                //if (x == 0)
                //{
                //    x = 1;
                //}
            }
            return x;
    }
}