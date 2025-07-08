public class Solution {
    public int[] Decrypt(int[] code, int k) {
           int x = 0;
   int[] y = new int[code.Length];

   if (k > 0)
   {
       
       for (int i=0;i<code.Length;i++)
       {
           int z = 0;
           x = i+1;
           for (int j = 0; j < k; j++)
           {
              
               if (x >= code.Length)
               {
                   x -= code.Length;

               }
                   z += code[x];
               x++;


           }

           y[i] = z;

       }

   }

 
   else if (k < 0)
   {
       k *= -1;
       for (int i = 0; i < code.Length; i++)
       {
           int z = 0;
           x = i - 1;
           for (int j = 0; j < k; j++)
           {

               if (x <0)
               {
                   x += code.Length;

               }
               z += code[x];
               x--;


           }

           y[i] = z;

       }

   }
   else
   {
       for(int i = 0; i < code.Length; i++)
       {
           y[i] = 0;
       }

   }
   return y;
    }
}