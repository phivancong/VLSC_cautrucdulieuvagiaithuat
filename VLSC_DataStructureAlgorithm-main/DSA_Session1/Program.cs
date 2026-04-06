using System;

namespace Buoi1_ThucHanh
{

    class SinhVien
    {

        public string HoTen { get; set; } = string.Empty; 
    }

    class Program
    {
   
        static void Main(string[] args)
        {

            Console.WriteLine("--- Bai tap 1: Tham chieu ---");
            SinhVien sv1 = new SinhVien { HoTen = "Vo Bao Lan" };
            SinhVien sv2 = sv1; 

            sv2.HoTen = "Phi Van Cong";
            Console.WriteLine($"Ten cua sv1 sau khi thay doi qua sv2: {sv1.HoTen}");


            Console.WriteLine("\n--- Bai tap 2: Hoan doi (Swap) ---");
            int a = 10, b = 20;
            Console.WriteLine($"Truoc khi swap: a = {a}, b = {b}");

            Swap(ref a, ref b);
            Console.WriteLine($"Sau khi swap: a = {a}, b = {b}");


            Console.WriteLine("\n--- Bai tap 3: Thao tac mang ---");
            int[] numbers = { 1, 2, 3, 4, 5 };

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
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}