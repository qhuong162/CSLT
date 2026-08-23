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
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Bai_1();
            //• Nhập vào chiều cao (tính bằng mét, ví dụ 1.72) và cân nặng (tính bằng kg, ví dụ 68.5).
            //• Tính chỉ số BMI theo công thức: BMI = Cân nặng / (Chiều cao ^ 2).
            //• Phân loại tình trạng sức khỏe theo chuẩn WHO dành cho người châu Á:
            //• +BMI < 18.5: Gầy(Thiếu cân)
            //• +18.5 <= BMI < 23.0: Bình thường(Lý tưởng)
            //• +23.0 <= BMI < 25.0: Thừa cân(Tiền béo phì)
            //• +BMI >= 25.0: Béo phì
            //• Tính dải cân nặng lý tưởng cho chiều cao đó (Cân nặng tối thiểu = 18.5 * Chiều cao^2; Cân nặng tối đa =
            //22.9 * Chiều cao^2).
            //• Xuất ra chỉ số BMI (lấy 2 chữ số thập phân), phân loại và khoảng cân nặng lý tưởng
            Console.WriteLine("Nhập vào chiều cao(m):");
            double chieuCao = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhập vào cân nặng (kg)");
            double canNang = double.Parse(Console.ReadLine());

            double bmi = canNang / Math.Pow(chieuCao, 2);
            Console.WriteLine($"Chỉ số BMI của bạn: {bmi:F2} ");
            if(bmi< 18.5)
                Console.WriteLine("");



            Console.ReadKey();
        }
      }
}

