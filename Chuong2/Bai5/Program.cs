/*Bài 1: Xây dựng lớp NhaphocTKTH gồm:
-Thuộc tính: Họ tên sinh viên, Ngày sinh, Giới tính,\
             Chuyên ngành(Thống Kê, Quản trị HTTT, THQL)
-Phương thức: 
+ Hàm khởi tạo để nhập thông tin 
(trên 10 sv, có thể dùng mảng, list, hoặc không)
+ Hàm LocSV để học sinh viên theo chuyên ngành. 
Xuất ra màn hình danh sách sinh viên và tổng số lượng
sinh viên nhập học theo chuyên ngành đã chọn
+ Hàm ThongKe để biết được có bao nhiêu sinh viên nam 
và sinh viên nữ theo học các chuyên ngành.*/

using System;
class SinhVien
{
    public string HoTen;
    public string NgaySinh;
    public string GioiTinh;
    public string ChuyenNganh; 

    public SinhVien(string hoten, string ngaysinh, string gioitinh, string chuyennganh)
    {
        HoTen = hoten;
        NgaySinh = ngaysinh;
        GioiTinh = gioitinh;
        ChuyenNganh = chuyennganh;
    }
}

class NhaphocTKTH
{
    private SinhVien[] DanhSachSinhVien;
    private int SoLuongSV;

    public NhaphocTKTH()
    {
        Console.Write("Nhap so luong sinh vien: ");
        SoLuongSV = int.Parse(Console.ReadLine());

        DanhSachSinhVien = new SinhVien[SoLuongSV];

        for (int i = 0; i < SoLuongSV; i++)
        {
            Console.WriteLine("Nhap thong tin cho sinh vien thu:" + (i + 1));
            Console.Write("Ho ten: ");
            string hoten = Console.ReadLine();
            Console.Write("Ngay sinh: ");
            string ngaysinh = Console.ReadLine();
            Console.Write("Gioi tinh: ");
            string gioitinh = Console.ReadLine();
            Console.Write("Chuyen nganh: ");
            string chuyennganh = Console.ReadLine();

            DanhSachSinhVien[i] = new SinhVien(hoten, ngaysinh, gioitinh, chuyennganh);
        }
    }

    public void LocSV(string chuyennganh)
    {
        int TongSoSinhVien = 0;

        Console.WriteLine("Danh sach sinh vien theo chuyen nganh: " + chuyennganh);
        foreach (SinhVien sv in DanhSachSinhVien)
        {
            if (sv.ChuyenNganh == chuyennganh)
            {
                Console.WriteLine("Ho ten: "+ sv.HoTen + ", Ngay sinh: "+ sv.NgaySinh + ", Gioi tinh: " + sv.GioiTinh);
                TongSoSinhVien++;
            }
        }

        Console.WriteLine("Tong so sinh vien nhap hoc theo chuyen nganh: " + chuyennganh + ": " + TongSoSinhVien);
    }

    public void ThongKe()
    {
        int SoSVNam = 0;
        int SoSVNu = 0;

        foreach (SinhVien sv in DanhSachSinhVien)
        {
            if (sv.GioiTinh == "Nam")
            {
                SoSVNam++;
            }
            else if (sv.GioiTinh == "Nu")
            {
                SoSVNu++;
            }
        }

        Console.WriteLine("So luong sinh vien nam: " + SoSVNam);
        Console.WriteLine("So luong sinh vien nu: " + SoSVNu);
    }

    static void Main()
    {
        NhaphocTKTH nhaphoc = new NhaphocTKTH();

        Console.WriteLine("Nhap chuyen nganh can tim:");
        string ChuyenNganhCanTim = Console.ReadLine();

        nhaphoc.LocSV(ChuyenNganhCanTim);
        nhaphoc.ThongKe();
    }
}


