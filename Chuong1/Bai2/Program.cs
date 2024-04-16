using System;

namespace Bai2
{
    class Program
    {
        static void Nhap(ref double a, ref double b, ref char tt)
        {
            Console.Write("a=");
            a = double.Parse(Console.ReadLine());
            Console.Write("b=");
            b = double.Parse(Console.ReadLine());
            Console.Write("Toan tu:");
            tt = char.Parse(Console.ReadLine());
        
        }
        
        static double Thuchien(double a, double b, double tt, double kq)
        {
            if (tt == '+')
            {
                kq = a+b;
            }
            else if (tt == '-')
            {
                kq = a-b;
            }
            else if (tt == '*')
            {
                kq = a*b;
            }
            else if (tt == '/')
            {
                kq = a/b;
            }
            return kq;
        }
        
        static void InKQ(double a, double b, char tt, double kq)
        {
            Console.WriteLine("{0} {1} {2} = {3}", a, tt, b, kq);
        }
        static void Main(string[] args)
        {
            double a = 0, b = 0, kq = 0;
            char tt = '+';
            char tieptuc;
            while (true)
            {
                Nhap(ref a, ref b, ref tt);
                kq = Thuchien(a, b, tt, kq);
                InKQ(a, b, tt, kq);
                Console.Write("Tiep tuc:");
                tieptuc = char.Parse(Console.ReadLine());
                if (tieptuc == 't' || tieptuc == 'T')
                    break;
            }

        }
    }
}