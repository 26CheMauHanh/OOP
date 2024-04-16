/*Viết chương trình xây dựng một lớp Time,
trong đó có một phương thức tạo lập nhận tham số có
kiểu DataTime (kiểu xây dựng sẵn các trình biên dịch)
làm tham số khởi tạo gán cho các thành phần dữ liệu
của đối tượng thuộc tính lớp Time*/

public class Time
{// khởi tạo các thuộc tính có phạm vi là private
    private int Nam;
    private int Thang;
    private int Ngay;
    int Gio;
    int Phut;
    int Giay;

    // khởi tạo phương thức

    public void Hienthithoigianthuc()
    {
        Console.Write("Thoi gian thuc: {0}-{1}-{2} {3}:{4}:{5}", Ngay, Thang, Nam, Gio, Phut, Giay);
    }
    // Viết hàm khởi tạo để truyền giá trị
    public Time(System.DateTime ngaygio) //phạm vi truy cập +tên lớp
    {
        Nam=ngaygio.Year;
        Thang=ngaygio.Month;
        Ngay=ngaygio.Day;
        Gio=ngaygio.Hour;
        Phut=ngaygio.Minute;
        Giay=ngaygio.Second;
    }
}
class Program
{
    static void Main()
    {
        System.DateTime ThoigianThuc=System.DateTime.Now;
        //khở tạo đối tượng
        Time thoigian=new Time(ThoigianThuc);
        thoigian.Hienthithoigianthuc();
    }
}