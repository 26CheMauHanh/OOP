/* Viết chương trình quảng lý học phí của sinh viên
Yêu cầu:
Class sinhvien(MaSV,SoTC,Giamtru(%),hocphi)
Biết rằng, học phí=SoTC*450000-giamtru(%)*(SoTC*450000)
Sử dụng phương thức truy cập, truy vấn, hoặc get,set,..
Xuất ra màn hinh:
Sinh vien có mã số.., học....Tín chỉ, Giảm trừ...phảo đóng học phí là....*/

using System;

class SinhVien
{
    private string maSV;
    private int soTC;
    private double giamTru;

    public string MaSV
    {
        get { return maSV; }
        set { maSV = value; }
    }

    public int SoTC
    {
        get { return soTC; }
        set { soTC = value; }
    }

    public double GiamTru
    {
        get { return giamTru; }
        set { giamTru = value; }
    }

    public double HocPhi
    {
        get { return soTC * 450000 - (giamTru / 100) * (soTC * 450000); }
    }

    public void Xuat()
    {
        Console.WriteLine("Sinh vien co ma so {0}, hoc {1} tin chi, giam tru {2}%, phai dong hoc phi la {3}", maSV, soTC, giamTru, HocPhi);
    }
}

class QuanlyHocphi
{
    static void Main(string[] args)
    {
        SinhVien sv = new SinhVien();
        sv.MaSV = "SV2111215";
        sv.SoTC = 8;
        sv.GiamTru = 30;

        sv.Xuat();
    }
}

