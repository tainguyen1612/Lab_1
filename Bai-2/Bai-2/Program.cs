using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // hinh thoi
            int i, j, k , n;
            Console.Write("Nhap so hang : ");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= n; i++)
            {
                for (k = 1; k <= n - i; k++)
                {
                    Console.Write(" ");
                }
                    
                for (j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                  
                Console.WriteLine();
            }

            //for (i = 1; i <= n; i++)
            //{
            //    for (k = 1; k <= i; k++)
            //    {
            //        Console.Write(" ");
            //    }
                   
            //    for (j = n - 1; j >= i ; j--)
            //    {
            //        Console.Write("* ");
            //    }
                    
            //    Console.WriteLine();
            //}

            Console.ReadLine();
        }
    }
}
