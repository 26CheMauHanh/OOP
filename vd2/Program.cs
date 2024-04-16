/*Bài 3: Xây dựng lớp Organization gồm:
+ Thuộc tính: Name, Country, City, Address, Telephone là Tên
Doanh nghiệp, Quốc gia, Thành phố, Địa chỉ, Số điện thoại
+ Phương thức:
• Hàm Khởi tạo, Hàm hủy
• Hàm Nhập, Xuất – Để nhập và xuất thông tin
Nhập và xác nhận các thông tin đầu vào trong đó yêu cầu:
• Thông tin đầu vào các thuộc tính không được để trống
• Thông tin về Số điện thoại phải đảm bảo đủ 10 chữ số và không được để trống
Xuất ra màn hình thông tin của Doanh nghiệp nếu tất các thông tin nhập vào là hợp lệ.
Trường hợp thông tin không hợp lệ thì thông báo “Nhập thông tin lỗi” và Dừng chương trình.*/

using System;
class Organization
{
    public string Name;
    public string Country;
    public string City;
    public string Address;
    public string Telephone;
    public void Nhap()
    {
        Console.Write("Nhap ten doanh nghiep: ");
        Name = Console.ReadLine();
        Console.Write("Nhap quoc gia: ");
        Country = Console.ReadLine();
        Console.Write("Nhap thanh pho: ");
        City = Console.ReadLine();
        Console.Write("Nhap dia chi: ");
        Address = Console.ReadLine();
        Console.Write("So dien thoai: ");
        Telephone = Console.ReadLine();
    }
    public void Xuat()
    {
        Console.WriteLine("Doanh nghiep: {0}, Quoc gia: {1}, Thanh pho: {2}, Dia chi: {3}, So dien thoai: {4}", Name, Country, City, Address, Telephone);
    }
    ~Organization()
    {
        Console.WriteLine("Huy");
    }
    class Program
    {
        static void Main(string[] args)
        {
            Organization O = new Organization();
            O.Nhap();
            
            if (string.IsNullOrWhiteSpace(O.Name)||
                string.IsNullOrWhiteSpace(O.Country)||
                string.IsNullOrWhiteSpace(O.City)||
                string.IsNullOrWhiteSpace(O.Address)||
                string.IsNullOrWhiteSpace(O.Telephone)||
                O.Telephone.Length != 10 && !Char.IsDigit(Telephone))
            {
                Console.WriteLine("Nhap thong tin loi.");
            }
            else
            {
                O.Xuat();
            }
        }
    }

}

