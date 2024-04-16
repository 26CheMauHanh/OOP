using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class SUCKHOE
{
    private string MaBN;
    private string TenBN;
    private string GioiTinh;
    private string Benh;
    private string Mucdo;

    public SUCKHOE(string maBN, string tenBN, string gioiTinh, string benh, string mucdo)
    {
        MaBN = maBN;
        TenBN = tenBN;
        GioiTinh = gioiTinh;
        Benh = benh;
        Mucdo = mucdo;
    }

    public override string ToString()
    {
        return $"{MaBN}; {TenBN}; {GioiTinh}; {Benh}; {Mucdo}";
    }
}

class QuanlySuckhoe
{
    private List<SUCKHOE> danhSachSuckhoe;

    public QuanlySuckhoe()
    {
        danhSachSuckhoe = new List<SUCKHOE>();
    }

    public void ThemBenhNhan(SUCKHOE benhNhan)
    {
        danhSachSuckhoe.Add(benhNhan);
    }

    public void HienThiDanhSach()
    {
        foreach (var benhNhan in danhSachSuckhoe)
        {
            Console.WriteLine(benhNhan);
        }
    }

    public void CachLyBenhNhan()
    {
        var danhSachCanCachLy = danhSachSuckhoe.Where(SUCKHOE => SUCKHOE.Benh == "Lao" || SUCKHOE.Benh == "Covid").ToList();

        Console.WriteLine("Danh sach benh nhan can cach ly:");
        foreach (var benhNhan in danhSachCanCachLy)
        {
            Console.WriteLine(benhNhan);
        }
    }

    public void SapXepTheoMucDo()
    {
        var danhSachSapXep = danhSachSuckhoe.OrderBy(bn => bn.Mucdo).ToList();

        Console.WriteLine("Danh sach benh nhan sau khi sap xep theo muc do benh:");
        foreach (var benhNhan in danhSachSapXep)
        {
            Console.WriteLine(benhNhan);
        }
    }
}

class Program
{
    static void Main()
    {
        QuanlySuckhoe quanly = new QuanlySuckhoe();

        // Đọc danh sách bệnh nhân từ file .txt
        string[] lines = File.ReadAllLines("DanhSachBenhNhan.txt");
        foreach (var line in lines)
        {
            string[] tokens = line.Split(';');
            SUCKHOE benhNhan = new SUCKHOE(tokens[0], tokens[1], tokens[2], tokens[3], tokens[4]);
            quanly.ThemBenhNhan(benhNhan);
        }

        int choice;
        do
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Them benh nhan");
            Console.WriteLine("2. Cach ly benh nhan");
            Console.WriteLine("3. Sap xep theo muc do");
            Console.WriteLine("0. Exit");
            Console.Write("Nhap lua chon cua ban: ");
            if (int.TryParse(Console.ReadLine(), out choice))
            {
                switch (choice)
                {
                    case 1:
                        // Code để thêm bệnh nhân
                        break;
                    case 2:
                        quanly.CachLyBenhNhan();
                        break;
                    case 3:
                        quanly.SapXepTheoMucDo();
                        break;
                    case 0:
                        Console.WriteLine("Tam biet!");
                        break;
                    default:
                        Console.WriteLine("Lua chon khong hop le. Vui long chon lai.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Nhap khong hop le. Vui long nhap lai.");
            }

        } while (choice != 0);
    }
}
