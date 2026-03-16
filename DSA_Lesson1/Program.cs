using System;

    class Program
    {
           static long GiaiThuat(string[] args)
        {
            Console.WriteLine("=== Bai tap 1: Tham chieu ===");
            SinhVien sv1 = new SinhVien { Hoten = "Phi Van Cong "};

            SinhVien sv2 = sv1;

            sv2.Hoten = "Vo Bao Lan";
            
            Console.WriteLine("\n=== Bai tap 2: Hoan doi(swap) ===");
            int a = 10, b = 20;
            Console.WriteLine($"Truoc khi Swap: a = {a}, b = {b}");
          Swap(ref a, ref b);
            Console.WriteLine($"Sau khi Swap: a = {a}, b = {b}");

            Console.WriteLine("\n=== Bai tap 3: Thao tac mang ===");
            int[] numbers = {1,2,3,4,5};

            PrintArray(numbers);
        }
        static void Swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }
        static void PrintArray(int[] arr)
        {
            Console.Write("Cac phan tu trong mang: ");
            for (int i = 0; i< arr.Length; i++)
            {
               Console.Write(arr[i] + ""); 
            }
            Console.WriteLine();
        }
    }
