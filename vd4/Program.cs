// Nhập điểm thi từ 0->10, in lên màn hình xếp loại kết quả học tập. Nhập sai thì bỏ qua.
int diem;
Console.WriteLine("Nhap diem thi (0-->10): ");
diem = Convert.ToInt32(Console.ReadLine());
switch (diem)
{
    case 0:
    case 1:
    case 2:
    case 3: Console.WriteLine("Kem\n"); break;
    case 4: Console.WriteLine("Yeu\n"); break;
    case 5: 
    case 6: Console.WriteLine("Trung binh\n"); break;
    case 7: 
    case 8: Console.WriteLine("Kha\n"); break;
    case 9: 
    case 10:Console.WriteLine("Gioi\n"); break;
}