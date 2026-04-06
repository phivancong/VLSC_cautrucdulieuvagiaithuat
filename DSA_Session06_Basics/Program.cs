using System;

namespace DSA_Session06_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            
            do
            {
                Console.WriteLine("\n=== MENU QUẢN LÝ ===");
                Console.WriteLine("1. Chức năng A");
                Console.WriteLine("2. Chức năng B");
                Console.WriteLine("0. Thoát chương trình");
                Console.Write("Mời bạn chọn (0-2): ");

                choice = int.TryParse(Console.ReadLine(), out choice)
                    ? choice
                    : -1; 
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Đang chạy chức năng A...");
                        break;
                    case 2:
                        Console.WriteLine("Đang chạy chức năng B...");
                        break;
                    case 0:
                        Console.WriteLine("Tạm biệt!");
                        break;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ, vui lòng nhập lại!");
                        break;
                }
            } while (choice != 0);
        }
    }
}