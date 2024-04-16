/* Bài 4: Xây dựng một ứng dụng quản lý điểm học phần OOP
của sinh viên có chứa nội dung như sau:
+ Lớp thông tin sinh viên (Info) bao gồm: ID, Hoten, Group
lần lượt là Mã Sinh viên, Họ Tên sinh viên, Lớp sinh hoạt
+ Lớp điểm thành phần (DiemTP) bao gồm TP1, TP2, TP3
Các phương thức yêu cầu trong bài:
• Nhập mã sinh viên, Họ và tên sinh viên và Lớp SH
• Xuất số lượng sinh viên có trong lớp học phần OOP
• Nhập điểm TP1, TP2, TP3 cho mỗi sinh viên
• Tính điểm TB = TP1*0.1+TP2*0.3+TP3*0.6
• Xuất ra thông tin của sinh viên và điểm trung bình môn
OOP
*/
using System;
class Info
{
    public int ID;
    public string Hoten;
    public string Group;
    static int dem = 0;
    public DiemTP Diem;
    public Info()
    {
        Console.Write("Nhap MSV: ");
        ID = int.Parse(Console.ReadLine());
        Console.Write("Nhap Ho va Ten: ");
        Hoten = Console.ReadLine();
        Console.Write("Nhap lop sinh hoat: ");
        Group = Console.ReadLine();
        Diem = new DiemTP();
        dem++;
    }
    public class DiemTP
    {
        public int TP1;
        public int TP2;
        public int TP3;
        public DiemTP()
        {
            Console.Write("Nhap diem TP1: ");
            TP1 = int.Parse(Console.ReadLine());
            Console.Write("Nhap diem TP2: ");
            TP2 = int.Parse(Console.ReadLine());
            Console.Write("Nhap diem TP3: ");
            TP3 = int.Parse(Console.ReadLine());
        }
        public double Tinhdiemtb()
        {
            double DTB;
            DTB = TP1 * 0.1 + TP2 * 0.3 + TP3 * 0.6;
            return (DTB);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Info SV = new Info();
           
            Console.WriteLine($"Tong so sinh vien da nhap la: {dem}");
            Console.WriteLine($"Thong tin sinh vien:\n MSV:{SV.ID}\n Hoten: {SV.Hoten}\n Lop: {SV.Group}");
            Console.WriteLine($"Diem trung binh cua sinh vien {SV.ID} la {SV.Diem.Tinhdiemtb()}");

            Info SV1 = new Info();
            Console.WriteLine($"Tong so sinh vien da nhap la: {dem}");
            Console.WriteLine($"Thong tin sinh vien:\n MSV:{SV1.ID}\n Hoten: {SV1.Hoten}\n Lop: {SV1.Group}");
            Console.WriteLine($"Diem trung binh cua sinh vien {SV1.ID} la {SV1.Diem.Tinhdiemtb()}");
            
            Info SV2 = new Info();
            Console.WriteLine($"Tong so sinh vien da nhap la: {dem}");
            Console.WriteLine($"Thong tin sinh vien:\n MSV:{SV2.ID}\n Hoten: {SV2.Hoten}\n Lop: {SV2.Group}");
            Console.WriteLine($"Diem trung binh cua sinh vien {SV2.ID} la {SV2.Diem.Tinhdiemtb()}");
        }
    }
}        