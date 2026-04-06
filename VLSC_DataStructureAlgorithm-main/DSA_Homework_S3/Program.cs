using System;
using System.Diagnostics; 

// Author: Phí Văn Công - 2500116169
// Mục tiêu: So sánh hiệu năng giữa Linear Search và Binary Search trên mảng đã sắp xếp với 10 triệu phần tử
class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        // --- BÀI TẬP 2: SO SÁNH THỰC TẾ VỚI 10 TRIỆU PHẦN TỬ ---
        int n = 10000000; 
        int[] arr = new int[n];

        
        for (int i = 0; i < n; i++)
            arr[i] = i;

        int target = 9999999; 

        Stopwatch sw = new Stopwatch();

        Console.WriteLine($"--- Thử nghiệm với {n} phần tử ---");

        sw.Start();
        int res1 = LinearSearch(arr, target);
        sw.Stop();
        Console.WriteLine($"[Linear Search] Index: {res1}, Time: {sw.Elapsed.TotalMilliseconds} ms");

       
        sw.Restart();
        int res2 = BinarySearchRecursive(arr, 0, n - 1, target);
        sw.Stop();
        Console.WriteLine($"[Binary Search - Recursive] Index: {res2}, Time: {sw.Elapsed.TotalMilliseconds} ms");
    }

    
    static int LinearSearch(int[] arr, int x)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == x)
                return i;
        }
        return -1;
    }

 
    static int BinarySearchRecursive(int[] arr, int left, int right, int x)
    {
       
        if (left > right)
            return -1;

       
        int mid = left + (right - left) / 2;

       
        if (arr[mid] == x)
            return mid;

        
        if (arr[mid] > x)
            return BinarySearchRecursive(arr, left, mid - 1, x);

       
        return BinarySearchRecursive(arr, mid + 1, right, x);
    }
}