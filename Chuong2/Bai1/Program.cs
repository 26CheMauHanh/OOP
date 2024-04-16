/*  Bài 1: Xây dựng lớp Sach gồm:
+Thuộc tính: Tensach, Tacgia, NamXB, Soluong
+ Phương thức:
• Hàm Khởi tạo, Hàm hủy
• Hàm Nhập, Xuất
Xuất ra thông tin các loại sách đã nhập ra màn hình
*/
using System;

class Sach
{
    public string Tensach;
    public string Tacgia;
    public float NamXB;
    public float Soluong;
    public Sach(string tensach, string tacgia, float namXB, float soluong)
    {
        Tensach = tensach;
        Tacgia = tacgia;
        NamXB = namXB;
        Soluong = soluong;
    }
    public Sach()
    {
        Tensach ="";
        Tacgia ="";
        NamXB = 0;
        Soluong = 0;
    }
    public void Nhap()
    {
        Console.Write("Nhap ten sach: ");
        Tensach = Console.ReadLine();
        Console.Write("Nhap ten tac gia: ");
        Tacgia = Console.ReadLine();
        Console.Write("Nhap nam xuat ban: ");
        NamXB = float.Parse(Console.ReadLine());
        Console.Write("Nhap so luong: ");
        Soluong = float.Parse(Console.ReadLine());

    }

    public void Xuat()
    {
        Console.WriteLine("Ten sach: " + Tensach + ", Tac gia: " + Tacgia + ", Nam xuat ban: " + NamXB + ", So luong: " + Soluong);

    }
    ~Sach()
    {
        Console.WriteLine("Huy");
    }
    class Program
    {
        private static void Main(string[] args)
        {
            Sach sach = new Sach("Vo nhat","Van Cao",2003,2);
            sach.Xuat();
            Sach sach1 = new Sach();
            sach1.Nhap();
            sach1. Xuat();
        }
    }
}