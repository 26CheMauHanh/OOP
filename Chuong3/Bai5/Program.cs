/* Bài 5: Xây dựng lớp Doanhnghiep gồm các thuộc tính: TenDN,
MST, Diachi lần lượt là Tên doanh nghiệp, Mã số thuế, Địa chỉ
của doanh nghiệp đó.
Từ đó xây dựng lớp DanhsachDN (Danh sách doanh nghiệp)
với các phương thức:
+ Nhập danh sách doanh nghiệp
+ Xuất danh sách doanh nghiệp
+ Tìm mã số thuế theo tên doanh nghiệp (chỉ mục )
+ Tìm tên doanh nghiệp và địa chỉ doanh nghiệp theo mã số
thuế (chỉ mục )
*/
using System;

class Doanhnghiep
{
    public string TenDN { get; set; }
    public string MST { get; set; }
    public string Diachi { get; set; }
}

class DanhsachDN
{
    private List<Doanhnghiep> danhSachDN;

    public DanhsachDN()
    {
        danhSachDN = new List<Doanhnghiep>();
    }

    public void NhapDanhSachDN()
    {
        Console.WriteLine("Nhap so luong: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Nhap thong tin thu {i + 1}:");
            Doanhnghiep dn = new Doanhnghiep();

            Console.Write("Ten doanh nghiep: ");
            dn.TenDN = Console.ReadLine();

            Console.Write("Ma so thue: ");
            dn.MST = Console.ReadLine();

            Console.Write("Dia chi: ");
            dn.Diachi = Console.ReadLine();

            danhSachDN.Add(dn);
        }
    }

    public void XuatDanhSachDN()
    {
        Console.WriteLine("Danh sach doanh nghiep:");
        foreach (var dn in danhSachDN)
        {
            Console.WriteLine($"Ten doanh nghiep: {dn.TenDN}");
            Console.WriteLine($"Ma so thue: {dn.MST}");
            Console.WriteLine($"Dia chi: {dn.Diachi}");
        }
    }

    public string TimMST(string tenDN)
    {
        foreach (var dn in danhSachDN)
        {
            if (dn.TenDN == tenDN)
            {
                return dn.MST;
            }
        }

        return " ";
    }

    public void TimTenVaDiaChi(string mst)
    {
        foreach (var dn in danhSachDN)
        {
            if (dn.MST == mst)
            {
                Console.WriteLine($"Ten doanh nghiep: {dn.TenDN}");
                Console.WriteLine($"Dia chi: {dn.Diachi}");
                return;
            }
        }

        Console.WriteLine("Khong co");
    }
}

class Program
{
    static void Main(string[] args)
    {
        DanhsachDN danhSach = new DanhsachDN();

        danhSach.NhapDanhSachDN();
        danhSach.XuatDanhSachDN();

        Console.WriteLine("Nhap ten dn de tim ma so thue:");
        string tenDN = Console.ReadLine();
        string mst = danhSach.TimMST(tenDN);
        Console.WriteLine($"Ma so thue cua doanh nghiep {tenDN} la: {mst}");

        Console.WriteLine("Nhap ma so thue de tim  ten và  dia chi doanh nghiep:");
        string mstTimKiem = Console.ReadLine();
        danhSach.TimTenVaDiaChi(mstTimKiem);
    }
}