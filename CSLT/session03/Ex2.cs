using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;

namespace CSLT.session03
{

    internal class Ex2

    {
        enum CurrencyType
        {
            USD = 1,
            EUR = 2,
            JPY = 3,
            GBP = 4
        }
        enum StockStatus
        {
            OutOfStock,
            LowStock,
            InStock,
            Discontinued
        }
        enum LoaiPhuongTien
        {
            XeMay = 1,
            OTo = 2,
            XeTai = 3
        }
        enum CustomerType
        {
            Child = 1,   
            Student = 2,
            Adult = 3,
            Senior = 4
        }
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
        static void Bai_3()
        {
            Console.WriteLine("Bài 3:");
            const decimal giaUSD = 25400m;
            const decimal giaEUR = 27200m;
            const decimal giaJPY = 165m;
            const decimal giaGBP = 32100m;
            Console.WriteLine("Nhập số tiền VNĐ cần đổi:");
            decimal soTienVND = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Chọn ngoại tệ muốn đổi (1-USD, 2-EUR, 3-JPY, 4-GBP):");
            int loaiTien = int.Parse(Console.ReadLine());
            decimal phiDichVu = soTienVND * 0.005m;
            decimal vndSauPhi = soTienVND - phiDichVu;
            decimal ngoaiTe = 0m;
            switch (loaiTien)
            {
                case 1: ngoaiTe = vndSauPhi / giaUSD; break;
                case 2:
                    ngoaiTe = vndSauPhi / giaEUR; break;
                case 3:
                    ngoaiTe = vndSauPhi / giaJPY; break;
                case 4:
                    ngoaiTe = vndSauPhi / giaGBP; break;
                default:
                    Console.WriteLine("Loại tiền tệ không hợp lệ.");
                    break;
            }
            Console.WriteLine($"Phí dịch vụ: {phiDichVu} VNĐ");
            Console.WriteLine($"Số tiền VNĐ tính đổi: {vndSauPhi} VNĐ");
            Console.WriteLine($"Số tiền ngoại tệ sau qui đổi là: {ngoaiTe:F2}");


        }
        static void Bai_4()
        {
            Console.WriteLine("Bài 4");
            Console.WriteLine("Nhập ngày sinh của bạn(dd/MM/yyyy):");
            string input = Console.ReadLine();
            if (!DateTime.TryParseExact(input, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime ngaySinh))
            {
                Console.WriteLine("Định dạng ngày sinh không hợp lệ.");
                return;
            }
            DateTime ngayHienTai = DateTime.Now.Date;
            int tuoi = ngayHienTai.Year - ngaySinh.Year;
            if (ngayHienTai < ngaySinh.AddYears(tuoi))
            {
                tuoi--;
            }
            TimeSpan soNgaySong = ngayHienTai - ngaySinh;
            int tongsoNgaySong = (int)soNgaySong.TotalDays;
            DateTime snTiepTheo;
            try
            {
                snTiepTheo = new DateTime(ngayHienTai.Year, ngaySinh.Month, ngaySinh.Day);
            }
            catch (ArgumentOutOfRangeException)
            {
                snTiepTheo = new DateTime(ngayHienTai.Year, 3, 1);
            }
            if (snTiepTheo < ngayHienTai)
            {
                try
                {
                    snTiepTheo = new DateTime(ngayHienTai.Year + 1, ngaySinh.Month, ngaySinh.Day);
                }
                catch (ArgumentOutOfRangeException)
                {
                    snTiepTheo = new DateTime(ngayHienTai.Year + 1, 3, 1);
                }
            }
            TimeSpan thoiGianDenSN = snTiepTheo - ngayHienTai;
            int soNgayConLai = (int)thoiGianDenSN.TotalDays;
            Console.WriteLine($"Tuổi hiện tại: {tuoi} tuổi");
            Console.WriteLine($"Bạn đã sống tổng cộng: {tongsoNgaySong:N0} ngày");
            Console.WriteLine($"Sinh nhật tiếp theo còn: {soNgayConLai} ngày nữa");
        }
        static void Bai_5()
        {
            Console.WriteLine("Bài 5");
            Console.WriteLine("Nhập điểm số(thang 10) môn Lập trình C#:");
            double diemCSharp = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhập số tín chỉ môn Lập trình C#:");
            int tcC = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập điểm số(thang 10) môn Toán rời rạc:");
            double diemToan = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhập số tín chỉ môn Toán rời rạc:");
            int tcToan = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập điểm số(thang 10) môn Tiếng Anh:");
            double diemAnh = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhập số tín chỉ môn Tiếng Anh:");
            int tcAnh = int.Parse(Console.ReadLine());

            double gpa = (diemCSharp * tcC + diemToan * tcToan + diemAnh * tcAnh) / (tcC + tcToan + tcAnh);

            string diemChu;
            double thang4;
            string xepLoai;
            if (gpa >= 8.5)
            {
                diemChu = "A"; thang4 = 4.0; xepLoai = "Xuất sắc / Giỏi";
            }
            else if (gpa >= 7.0)
            {
                diemChu = "B"; thang4 = 3.0; xepLoai = "Khá";
            }
            else if (gpa >= 5.5)
            {
                diemChu = "C"; thang4 = 2.0; xepLoai = "Trung bình";
            }
            else if (gpa >= 4.0)
            {
                diemChu = "D"; thang4 = 1.0; xepLoai = "Yếu";
            }
            else
            {
                diemChu = "F"; thang4 = 0.0; xepLoai = "Kém(Trượt)";
            }
            Console.WriteLine($"Điểm trung bình thang 10: {gpa:F2}");
            Console.WriteLine($"Điểm chữ quy đổi:{diemChu}");
            Console.WriteLine($"Điểm GPA thang 4:{thang4:F1}");
            Console.WriteLine($"\nXếp loại học lực: {xepLoai}");

        }
        static void Bai_6()

        {
            Console.WriteLine("BÀI 6");
            Console.Write("Nhập họ tên thô: ");
            string hoTenTho = Console.ReadLine();

            string chuoiDaCatHaiDau = hoTenTho.Trim();
            char[] kyTuPhanCach = new char[] { ' ' };
            string[] cacTu = chuoiDaCatHaiDau.Split(kyTuPhanCach, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < cacTu.Length; i++)
            {
                string tuHienTai = cacTu[i];

                char kyTuDau = tuHienTai[0];
                char kyTuDauInHoa = char.ToUpper(kyTuDau);

                string phanConLai = tuHienTai.Substring(1);
                string phanConLaiVietThuong = phanConLai.ToLower();

                string tuDaChuanHoa = kyTuDauInHoa + phanConLaiVietThuong;
                cacTu[i] = tuDaChuanHoa;
            }

            string hoTenChuanHoa = string.Join(" ", cacTu);

            string ho = cacTu[0];
            string ten = cacTu[cacTu.Length - 1];

            string tenDem = "";
            if (cacTu.Length > 2)
            {
                string[] mangTenDem = new string[cacTu.Length - 2];
                Array.Copy(cacTu, 1, mangTenDem, 0, cacTu.Length - 2);
                tenDem = string.Join(" ", mangTenDem);
            }

            string BoDauTiengViet(string vanBan)
            {
                if (string.IsNullOrEmpty(vanBan)) return "";

                string chuoiDaTachDau = vanBan.Normalize(NormalizationForm.FormD);
                StringBuilder ketQua = new StringBuilder();

                foreach (char c in chuoiDaTachDau)
                {
                    if (CharUnicodeInfo.GetUnicodeCategory(c) != UnicodeCategory.NonSpacingMark)
                    {
                        ketQua.Append(c);
                    }
                }

                return ketQua.ToString().Replace('đ', 'd').Replace('Đ', 'D').Normalize(NormalizationForm.FormC);
            }

            string tenKhongDau = BoDauTiengViet(ten).ToLower();
            string hoKhongDau = BoDauTiengViet(ho).ToLower();
            string tenDemKhongDau = BoDauTiengViet(tenDem).ToLower();

            string tenTaiKhoan = $"{tenKhongDau}.{hoKhongDau}{tenDemKhongDau}";
            string thuDienTu = $"{tenTaiKhoan}@company.edu.vn";

            Console.WriteLine($"\nHọ tên chuẩn hóa: {hoTenChuanHoa}");
            Console.WriteLine($"Họ: {ho} | Tên đệm: {tenDem} | Tên: {ten}");
            Console.WriteLine($"Username tạo tự động: {tenTaiKhoan}");
            Console.WriteLine($"Email cấp phát: {thuDienTu}");
        }
        static void Bai_7()
        {
            Console.WriteLine("Bài 7");
            Console.WriteLine("Nhập quãng đường (km): ");
            double quangDuong = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhập mức tiêu thụ nhiên liệu (L/100km): ");
            double mucTieuThu = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhập giá xăng (VNĐ/Lít): ");
            decimal giaXang = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Nhập số người: ");
            int soNguoi = int.Parse(Console.ReadLine());

            double tongNhienLieu = (quangDuong / 100.0) * mucTieuThu;
            decimal tongChiPhi = (decimal)tongNhienLieu * giaXang;

            decimal chiPhiMoiNguoiThucTe = tongChiPhi / soNguoi;
            decimal chiPhiMoiNguoi = Math.Ceiling(chiPhiMoiNguoiThucTe / 1000m) * 1000m;

            Console.WriteLine($"Tổng nhiên liệu tiêu thụ: {tongNhienLieu:F2} Lít");
            Console.WriteLine($"Tổng chi phí xăng dầu: {tongChiPhi:N0} VNĐ");
            Console.WriteLine($"Chi phí mỗi người: {chiPhiMoiNguoi:N0} VNĐ");
        }
        static void Bai_8()
        {


            string maOtpHeThong = "839201";
            DateTime thoiDiemTao = DateTime.Now;

            Console.Write("Nhập mã OTP nhận được: ");
            string maOtpNhap = Console.ReadLine();
            DateTime thoiDiemXacThuc = thoiDiemTao.AddMinutes(6).AddSeconds(15);

            if (string.IsNullOrEmpty(maOtpNhap) || maOtpNhap.Length != 6 || !int.TryParse(maOtpNhap, out _))
            {
                Console.WriteLine("\nTrạng thái xác thực: THẤT BẠI");
                Console.WriteLine("Lỗi: Định dạng mã OTP không hợp lệ (phải gồm đúng 6 chữ số).");
                return;
            }
            TimeSpan cheNhLechThoiGian = thoiDiemXacThuc - thoiDiemTao;
            if (cheNhLechThoiGian.TotalMinutes > 5)
            {
                Console.WriteLine("\nTrạng thái xác thực: THẤT BẠI");
                Console.WriteLine("Lỗi: Mã OTP đã hết hạn (quá 5 phút).");
                return;
            }

            if (maOtpNhap != maOtpHeThong)
            {
                Console.WriteLine("\nTrạng thái xác thực: THẤT BẠI");
                Console.WriteLine("Lỗi: Mã OTP không chính xác.");
                return;
            }
            Console.WriteLine("\nTrạng thái xác thực: THÀNH CÔNG");
            Console.WriteLine("Giao dịch đã được phê duyệt.");
        }
        static void Bai_9()
        {
            {

                Console.WriteLine("Bài 9");
                Console.Write("Nhập Lương Gross (VNĐ): ");
                bool laLuongHopLe = decimal.TryParse(Console.ReadLine(), out decimal luongGross);

                Console.Write("Nhập số người phụ thuộc: ");
                bool laSoNguoiHopLe = int.TryParse(Console.ReadLine(), out int soNguoiPhuThuoc);

                if (!laLuongHopLe || !laSoNguoiHopLe || luongGross < 0 || soNguoiPhuThuoc < 0)
                {
                    Console.WriteLine("Lỗi: Dữ liệu nhập vào không hợp lệ.");
                    return;
                }
                double tyLeBHXH = 0.08;
                double tyLeBHYT = 0.015;
                double tyLeBHTN = 0.01;
                double tongTyLeBaoHiem = tyLeBHXH + tyLeBHYT + tyLeBHTN;
                decimal tongBaoHiem = luongGross * (decimal)tongTyLeBaoHiem;

                decimal mucGiamTruBanThan = 11000000m;
                decimal mucGiamTruPhuThuoc = soNguoiPhuThuoc * 4400000m;
                decimal tongGiamTru = tongBaoHiem + mucGiamTruBanThan + mucGiamTruPhuThuoc;

                decimal thuNhapChiuThue = luongGross - tongGiamTru;
                if (thuNhapChiuThue < 0m)
                {
                    thuNhapChiuThue = 0m;
                }
                decimal thueTNCN = 0m;

                if (thuNhapChiuThue > 0m)
                {
                    if (thuNhapChiuThue <= 5000000m)
                    {
                        thueTNCN = thuNhapChiuThue * 0.05m;
                    }
                    else if (thuNhapChiuThue <= 10000000m)
                    {
                        thueTNCN = (5000000m * 0.05m) + ((thuNhapChiuThue - 5000000m) * 0.10m);
                    }
                    else if (thuNhapChiuThue <= 18000000m)
                    {
                        thueTNCN = (5000000m * 0.05m) + (5000000m * 0.10m) + ((thuNhapChiuThue - 10000000m) * 0.15m);
                    }
                    else if (thuNhapChiuThue <= 32000000m)
                    {
                        thueTNCN = (5000000m * 0.05m) + (5000000m * 0.10m) + (8000000m * 0.15m) + ((thuNhapChiuThue - 18000000m) * 0.20m);
                    }
                    else if (thuNhapChiuThue <= 52000000m)
                    {
                        thueTNCN = (5000000m * 0.05m) + (5000000m * 0.10m) + (8000000m * 0.15m) + (14000000m * 0.20m) + ((thuNhapChiuThue - 32000000m) * 0.25m);
                    }
                    else if (thuNhapChiuThue <= 80000000m)
                    {
                        thueTNCN = (5000000m * 0.05m) + (5000000m * 0.10m) + (8000000m * 0.15m) + (14000000m * 0.20m) + (20000000m * 0.25m) + ((thuNhapChiuThue - 52000000m) * 0.30m);
                    }
                    else
                    {
                        thueTNCN = (5000000m * 0.05m) + (5000000m * 0.10m) + (8000000m * 0.15m) + (14000000m * 0.20m) + (20000000m * 0.25m) + (28000000m * 0.30m) + ((thuNhapChiuThue - 80000000m) * 0.35m);
                    }
                }

                decimal luongNet = luongGross - tongBaoHiem - thueTNCN;

                Console.WriteLine($"\nGiảm trừ Bảo hiểm ({tongTyLeBaoHiem * 100}%): {tongBaoHiem:N0} VNĐ");
                Console.WriteLine($"Thu nhập chịu thuế: {thuNhapChiuThue:N0} VNĐ");
                Console.WriteLine($"Thuế TNCN phải nộp: {thueTNCN:N0} VNĐ");
                Console.WriteLine($"LƯƠNG NET THỰC NHẬN: {luongNet:N0} VNĐ");
            }
        }
        static void Bai_10()
        {
            Console.WriteLine("Bài 10");
            string maSanPham = "KB-09";
            string tenSanPham = "Bàn phím Cơ Akko";

            int? quantity = null;
            int minThreshold = 10;
            DateTime? restockDate = null;
            int soLuongHienThi = quantity ?? 0;
            StockStatus trangThaiKho;

            if (quantity == null || quantity == 0)
            {
                trangThaiKho = StockStatus.OutOfStock;
            }
            else if (quantity < minThreshold)
            {
                trangThaiKho = StockStatus.LowStock;
            }
            else
            {
                trangThaiKho = StockStatus.InStock;
            }
            string thongBaoRestock = restockDate?.ToString("dd/MM/yyyy") ?? "Chưa có lịch nhập hàng";
            Console.WriteLine($"Sản phẩm: {tenSanPham} (Mã: {maSanPham})");
            Console.WriteLine($"Số lượng hiển thị: {soLuongHienThi} {(quantity == null ? "(Cảnh báo: Dữ liệu trống)" : "")}");
            Console.WriteLine($"Trạng thái kho: {trangThaiKho} (Hết hàng)");
            Console.WriteLine($"Dự kiến nhập hàng: {thongBaoRestock}");
        }
        static void Bai_11()
        {
            Console.WriteLine("Bài 11");
            Console.Write("Nhập số tiền gửi ban đầu P (VNĐ): ");
            decimal soTienBanDau = decimal.Parse(Console.ReadLine());

            Console.Write("Nhập lãi suất năm r (%/năm): ");
            double laiSuatNam = double.Parse(Console.ReadLine());

            Console.Write("Nhập kỳ hạn gửi n (tháng): ");
            int kyHanThang = int.Parse(Console.ReadLine());
            decimal tienLaiDon = soTienBanDau * (decimal)(laiSuatNam / 100.0) * (decimal)(kyHanThang / 12.0);

            double laiSuatThang = (laiSuatNam / 100.0) / 12.0;

            double tongTienLaiKep = (double)soTienBanDau * Math.Pow(1.0 + laiSuatThang, kyHanThang);
            decimal tienLaiKep = (decimal)tongTienLaiKep - soTienBanDau;

            // 4. Tính chênh lệch
            decimal chenhLech = tienLaiKep - tienLaiDon;

            // 5. In kết quả
            Console.WriteLine($"Tổng tiền lãi (Lãi đơn): {tienLaiDon:N0} VNĐ");
            Console.WriteLine($"Tổng tiền lãi (Lãi kép): {tienLaiKep:N0} VNĐ");
            Console.WriteLine($"Lợi nhuận chênh lệch: {chenhLech:N0} VNĐ (Lãi kép tối ưu hơn)");
        }
        static void Bai_12()
        { 
            Console.Write("Nhập chuỗi văn bản cần mã hóa: ");
            string vanBanGoc = Console.ReadLine();
            int khoaShiftKey = 0;
            while (true)
            {
                Console.Write("Nhập số vị trí dịch chuyển (k từ 1 đến 25): ");
                if (int.TryParse(Console.ReadLine(), out khoaShiftKey) && khoaShiftKey >= 1 && khoaShiftKey <= 25)
                {
                    break;
                }
                Console.WriteLine("Lỗi: Khóa k không hợp lệ (phải là số nguyên từ 1 đến 25). Vui lòng nhập lại!\n");
            }

            StringBuilder chuoiMaHoa = new StringBuilder();
            foreach (char c in vanBanGoc)
            {
                if (c >= 'A' && c <= 'Z')
                {
                    char kyTuMoi = (char)('A' + (c - 'A' + khoaShiftKey) % 26);
                    chuoiMaHoa.Append(kyTuMoi);
                }
                else if (c >= 'a' && c <= 'z')
                {
                    char kyTuMoi = (char)('a' + (c - 'a' + khoaShiftKey) % 26);
                    chuoiMaHoa.Append(kyTuMoi);
                }
                else
                {
                    chuoiMaHoa.Append(c);
                }
            }
            string vanBanMaHoa = chuoiMaHoa.ToString();

            int khoaGiaiMa = 26 - khoaShiftKey;
            StringBuilder chuoiGiaiMa = new StringBuilder();
            foreach (char c in vanBanMaHoa)
            {
                if (c >= 'A' && c <= 'Z')
                {
                    char kyTuMoi = (char)('A' + (c - 'A' + khoaGiaiMa) % 26);
                    chuoiGiaiMa.Append(kyTuMoi);
                }
                else if (c >= 'a' && c <= 'z')
                {
                    char kyTuMoi = (char)('a' + (c - 'a' + khoaGiaiMa) % 26);
                    chuoiGiaiMa.Append(kyTuMoi);
                }
                else
                {
                    chuoiGiaiMa.Append(c);
                }
            }
            string vanBanGiaiMa = chuoiGiaiMa.ToString();

            Console.WriteLine($"Văn bản mã hóa:   {vanBanMaHoa}");
            Console.WriteLine($"Văn bản giải mã:  {vanBanGiaiMa}");
        }
        static void Bai_13()
        {
            Console.WriteLine("Bài 13");
            int chonLoaiXe = 0;
            while (true)
            {
                Console.WriteLine("Chọn loại phương tiện(1-Xe máy, 2-Ô tô, 3-Xe tải): ");

                if (int.TryParse(Console.ReadLine(), out chonLoaiXe) && chonLoaiXe >= 1 && chonLoaiXe <= 3)
                {
                    break;
                }
                Console.WriteLine("Lỗi: Vui lòng chỉ chọn 1, 2 hoặc 3!\n");
            }
            LoaiPhuongTien loaiXe = (LoaiPhuongTien)chonLoaiXe;

            string dinhDang = "yyyy-MM-dd HH:mm";

            DateTime thoiGianVao;
            while (true)
            {
                Console.Write("Nhập thời gian vào (yyyy-MM-dd HH:mm): ");
                if (DateTime.TryParseExact(Console.ReadLine(), dinhDang, CultureInfo.InvariantCulture, DateTimeStyles.None, out thoiGianVao))
                {
                    break;
                }
                Console.WriteLine($"Lỗi: Đúng định dạng là '{dinhDang}' (VD: 2026-08-21 08:15)!");
            }

            DateTime thoiGianRa;
            while (true)
            {
                Console.Write("Nhập thời gian ra (yyyy-MM-dd HH:mm): ");
                if (DateTime.TryParseExact(Console.ReadLine(), dinhDang, CultureInfo.InvariantCulture, DateTimeStyles.None, out thoiGianRa))
                {
                    if (thoiGianRa > thoiGianVao)
                    {
                        break;
                    }
                    Console.WriteLine("Lỗi: Thời gian ra phải sau thời gian vào!");
                    continue;
                }
                Console.WriteLine($"Lỗi: Đúng định dạng là '{dinhDang}' (VD: 2026-08-21 13:40)!");
            }

            TimeSpan thoiGianDo = thoiGianRa - thoiGianVao;
            double soGioThucTe = thoiGianDo.TotalHours;
            int soGioTinhPhi = (int)Math.Ceiling(soGioThucTe);

            decimal phi2GioDau = 0m;
            decimal phiMoiGioTiepTheo = 0m;

            switch (loaiXe)
            {
                case LoaiPhuongTien.XeMay:
                    phi2GioDau = 5000m;
                    phiMoiGioTiepTheo = 2000m;
                    break;
                case LoaiPhuongTien.OTo:
                    phi2GioDau = 20000m;
                    phiMoiGioTiepTheo = 10000m;
                    break;
                case LoaiPhuongTien.XeTai:
                    phi2GioDau = 50000m;
                    phiMoiGioTiepTheo = 25000m;
                    break;
            }
            decimal phiDoXe = 0m;
            if (soGioTinhPhi <= 2)
            {
                phiDoXe = phi2GioDau;
            }
            else
            {
                int soGioSau = soGioTinhPhi - 2;
                phiDoXe = phi2GioDau + (soGioSau * phiMoiGioTiepTheo);
            }

            decimal phuPhiQuaDem = 0m;
            if (thoiGianVao.Date < thoiGianRa.Date)
            {
                phuPhiQuaDem = 30000m;
            }

            decimal tongPhi = phiDoXe + phuPhiQuaDem;

            Console.WriteLine($"Loại xe: {loaiXe}");
            Console.WriteLine($"Thời gian vào: {thoiGianVao:yyyy-MM-dd HH:mm}");
            Console.WriteLine($"Thời gian ra:  {thoiGianRa:yyyy-MM-dd HH:mm}");
            Console.WriteLine($"Số giờ thực tế: {soGioThucTe:F2} giờ -> Tính phí: {soGioTinhPhi} giờ");
            Console.WriteLine($"Phí 2 giờ đầu: {phi2GioDau:N0} VNĐ");

            if (soGioTinhPhi > 2)
            {
                int soGioSau = soGioTinhPhi - 2;
                Console.WriteLine($"Phí {soGioSau} giờ tiếp theo: {soGioSau * phiMoiGioTiepTheo:N0} VNĐ");
            }

            if (phuPhiQuaDem > 0)
            {
                Console.WriteLine($"Phụ phí qua đêm: {phuPhiQuaDem:N0} VNĐ");
            }
            Console.WriteLine($"TỔNG PHÍ: {tongPhi:N0} VNĐ");
        }
        static void Bai_14()
        {
            Console.WriteLine("Bài 14");
                int giaTriInt = 0;

                while (true)
                {
                    Console.Write("Nhập chuỗi số: ");
                    string input = Console.ReadLine();

                    if (!string.IsNullOrWhiteSpace(input) && int.TryParse(input, out giaTriInt))
                    {
                        break;
                    }
                    Console.WriteLine("Lỗi: Chuỗi nhập vào không phải là số nguyên hợp lệ trong khoảng int32. Vui lòng nhập lại!");
                }
                Console.WriteLine($"Kiểm tra Parse: Thành công! Giá trị int = {giaTriInt}");

                bool phuHopByte = giaTriInt >= byte.MinValue && giaTriInt <= byte.MaxValue;
                bool phuHopShort = giaTriInt >= short.MinValue && giaTriInt <= short.MaxValue;

                Console.WriteLine($"Phù hợp kiểu byte (0-255): {(phuHopByte ? "CÓ (Vừa vặn trong dải 0-255)" : "KHÔNG")}");
                Console.WriteLine($"Phù hợp kiểu short (-32768 đến 32767): {(phuHopShort ? "CÓ" : "KHÔNG")}");

                int tongChuSo = 0;
                int soTua = Math.Abs(giaTriInt);
                while (soTua > 0)
                {
                    tongChuSo += soTua % 10;
                    soTua /= 10;
                }
                Console.WriteLine($"Tổng các chữ số: {tongChuSo}");

                try
                {
                    checked
                    {
                        int ketQuaNhan = giaTriInt * giaTriInt * giaTriInt;
                        Console.WriteLine($"Kiểm tra Tràn số: An toàn trong phạm vi int32 (Lập phương = {ketQuaNhan}).");
                    }
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Kiểm tra Tràn số: CẢNH BÁO TRÀN SỐ (OverflowException)! Phép toán nhân vượt quá giới hạn int32.");
                }
            }
        static void Bai_15()
        {
            Console.WriteLine("Bài 15:");

                decimal basePrice = 100000m;
                int chonKhach = 0;
                while (true)
                {
                    Console.WriteLine("Chọn loại khách hàng:");
                    Console.WriteLine("1. Child (Trẻ em < 12 tuổi)");
                    Console.WriteLine("2. Student (Sinh viên)");
                    Console.WriteLine("3. Adult (Người lớn)");
                    Console.WriteLine("4. Senior (Người cao tuổi > 60 tuổi)");
                    Console.Write("Nhập lựa chọn (1-4): ");

                    if (int.TryParse(Console.ReadLine(), out chonKhach) && chonKhach >= 1 && chonKhach <= 4)
                    {
                        break;
                    }
                    Console.WriteLine("Lỗi: Vui lòng chọn số nguyên từ 1 đến 4!\n");
                }
                CustomerType customer = (CustomerType)chonKhach;
                bool hasStudentCard = false;
                if (customer == CustomerType.Student)
                {
                    while (true)
                    {
                        Console.Write("Khách hàng có thẻ Sinh viên hợp lệ không? (true/false hoặc y/n): ");
                        string inputCard = Console.ReadLine().Trim().ToLower();

                        if (inputCard == "true" || inputCard == "y" || inputCard == "yes")
                        {
                            hasStudentCard = true;
                            break;
                        }
                        else if (inputCard == "false" || inputCard == "n" || inputCard == "no")
                        {
                            hasStudentCard = false;
                            break;
                        }
                        Console.WriteLine("Lỗi: Vui lòng nhập 'true'/'y' (Có) hoặc 'false'/'n' (Không)!\n");
                    }
                }

                int chonNgay = 0;
                while (true)
                {
                    Console.WriteLine("\nChọn ngày xem phim trong tuần:");
                    Console.WriteLine("1. Monday (Thứ 2)");
                    Console.WriteLine("2. Tuesday (Thứ 3)");
                    Console.WriteLine("3. Wednesday (Thứ 4)");
                    Console.WriteLine("4. Thursday (Thứ 5)");
                    Console.WriteLine("5. Friday (Thứ 6)");
                    Console.WriteLine("6. Saturday (Thứ 7)");
                    Console.WriteLine("7. Sunday (Chủ Nhật)");
                    Console.Write("Nhập ngày (1-7): \n");

                    if (int.TryParse(Console.ReadLine(), out chonNgay) && chonNgay >= 1 && chonNgay <= 7)
                    {
                        break;
                    }
                    Console.WriteLine("Lỗi: Vui lòng chọn từ 1 đến 7!\n");
                }

                DayOfWeek dayOfWeek = DayOfWeek.Monday;
                switch (chonNgay)
                {
                    case 1: dayOfWeek = DayOfWeek.Monday; break;
                    case 2: dayOfWeek = DayOfWeek.Tuesday; break;
                    case 3: dayOfWeek = DayOfWeek.Wednesday; break;
                    case 4: dayOfWeek = DayOfWeek.Thursday; break;
                    case 5: dayOfWeek = DayOfWeek.Friday; break;
                    case 6: dayOfWeek = DayOfWeek.Saturday; break;
                    case 7: dayOfWeek = DayOfWeek.Sunday; break;
                }

                decimal discountAmount = 0m;
                decimal weekendSurcharge = 0m;
                string discountNote = "Không áp dụng";

                // - Trẻ em (<12t) hoặc Người cao tuổi (>60t): Giảm 50%
                if (customer == CustomerType.Child || customer == CustomerType.Senior)
                {
                    discountAmount = basePrice * 0.50m;
                    discountNote = "Giảm 50% (Trẻ em / Người cao tuổi)";
                }
                // - Sinh viên (có thẻ hợp lệ): Giảm 30% từ Thứ 2 đến Thứ 5
                else if (customer == CustomerType.Student && hasStudentCard &&
                         (dayOfWeek >= DayOfWeek.Monday && dayOfWeek <= DayOfWeek.Thursday))
                {
                    discountAmount = basePrice * 0.30m;
                    discountNote = "Giảm 30% (Sinh viên có thẻ từ T2 - T5)";
                }
                // - Thứ 4 Vui Vẻ: Giảm 20% cho tất cả khách hàng Adult
                else if (customer == CustomerType.Adult && dayOfWeek == DayOfWeek.Wednesday)
                {
                    discountAmount = basePrice * 0.20m;
                    discountNote = "Giảm 20% (Thứ 4 Vui Vẻ cho Người lớn)";
                }

                // - phụ thu Cuối tuần (Friday, Saturday, Sunday): Cộng thêm 20,000 VNĐ/vé
                if (dayOfWeek == DayOfWeek.Friday || dayOfWeek == DayOfWeek.Saturday || dayOfWeek == DayOfWeek.Sunday)
                {
                    weekendSurcharge = 20000m;
                }

                decimal finalPrice = basePrice - discountAmount + weekendSurcharge;
                Console.WriteLine($"Khách hàng:        {customer}");
                if (customer == CustomerType.Student)
                {
                    Console.WriteLine($"Thẻ SV hợp lệ:     {hasStudentCard}");
                }
                Console.WriteLine($"Ngày xem phim:     {dayOfWeek}");
                Console.WriteLine($"Giá vé gốc:        {basePrice:N0} VNĐ");
                Console.WriteLine($"Giảm giá ({discountNote}): -{(discountAmount > 0 ? $"{discountAmount:N0}" : "0")} VNĐ");
                Console.WriteLine($"Phụ thu cuối tuần: +{weekendSurcharge:N0} VNĐ");
                Console.WriteLine($"TỔNG TIỀN VÉ:      {finalPrice:N0} VNĐ");
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
            Bai_9();
            Bai_10();
            Bai_11();
            Bai_12();
            Bai_13();   
            Bai_14();
            Bai_15();

    Console.ReadKey();

        }
      }
}

