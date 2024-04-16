using System;

interface ThietBi
{
    bool IsOn { get; set; }
    void Bat();
    void Tat();
}

class MayQuat : ThietBi
{
    public bool IsOn { get; set; }

    public void Bat()
    {
        IsOn = true;
        Console.WriteLine("May quat da bat");
    }

    public void Tat()
    {
        IsOn = false;
        Console.WriteLine("May quat da tat");
    }
}

class DieuHoa : ThietBi
{
    public bool IsOn { get; set; }

    public void Bat()
    {
        IsOn = true;
        Console.WriteLine("Dieu hoa da bat");
    }

    public void Tat()
    {
        IsOn = false;
        Console.WriteLine("Dieu hoa da tat");
    }
}

class TiVi : ThietBi
{
    public bool IsOn { get; set; }

    public void Bat()
    {
        IsOn = true;
        Console.WriteLine("TV da bat");
    }

    public void Tat()
    {
        IsOn = false;
        Console.WriteLine("TV da tat");
    }
}

class Program
{
    static void Main(string[] args)
    {
        ThietBi[] tb = new ThietBi[3];
        tb[0] = new MayQuat();
        tb[1] = new DieuHoa();
        tb[2] = new TiVi();

        Console.WriteLine("MENU: ");
        Console.WriteLine("1. May quat");
        Console.WriteLine("2. Dieu hoa");
        Console.WriteLine("3. TV");
        Console.WriteLine("0. Ket thuc");

        while (true)
        {
            Console.Write("Chon menu: ");
            string menu = Console.ReadLine();

            if (menu == "1" || menu == "2" || menu == "3")
            {
                int index = int.Parse(menu) - 1;
                Console.WriteLine("1. Bat");
                Console.WriteLine("2. Tat");
                Console.Write("Lua chon cua ban: ");
                string luaChon = Console.ReadLine();

                if (luaChon == "1")
                {
                    tb[index].Bat();
                }
                else if (luaChon == "2")
                {
                    tb[index].Tat();
                }
                else
                {
                    Console.WriteLine("Lua chon khong hop le!");
                }
            }
            else if (menu == "0")
            {
                Console.WriteLine("KET THUC ");
                break;
            }
            else
            {
                Console.WriteLine("Lua chon khong hop le!");
            }
        }
    }
}
