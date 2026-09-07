using System;
using System.Collections.Generic;
using System.Text;

namespace CSLT_VoNgocQuynhHuong_31251026030.session05
{
    internal class Ex1
    {
        static void Equilateral_Isosceles_orScalene()
        {
            Console.WriteLine( "KIỂM TRA 3 CẠNH CỦA MỘT TAM GIÁC");
            Console.WriteLine("Nhập cạnh thứ nhất:");
            double a=double.Parse(Console.ReadLine());
            Console.WriteLine("Nhập cạnh thứ hai:");
            double b=double.Parse(Console.ReadLine());
            Console.WriteLine("Nhập cạnh thứ ba:");
            double c = double.Parse(Console.ReadLine());
            if(a+b>c && a+c>b && b+c >a)
            {
                if(a==b || a==c || b==c)
                    Console.WriteLine( "Đây là tam giác cân");
                else if(a==b && b==c)
                    Console.WriteLine("Đây là tam giác đều");
                else Console.WriteLine("Đây là tam giác thường");

            }   
            else Console.WriteLine("Ba cạnh đã nhập không phải là cạnh của một tam giác");
        }
        public static void Main (string[] args)
        {
//1. Write a program to check whether a triangle is Equilateral, Isosceles or Scalene.

//2.Write a program to read 10 numbers and find their average and sum.
//3.Write a program to display the multiplication table of a given integer.
//4.Write a program to display a pattern like triangles with a number.
//5.The patterns like :
//6.Write a program to display the n terms of harmonic series and their
//sum. 1 + 1 / 2 + 1 / 3 + 1 / 4 + 1 / 5... 1 / n terms
//7.Write a program to find the ‘perfect’ numbers within a given number
//range.
//8.Write a program to determine whether a given number is prime or not.
        }
    }
}
