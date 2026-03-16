using System;

class Program
{
    static int TinhTong(int n)
    {

        if (n == 1) return 1;
        return n + TinhTong(n - 1);
    }

static long GiaiThuaVongLap(int n)
{
   long ketqua = 1;
   for(int i = 1; i <= n; i++)
   {
    ketqua *= i;
   }
   return ketqua;
}
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.Write("Nhap so n: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine($"Tong S({n}) = {TinhTong(n)}");
        Console.WriteLine($"Giai thua cua {n} la {GiaiThuaVongLap(n)}");
    }
}