//Bài 5: KIỂU DỮ LIỆU
using System;
class Program
{
    static void Main(string[]args)
    {
        /* KIỂU DỮ LIỆU:
            + Là tập hợp các nhóm dữ liệu có cùng đặc tính,
              cách lưu trữ và thao tác xử lý trên trường dữ liệu đó
            + Là một tính hiệu để trình biên dịch nhận biết kích thước của một biến
              và khả năng của nó
            + Là thành phần cốt lõi của một ngôn ngữ lập trình
        */
        //Kiểu số nguyên
        byte BienByte = 10;
        short BienShort = 10;
        int BienInt = 10;
        long BienLong = 10;

        // Kiểu số thực
        float c = 10.9f;   // giá trị của kiểu float  phải có chữ f or F làm hậu tố
        decimal d = 10.9m;  // giá trị của kiểu decimal phải có chữ m làm hậu tố
        double e = 10.9;    // giá trị của kiểu double ko cần hậu tố

        // Kiểu ký tự và chuỗi
        char a = 'H';  // giá trị của kiểu char nằm trong dấu ''
        string b = "Hello";  // giá trị của kiểu string nằm trong dấu ""
        
    }
}
