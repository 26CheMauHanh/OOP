/*Bài 1: Xây dựng lớp Phanso (Phân số) gồm:
+ Thuộc tính: Tuso, Mauso (Tử số, Mẫu số)
+ Phương thức:
• Hàm Khởi tạo không Tham số, Hàm hủy
• Hàm Nhập, xuất
• Hàm Cong(), Tru(), Nhan(),Chia()
Tính Tổng, Hiệu, Tích, Thương 2 phân số A và B rồi in ra kết
quả trên màn hình.
*/
using System;
class Phanso
{
    public int Tuso { get; set; }
    public int Mauso { get; set; }
    public Phanso()
    {
        Tuso = 0;
        Mauso = 1;
    }
    ~Phanso()
    {
        Console.WriteLine("Huy");
    }
    public void Nhap()
    {
        Console.Write("Nhap Tu so: ");
        Tuso = int.Parse(Console.ReadLine());

        Console.Write("Nhap Mau so: ");
        Mauso = int.Parse(Console.ReadLine());
        
        if (Mauso == 0)
        {
            Console.WriteLine("Mau so khong duoc bang 0");
            Nhap();
        }
    }
    public void Xuat()
    {
        Console.WriteLine($"Phan so la:{Tuso}/{Mauso}");
    }
    public Phanso Cong(Phanso ps)
    {
        Phanso ketqua = new Phanso();
        ketqua.Tuso = this.Tuso * ps.Mauso + ps.Tuso * this.Mauso;
        ketqua.Mauso = this.Mauso * ps.Mauso;
        return ketqua;
    }

    public Phanso Tru(Phanso ps)
    {
        Phanso ketqua = new Phanso();
        ketqua.Tuso = this.Tuso * ps.Mauso - ps.Tuso * this.Mauso;
        ketqua.Mauso = this.Mauso * ps.Mauso;
        return ketqua;
    }

    public Phanso Nhan(Phanso ps)
    {
        Phanso ketqua = new Phanso();
        ketqua.Tuso = this.Tuso * ps.Tuso;
        ketqua.Mauso = this.Mauso * ps.Mauso;
        return ketqua;
    }

    public Phanso Chia(Phanso ps)
    {
        Phanso ketqua = new Phanso();
        ketqua.Tuso = this.Tuso * ps.Mauso;
        ketqua.Mauso = this.Mauso * ps.Tuso;
        return ketqua;
    }
}
class Program
{
    static void Main(string[] args)
    {
        Phanso A = new Phanso();
        Console.WriteLine("Nhap phan so A:");
        A.Nhap();

        Phanso B = new Phanso();
        Console.WriteLine("Nhap phan so B:");
        B.Nhap();

        Phanso tong = A.Cong(B);
        Console.WriteLine("Tong:");
        tong.Xuat();

        Phanso hieu = A.Tru(B);
        Console.WriteLine("Hieu:");
        hieu.Xuat();

        Phanso tich = A.Nhan(B);
        Console.WriteLine("Tich:");
        tich.Xuat();

        Phanso thuong = A.Chia(B);
        Console.WriteLine("Thuong:");
        thuong.Xuat();
    }
}