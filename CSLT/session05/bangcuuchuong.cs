using System;
using System.Collections.Generic;
using System.Text;

namespace CSLT_VoNgocQuynhHuong_31251026030.session05
{
    internal class bangcuuchuong
    {
        public static void printStartTriangle()
        {
            int n = 1;
            for (int i = 10; i >= n; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
        public static void Main(string[] args)
        {
            Console.OutputEncoding=Encoding.UTF8;
            printStartTriangle();
            for (int i = 2; i <= 9;  i++) 
            {
                Console.WriteLine($"Bảng nhân {i}");
                for (int j=1;  j <= 9; j++)
                {
                    Console.WriteLine($"{i} * {j} = {i*j}");
                } 
                    
            }
            
        }
    }
}
