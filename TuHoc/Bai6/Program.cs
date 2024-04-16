//Bài 6: TOÁN TỬ
using System;
class Program
{
    static void Main(string[]args)
    {
        /* Toán tử toán học:
            %   -> thực hiện chia lấy dư
            ++  -> tăng giá trị lên 1 đơn vị
            --  -> giảm giá trị xuống 1 đơn vị
        */
        /* Lưu ý:
              a++  : là sử dụng giá trị của biến a để thực hiện biểu thức trước rồi mới thực hiện tăng lên 1 đơn vị. tương tự a--
              ++a  : là tăng giá trọ biến a lên 1 đơn vị rồi mới sử dụng biến a để thực hiện biểu thức. tương tự --a
        */
                int i = 5, j = 5;
                Console.WriteLine(i++); //in ra màn hình -> 5
                Console.WriteLine(++j); //in ra màn hình -> 6
        
        /* Toán tử quan hệ:
                == : bằng
                != : khác
            Chỉ áp dụng cho số hoặc ký tự
            Ko nên sử dụng để so sánh các chuổi với nhau
        */

        /* Toán tử logic:
                &&  : và
                ||  : hoặc
                !   : not (phủ định)
        */


        /* Toán tử khởi tạo và gán:
            =     -> K = 10 : sẽ gán 10 cho biến K
            +=    -> lấy toán hạng bên trái cộng toán hạng bên phải : K += 1 -> K = K + 1
            -=    -> lấy toán hạng bên trái trừ toán hạng bên phải  : K -+ 1 -> K = K - 1
            tương tự phép nhân, phép chia.
        */

        /* Toán tử khác:
            new : cấp phát vùng nhớ mới, áp dụng cho kiểu dữ liệu tham chiếu
            is  : xác định đối tượng có phải là một kiểu cụ thể nào đó hay ko
            as  : ép kiểu mà ko gây ra lỗi. nếu éo kiểu ko thành công sẽ trả về null
            ?:  : được gọi là toán tử 3 ngôi. Tương đương với cấu trúc điều kiện 
                  Cú pháp: (toán hạng 1) ? (toán hạng 2) : (toán hạng 3)
                  Ý nghĩa: trả về toán hạng 2 nếu toán hạng 1 là true và ngược lại trả về toán hạng 3
        */
    }
}
