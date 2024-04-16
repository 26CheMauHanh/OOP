// viết chương trình tính chu vi và diện tích HCN
using System;

class Hinhchunhat
{
    // Các thuộc tính (chiều dài và chiều rộng) của hình chữ nhật
    public double dai;
    public double rong;

    // xây dựng để khởi tạo hình chữ nhật với chiều dài và chiều rộng
    public Hinhchunhat(double dai, double rong)
    {
        this.dai = dai;
        this.rong = rong;
    }

    // Phương thức tính chu vi hình chữ nhật
    public double Chuvi()
    {
        return 2 * (dai + rong);
    }

    // Phương thức tính diện tích hình chữ nhật
    public double Dientich()
    {
        return dai * rong;
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Nhap chieu dai HCN: ");
        double dai = Convert.ToDouble(Console.ReadLine());

        Console.Write("Nhap chieu rong HCN: ");
        double rong = Convert.ToDouble(Console.ReadLine());

        // Tạo một đối tượng hình chữ nhật: Tênlớp Tênbiếnđốitượng = new Tênlớp(danhsáchđốisố);
        Hinhchunhat HCN = new Hinhchunhat(dai, rong);

        // Tính và hiển thị chu vi và diện tích
        double chuvi = HCN.Chuvi();
        double dientich =HCN.Dientich();

        Console.WriteLine("Chu vi hinh chu nhat la:" + chuvi);
        Console.WriteLine("Dien tich hinh chu nhat la:" + dientich);
    }
}
