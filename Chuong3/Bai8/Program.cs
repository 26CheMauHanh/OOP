using System;
using System.Text;

class SUCKHOE
{
    private int MaBN;
    private string TenBN;
    private string GioiTinh; 
    private string Benh;
    private string Khuvuc;
    private string Mucdo;
}
class QuanlySuckhoe
{
    public List<SUCKHOE> DS = new List<SUCKHOE>();
    public QuanlySuckhoe()
    {
        Console.OutputEncoding = Encoding.UTF8;
        var intput = File.ReadAllText("suckhoe.txt");
        string[] res;
        foreach (var row in intput.Split('\n'))
        {
            res = row.Split(';');
            DS.Add(new SUCKHOE()
            {
                MaBN = int.Parse(res[0].Trim()),
                TenBN = res[1].Trim(),
                GioiTinh = res[2].Trim(),
                Benh = res[3].Trim(),
                Mucdo = res[4].Trim()

            });
        }
    }
    public void Them()
    {
        SUCKHOE SK = new SUCKHOE();
        Console.Write("Ma BN:");
        SK.MaBN = int.Parse(Console.ReadLine());
        Console.Write("Ten BN:");
        SK.TenBN = Console.ReadLine();
        Console.Write("Gioi tinh:");
        SK.GioiTinh = Console.ReadLine();
        Console.Write("Benh:");
        SK.Benh = Console.ReadLine();
        Console.Write("Muc do:");
        SK.Mucdo = Console.ReadLine();
        DS.Add(SK);
    }
    public void Cachly()
    {

    }
    public void Sapxep()
    {
        DS.Sort((x, y));
        Console.WriteLine("Danh sach benh nhan theo muc đo benh: ");
        foreach(SUCKHOE SK in DS)
        {
            Console.WriteLine(SK.ToString());
        }
    }
}
class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.Unicode;
        Console.InputEncoding = Encoding.Unicode;
        QuanlySuckhoe DS = new QuanlySuckhoe();
        int input;
        while (true)
        {
            Console.WriteLine("========== MENU ==========");
            Console.WriteLine("Bam 1: Them");
            Console.WriteLine("Bam 2: Cach ly");
            Console.WriteLine("Bam 3: Sap xep");
            Console.WriteLine("Bam 0: Exit");
            Console.WriteLine("==========================");
            Console.WriteLine("Bam: ");
            input = int.Parse(Console.ReadLine());
            switch (input)
            {
                case 1: DS.Them(); break;
                case 2: DS.Cachly(); break;
                case 3: DS.Sapxep(); break;
                case 0: return;
                default: Console.WriteLine("Lua chon khong hop le!"); break;
            }
        }
    }
}