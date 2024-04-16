using System;
class Info
{
    public string ID { get; set; }
    public string Hoten { get; set; }
    public string Group { get; set; }
}

class DiemTP
{
    public double TP1 { get; set; }
    public double TP2 { get; set; }
    public double TP3 { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        List<Info> danhSachSinhVien = new List<Info>();
        List<DiemTP> danhSachDiem = new List<DiemTP>();

        Console.WriteLine("Quan ly điem hoc phan OOP");
        

        Console.Write("Nhap so luong sinh vien: ");
        int soLuong = int.Parse(Console.ReadLine());

        for (int i = 0; i < soLuong; i++)
        {
            Console.WriteLine($"Nhap thong tin sinh vien thu {i + 1}:");

            Info sinhVien = new Info();

            Console.Write("Ma sinh vien: ");
            sinhVien.ID = Console.ReadLine();

            Console.Write("Ho va ten: ");
            sinhVien.Hoten = Console.ReadLine();

            Console.Write("Lop sinh hoat: ");
            sinhVien.Group = Console.ReadLine();

            danhSachSinhVien.Add(sinhVien);

            DiemTP diem = new DiemTP();

            Console.Write("Diem TP1: ");
            diem.TP1 = double.Parse(Console.ReadLine());

            Console.Write("Diem TP2: ");
            diem.TP2 = double.Parse(Console.ReadLine());

            Console.Write("Diem TP3: ");
            diem.TP3 = double.Parse(Console.ReadLine());

            danhSachDiem.Add(diem);
        }

        Console.WriteLine("Thong tin sinh vien và diem trung binh mon:");

        for (int i = 0; i < soLuong; i++)
        {
            double diemTB = danhSachDiem[i].TP1 * 0.1 + danhSachDiem[i].TP2 * 0.3 + danhSachDiem[i].TP3 * 0.6;

            Console.WriteLine($"Sinh vien {danhSachSinhVien[i].Hoten}");
            Console.WriteLine($"Ma sinh vien: {danhSachSinhVien[i].ID}");
            Console.WriteLine($"Lop sinh hoat: {danhSachSinhVien[i].Group}");
            Console.WriteLine($"Diem trung binh mon: {diemTB}");
        }
    }
}