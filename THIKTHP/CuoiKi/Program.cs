using System;
public class NGHESI
{
    public string TenNS;
    public double Sonamlamviec;
    public int SoluongTD;

    
    public virtual void Nhap()
    {
        Console.Write("Ten nghe si: ");
        TenNS = Console.ReadLine();
        Console.Write("So nam lam viec: ");
        Sonamlamviec = double.Parse(Console.ReadLine());
        Console.Write("So luong trinh dien: ");
        SoluongTD = int.Parse(Console.ReadLine());

    }
    public virtual double Luong()
    {
        return 0;
    }
    public virtual void Xuat()
    {
        Console.WriteLine($"Ten nghe si la {TenNS}");
        Console.WriteLine($"So nam lam viec la {Sonamlamviec}");
        Console.WriteLine($"So luong trinh dien la {SoluongTD}");

    }
}
public class IDOL : NGHESI
{
    public int SoluongSK;
    public int SoluongGameshow;
    public double KPI;
    public double luong;
    public override void Nhap()
    {
        base.Nhap();
        Console.Write("Nhap so luong su kien: ");
        SoluongSK = int.Parse(Console.ReadLine());
        Console.Write("Nhap so luong Gameshow: ");
        SoluongGameshow = int.Parse(Console.ReadLine());
    }
    public override double Luong()
    {
        luong = 1000 + 100 * Sonamlamviec + 500 * SoluongTD + 200 * SoluongSK + 300 * SoluongGameshow + KPI;
        

    }
    public override void Xuat()
    {
        base.Xuat();
        Console.WriteLine($"Luong cua Idol la {luong}");
    }
}
public class DEBUT : NGHESI
{
    public int SoluongSK;
    public double KPI;
    public double luong;
    public override void Nhap()
    {
        base.Nhap();
        Console.Write("Nhap so luong su kien: ");
        SoluongSK = int.Parse(Console.ReadLine());

    }
    public override double Luong()
    {
        luong = 500 + 50 * Sonamlamviec + 300 * SoluongTD + 100 * SoluongSK + KPI;

    }
    public override void Xuat()
    {
        base.Xuat();
        Console.WriteLine($"Luong cua Debut la {luong}");
    }
}
public class INTERN : NGHESI
{
    public double KPI;
    public double luong;
    public override void Nhap()
    {
        base.Nhap();
        

    }
    public override double Luong()
    {
        luong = 300 + 50 * Sonamlamviec + 200 * SoluongTD + KPI;

    }
    public override void Xuat()
    {
        base.Xuat();
        Console.WriteLine($"Luong cua Intern la {luong}");
    }
}
public class NGOISAOMOI
{
    public int n;
    public virtual void Nhap()
    {
        Console.WriteLine("Nhap cac doi tuong nghe si: ");
        n = int.Parse(Console.ReadLine());
    }
}

class Program
{
    static void Main(string[] args)
    {
        NGHESI idol = new IDOL();
        idol.Nhap();
        idol.Luong();
        idol.Xuat();
        NGHESI debut = new DEBUT();
        debut.Nhap();
        debut.Luong();
        debut.Xuat();
        NGHESI intern = new INTERN();
        intern.Nhap();
        intern.Luong();
        intern.Xuat();
    }
}