/* Bài 2: Xây dựng lớp SoPhuc (Số phức) gồm:
+ Thuộc tính: PhanThuc, PhanAo (Phần thực, Phần ảo)
+ Phương thức:
• Hàm Khởi tạo không Tham số, Hàm hủy
• Hàm Nhập, xuất
• Hàm Cong(), Tru(), Nhan(),Chia()
Tính Tổng, Hiệu, Tích, Thương 2 số phức A và B rồi in ra kết
quả trên màn hình
*/
using System;
class SoPhuc
{
    public double PhanThuc { get; set; }
    public double PhanAo { get; set; }
    public SoPhuc()
    {
        PhanThuc = 0;
        PhanAo = 0;
    }
    ~SoPhuc()
    {
        Console.WriteLine("Huy");
    }
    public void Nhap()
    {
        Console.Write("Nhap phan thuc: ");
        PhanThuc = double.Parse(Console.ReadLine());

        Console.Write("Nhap phan ao: ");
        PhanAo = double.Parse(Console.ReadLine());
    }
    public void Xuat()
    {
        Console.WriteLine($"{PhanThuc} + {PhanAo}i");
    }
    public SoPhuc Cong(SoPhuc soPhuc)
    {
        SoPhuc ketQua = new SoPhuc();
        ketQua.PhanThuc = PhanThuc + soPhuc.PhanThuc;
        ketQua.PhanAo = PhanAo + soPhuc.PhanAo;
        return ketQua;
    }
    public SoPhuc Tru(SoPhuc soPhuc)
    {
        SoPhuc ketQua = new SoPhuc();
        ketQua.PhanThuc = PhanThuc - soPhuc.PhanThuc;
        ketQua.PhanAo = PhanAo - soPhuc.PhanAo;
        return ketQua;
    }
    public SoPhuc Nhan(SoPhuc soPhuc)
    {
        SoPhuc ketQua = new SoPhuc();
        ketQua.PhanThuc = PhanThuc * soPhuc.PhanThuc - PhanAo * soPhuc.PhanAo;
        ketQua.PhanAo = PhanThuc * soPhuc.PhanAo + PhanAo * soPhuc.PhanThuc;
        return ketQua;
    }
    public SoPhuc Chia(SoPhuc soPhuc)
    {
        SoPhuc ketQua = new SoPhuc();
        double mauSo = Math.Pow(soPhuc.PhanThuc, 2) + Math.Pow(soPhuc.PhanAo, 2);
        ketQua.PhanThuc = (PhanThuc * soPhuc.PhanThuc + PhanAo * soPhuc.PhanAo) / mauSo;
        ketQua.PhanAo = (PhanAo * soPhuc.PhanThuc - PhanThuc * soPhuc.PhanAo) / mauSo;
        return ketQua;
    }
}
class Program
{
    static void Main(string[] args)
    {
        SoPhuc soPhucA = new SoPhuc();
        SoPhuc soPhucB = new SoPhuc();

        Console.WriteLine("Nhap so phuc A:");
        soPhucA.Nhap();

        Console.WriteLine("Nhap so phuc B:");
        soPhucB.Nhap();

        SoPhuc tong = soPhucA.Cong(soPhucB);
        Console.WriteLine("Tong hai so phuc:");
        tong.Xuat();

        SoPhuc hieu = soPhucA.Tru(soPhucB);
        Console.WriteLine("Hieu hai so phuc:");
        hieu.Xuat();

        SoPhuc tich = soPhucA.Nhan(soPhucB);
        Console.WriteLine("Tich hai so phuc:");
        tich.Xuat();

        SoPhuc thuong = soPhucA.Chia(soPhucB);
        Console.WriteLine("Thuong hai so phuc:");
        thuong.Xuat();
    }
}
