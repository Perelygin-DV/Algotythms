using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task1

            int a1 = 2;
            int b1 = 5;
           // Console.WriteLine(Multiply(a1, b1));

            #endregion


            #region Task2-1
            Console.WriteLine(Solve(3,20,0));

            #endregion

            Console.ReadKey();

        }

        private static int Solve(int v1, int v2, int count)
        {
            
            if (v1 == v2) count++;
            
            if (v1 < v2)
            {
                Solve(++v1, v2, count);
                Solve(v1 * 2, v2, count);
            }
            return count;
           
           
            
      

        }

        private static int Multiply(int a1, int b1)
        {

            if (b1 == 0) return 1;

              
                if (b1 % 2 != 0) return a1 * Multiply(a1, b1 - 1);
                else   return Multiply(a1 * a1, b1 / 2); 
        



        }
    }
}
