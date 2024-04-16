using System;
class Khachhang
{
    public string Ten;
    public double Gia;
    public Khachhang()
    {

    }
    public virtual void Nhap()
    {
        Console.Write("Nhap ten khach hang: ");
        Ten = Console.ReadLine();
    }
    public virtual void Deothe()
    {

    }
}
class NguoiLon : Khachhang
{
    public string CMND;
    public static int demnl = 0;
    public override void Nhap()
    {
        Gia = 250000;
        base.Nhap();
        Console.Write("Nhap CMND: ");
        CMND = Console.ReadLine();
        Console.WriteLine("Gia ve la 250.000");
        demnl = demnl + 1;
    }
    public override void Deothe()
    {
        Console.WriteLine("Nguoi lon deo the do");
    }
}
class Treem : Khachhang
{
    public double Chieucao;
    public static int demte = 0;
    public override void Nhap()
    {

        base.Nhap();
        Console.Write("Nhap chieu cao: ");
        Chieucao = Convert.ToDouble(Console.ReadLine());

        if (Chieucao > 100)
        {
            Gia = 130000;
            Console.WriteLine("Gia ve la 130.000");
            demte = demte + 1;
        }
        else
        {
            Gia = 0;
            Console.WriteLine("Mien phi");
        }
    }
    public override void Deothe()
    {
        Console.WriteLine("Tre em deo the xanh");
    }
}
internal class Program
{
    static void Main()
    {

        NguoiLon nguoilon = new NguoiLon();
        Treem treem = new Treem();
        while (true)
        {
            Console.WriteLine("Hay nhap tuy chon sau: ");
            Console.WriteLine("1. Nhap thong tin nguoi lon");
            Console.WriteLine("2. Nhap thong tin tre em");
            Console.WriteLine("3. Tinh doanh thu");
            Console.WriteLine("0. Thoat khoi chuong trinh");
            int Menu = Convert.ToInt32(Console.ReadLine());
            switch (Menu)
            {
                case 1:
                    {
                        nguoilon.Nhap();
                        nguoilon.Deothe();
                        break;
                    }
                case 2:
                    {
                        treem.Nhap();
                        treem.Deothe();
                        break;
                    }
                case 3:
                    {
                        double Doanhthu = 250000 * NguoiLon.demnl + 130000 * Treem.demte;
                        Console.WriteLine($"Doanh thu la: {Doanhthu}");
                        break;
                    }
                case 0:
                    {
                        return;
                    }
            }
        }
    }
}