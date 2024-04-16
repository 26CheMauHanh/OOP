//Bài 4: BIẾN
using System;
class Program
{
    static void Main(string[]args)
    {
        //biến -> có thể thay đổi
        /*
        - Biến:
                + Là một giá trị dữ liệu có thể thay đổi được
                + Là tên gọi tham chiếu đến một vùng nhớ nào đó trong bộ nhớ
                + Là thành phần cốt lõi của một ngôn ngữ lập trình
        
        ==> Lưu trữ dữ liệu và tái sử dụng
            Thao tác vs bộ nhớ một cách dễ dàng
        */


        //Khai báo và sử dụng biến:
        /*
        + Cú pháp:
                    <Kiểu dữ liệu> <Tên biến>;
        */
                    int a;
                    int KieuSoNguyen;
        
        /* Gán giá trị:
                    <Kiểu dữ liệu> <Tên biến> = <giá trị>;
        */
                    int a = 5;
                    Console.WriteLine(a); //In giá trị của biến a ra màn hình => 5
        

        /* QUY TẮC ĐẶT TÊN BIẾN:
        + Tên biến là một chuỗi ký tự liên kết(ko có khoảng trắng) và ko chứ ký tự đặc biệt
        + Tên biến ko đc đặt bằng tiếng Việt có dấu
        + Tên ko đc bắt đầu bằng số
        + Tên biến ko đc trùng nhau
        + Tên biến ko đc trùng với từ khóa: int, as, bool, char,.....
        + Nên đặt tên ngắn gọn dễ hiểu, thể hiện rõ mục đích của biến
        + Có phân biệt chữ hoa chữ thường
        */
    }
}