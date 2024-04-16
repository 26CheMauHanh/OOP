/* Bài 2: Xây dựng lớp Meo gồm:
+ Thuộc tính: Ten, Giong, Gioitinh, Tuoi
+ Phương thức:
• Hàm Khởi tạo, Hàm hủy
• Hàm Nhập, Xuất, Đếm
a) Xuất ra danh sách thông tin mèo đã nhập ra màn hình
b) Đếm số lượng mèo có trong danh sách*/

using System;
class Meo
{
    public string Ten;
    public string Giong;
    public string Gioitinh;
    public int Tuoi;
    public static int dem = 0;
    public Meo()
    {
        Ten = "Ten";
        Giong = "Giong";
        Gioitinh = "Gioitinh";
        Tuoi = 0;
        dem++;
    }
    public void Nhap()
    {
        Console.Write("Nhap ten meo: ");
        Ten = Console.ReadLine();
        Console.Write("Nhap giong: ");
        Giong = Console.ReadLine();
        Console.Write("Nhap gioi tinh: ");
        Gioitinh = Console.ReadLine();
        Console.Write("Nhap tuoi:");
        Tuoi = int.Parse(Console.ReadLine());
    }
    public void Xuat()
    {
        Console.WriteLine("Ten meo :" + Ten + ", Giong :" + Giong + ", Gioi tinh :" + Gioitinh + ", Tuoi:" + Tuoi);
    }
    public void Dem()
    {
        Console.WriteLine("So con meo da nhap: " + dem);
    }
    ~Meo()
    {
        Console.WriteLine("Huy");
    }
    class Program
    {
        private static void Main(string[] args)
        {
            Meo meo1 = new Meo();
            meo1.Nhap();
            meo1.Xuat();
            Meo meo2 = new Meo();
            meo2.Nhap();
            meo2.Xuat();
            Meo meo3 = new Meo();
            meo3.Nhap();
            meo3.Xuat();
            Console.WriteLine("Dem so luong: " + Meo.dem);
        }
    }
}