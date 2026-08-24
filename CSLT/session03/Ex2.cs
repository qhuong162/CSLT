using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;

namespace CSLT.session03
{
    
    internal class Ex2
    {
        static void Bai_1()
        {
            Console.WriteLine("Bài 1");
            Console.WriteLine("Nhập vào chỉ số điện cũ (kWh):");
            float csd_cu = float.Parse(Console.ReadLine());
            float csd_moi;
            do
            {
                Console.WriteLine("Nhập chỉ số điện mới (kWh):");
                csd_moi = float.Parse(Console.ReadLine());
                if (csd_moi >= csd_cu)
                    break;
                else
                    Console.WriteLine("Chỉ số điện mới phải lớn hơn hoặc bằng chỉ số điện cũ.");
            } while (true);
            float tieuThu = csd_moi - csd_cu;
            const decimal b1 = 1806m;
            const decimal b2 = 1866m;
            const decimal b3 = 2167m;
            const decimal b4 = 2729m;
            const decimal b5 = 3050m;
            decimal tienDien;
            if (tieuThu <= 50 && tieuThu > 0)
            {
                tienDien = (decimal)tieuThu * b1;
            }
            else if (tieuThu <= 100)
            {
                tienDien = 50 * b1 + (decimal)(tieuThu - 50) * b2;
            }
            else if (tieuThu <= 200)
            {
                tienDien = 50 * b1 + 50 * b2 + (decimal)(tieuThu - 100) * b3;
            }
            else if (tieuThu <= 300)
            {
                tienDien = 50 * b1 + 50 * b2 + 100 * b3 + (decimal)(tieuThu - 200) * b4;
            }
            else
            {
                tienDien = 50 * b1 + 50 * b2 + 100 * b3 + 100 * b4 + (decimal)(tieuThu - 300) * b5;
            }
           
            float vat = 0.08f;
            decimal tienVat = tienDien * (decimal)vat;
            Console.WriteLine($"Số kWh tiêu thụ:{tieuThu} kWh");
            Console.WriteLine($"Tiền điện chưa thuế: {tienDien:C} VNĐ");
            Console.WriteLine($"Tiền thuế VAT: {tienVat:C} VNĐ");
            Console.WriteLine($"Tổng tiền phải thanh toán: {(tienDien + tienVat):C} VNĐ");
        }           
        static void Bai_2()
        {
            Console.WriteLine("Bài 2");
            Console.WriteLine("Nhập vào chiều cao(m):");
            double chieuCao = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhập vào cân nặng (kg)");
            double canNang = double.Parse(Console.ReadLine());

            double bmi = canNang / Math.Pow(chieuCao, 2);
            Console.WriteLine($"Chỉ số BMI của bạn: {bmi:F2} ");
            if (bmi < 18.5)
                Console.WriteLine("Phân loại sức khỏe: Gầy(Thiếu cân)");
            else if (bmi >= 18.5 && bmi < 23)
                Console.WriteLine("Phân loại sức khỏe: Bình thường(Lý tưởng)");
            else if (bmi >= 23 && bmi < 25)
                Console.WriteLine("Phân loại sức khỏe: Thừa cân(Tiền béo phì)");
            else
                Console.WriteLine("Phân loại sức khỏe: Béo phì");
            double canNangToiThieu = 18.5 * Math.Pow(chieuCao, 2);
            double canNangToiDa = 22.9 * Math.Pow(chieuCao, 2);
            Console.WriteLine($"Khuyên dùng: Cân nặng lý tưởng của bạn nên từ {canNangToiThieu:F2} kg đến {canNangToiDa:F2} kg");
        }
           
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Bai_1();
            Bai_2();
// Kiến thức trọng tâm: Kiểu decimal, enum (CurrencyType), switch-case, định dạng tiền tệ quốc tế.
//Yêu cầu bài toán: 
//• Tạo một enum tên CurrencyType gồm: USD, EUR, JPY, GBP.
//• Khai báo tỷ giá cố định(Ví dụ: 1 USD = 25,400 VNĐ; 1 EUR = 27,200 VNĐ; 1 JPY = 165 VNĐ; 1 GBP = 
//32,100 VNĐ). 
//• Nhập vào số tiền VNĐ cần đổi(decimal) và chọn loại ngoại tệ muốn đổi.
//• Phí dịch vụ quy đổi là 0.5 % trên tổng số tiền VNĐ.
//• Tính số tiền VNĐ thực tế sau khi trừ phí, sau đó quy đổi ra ngoại tệ tương ứng.
//• In kết quả chính xác đến 2 chữ số thập phân kèm ký hiệu tiền tệ.
         enum CurrenccyType
        {
            USD,
            EUR,
            JPY,
            GBP
        }
        decimal tienTe;
        const decimal tienUSD =






        Console.ReadKey();
        }
      }
}

