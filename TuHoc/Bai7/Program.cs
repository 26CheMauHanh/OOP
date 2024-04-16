// Bài 7: HẰNG
using System;
class Program
{
    static void Main(string[] args)
    {
        const int x = 10; // x: là biểu tượng hằng
                          // 10: là giá trị hằng
        Console.WriteLine(x); //vẫn in ra màn hình giá trị 10

        x = 15; //sẽ báo lỗi vì hằng chỉ 1 lần gán giá trị khi lúc khai báo


        /*
        int a = 15;
        const int x = a;
        Console.WriteLine(x);
        => đoạn code trên sẽ báo lỗi vì hằng vs biến ko thể gán vs nhau đc, chỉ gán khi hằng với hằng
        */
    }
}

        /* Hằng là gì?
            - Hằng là một biến những giá trị ko thay đổi trong suốt chương trinh
            - Bắt buộc phải khỏi tạo giá trị khi khai báo 
            - Để ngăn chặn việc gắn giá trị khác vào
            - Hằng làm cho chương trình dễ đọc hơn bằng các biến những con số vô cảm thành những tên có ý nghĩa
            - Hằng giúp cho chương trình dễ năng cấp, dễ sửa chữa hơn
            - Hằng giúp cho việc tránh lỗi dễ dàng hơn
        */
