/* Bài 3: Xây dựng lớp Tamgiac (Tam giác) gồm:
+ Thuộc tính: Cạnh a, Cạnh b, Cạnh c
+ Phương thức:
• Hàm Khởi tạo không Tham số, Hàm hủy
• Hàm Nhập, xuất
• Hàm Kiemtra()
Xuất ra màn hình kiểu của tam giác (Tam giác thường, tam
giác vuông, tam giác cân, tam giác vuông cân, tam giác đều)
*/
using System;
class Tamgiac
{
    public int a;
    public int b;
    public int c;
    public Tamgiac()
    {
        a = 0;
        b = 0;
        c = 0;
    }
    ~Tamgiac()
    {
        Console.WriteLine("Huy");
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
    public void Kiemtra()
            {
                if ( a==b && b==c)
                {
                    Console.WriteLine("Tam giac deu");
                }
                
                else if ( a*a + b*b == c*c || a*a + c*c == b*b|| b*b + c*c == a*a)
                {
                    if ( a==b || a==c || b==c)
                    {
                       Console.WriteLine("Tam giac vuong can");
                    }
                    else
                    {
                        Console.WriteLine("Tam giac vuong ");
                    }
                }

                else if ( a==b || a==c || b==c)
                    {
                       Console.WriteLine("Tam giac can");
                    }
                else
                {
                    Console.WriteLine("Tam giac thuong");
                }
            }
            public bool Kiemtratamgiac()
            {
                if (a + b == c)
                {
                    return false;
                }
                if (a + c == b)
                {
                    return false;
                }
                if (c + b == a)
                {
                    return false;
                }
                return true;
            }
}
class Program
{
     static void Main(string[] args)
        {
            Tamgiac tg = new Tamgiac();
                    tg.Nhap();
                    if (tg.Kiemtratamgiac())
                    {
                        tg.Kiemtra();
                    }
                    else
                    {
                        Console.WriteLine("Khong hop le");
                    }
        }
}