using System;

class HinhTron
{
    public double Pi = 3.14;
    public double BanKinh;
    public double DuongKinh;
    public double DienTich;
    public HinhTron()
    {
        BanKinh = 5;
        DuongKinh = 10;
    }
    public void Tinhdientich()
    {
        DienTich = BanKinh * BanKinh * Pi;
        Console.WriteLine($"Dien tich hinh tron la: {DienTich}");
    }
    //a) Xây dựng lớp hình cầu
    class HinhCau : HinhTron
    {
        public double TheTich;
        public HinhCau()
        {
        }
        public new void Tinhdientich()
        {
            DienTich = BanKinh * BanKinh * Pi * 4;
            Console.WriteLine($"Dien tich hinh cau la {DienTich}");
        }
        public void Tinhthetich()
        {
            TheTich = 4 / 3 * BanKinh * BanKinh * BanKinh;
            Console.WriteLine($"The tich hinh cau la: {TheTich}");
        }
    }
    //b) Xây dựng lớp hình trụ tròn
    class HinhTruTron : HinhTron
    {
        public double ChuviD;
        public double SDay;
        public double Sxq;
        public double Stp;
        public double V;
        public double h;
        public void Tinh()
        {
            Console.Write("Nhap chieu cao: ");
            h = double.Parse(Console.ReadLine());
            ChuviD = 2 * Pi * BanKinh * h;
            SDay = Pi * BanKinh * BanKinh;
            Sxq = 2 * Pi * BanKinh * h;
            Stp = Sxq + (SDay * 2);
            V = Pi * BanKinh * BanKinh * h;
            Console.WriteLine($"Chu vi mat day: {ChuviD}\n Dien tich mat day: {SDay}\n Dien tich xung quanh: {Sxq}\n Dien tich toan phan: {Stp}\n The tich: {V}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            HinhTron ht = new HinhTron();

            ht.Tinhdientich();
            HinhCau hc = new HinhCau();

            hc.Tinhdientich();
            hc.Tinhthetich();
            HinhTruTron htt = new HinhTruTron();

            htt.Tinh();
        }
    }
}
