using System;
using System.Text;

class ThanhToan
{
    private string MaBN;
    private string TenBN;
    private string Benh;
    private string BHYT;
    private int SoNgay;
}
class QuanlyBaoHiem
{
    public List<ThanhToan> DS = new List<ThanhToan>();
    public QuanlyBaoHiem()
    {
        Console.OutputEncoding = Encoding.UTF8;
        var input = File.ReadAllText("BHYT.txt");
        string[] res;
        foreach (var row in input.Split('\n'))
        {
            res = row.Split(';');
            DS.Add(new ThanhToan()
            {
                MaBN = res[0].Trim(),
                TenBN = res[1].Trim(),
                Benh = res[2].Trim(),
                BHYT = res[3].Trim(),
                SoNgay = int.Parse(res[4].Trim())
            });
        }
    }
    public void CapNhat()
    {
        Console.Write("Nhap ma BN can cap nhat: ");
        string maBN = Console.ReadLine();
        if (maBN == "")
        {
            Console.WriteLine("Benh nhan khong ton tai");
        }
        foreach (ThanhToan tt in DS)
        {
            if (tt.MaBN == maBN)
            {
                Console.Write("Ten Bn: ");
                tt.TenBN = Console.ReadLine();
                Console.Write("Benh: ");
                tt.Benh = Console.ReadLine();
                Console.Write("BHYT: ");
                tt.BHYT = Console.ReadLine();
                Console.Write("SoNgay: ");
                tt.SoNgay = int.Parse(Console.ReadLine());
            }
        }
    }
    public void ThongKe()
    {

    }
    public void Xoa()
    {
        Console.Write("Nhap BHYT can xoa:");
        string bhyt = Console.ReadLine();
        if (bhyt == "")
        {
            Console.WriteLine("Benh nhan khong ton tai");
        }
        foreach (ThanhToan tt in DS)
        {

        
        }
    }
}
class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.Unicode;
        Console.InputEncoding = Encoding.Unicode;
        QuanlyBaoHiem DS = new QuanlyBaoHiem();
        int input;
        while (true)
        {
            foreach (ThanhToan tt in DS)
            {
                Console.WriteLine("==========MENU==========");
                Console.WriteLine("Bam 1: Cap nhat");
                Console.WriteLine("Bam 2: Thong ke");
                Console.WriteLine("Bam 3: Xoa");
                Console.WriteLine("Bam 0: Exit");
                Console.WriteLine("========================");
                Console.Write("Bam: ");
                input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1: DS.CapNhat(); break;
                    case 2: DS.ThongKe(); break;
                    case 3: DS.Xoa(); break;
                    case 0: return;
                    default: Console.WriteLine("lua chon khong hop le!"); break;
                }

            }
        }
    }
}
