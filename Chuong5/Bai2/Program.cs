using System;
class People
{
    public string ID;
    public string Hoten;
    public int Tuoi;
    public string Diachi;
    public People()
    {
        ID = "";
        Hoten = "";
        Tuoi = 0;
        Diachi = "";
    }
    ~People()
    {
        Console.WriteLine("Huy");
    }
    public void Nhap()
    {
        Console.Write("Nhap ID: ");
        ID = Console.ReadLine();
        Console.Write("Nhap ho ten: ");
        Hoten = Console.ReadLine();
        Console.Write("Nhap tuoi: ");
        Tuoi = int.Parse(Console.ReadLine());
        Console.Write("Nhap dia chi: ");
        Diachi = Console.ReadLine();
    }
    public void Xuat()
    {
        Console.WriteLine($"Ma so: {ID}\n Ho ten: {Hoten}\n Tuoi: {Tuoi}\n Dia chi: {Diachi}");
    }
    // a) Tạo lớp Students
    class Students : People
    {
        public string Term;
        public double TP1;
        public double TP2;
        public double TP3;
        public double GPA;
        public new void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap ten hoc phan: ");
            Term = Console.ReadLine();
            Console.Write("Nhap diem TP1: ");
            TP1 = double.Parse(Console.ReadLine());
            Console.Write("Nhap diem TP2: ");
            TP2 = double.Parse(Console.ReadLine());
            Console.Write("Nhap diem TP3: ");
            TP3 = double.Parse(Console.ReadLine());
        }
        public void gpa()
        {
            GPA = (TP1 + TP2 + TP3) / 3;
            if (GPA >= 9.5 && GPA <= 10)
            {
                Console.WriteLine($"GPA sinh vien la: {GPA}"); Console.WriteLine("Xep loai A+");
            }
            else if (GPA >= 8.5 && GPA <= 9.4)
            {
                Console.WriteLine($"GPA sinh vien la: {GPA}"); Console.WriteLine("Xep loai A");
            }
            else if (GPA >= 8.0 && GPA <= 8.4)
            {
                Console.WriteLine($"GPA sinh vien la: {GPA}"); Console.WriteLine("Xep loai B+");
            }
            else if (GPA >= 7.0 && GPA <= 7.9)
            {
                Console.WriteLine($"GPA sinh vien la: {GPA}"); Console.WriteLine("Xep loai B");
            }
            else if (GPA >= 6.5 && GPA <= 6.9)
            {
                Console.WriteLine($"GPA sinh vien la: {GPA}"); Console.WriteLine("Xep loai C+");
            }
            else if (GPA >= 5.5 && GPA <= 6.4)
            {
                Console.WriteLine($"GPA sinh vien la: {GPA}"); Console.WriteLine("Xep loai C");
            }
            else if (GPA >= 5.0 && GPA <= 5.4)
            {
                Console.WriteLine($"GPA sinh vien la: {GPA}"); Console.WriteLine("Xep loai D+");
            }
            else if (GPA >= 4.0 && GPA <= 4.9)
            {
                Console.WriteLine($"GPA sinh vien la: {GPA}"); Console.WriteLine("Xep loai D");
            }
            else
            {
                Console.WriteLine("Xep loai F");
            }
        }

    }
    // b) Tạo lớp Lecture
    class Lecture : People
    {
        public double Kinhnghiem;
        public string Hocvi;
        public string Chucvu;

        public new void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap so nam kinh nghiep: ");
            Kinhnghiem = double.Parse(Console.ReadLine());
            Console.Write("Nhap hoc vi: ");
            Hocvi = Console.ReadLine();
            Console.Write("Nhap chuc vu: ");
            Chucvu = Console.ReadLine();
        }

        public static void Sapxep(Lecture[] lectures)
        {
            Array.Sort(lectures, (x, y) => y.Kinhnghiem.CompareTo(x.Kinhnghiem));
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap thong tin sinh vien:");
            Students students = new Students();
            students.Nhap();
            students.Xuat();
            students.gpa();
            Console.WriteLine("\nNhap thong tin giang vien:");
            int n;
            Console.Write("Nhap so luong giang vien: ");
            n = Convert.ToInt32(Console.ReadLine());

            Lecture[] lectures = new Lecture[n];
            for (int i = 0; i < n; i++)
            {
                lectures[i] = new Lecture();
                lectures[i].Nhap();
            }

            Lecture.Sapxep(lectures);
            Console.WriteLine("\nThong tin giang vien sau khi sap xep:");
            foreach (var lecture in lectures)
            {
                lecture.Xuat();
            }
        }
    }
}

