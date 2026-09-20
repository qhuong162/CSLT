using System;
using System.Collections.Generic;
using System.Text;

namespace CSLT_VoNgocQuynhHuong_31251026030.session06
{
    public class Ham
    {
        public static int Tong(int a, int b)
        {
            return a + b;
        }
        public static bool KiemTraChanLe(int n)
        {
            return n % 2 == 0;
        }
        public static int TimMax(int a, int b, int c)
        {
            return Math.Max(Math.Max(a, b), c);
        }
        public static long TinhGiaiThua(int n)
        {
            long ketQua = 1;
            for (int i = 1; i <= n; i++)
            {
                ketQua *= i; 
            }
            return ketQua;
        }
        public static string DaoNguocChuoi(string str)
        {
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
        public static bool KiemTraSoNguyenTo(int n)
        {
            if (n < 2) return false;
            for (int i = 2; i <=n/2; i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }
        public static void InFibonacci(int n)
        {
            if (n <= 0) return;

            long a = 0, b = 1;
            for (int i = 0; i < n; i++)
            {
                Console.Write(a + " ");
                long next = a + b;
                a = b;
                b = next;
            }
            Console.WriteLine();
        }
        public static int DemNguyenAm(string s)
        {
            int count = 0;
            string vowels = "aeiouAEIOU";

            foreach (char c in s)
            {
                if (vowels.Contains(c))
                {
                    count++;
                }
            }
            return count;
        }
        public static double TinhLuyThua(double x, int y)
        {
            double ketQua = 1.0;
            int soMu= Math.Abs(y);

            for (int i = 0; i < soMu; i++)
            {
                ketQua *= x;
            }

            return y < 0 ? 1.0 / ketQua : ketQua;
        }
        public static double TinhTrungBinh(int[] arr)
        {
            if (arr == null || arr.Length == 0) return 0;

            int tong = 0;
            foreach (int giatri in arr)
            {
                tong += giatri;
            }
            return (double)tong / arr.Length;
        }
        public static bool KiemTraDoiXung(string s)
        {
            if (string.IsNullOrEmpty(s)) return true;

            int left = 0;
            int right = s.Length - 1;

            while (left < right)
            {
                if (s[left] != s[right])
                {
                    return false;
                }
                else
                {
                    left++;
                    right--;
                }
            }
            return true;
        }
        public static double CelsiusToFahrenheit(double c)
        {
            return c * 1.8 + 32;
        }
        public static int TimMin(int[] arr)
        {
            if (arr == null || arr.Length == 0) return 0;
            int min = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < min) min = arr[i];
            }
            return min;
        }
        public static int TongCacChuSo(int n)
        {
            int absN = Math.Abs(n);
            int tong = 0;
            while (absN > 0)
            {
                tong += absN % 10;
                absN /= 10;
            }
            return tong;
        }
        public static void SapXepMang(int[] arr)
        {
            if (arr == null) return;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            foreach (int giatri in arr)
            {
                Console.Write($"{giatri} ");
            }
            Console.WriteLine();
        }
        public static string XoaTrungLap(string s)
        {
            if (string.IsNullOrEmpty(s)) return "";

            string result = "";
            foreach (char c in s)
            {
                if (!result.Contains(c))
                {
                    result += c;
                }
            }
            return result;
        }
        public static int UCLN(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);

            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
        public static string DecimalToBinary(int n)
        {
            if (n == 0) return "0";

            string chuoiNhiPhan = "";
            int temp = Math.Abs(n);

            while (temp > 0)
            {
                int soDu = temp % 2;
                chuoiNhiPhan = soDu + chuoiNhiPhan;
                temp /= 2;
            }

            return n < 0 ? "-" + chuoiNhiPhan : chuoiNhiPhan;
        }
        public static bool KiemTraNamNhuan(int year)
        {
            return (year % 400 == 0) || (year % 4 == 0 && year % 100 != 0);
        }
        public static int DemSoTu(string sentence)
        {
            if (string.IsNullOrWhiteSpace(sentence)) return 0;
            string[] words = sentence.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            return words.Length;
        }
    }
    internal class Ex_Funtions
    {
        public static void Bai1()
        {
            Console.WriteLine("Bài 1: Tính tổng hai số");
            Console.Write("Nhập số nguyên a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhập số nguyên b: ");
            int b = int.Parse(Console.ReadLine());
            int tong = Ham.Tong(a, b);
            Console.WriteLine($"Tổng của {a} và {b} là: {tong}\n");
        }
        public static void Bai2()
        {
            Console.WriteLine("Bài 2: Kiểm tra số chẵn hay lẻ");
            Console.Write("Nhập một số nguyên: ");
            int n = int.Parse(Console.ReadLine());
            bool soChan = Ham.KiemTraChanLe(n);
            if (soChan)
                Console.WriteLine($"Số {n} là số chẵn.\n");
            else
                Console.WriteLine($"Số {n} là số lẻ.\n");
        }
        public static void Bai3()
        {
            Console.WriteLine("Bài 3: Tìm số lớn nhất trong ba số");
            Console.Write("Nhập số nguyên a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhập số nguyên b: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Nhập số nguyên c: ");
            int c = int.Parse(Console.ReadLine());
            int max = Ham.TimMax(a, b, c);
            Console.WriteLine($"Số lớn nhất trong ba số {a}, {b}, {c} là: {max}\n");
        }
        public static void Bai4()
        {
            Console.WriteLine("Bài 4: Tính giai thừa của một số");
            Console.Write("Nhập số nguyên n (n >= 0): ");
            int n = int.Parse(Console.ReadLine());

            long giaiThua = Ham.TinhGiaiThua(n);
            Console.WriteLine($"{n}! = {giaiThua}\n");
        }
        public static void Bai5()
        {
            Console.WriteLine("Bài 5: Đảo ngược chuỗi ký tự");
            Console.Write("Nhập chuỗi cần đảo ngược: ");
            string str = Console.ReadLine();

            string chuoiDao = Ham.DaoNguocChuoi(str);
            Console.WriteLine($"Chuỗi sau khi đảo ngược: {chuoiDao}\n");
        }
        public static void Bai6()
        {
            Console.WriteLine("Bài 6: Kiểm tra số nguyên tố");
            Console.Write("Nhập một số nguyên: ");
            int n = int.Parse(Console.ReadLine());
            bool soNguyenTo = Ham.KiemTraSoNguyenTo(n);
            Console.WriteLine($"Kết quả kiểm tra: {soNguyenTo}");          
        }
        public static void Bai7()
        {
            Console.WriteLine("Bài 7: In dãy Fibonacci");
            Console.Write("Nhập số lượng cần in: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Dãy Fibonacci: ");
            Ham.InFibonacci(n);
        }
        public static void Bai8()
        {
            Console.WriteLine("Bài 8: Đếm số nguyên âm trong chuỗi");
            Console.Write("Nhập một chuỗi: ");
            string s = Console.ReadLine();
            int demNguyenAm = Ham.DemNguyenAm(s);
            Console.WriteLine($"Số lượng nguyên âm trong chuỗi là: {demNguyenAm}\n");
        }
        public static void Bai9()
        {
            Console.WriteLine("Bài 9: Tính lũy thừa");
            Console.Write("Nhập cơ số x: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Nhập số mũ y: ");
            int y = int.Parse(Console.ReadLine());
            double ketQua = Ham.TinhLuyThua(x, y);
            Console.WriteLine($"{x}^{y} = {ketQua}\n");
        }
        public static void Bai10()
        {
            Console.WriteLine("Bài 10: Tính trung bình cộng của mảng");
            Console.Write("Nhập số lượng phần tử mảng: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhập số thứ {i}: ");
                arr[i] = int.Parse(Console.ReadLine());
            }
            double trungBinh= Ham.TinhTrungBinh(arr);
            Console.WriteLine($"Output Trung bình: {trungBinh}");
        }
        public static void Bai11()
        {
            Console.WriteLine("Bài 11: Kiểm tra chuỗi đối xứng");
            Console.Write("Nhập một chuỗi: ");
            string s = Console.ReadLine();
            bool doiXung = Ham.KiemTraDoiXung(s);
            Console.WriteLine($"Kết quả kiểm tra:{doiXung}\n");
        }
        public static void Bai12()
        {
            Console.WriteLine("Bài 12: Chuyển đổi độ C sang độ F");
            Console.Write("Nhập nhiệt độ (°C): ");
            double doC = double.Parse(Console.ReadLine());
            double doF = Ham.CelsiusToFahrenheit(doC);
            Console.WriteLine($"{doC}°C = {doF}°F\n");
        }
        public static void Bai13()
        {
            Console.WriteLine("Bài 13: Tìm số nhỏ nhất trong mảng");
            Console.Write("Nhập số lượng phần tử mảng: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhập số thứ {i}: ");
                arr[i] = int.Parse(Console.ReadLine());
            }
            int min = Ham.TimMin(arr);
            Console.WriteLine($"Số nhỏ nhất trong mảng là: {min}\n");
        }
        public static void Bai14()
        {
            Console.WriteLine("Bài 14: Tính tổng các chữ số ");
            Console.Write("Nhập một số nguyên: ");
            int n = int.Parse(Console.ReadLine());
            int tongChuSo = Ham.TongCacChuSo(n);
            Console.WriteLine($"Tổng các chữ số của {n} là: {tongChuSo}\n");
        }
        public static void Bai15()
        {
            Console.WriteLine("Bài 15: Sắp xếp mảng theo thứ tự tăng dần");
            Console.Write("Nhập số lượng phần tử mảng: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhập số thứ {i}: ");
                arr[i] = int.Parse(Console.ReadLine());
            }
            Ham.SapXepMang(arr);
        }
        public static void Bai16()
        {
            Console.WriteLine("Bài 16: Xóa các ký tự trùng lặp trong chuỗi");
            Console.Write("Nhập một chuỗi: ");
            string s = Console.ReadLine();
            string ketQua = Ham.XoaTrungLap(s);
            Console.WriteLine($"Chuỗi sau khi xóa các ký tự trùng lặp: {ketQua}\n");
        }
        public static void Bai17()
        {
            Console.WriteLine("Bài 17: Tìm ước chung lớn nhất của hai số");
            Console.Write("Nhập số a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhập số b: ");
            int b = int.Parse(Console.ReadLine());
            int ucln = Ham.UCLN(a, b);
            Console.WriteLine($"Ước chung lớn nhất của {a} và {b} là: {ucln}\n");
        }
        public static void Bai18()
        {
            Console.WriteLine("Bài 18: Chuyển đổi số thập phân sang nhị phân");
            Console.Write("Nhập một số : ");
            int n = int.Parse(Console.ReadLine());
            string nhiPhan = Ham.DecimalToBinary(n);
            Console.WriteLine($"Số {n} trong hệ nhị phân là: {nhiPhan}\n");
        }
        public static void Bai19()
        {
            Console.WriteLine("Bài 19: Kiểm tra năm nhuận");
            Console.Write("Nhập một năm: ");
            int year = int.Parse(Console.ReadLine());
            bool namNhuan = Ham.KiemTraNamNhuan(year);
            if (namNhuan)
                Console.WriteLine($"Năm {year} là năm nhuận.\n");
            else
                Console.WriteLine($"Năm {year} không phải là năm nhuận.\n");
        }
        public static void Bai20()
        {
            Console.WriteLine("Bài 20: Đếm số từ trong câu");
            Console.Write("Nhập một câu: ");
            string sentence = Console.ReadLine();
            int soTu = Ham.DemSoTu(sentence);
            Console.WriteLine($"Số từ trong câu là: {soTu}\n");
        }
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Bai1();
            Bai2();
            Bai3();
            Bai4();
            Bai5();
            Bai6();
            Bai7();
            Bai8();
            Bai9();
            Bai10();
            Bai11();
            Bai12();
            Bai13();
            Bai14();
            Bai15();
            Bai16();
            Bai17();
            Bai18();
            Bai19();
            Bai20();
            Console.ReadKey();
        }
    }
}