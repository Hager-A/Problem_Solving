public class Solution {
    public string ConvertToTitle(int columnNumber) {
                    string s = "";
            while (columnNumber > 0)
            {
   
                    int rem = columnNumber % 26 ;
                    
                    columnNumber /= 26;
       

                    switch (rem)
                        {
                            case 1: s = "A" + s; break;
                            case 2: s =  "B" + s; break;
                            case 3: s = "C" + s; break;
                            case 4: s = "D" + s; break;
                            case 5: s = "E" + s; break;
                            case 6: s =  "F" + s; break;
                            case 7: s =  "G" + s; break;
                            case 8: s =  "H" + s; break;
                            case 9: s = "I" + s; break;
                            case 10: s =  "J" + s; break;
                            case 11: s =  "K" + s; break;
                            case 12: s =  "L" + s; break;
                            case 13: s =  "M" + s; break;
                            case 14: s = "N" + s; break;
                            case 15: s =  "O" + s; break;
                            case 16: s = "P" + s; break;
                            case 17: s = "Q" + s; break;
                            case 18: s =  "R" + s; break;
                            case 19: s =  "S"+ s; break;
                            case 20: s =  "T" +s; break;
                            case 21: s =  "U" + s; break;
                            case 22: s = "V"+s; break;
                            case 23: s =  "W"+s; break;
                            case 24: s =  "X"+s; break;
                            case 25: s =  "Y"+s; break;
                            case 0: s =  "Z"+s; break;
                                break;
                    }
             
                if (rem == 0&&columnNumber==1)
                {
                    return s;
                }
                if(rem==0){
                    columnNumber-=1;
                }

            }
            
           
            
          

            return s;
    }
}