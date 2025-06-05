public class Solution {
    // step1
    public int Divide(double dividend, double divisor) {

 if (dividend == int.MinValue && divisor == -1) return int.MaxValue;

 bool isNegative = (dividend < 0) ^ (divisor < 0);

 long absDividend = Math.Abs((long)dividend);
 long absDivisor = Math.Abs((long)divisor);

 int result = 0;

 while (absDividend >= absDivisor)
 {
     long temp = absDivisor, multiple = 1;

     while (absDividend >= (temp << 1))
     {
         temp <<= 1;
         multiple <<= 1;
     }

     absDividend -= temp;
     result += (int)multiple;
 }

 return isNegative ? -result : result;
//        int num = 0;
//  int d = 1;
// if (dividend == int.MinValue && divisor == 1) return int.MinValue;
// if (dividend == int.MinValue && divisor == -1) return int.MaxValue;

//  if (dividend < 0)
//  {
//      dividend *= -1;
//      d *= -1;
//  }

//  if (divisor < 0)
//  {
//      divisor *= -1;
//      d *= -1;
//  }
//  if (divisor == 1)
//  {
 
//      return (int)dividend * d;
//  }
          

//  for (int i = 0; i < dividend; i++)
//  {
//      if (dividend >=divisor)
//      {
//          dividend -= divisor;
//          num += 1;
//      }
//      else
//      {
//          break;
//      }


//  }
//  return num*d;
    }
}