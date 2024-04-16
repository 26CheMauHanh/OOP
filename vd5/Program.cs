//Nhập từ bàn phím một số nguyên n và n số nguyên;Việc nhập sẽ dừng lại cho đến khi đủ n số nguyên hoặc số 0 được nhập vào. In lên màn hình tổng của các số nguyên dương đã được nhập
int i,n,x,S=0;
Console.Write("Nhap n= ");
n=int.Parse(Console.ReadLine());
for (i=1; i<=n; i++)
{
    Console.Write("So thu " + i + ":");
    x=int.Parse(Console.ReadLine());
    if (x<0) continue;
    if (x==0)
       break;
    else S += x;
}
Console.Write("S=" + S);