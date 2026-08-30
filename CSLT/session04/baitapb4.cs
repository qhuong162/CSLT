using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;

namespace CSLT_VoNgocQuynhHuong_31251026030.session04
{
    internal class baitapb4
    {
        static void Giai_phuong_trinh_bac_hai()
        {
            Console.WriteLine("Giải phương trình bậc 2 ax^2 + bx + c = 0");
            Console.WriteLine("Nhập số a: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhập số b: ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhập số c: ");
            double c = double.Parse(Console.ReadLine());

            if (a == 0)
            {
                if (b == 0)
                {
                    if (c == 0)
                        Console.WriteLine("Phương trình có vô số nghiệm");
                    else
                        Console.WriteLine("Phương trình vô nghiệm");
                }
                else
                {
                    double x = -c / b;
                    Console.WriteLine($"Phương trình có nghiệm duy nhất x ={x:F1}");
                }
            }
            else
            {
                double delta = Math.Pow(b, 2) - 4 * a * c;
                if (delta < 0)
                    Console.WriteLine("Phương trình vô nghiệm");
                else if (delta == 0)
                {
                    Console.WriteLine($"Phương trình có nghiệm kép x1= x2 = {-b / (2 * a):F1}");
                }
                else
                {
                    double x1 = ((-b + Math.Sqrt(delta)) / 2 * a);
                    double x2 = ((-b - Math.Sqrt(delta)) / 2 * a);
                    Console.WriteLine($"Phương trình có hai nghiệm x1={x1:F1} và x2={x2:F1}");
                }
            }
        }
        static void Odd_or_even()
        {
            Console.WriteLine("Chẳn hay lẻ");
            Console.WriteLine("Nhập một số nguyên:");
            int number =int.Parse(Console.ReadLine());
            if (number % 2 == 0)
                Console.WriteLine($"Số {number} là số chẵn");
            else
                Console.WriteLine($"Số {number} là số lẻ");
        }
        static void Tim_max()
        {
            Console.WriteLine(  "Tìm số lớn nhất");
            Console.WriteLine("Nhập số thứ nhất:");
            double n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhập số thứ hai:");
            double n2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhập số thứ ba:");
            double n3 = double.Parse(Console.ReadLine());
            if(n1==n2 && n2==n3)
                Console.WriteLine("Cả ba số đều bằng nhau");
            else
            {
                double max = n1;
                if (n2 > max) max = n2;
                if (n3 > max) max = n3;
                Console.WriteLine($"Số lớn nhất là: {max}");
            }    
            
        }
        static void Equilateral_Isosceles_Scalene()
        {
            Console.WriteLine("Kiểm tra loại tam giác");
            Console.WriteLine("Nhập độ dài cạnh a:");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhập độ dài cạnh b:");
            float b = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhập độ dài cạnh c:");
            float c = float.Parse(Console.ReadLine());
            if(a + b >c && a + c > b && b + c > a)
            {
                if (a == b && b == c)
                    Console.WriteLine("Đây là tam giác đều");
                else if (a == b || b == c || a == c)
                    Console.WriteLine("Đây là tam giác cân");
                else
                    Console.WriteLine("Đây là tam giác thường");
            }
            else
            {
                Console.WriteLine("Ba cạnh không tạo thành tam giác");
            }
        }
        static void Xac_dinh_goc_phan_tu()
        {
            Console.WriteLine("Xác định góc phần tư");
            Console.WriteLine("Nhập hoành độ x:");
            float x = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhập tung độ y");
            float y = float.Parse(Console.ReadLine());
            if(x > 0 && y > 0)
                Console.WriteLine($"Tọa độ ({x}, {y}) nằm ở góc phần tư thứ nhất");
            else if(x < 0 && y > 0)
                Console.WriteLine($"Tọa độ ({x}, {y}) nằm ở góc phần tư thứ hai");
            else if(x < 0 && y < 0)
                Console.WriteLine($"Tọa độ ({x}, {y}) nằm ở góc phần tư thứ ba");
            else if(x > 0 && y < 0)
                Console.WriteLine($"Tọa độ ({x}, {y}) nằm ở góc phần tư thứ tư");
            else if(x==0 && y==0)
                Console.WriteLine($"Tọa độ ({x}, {y}) nằm tại gốc toạ độ");
            else Console.WriteLine("Tọa độ ({x}, {y}) nằm trên trục tọa độ");
        }



        public static void Main(string[] args)
        {
            Giai_phuong_trinh_bac_hai();
            Odd_or_even();
            Tim_max();
            Equilateral_Isosceles_Scalene();
            Xac_dinh_goc_phan_tu();
            Console.ReadKey();
        }
    }
}
    
