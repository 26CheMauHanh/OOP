// Viết chương trình mô tả số đo của học sinh
using System;
class Hocsinh
{
    public double Weight;
    public double Height;
    public void Info()
    {
        Console.WriteLine(" Hoc sinh co can nang la: " + Height + " va chieu cao la: " + Weight);
    }
    public Hocsinh() //Constructor không có tham số
    {
        Weight = 40;
        Height = 150;
    }
    public Hocsinh(int w, int h) //Constructor có tham số
    {
        Weight = w;
        Height = h;
    }
}
class SodoHocsinh
{
    static void Main()
    {
        Hocsinh hs1 = new Hocsinh();
        hs1.Info();
        Hocsinh hs2 = new Hocsinh(48, 160);
        hs2.Info();
    }
}

