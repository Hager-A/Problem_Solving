public class Solution {
    public bool IsPerfectSquare(int num) {
        if(num==1){
            return true;
        }
         for(int i = 1; i <num/2+1; i++)
 {
    
    int x = i * i;
if (x == num&&num%i==0)
{
    return true;
}
 }

 return false;
    }
}