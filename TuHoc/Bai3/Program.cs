//Bài 3: NHẬP XUẤT CƠ BẢN
using System;
class Program
{
    static void Main(string[] args) // hàm chạy đầu tiên khi chương trình được biên dịch
    {
        int a = 5;   // khai báo biến kiểu nguyên có tên là a và khởi tạo giá trị là 5
        Console.Write("a = " + a); //in ra màn hình a = 5
        Console.Write("a = {0}", a); //in ra màn hình a = 5

        Console.Write("Moi ban nhap ten cua minh: "); //in ko xuống dòng
        Console.WriteLine("Ten cua ban la: " + Console.ReadLine()); //đọc giá trị mà bạn nhập vào






        Console.Write("Hello");   // In ra màn hình dòng chữ Hello nhưng ko xuống dòng
        Console.WriteLine("Hello"); // Sử dụng lệnh in ra màn hình có xuống dòng
        Console.WriteLine("Hello\n"); // Sử dụng ký tự đặc biệt để xuống dòng
        Console.Write(10);      // In ra màn hình số 0
        Console.Write(10.9f);   // In ra màn hình số 10.9 (f biểu thị cho kiểu dữ liệu float)
        Console.Write(true);    // In ra màn hình chữ true của kiểu dữ liệu bool
    }
}