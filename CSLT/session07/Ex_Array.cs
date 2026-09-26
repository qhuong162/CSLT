using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CSLT_VoNgocQuynhHuong_31251026030.session07
{
    internal class Ex_Array
    {

        static void nhap_mang_ngau_nhien(int[] a)
        {
            Random rnd=new Random();
            for ( int i=0; i < a.Length;i++)
            {
                a[i]=rnd.Next(10,100);
            }    
        }
        static void in_mang(int[]a)
        {
            foreach(int v in a)
            {
                Console.Write($"{v}, ");
               
            }    
        }
        static float tinh_tb(int[]a)

        {
            int sum = 0;
            foreach (int v in a)
                sum += v;
            return (float)sum / a.Length;
        }
        static bool kiem_tra(int[]a, int x)
        {
            foreach (int v in a)
                if (v == x)
                    return true;
            return false;
        }
        static int timViTri(int[]a, int x)
        {
            for (int i = 0; i < a.Length; i++)
                if (a[i] == x)
                    return i;
            return -1;
        }
        static int[] xoaPhanTu(int[]a, int x)
        {
            int viTri = timViTri(a, x);
            if (viTri == -1)
                return a;
            int[] mangMoi = new int[a.Length - 1];
            for (int i=0, j=0; i<a.Length;i++)
            {
                if (i == viTri) continue;
                mangMoi[j++] = a[i];
            }    
            return mangMoi;
        }
        static int maxMin(int[]a, out int max, out int min)
        {
            max = a[0];
            min = a[0];
            foreach (int v in a)
            {
                if (v > max) max = v;
                if (v < min) min = v;
            }
            return 0;
        }
        static int[] daoNguocMang(int[] a)
        {
            int[] mangMoi = new int[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                mangMoi[i] = a[a.Length - 1 - i];
            }
            return mangMoi;
        }  
        static List<int> timTrungLap(int[] a)
        {
            List<int> trungLap = new List<int>();
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[i] == a[j] && !trungLap.Contains(a[i]))
                    {
                        trungLap.Add(a[i]);
                    }
                }
            }
            return trungLap;
        }
        static int[] xoaTrungLap(int[] a)
        {
            List<int> duyNhat=new List<int>();
            foreach(int v in a)
               {
                if (duyNhat.Contains(v))
                    continue;
                duyNhat.Add(v);
            }
            return duyNhat.ToArray();
        }
        public static void Bai_1()
        {
            Console.Write("Bài 1: Nhập số phần tử của mảng:");
            int n=int.Parse(Console.ReadLine());
            int[] mang = new int[n];
            nhap_mang_ngau_nhien(mang);
            in_mang(mang);
            Console.WriteLine("\n");
        
          
        //1.to calculate the average value of array elements.
            float tb =tinh_tb(mang);
            Console.WriteLine($"Trung bình cộng của mảng là: {tb}\n");

            //2.to test if an array contains a specific value.
            Console.Write("Nhập giá trị cần kiểm tra: ");
            int x=int.Parse(Console.ReadLine());
            bool found = kiem_tra(mang, x);
            if (found)
                Console.WriteLine($"Mảng có chứa giá trị {x}\n");
            else
                Console.WriteLine($"Mảng không chứa giá trị {x}\n");

            //3.to find the index of an array element.
            Console.Write("Nhập giá trị cần tìm vị trí:");
            int soCanTim=int.Parse(Console.ReadLine());
            int viTri = timViTri(mang, soCanTim);
            Console.WriteLine($"Vị trí của {soCanTim} là :{viTri}\n");

            //4.to remove a specific element from an array.
            Console.WriteLine("Nhập giá trị cần xóa:");
            int soCanXoa = int.Parse(Console.ReadLine());
            int[] mangMoi = xoaPhanTu(mang, soCanXoa);
            Console.WriteLine($"Mảng sau khi xóa là:");
            in_mang(mangMoi);
            Console.WriteLine("\n");

            //5.to find the maximum and minimum value of an array.
            maxMin(mang, out int max, out int min);
            Console.WriteLine($"Giá trị lớn nhất của mảng là: {max}");
            Console.WriteLine($"Giá trị nhỏ nhất của mảng là: {min}\n");

            //6.to reverse an array of integer values.
            int[] mangDaoNguoc = daoNguocMang(mang);
            Console.WriteLine("Mảng đảo ngược là:");
            in_mang(mangDaoNguoc);

            //7.to find duplicate values in an array of values.
            List<int> trungLap = timTrungLap(mang);
            Console.WriteLine("\nCác giá trị trùng lặp trong mảng là:" +(trungLap.Count>0?string.Join(", ",trungLap):"Không có\n"));

            //8.to remove duplicate elements from an array.
            int[] mangKhongTrungLap = xoaTrungLap(mang);
            Console.WriteLine("Mảng sau khi xóa các giá trị trùng lặp là:");
            in_mang(mangKhongTrungLap);

        }
        static void BubbleSort(int[] a)
        {
            int n = a.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (a[j] > a[j + 1])
                    {
                        int temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                    }
                }
            }
        }
        static int LinearSearch(string[] a, string target)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (string.Equals(a[i], target, StringComparison.OrdinalIgnoreCase))
                {
                    return i; 
                }
            }
            return -1; 
        }
        public static void Bai_2()
        {
            Console.WriteLine("\nBài 2: Sắp xếp nổi bọt");
            int[] a = new int[10];
            Console.WriteLine("Nhập vào 10 số nguyên:");
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"a[{i}]: ");
                a[i] = int.Parse(Console.ReadLine());
            }
            BubbleSort(a);
            Console.WriteLine("\nMảng sau khi sắp xếp tăng dần:");
            in_mang(a);

            Console.WriteLine("\nTìm kiếm tuyến tính");
            Console.Write("Nhập vào một câu văn: ");
            string cauVan = Console.ReadLine();

            Console.Write("Nhập từ cần tìm kiếm: ");
            string tuCanTim = Console.ReadLine();
            char[] phanCach = new char[] { ' ', ',', '.', '!', '?', ';', ':' };
            string[] danhSachTu = cauVan.Split(phanCach, StringSplitOptions.RemoveEmptyEntries);

            int viTri = LinearSearch(danhSachTu, tuCanTim);

            if (viTri != -1)
            {
                Console.WriteLine($"Tìm thấy từ {tuCanTim} tại vị trí từ thứ {viTri + 1} trong câu.");
            }
            else
            {
                Console.WriteLine($"--> Không tìm thấy từ {tuCanTim} trong câu.");
            }
        }
        public static void Bai_3()
        {
            Console.Write("Nhập số hàng N: ");
            int N = int.Parse(Console.ReadLine());
            Console.Write("Nhập số cột M: ");
            int M = int.Parse(Console.ReadLine());

            int[,] maTran = TaoMaTranNgauNhien(N, M, 1, 99);

            Console.WriteLine("\nMa trận đã tạo");
            InMaTran(maTran);

            Console.Write($"\nNhập số hàng muốn in (0 đến {N - 1}): ");
            int hangI = int.Parse(Console.ReadLine());
            InHang(maTran, hangI);

            Console.Write($"Nhập số cột muốn in (0 đến {M - 1}): ");
            int cotI = int.Parse(Console.ReadLine());
            InCot(maTran, cotI);

            Console.WriteLine($"\nGiá trị LỚN NHẤT trong toàn bộ ma trận: {TimMaxMaTran(maTran)}");

            Console.WriteLine($"Giá trị NHỎ NHẤT của hàng {hangI}: {TimMinHang(maTran, hangI)}");
            Console.WriteLine($"Giá trị NHỎ NHẤT của cột {cotI}: {TimMinCot(maTran, cotI)}");

            int[,] maTranChuyenVi = ChuyenViMaTran(maTran);
            Console.WriteLine("\nMa trận chuyển vị");
            InMaTran(maTranChuyenVi);

            Console.WriteLine("\nĐường chéo chính ,phụ");
            if (N == M)
            {
                InDuongCheo(maTran);
            }
            else
            {
                Console.WriteLine("Ma trận hiện tại không phải là ma trận vuông (N != M) nên không có đường chéo chính/phụ.");
            }
        }

        static int[,] TaoMaTranNgauNhien(int rows, int cols, int min, int max)
        {
            Random rand = new Random();
            int[,] matrix = new int[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = rand.Next(min, max + 1);
                }
            }
            return matrix;
        }

        static void InMaTran(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"{matrix[i, j],4} ");
                }
                Console.WriteLine();
            }
        }

        static void InHang(int[,] matrix, int hang)
        {
            if (hang < 0 || hang >= matrix.GetLength(0))
            {
                Console.WriteLine("Chỉ số hàng không hợp lệ!");
                return;
            }
            Console.Write($"Các phần tử thuộc hàng {hang}: ");
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write($"{matrix[hang, j]} ");
            }
            Console.WriteLine();
        }

        static void InCot(int[,] matrix, int cot)
        {
            if (cot < 0 || cot >= matrix.GetLength(1))
            {
                Console.WriteLine("Chỉ số cột không hợp lệ!");
                return;
            }
            Console.Write($"Các phần tử thuộc cột {cot}: ");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                Console.Write($"{matrix[i, cot]} ");
            }
            Console.WriteLine();
        }

        static int TimMaxMaTran(int[,] matrix)
        {
            int max = matrix[0, 0];
            foreach (int val in matrix)
            {
                if (val > max) max = val;
            }
            return max;
        }

        static int TimMinHang(int[,] matrix, int hang)
        {
            int min = matrix[hang, 0];
            for (int j = 1; j < matrix.GetLength(1); j++)
            {
                if (matrix[hang, j] < min) 
                    min = matrix[hang, j];
            }
            return min;
        }

        static int TimMinCot(int[,] matrix, int cot)
        {
            int min = matrix[0, cot];
            for (int i = 1; i < matrix.GetLength(0); i++)
            {
                if (matrix[i, cot] < min) 
                    min = matrix[i, cot];
            }
            return min;
        }

        static int[,] ChuyenViMaTran(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            int[,] result = new int[cols, rows];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    result[j, i] = matrix[i, j];
                }
            }
            return result;
        }

        static void InDuongCheo(int[,] matrix)
        {
            int n = matrix.GetLength(0);

            Console.Write("Đường chéo chính: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{matrix[i, i]} ");
            }
            Console.WriteLine();

            Console.Write("Đường chéo phụ: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{matrix[i, n - 1 - i]} ");
            }
            Console.WriteLine();
        }
   
        static void Main(string[ ] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Bai_1();
            Bai_2();
            Bai_3();


            Console.ReadKey();
        }
   }
}
