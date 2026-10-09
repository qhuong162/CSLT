using System;
using System.Collections.Generic;
using System.Text;

namespace CSLT_VoNgocQuynhHuong_31251026030.session_08
{
    internal class Ex7
    {
          
        static void Bai_1()
        {
            Console.WriteLine("nhập");
            string str = Console.ReadLine();
            Console.WriteLine(str);
        }
        static int DoDaiChuoi(string str)
        {
            str = str.Replace(" ", "");
            int dem = 0;
            foreach (int x in str)
                dem++;
            return dem;
        }
        static void Bai_2()
        {
            Console.WriteLine("nhập một chuỗi:");
            string str = Console.ReadLine();

            Console.WriteLine($"độ dài của chuỗi là:{DoDaiChuoi(str)}");
        }
        static void Bai_3()
        {
            Console.WriteLine("Nhập một chuỗi");
            string str = Console.ReadLine();
            str = str.Replace(" ", "");
            foreach (char x in str)
                Console.WriteLine($"{x}");
        }
        static void InChuoiNguoc()
        {
            string str = Console.ReadLine();
            str = str.Replace(" ", "");
            for (int i = str.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(str[i]);
            }
        }
        static void Bai_4()
        {
            Console.WriteLine("Bài 4:");
            InChuoiNguoc();

        }
        static int DemTu(string str)
        {
            int count = 0;
            bool inWord = false;
            foreach (char ch in str)
            {
                if (ch != ' ' && ch != '\t' && ch != '\n')
                {
                    if (!inWord)
                    {
                        count++;
                        inWord = true;
                    }
                }
                else
                {
                    inWord = false;
                }
            }
            return count;
        }
        static
            void Bai_5()
        {
            Console.WriteLine("Nhập một chuỗi:");
            string str = Console.ReadLine();
            int wordCount = DemTu(str);
            Console.WriteLine($"Số từ trong chuỗi là: {wordCount}");
        }
        static bool CompareStrings(string str1, string str2)
        {
            int len1 = DoDaiChuoi(str1);
            int len2 = DoDaiChuoi(str2);

            if (len1 != len2) return false;

            for (int i = 0; i < len1; i++)
            {
                if (str1[i] != str2[i]) return false;
            }
            return true;
        }
        static void Bai_6()
        {
            Console.WriteLine("Nhập chuỗi thứ nhất:");
            string str1 = Console.ReadLine();
            Console.WriteLine("Nhập chuỗi thứ hai:");
            string str2 = Console.ReadLine();
            if (CompareStrings(str1, str2))
                Console.WriteLine("Hai chuỗi giống nhau.");
            else
                Console.WriteLine("Hai chuỗi khác nhau.");
        }
        static void CountTypesOfCharacters(string str, out int alphabets, out int digits, out int specials)
        {
            alphabets = 0;
            digits = 0;
            specials = 0;

            foreach (char ch in str)
            {
                if ((ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch <= 'Z'))
                {
                    alphabets++;
                }
                else if (ch >= '0' && ch <= '9')
                {
                    digits++;
                }
                else if (ch != ' ')
                {
                    specials++;
                }
            }
        }
        static void Bai_7()
        {
            Console.WriteLine("Nhập một chuỗi:");
            string str = Console.ReadLine();
            CountTypesOfCharacters(str, out int alphabets, out int digits, out int specials);
            Console.WriteLine($"Số chữ cái: {alphabets}");
            Console.WriteLine($"Số chữ số: {digits}");
            Console.WriteLine($"Số ký tự đặc biệt: {specials}");
        }
        static void CountVowelsAndConsonants(string str, out int vowels, out int consonants)
        {
            vowels = 0;
            consonants = 0;
            string vowelList = "aeiouAEIOU";

            foreach (char ch in str)
            {
                if ((ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch <= 'Z'))
                {
                    bool isVowel = false;
                    foreach (char v in vowelList)
                    {
                        if (ch == v)
                        {
                            isVowel = true;
                            break;
                        }
                    }

                    if (isVowel) vowels++;
                    else consonants++;
                }
            }
        }
        static void Bai_8()
        {
            Console.WriteLine("Nhập một chuỗi:");
            string str = Console.ReadLine();
            CountVowelsAndConsonants(str, out int vowels, out int consonants);
            Console.WriteLine($"Số nguyên âm: {vowels}");
            Console.WriteLine($"Số phụ âm: {consonants}");
        }
        static int FindSubstringIndex(string str, string sub)
        {
            int lenStr = DoDaiChuoi(str);
            int lenSub = DoDaiChuoi(sub);

            if (lenSub == 0 || lenSub > lenStr) return -1;

            for (int i = 0; i <= lenStr - lenSub; i++)
            {
                bool match = true;
                for (int j = 0; j < lenSub; j++)
                {
                    if (str[i + j] != sub[j])
                    {
                        match = false;
                        break;
                    }
                }
                if (match) return i;
            }
            return -1;
        }
        static bool ContainsSubstring(string str, string sub)
        {
            return FindSubstringIndex(str, sub) != -1;
        }
        static void CheckCharacterType(char ch)
        {
            if (ch >= 'a' && ch <= 'z')
            {
                Console.WriteLine($"   => '{ch}' là chữ cái viết THƯỜNG.");
            }
            else if (ch >= 'A' && ch <= 'Z')
            {
                Console.WriteLine($"   => '{ch}' là chữ cái viết HOA.");
            }
            else
            {
                Console.WriteLine($"   => '{ch}' KHÔNG PHẢI là chữ cái tiếng Anh.");
            }
        }
        static int CountSubstringOccurrences(string str, string sub)
        {
            int lenStr = DoDaiChuoi(str);
            int lenSub = DoDaiChuoi(sub);

            if (lenSub == 0 || lenSub > lenStr) return 0;

            int count = 0;
            for (int i = 0; i <= lenStr - lenSub; i++)
            {
                bool match = true;
                for (int j = 0; j < lenSub; j++)
                {
                    if (str[i + j] != sub[j])
                    {
                        match = false;
                        break;
                    }
                }
                if (match) count++;
            }
            return count;
        }
        static void Bai_9_12()
        {
            Console.Write("Nhập chuỗi ban đầu: ");
            string str = Console.ReadLine() ?? "";
            Console.Write("Nhập chuỗi con cần xử lý (bài 9, 10, 12): ");
            string sub = Console.ReadLine() ?? "";
            Console.WriteLine($"9. Chuỗi con {(ContainsSubstring(str, sub) ? "CÓ" : "KHÔNG")} xuất hiện.");

            int pos = FindSubstringIndex(str, sub);
            Console.WriteLine($"10. Vị trí đầu tiên tìm thấy: {pos}");

            Console.Write("11. Nhập 1 ký tự để kiểm tra: ");
            string charInput = Console.ReadLine() ?? "";
            if (charInput.Length > 0)
            {
                CheckCharacterType(charInput[0]);
            }
            Console.WriteLine();
            Console.WriteLine($"12. Số lần chuỗi con xuất hiện: {CountSubstringOccurrences(str, sub)}\n");
        }

        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Bai_1();
            Bai_2();
            Bai_3();
            Bai_4();
            Bai_5();
            Bai_6();
            Bai_7();
            Bai_8();
            Bai_9_12();
        }
    }
}
