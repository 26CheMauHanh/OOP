using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

class Batdongsan
{
    public string MaBDS { get; set; }
    public string Diachi { get; set; }
    public int Dientich { get; set; }
    public double Giaban { get; set; }
    public string TenBDS { get; set; }
    public string Huong { get; set; }
}
class DanhsachBDS
{
    public List<Batdongsan> DS = new List<Batdongsan>();
    public DanhsachBDS() //tạo hàm khởi tạo
    {
        Console.OutputEncoding = Encoding.UTF8; //thiết lập mã hóa đầu ra là UTF8 ->in ra các ký tự Unicode
        var input = File.ReadAllText("bds.txt"); //đọc toàn bộ nd file text và lưu vào biến input
        string[] res;   //Khai báo một mảng res các chuỗi
        foreach (var row in input.Split('\n')) //Duyệt qua từng dòng trong chuỗi input bằng cách tách dòng (Split();--> tách chuỗi)
        {
            res = row.Split(';'); //Tách các giá trị trong mỗi dòng thành các phần tử của mảng res bằng cách tách chúng với dấu chấm phẩy (;).
            DS.Add(new Batdongsan() //Tạo một đối tượng Batdongsan mới và thêm vào danh sách DS. Các thuộc tính của đối tượng được khởi tạo từ các giá trị trong mảng res
            {
                MaBDS = res[0].Trim(), //Gán giá trị của phần tử đầu tiên trong mảng res vào thuộc tính MaBDS của đối tượng Batdongsan mới. .Trim() được sử dụng để loại bỏ khoảng trắng thừa ở đầu và cuối chuỗi
                TenBDS = res[1].Trim(), //Gán giá trị của phần tử thứ 2 trong mảng res vào thuộc tính TenBDS của đối tượng Batdongsan mới. .Trim() được sử dụng để loại bỏ khoảng trắng thừa ở đầu và cuối chuỗi
                Huong = res[2].Trim(),
                Diachi = res[3].Trim(),
                Dientich = int.Parse(res[4].Trim()),
                Giaban = double.Parse(res[5].Trim())
            });
        }
    }
    public void Them()
    {
        Batdongsan BDS = new Batdongsan();
        Console.Write("Ma BDS: ");
        BDS.MaBDS = Console.ReadLine();
        Console.Write("Ten BDS: ");
        BDS.TenBDS = Console.ReadLine();
        Console.Write("Huong BDS: ");
        BDS.Huong = Console.ReadLine();
        Console.Write("Dia chi: ");
        BDS.Diachi = Console.ReadLine();
        Console.Write("Dien tich: ");
        BDS.Dientich = int.Parse(Console.ReadLine());
        Console.Write("Gia ban: ");
        BDS.Giaban = double.Parse(Console.ReadLine());
        DS.Add(BDS);
    }
    public void Sua()
    {
        Console.Write("Nhap ma BDS can sua: ");
        string maBDS = Console.ReadLine();
        if (maBDS == "")
        {
            Console.WriteLine("BDS khong ton tai");
        }
        foreach (Batdongsan bds in DS)
        {
            if (bds.MaBDS == maBDS)
            {
                Console.Write("Nhap ten BDS moi: ");
                bds.TenBDS = Console.ReadLine();
                Console.Write("Nhap huong moi: ");
                bds.Huong = Console.ReadLine();
                Console.Write("Nhap dia chi moi: ");
                bds.Diachi = Console.ReadLine();
                Console.Write("Nhap dien tich moi: ");
                bds.Dientich = int.Parse(Console.ReadLine());
                Console.Write("Nhap gia ban moi: ");
                bds.Giaban = double.Parse(Console.ReadLine());
            }
        }
    }
    public void Xoa()
    {
        Console.Write("Nhap ma bds can xoa: ");
        string maBDS = Console.ReadLine();
        if (maBDS == "")
        {
            Console.WriteLine("BDS khong ton tai");
        }
        for (int i = 0; i < DS.Count; i++)
        {
            if (DS[i].MaBDS == maBDS)
            {
                DS.RemoveAt(i); //Nếu mã BDS của phần tử thứ i trong danh sách DS trùng khớp với mã BDS được nhập, dòng code này sẽ xóa phần tử đó khỏi danh sách DS 
                Console.WriteLine("Da xoa BDS");
            }
        }

    }
    public void Xuat()
    {
        foreach (Batdongsan bds in DS)
            Console.WriteLine("Ma BDS: {0}, Ten: {1}, Huong: {2}, Dia chi: {3}, Dien tich: {4}, Gia ban: {5}", bds.MaBDS, bds.TenBDS, bds.Huong, bds.Diachi, bds.Dientich, bds.Giaban);
    }
    public void TimTT()
    {
        Console.Write("Nhap ten BDS can tim thong tin : ");
        string Ten = Console.ReadLine();
        foreach (Batdongsan bds in DS)
        {
            if (bds.TenBDS == Ten)
            {
                Console.WriteLine("Ma BDS: {0}, Huong: {1}, Dia chi: {2}, Dien tich: {3}, Gia ban: {4}", bds.MaBDS, bds.Huong, bds.Diachi, bds.Dientich, bds.Giaban);
            }
        }
    }
    public void TimTH()
    {
        Console.Write("Nhap huong BDS can tim: ");
        string Huong = Console.ReadLine();
        foreach (Batdongsan bds in DS)
        {
            if (bds.Huong == Huong)
            {
                Console.WriteLine("Ten BDS: {0}; Dia chi: {1}", bds.TenBDS, bds.Diachi);
            }
        }
    }
    public void TimTK()
    {
        Console.Write("Nhap a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Nhap b: ");
        double b = double.Parse(Console.ReadLine());
        List<Batdongsan> Ketqua = new List<Batdongsan>();
        foreach (Batdongsan bds in DS)
        {
            if (bds.Giaban >= a & bds.Giaban <= b)
            {
                Ketqua.Add(bds);
            }
        }
        if (Ketqua.Count > 0)
        {
            for (int i = 0; i < Ketqua.Count - 1; i++)
            {
                for (int j = 0; j < Ketqua.Count - i - 1; j++)
                {
                    if (Ketqua[j].Giaban > Ketqua[j + 1].Giaban)
                    {
                        Batdongsan temp = Ketqua[j];
                        Ketqua[j] = Ketqua[j + 1];
                        Ketqua[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine("Thong tin bat dong san theo khoang gia tu {0} den {1}:", a, b);
            foreach (Batdongsan bds in Ketqua)
            {
                Console.WriteLine("Ma BDS: {0}, Ten: {1}, Huong: {2}, Dia chi: {3}, Dien tich: {4}, Gia ban: {5}", bds.MaBDS, bds.TenBDS, bds.Huong, bds.Diachi, bds.Dientich, bds.Giaban);
            }
        }
        else
        {
            Console.WriteLine("Khong tim thay bat dong san trong khoang gia tu {0} den {1}", a, b);
        }
    }
}
class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.Unicode;
        Console.InputEncoding = Encoding.Unicode;
        DanhsachBDS DS = new DanhsachBDS();
        int input;
        while (true)
        {
            Console.WriteLine("======= MENU =======");
            Console.WriteLine("Bam 1: Them moi danh sach");
            Console.WriteLine("Bam 2: Sua thong tin");
            Console.WriteLine("Bam 3: Xoa thong tin");
            Console.WriteLine("Bam 4: Xuat danh sach");
            Console.WriteLine("Bam 5: Tim theo Ten");
            Console.WriteLine("Bam 6: Tim theo Huong");
            Console.WriteLine("Bam 7: Tim theo Gia");
            Console.WriteLine("Bam 0: Exit");
            Console.WriteLine("====================");
            Console.Write("Bam: ");
            input = int.Parse(Console.ReadLine());
            switch (input)
            {
                case 1: DS.Them(); break;
                case 2: DS.Sua(); break;
                case 3: DS.Xoa(); break;
                case 4: DS.Xuat(); break;
                case 5: DS.TimTT(); break;
                case 6: DS.TimTH(); break;
                case 7: DS.TimTK(); break;
                case 0: return;
                default: Console.WriteLine("Lua chon khong hop le!"); break;
            }
        }
    }
}
