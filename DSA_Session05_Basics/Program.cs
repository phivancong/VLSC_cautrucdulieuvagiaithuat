//author: Phí Văn Công

using System;

namespace DSA_Session05_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            // Bài 1: Hoán đổi 2 số không dùng biến tạm
            Console.WriteLine("Bài 1: Hoán đổi 2 số không dùng biến tạm");

            Console.Write("Nhập a: ");
            string inputA = Console.ReadLine();
            int a;
            while (!int.TryParse(inputA, out a))
            {
                Console.Write("a không hợp lệ, vui lòng nhập lại: ");
                inputA = Console.ReadLine();
            }

            Console.Write("Nhập b: ");
            string inputB = Console.ReadLine();
            int b;
            while (!int.TryParse(inputB, out b))
            {
                Console.Write("b không hợp lệ, vui lòng nhập lại: ");
                inputB = Console.ReadLine();
            }

            // Hoán đổi
            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine($"Sau khi hoán đổi: a = {a}, b = {b}");

            Console.WriteLine("==============");

            // Bài 2: In hình vuông *
            Console.WriteLine("Bài 2: In hình vuông (n x n)");
            Console.Write("Nhập kích thước: ");
            string inputN = Console.ReadLine();
            int n;

            while (!int.TryParse(inputN, out n) || n <= 0)
            {
                Console.Write("n không hợp lệ, vui lòng nhập lại: ");
                inputN = Console.ReadLine();
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("==============");

            // Bài 3: Bảng cửu chương
            Console.WriteLine("Bài 3: In bảng cửu chương (2 đến 9)");

            for (int i = 2; i <= 9; i++)
            {
                Console.WriteLine($"===== Bảng cửu chương {i} =====");
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine($"{i} x {j} = {i * j}");
                }
            }
        }
    }
}