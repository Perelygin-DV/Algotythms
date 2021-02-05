using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1
{
    class Program
    {

      static  int Task4(int a, int b, int c, ref double x1, ref double x2)
        {
            int d = b * b - 4 * a * c;
            if (d < 0) return -1;
            else if (d == 0)
            {
                x1 = -b / (2 * a);
                return 0;

            }
            else if (d > 0)
            {
                x1 = (-b + Math.Sqrt(d)) / (2 * a);
                x2 = (-b - Math.Sqrt(d)) / (2 * a);
                return 1;
            }
            else return -2;
        }

        static bool Task10(int a)
        {
            int b = 0;
            while (a > 0)
            {
                b = a % 10;
                if (b % 2 != 0) return true;
                a /= 10;
            }
            
            
            return false;
        }

        static List<double> Task14(int a)
        {
            double c;
            List<double> Arr=new List<double>();
            for (int i = 1; i < a; i++)
            {
                double s = Math.Sqrt(i);
                c = (double)i;
              
                    while (s > 0)
                    {
                        if (c % 10 == s % 10) { s = (int)(s /10); c = (int)(c/10); continue; };
                        break;
                    }
                    if (s == 0) Arr.Add(i);
                
                
            }
            return Arr;
        }
        static void Main(string[] args)
        {
            #region Task4
            double x1=0, x2=0;
            int a = 3;
            int b = -14;
            int c = -5;
            switch(Task4(a,b,c,ref x1,ref x2))
            {
                case -2: Console.WriteLine("что-то не так"); break;
                case -1: Console.WriteLine("корней нет"); break;
                case 0: Console.WriteLine($"x={x1}"); break;
                case 1: Console.WriteLine($"x1={x1:f4}, x2={x2:f4}"); break;

            }



            #endregion

            #region Task10

            Console.WriteLine(Task10(246));
            #endregion

            List<double> M = Task14(700);
            foreach (int el in M)
            {
                Console.WriteLine(el);
            }

            Console.WriteLine(4.26%10);



            Console.ReadLine();
        
        
        }
    }
}
