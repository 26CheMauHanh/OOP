/*Bài 4: Xây dựng lớp Triangle gồm:
+ Thuộc tính: a, b, c (kiểu int) là 3 cạnh của một tam giác
+ Phương thức:
• Hàm Khởi tạo, Hàm hủy
• Hàm Nhập, Xuất – Để nhập và xuất thông tin
• Hàm Tính để tính chu vi và diện tích hình tam giác
Tạo một Menu để thực hiện lặp lại các chức năng cho đến khi thoát:
Bấm 1: Nhập các cạnh a,b,c của tam giác
Bấm 2: Tính chu vi và diện tích hình tam giác
Bấm 3: Xuất ra các giá trị a,b,c.
Trường hợp các cạnh tạo được một tam giác thì Xuất ra giá trị Chu
vi và Diện tích của tam giác. Trường hợp không tạo được tam giác
thì xuất ra màn hình “Không hợp lệ”
Bấm 0: Thoát khỏi chương trình*/


using System;

class Triangle
{
    private int a;
    private int b;
    private int c;

    public Triangle()
    {
        a = b = c = 0;
    }

    public void Nhap()
    {
        Console.Write("Nhap canh a: ");
        a = int.Parse(Console.ReadLine());
        Console.Write("Nhap canh b: ");
        b = int.Parse(Console.ReadLine());
        Console.Write("Nhap canh c: ");
        c = int.Parse(Console.ReadLine());
    }

    public void Xuat()
    {
        Console.WriteLine("Cac canh cua tam giac: a = {0}, b = {1}, c = {2}", a,b,c);
    }

    ~Triangle()
    {
        Console.WriteLine("Huy");
    }

    public bool IsTriangle()
    {
        return a + b > c && a + c > b && b + c > a;
    }

    public void Tinh()
    {
        if (IsTriangle())
        {
            double C = a + b + c;
            double p = C / 2;
            double S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

            Console.WriteLine("Chu vi: {0}",C);
            Console.WriteLine("Dien tich: {0}",S);
        }
        else
        {
            Console.WriteLine("Khong hop le");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        int menu;
        Triangle T = new Triangle();

        do
        {
            Console.WriteLine("----- MENU -----");
            Console.WriteLine("1. Nhap cac canh cua tam giac");
            Console.WriteLine("2. Tinh chu vi và dien tich tam giac");
            Console.WriteLine("3. Xuat cac gia tri a, b, c");
            Console.WriteLine("0. Thoat");
            Console.Write("Nhap lua chon cua ban: ");
            menu = int.Parse(Console.ReadLine());

            switch (menu)
            {
                case 1:
                    T.Nhap();
                    break;
                case 2:
                    T.Tinh();
                    break;
                case 3:
                    T.Xuat();
                    break;
                case 0:
                    break;
                default:
                    Console.WriteLine("Lua chon khong hop le.");
                    break;
            }

        } while (menu != 0);
    }
}