using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Threading.Tasks;

namespace BAI1
{
    class mang
    {
        static void Main(string[]args)
        {
            int[]A;
            int n;
            Console.Write("n=");
            n=int.Parse(Console.ReadLine());
            a= new int[n];

        for(int i=0,i<n;i++)
        {
            Console.Write("a[{0}]=",i);
            A[i]=int.Parse(Console.ReadLine());
        }
        //a
        Console.WriteLine("Tong="+sumArr(A));
        //b
        int dau, cuoi;
        timdaucuoi(a,out dau, out cuoi);
        Console.WriteLine("Tich=" + productArr(a,dau,cuoi));
        //c
        Array.Sort(A);
        Console.Write("A_tang=[");
        for(int i=0; i<a.Length -1 ;i++)
        Console.Write(A[i]+",");
        Console.Write(A[A.Length-1]+"]");
        //d
        int[]A2=new int[n];
        int j=0;
        for(int i=0;i<n,i++)
        if ((int A[i])%2== 0)
        {
            A2[j]=(int)A[i];
            j++;
        }
        for(int i=0;i<n;i++)
        if(((int)a[i])%2!=0)
        {
            A2[j]=(int) A[i];
            j++;
        }
        Console.Write("A_biendoi=[");
        for(int i=0;i<A2.Length-1;i++)
        Console.Write(A2[i]+",");
        Console.Write(A2[a.Length-1]+"]");
        }
        static int sumArr(int[]A)
        {
            double s=0;
            for(int i=0;i<a.Lengthl;i++)
            if (A[i]<0)
                s+=Math.Abs(A[i]);
            return s;
        }
        static int productArr(int[]A,int dau,int cuoi)
        {
            int s=1;
            for (int i=dau;i<=cuoi;i++)
            s*=A[i];
            return s;
        }
        static void timdaucuoi(int []A,out int dau,out int cuoi)
        {
            int max=0;
            int min=0;
            for(int i=0;i<a.Length;i++)
            {
                if(A[max]<A[i]) max=i;
                if(A[min]<A[i]) min=i;
            }
            if (max<min)
            {
                dau=max+1;
                cuoi=min-1;
            }
            else
            {
                dau=min+1;
                cuoi=max-1;
            }
        }
    }
}