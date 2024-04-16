// nhập từ bàn phím một số nguyên từ 1->7, in lên màn hình tên của ngày trong tuần. Nhập sai thì báo lỗi.
int day;
Console.WriteLine("Nhap so nguyen (1-->7): ");
day = Convert.ToInt32(Console.ReadLine());
switch (day)
{
    case 1:
        Console.WriteLine("Sunday"); break;
    case 2:
        Console.WriteLine("Monday"); break;
    case 3:
        Console.WriteLine("Tuesday"); break;
    case 4:
        Console.WriteLine("Wednesday"); break;
    case 5:
        Console.WriteLine("Thursday"); break;
    case 6:
        Console.WriteLine("Friday"); break;
    case 7:
        Console.WriteLine("Saturday"); break;
    default:
        Console.WriteLine("Vui long nhap so tu 1-->7 !!!"); break;
}