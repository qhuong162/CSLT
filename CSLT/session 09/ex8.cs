using System;
using System.Collections.Generic;
using System.Text;

namespace CSLT_VoNgocQuynhHuong_31251026030.session_09
{
    internal class ex8
    {
        static void CreateBlankFile(string filePath)
        {
            File.Create(filePath).Close();
            Console.WriteLine("1. Đã tạo tệp rỗng thành công.");
        }
        static void RemoveFile(string filePath)
        {
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
                Console.WriteLine($"2. Đã xóa tệp '{filePath}' thành công.");
            }
        }
        static void CreateAndWriteText(string filePath, string text)
        {
            File.WriteAllText(filePath, text);
            Console.WriteLine("3. Đã tạo tệp và ghi nội dung thành công.");
        }
        static void ReadTextFile(string filePath)
        {
            Console.WriteLine("4. Nội dung tệp:");
            string content = File.ReadAllText(filePath);
            Console.WriteLine(content);
            Console.WriteLine();
        }
        static void WriteArrayToFile(string filePath, string[] lines)
        {
            File.WriteAllLines(filePath, lines);
            Console.WriteLine("5. Đã ghi mảng chuỗi vào tệp thành công.\n");
        }
        static void AppendTextToFile(string filePath, string text)
        {
            File.AppendAllText(filePath, text);
            Console.WriteLine("6. Đã nối nội dung vào tệp thành công.\n");
        }
        static void CopyFileAndDisplay(string sourcePath, string destPath)
        {
            File.Copy(sourcePath, destPath, true);
            Console.WriteLine($"7. Đã sao chép sang '{destPath}'. Nội dung bản sao:");
            Console.WriteLine(File.ReadAllText(destPath));
            Console.WriteLine();
        }
        static void MoveFileInSameDirectory(string sourcePath, string newNamePath)
        {
            if (File.Exists(newNamePath)) File.Delete(newNamePath);
            File.Move(sourcePath, newNamePath);
            Console.WriteLine($"8. Đã đổi tên/di chuyển tệp sang '{newNamePath}'.");
        }
        static int CountLines(string filePath)
        {
            return File.ReadAllLines(filePath).Length;
        }
        static void DemSoDong(string filePath)
        {
            int lineCount = CountLines(filePath);
            Console.WriteLine($"Số dòng trong tệp '{filePath}': {lineCount}");
        }
        static string ReadSpecificLine(string filePath, int lineNumber)
        {
            string[] lines = File.ReadAllLines(filePath);
            if (lineNumber >= 1 && lineNumber <= lines.Length)
            {
                return lines[lineNumber - 1];
            }
            return "Dòng không tồn tại.";
        }
        static void DocDongThuN(string filePath, int lineNumber)
        {
            string lineContent = ReadSpecificLine(filePath, lineNumber);
            Console.WriteLine($"Nội dung dòng {lineNumber}: {lineContent}");
        }
        static void StatisticCharactersAndNumbers(string filePath)
        {
            Console.WriteLine("15. Thống kê ký tự và chữ số trong tệp:");

            string[] lines = File.ReadAllLines(filePath);

            int[,] charCounts = new int[2, 256];
            for (int i = 0; i < 256; i++) charCounts[0, i] = i;

            foreach (string line in lines)
            {
                foreach (char ch in line)
                {
                    if (ch < 256) charCounts[1, ch]++;
                }
            }

            Console.WriteLine("Thống kê số lần xuất hiện (Mảng chữ nhật):");
            for (int i = 0; i < 256; i++)
            {
                if (charCounts[1, i] > 0 && !char.IsControl((char)i))
                {
                    Console.WriteLine($"Ký tự '{(char)i}': {charCounts[1, i]} lần");
                }
            }
        }
        public static void Main(string[] args)
        {
            string fileName = "test.txt";
            string copyFileName = "test_copy.txt";
            string movedFileName = "test_renamed.txt";
            string folderPath = "TestFolder";
            CreateBlankFile(fileName);
            RemoveFile(fileName);
            CreateAndWriteText(fileName, "Hello, this is a test file.");
            ReadTextFile(fileName);
            string[] lines = { "Line 1:a", "Line 2:b", "Line 3:c" };
            WriteArrayToFile(fileName, lines);
            AppendTextToFile(fileName, "Đây là nội dung được nối vào tệp.");
            CopyFileAndDisplay(fileName, copyFileName);
            MoveFileInSameDirectory(copyFileName, movedFileName);
            DemSoDong(fileName);
            DocDongThuN(fileName, 2);
            StatisticCharactersAndNumbers(fileName);
        }
    }
}

    
