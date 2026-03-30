using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
// Author: Phi Van Cong - 2500116169
//Muc tieu:
//Bài 1: Lời chào thông minh  
//Yêu cầu: Nhập tên và mssv, in ra lời chào;
//Code:
//Sử dụng Console.ReadLine() để gán biến.
class Program{

    static void Main() {
       Console.OutputEncoding = System.Text.Encoding.UTF8;
       Console.Write("Nhap ho ten: ");
       String name = Console.ReadLine();
       Console.Write("Nhap mssv: ");
       String mssv = Console.ReadLine();
       Console.WriteLine($"Chao mung sinh vien {name} (MS: {mssv} ) den voi lop CTDL&GT!");

    //Bài 2: Máy tính cơ bản
    Console.WriteLine("\n\t-----Bai 2: May tinh co ban------");
    Console.Write("Nhap so a: ");
    int a = int.Parse(Console.ReadLine());
    Console.Write("Nhap so b: ");
    int b = int.Parse(Console.ReadLine());
    Console.WriteLine($"Tong: {a+b}");
    Console.WriteLine($"Hieu: {a- b}");
    Console.WriteLine($"Tich: {a * b}");
    if (b != 0)
{
    Console.WriteLine($"Thuong: {(double) a / b}");
} else
{
    Console.WriteLine("Khong the chia cho 0");
}
    //Bài 3: Kỹ thuật hoán đối (swap)
   Console.WriteLine("\n\t-----Bai 3: Ky thuat co ban------");
   int x = 5, y = 10;
   Console.WriteLine($"Truoc khi swap: x={x}, y={y}");
   int temp = x;
   x = y;
   y = temp;
   Console.WriteLine($"Sau khi swap: x={x}, y={y}");
    }
}
