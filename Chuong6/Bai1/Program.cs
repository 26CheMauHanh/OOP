using System;
public class Hinhhoc
{
    public virtual void Nhap()
    {

    }
    public virtual void ChuVi()
    {

    }
    public virtual void Dientich()
    {

    }
}
class HinhChuNhat : Hinhhoc
{
    public double chieudai, chieurong;
    public override void Nhap()
    {
        Console.Write("Nhap chieu dai hinh chu nhat: ");
        chieudai = double.Parse(Console.ReadLine());
        Console.Write("Nhap chieu rong hinh chu nhat: ");
        chieurong = double.Parse(Console.ReadLine());
    }
    public override void ChuVi()
    {
        double chuvi = (chieudai + chieurong) * 2;
        Console.WriteLine($"Chu vi hinh chu nhat la: {chuvi}");
    }
    public override void Dientich()
    {
        double dientich = chieudai * chieurong;
        Console.WriteLine($"Dien tich hinh chu nhat la: {dientich}");
    }
}
class HinhTron : Hinhhoc
{
    public double bankinh;
    public double pi = 3.14;
    public override void Nhap()
    {
        Console.Write("Nhap ban kinh hinh tron: ");
        bankinh = double.Parse(Console.ReadLine());

    }
    public override void ChuVi()
    {
        double chuvi = 2 * pi * bankinh;
        Console.WriteLine($"Chu vi hinh tron la: {chuvi}");
    }
    public override void Dientich()
    {
        double dientich = 2 * pi * bankinh * bankinh;
        Console.WriteLine($"Dien tich hinh tron la: {dientich}");
    }
}
class Hinhtamgiac : Hinhhoc
{
    public double a, b, c;
    public override void Nhap()
    {
        Console.Write("Nhap chieu dai canh a: ");
        a = double.Parse(Console.ReadLine());
        Console.Write("Nhap chieu dai canh b: ");
        b = double.Parse(Console.ReadLine());
        Console.Write("Nhap chieu dai canh c: ");
        c = double.Parse(Console.ReadLine());
    }
    public override void ChuVi()
    {
        double chuvi = a + b + c;
        Console.WriteLine($"Chu vi hinh tam giac la: {chuvi}");
    }
    public override void Dientich()
    {
        double p = (a + b + c) / 2;
        double dientich = Math.Sqrt(p * (p-a) * (p - b) * (p - c));
        Console.WriteLine($"Dien tich hinh tam giac la: {dientich}");
    }
}
class Hinhvuong : Hinhhoc
{
    public double canh;
    public override void Nhap()
    {
        Console.Write("Nhap chieu dai canh hinh vuong: ");
        canh = double.Parse(Console.ReadLine());

    }
    public override void ChuVi()
    {
        double chuvi = 4 * canh;
        Console.WriteLine($"Chu vi hinh vuong la: {chuvi}");
    }
    public override void Dientich()
    {
        double dientich = canh * canh;
        Console.WriteLine($"Dien tich hinh chu nhat la: {dientich}");
    }
}
internal class Bai1
{
    static void Main(string[] args)
    {
        HinhChuNhat hcn = new HinhChuNhat();
        hcn.Nhap(); hcn.ChuVi(); hcn.Dientich();
        HinhTron ht = new HinhTron();
        ht.Nhap(); ht.ChuVi(); ht.Dientich();
        Hinhtamgiac htg = new Hinhtamgiac();
        htg.Nhap(); htg.ChuVi(); htg.Dientich();
        Hinhvuong hv = new Hinhvuong();
        hv.Nhap(); hv.ChuVi(); hv.Dientich();
    }
}

