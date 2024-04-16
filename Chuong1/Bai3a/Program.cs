class Program
{
    private static void Nhap(out int a, out int b)
    {
        Console.Write("a=");
        a=Convert.ToInt32(Console.ReadLine());
        Console.Write("b=");
        b=Convert.ToInt32(Console.ReadLine());
    }

    private static void Tinh(int a, int b, int KQ)
    {
        KQ = ((a*a) + (b*b);
    }

    private static void InKQ(int a, int b, int KQ)
    {
        Console.WriteLine("Tong binh phuong= " + KQ)
    }

    static void Main(string[]args)
    {
        int a, b, KQ;

        Nhap(out a,b);
        KQ=Tinh(a,b);
        InKQ(KQ);
    }
}