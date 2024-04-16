using System;
class Phong
{
    public string Ten { get; set; }
    public string CMND { get; set; }
    public int SoNgayThue { get; set; }
    public static double Tong;
    public Phong(string Ten, string CMND, int SoNgayThue)
    {
        this.Ten = Ten;
        this.CMND = CMND;
        this.SoNgayThue = SoNgayThue;
    }
    public virtual double TongTien()
    {
        return 0;
    }
    public virtual void Nhap()
    {
        Console.WriteLine($"Ten: {Ten}, CMND: {CMND}, So ngay thue: {SoNgayThue}");
    }
}
class Standard : Phong
{
    public Standard(string Ten, string CMND, int SoNgayThue) : base(Ten, CMND, SoNgayThue)
    {
    }
    public override double TongTien()
    {
        if (SoNgayThue < 5)
        {
            return SoNgayThue * 500;
        }
        else
        {
            return SoNgayThue * 400;
        }
    }
    public override void Nhap()
    {
        base.Nhap();
        Console.WriteLine($"Tong tien: {TongTien()}");
    }
}
class Vip : Phong
{
    public string LoaiPhong { get; set; }
    public Vip(string Ten, string CMND, int SoNgayThue, string LoaiPhong) : base(Ten, CMND, SoNgayThue)
    {
        this.LoaiPhong = LoaiPhong;
    }
    public override double TongTien()
    {
        if (SoNgayThue <= 5 && LoaiPhong == "Luxury")
        {
            return SoNgayThue * 1100;
        }
        else if (SoNgayThue <= 5 && LoaiPhong == "President")
        {
            return SoNgayThue * 1300;
        }
        else
        {
            return SoNgayThue * 1000;
        }
    }
    public override void Nhap()
    {
        base.Nhap();
        Console.WriteLine($"Loai phong: {LoaiPhong}, Tong tien: {TongTien()}");
    }
}
class Ba4
{
    static void Main()
    {
        Phong[] p = new Phong[100];
        p[1] = new Standard("Vuong Hong Minh", "22112142", 7);
        p[2] = new Vip("Le Thi Hong Van", "222112152", 5, "Luxury");
        p[3] = new Standard("Vuong Huu Thang", "2121234", 6);
        Console.WriteLine("Cac thong tin trong danh sach");

        for (int i = 0; i < p.Length; i++)
        {
            if (p[i] != null)
            {
                p[i].Nhap();
            }
        }
        double tongphongStandard = 0;
        double tongphongVip = 0;
        Console.WriteLine("Tong tien tung loai phong");
        foreach (Phong i in p)
        {
            if (i != null)
            {
                if (i is Standard)
                {
                    tongphongStandard += i.TongTien();
                }
                else
                {
                    tongphongVip += i.TongTien();
                }
            }
        }
        Console.WriteLine($"Tong tien Standard: {tongphongStandard}");
        Console.WriteLine($"Tong tien Vip: {tongphongVip}");
        double Tong = 0;
        Tong += tongphongStandard + tongphongVip;
        Console.WriteLine($"Tong chung: {Tong}");
        Console.WriteLine();
        Console.WriteLine("Cac thong tin cua phong Standard");
        foreach (Phong i in p)
        {
            if (i != null && i is Standard)
            {
                i.Nhap();
            }
        }
    }
}