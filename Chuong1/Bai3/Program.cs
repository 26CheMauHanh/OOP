class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n = ");

            int n = Convert.ToInt32(Console.ReadLine());
            float[] A = new float[n];
            float tong, tich, max, min;
            int indexMax, indexMin;
            tong = 0;
            max = 0;
            min = 0;
            indexMax = 0;
            indexMin = 0;
            tich = 1;
            // Câu a:Tổng giá trị tuyệt đối các phần tử âm của mảng;
            for (int i = 0; i < n; i++)
            {
                A[i] = float.Parse(Console.ReadLine());
                if (A[i] < 0)
                {
                    tong += Math.Abs(A[i]);
                }
                if (A[i] < min)
                {
                    min = A[i];
                }
                if (A[i] > max)
                    max = A[i];
            }
            Console.WriteLine("Tong = " + tong);
            //Câu b: Tích của các phần tử nằm giữa phần tử tối đa và phần tử tối thiểu của mảng.
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] == max)
                    indexMax = i;
                if (A[i] == min)
                    indexMin = i;
            }
            if (indexMax > indexMin)
               {
                 for (int i = indexMin+1; i < indexMax; i++)
                  {
                        tich *= A[i];
                  }
                }
            else if (indexMax < indexMin)
                {
                  for (int i = indexMax+1; i < indexMin; i++)
                   {
                        tich *= A[i];
                   }
                }
            Console.WriteLine("Tich = " + tich);
            //Câu c: Sắp xếp các phần tử của mảng theo thứ tự tăng dần.
            Array.Sort(A);
            Console.Write("A_tang = [");
            for (int i = 0; i < A.Length; i++)  
            {
                if (i==n-1)
                {
                    Console.WriteLine(A[i]+"]");
                }
                else
                {
                    Console.Write(A[i] + ", ");
                }
            }
            //Câu d: Lấy phần nguyên của các phần tử là số thực, sau đó sắp xếp tất cả các phần tử chẵn đứng trước (bên trái), còn các phần tử lẻ đứng sau (bên phải)
            int[] A_biendoi = new int[n];
            int evenIndex = 0;
            int oddIndex = n - 1;
            foreach (float num in A)
            {
                int roundedNum = (int)num;
                if (roundedNum % 2 == 0)
                {
                    A_biendoi[evenIndex] = roundedNum;
                    evenIndex++;
                }
                else
                {
                    A_biendoi[oddIndex] = roundedNum;
                    oddIndex--;
                }
            }
            Console.Write("A_biendoi = [");
            for (int i = 0; i < A_biendoi.Length; i++)
            {
                Console.Write(A_biendoi[i]);
                if (i < A_biendoi.Length - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine("]");
        }
    }