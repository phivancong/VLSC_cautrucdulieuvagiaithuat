using System;
//author: Phí Văn Công
namespace DSA_Session05_Sortings
{
    class Program
    {
        static void Main(string[] args)
        {
            // Nhập mảng từ người dùng
            int[] arr = InputArray();

            // Tạo bản sao của mảng để sử dụng cho thuật toán khác
            int[] arrCopy = (int[])arr.Clone();

            Console.WriteLine("Mảng ban đầu:");
            PrintArray(arr);

            BubbleSort(arr);
            Console.WriteLine("Mảng sau khi sắp xếp (Bubble Sort):");
            PrintArray(arr);

            InsertionSort(arrCopy);
            Console.WriteLine("Mảng sau khi sắp xếp (Insertion Sort):");
            PrintArray(arrCopy);
        }

        // Hàm để nhập mảng từ người dùng
        private static int[] InputArray()
        {
            Console.WriteLine("Nhập số lượng phần tử:");
            int n;

            while (!int.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine("Nhập một số nguyên hợp lệ:");
            }

            int[] arr = new int[n];

            Console.WriteLine("Nhập các phần tử:");
            for (int i = 0; i < n; i++)
            {
                while (!int.TryParse(Console.ReadLine(), out arr[i]))
                {
                    Console.WriteLine("Nhập một số nguyên hợp lệ:");
                }
            }

            return arr;
        }

        // Hàm để in mảng
        private static void PrintArray(int[] arr)
        {
            foreach (int item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        // Bubble Sort
        static void BubbleSort(int[] arr)
        {
            int n = arr.Length;
            int swapCount = 0;

            for (int i = 0; i < n - 1; i++)
            {
                // Duyệt qua tất cả phần tử, trừ phần tử cuối cùng
                for (int j = 0; j < n - i - 1; j++)
                {
                    // So sánh phần tử hiện tại với phần tử tiếp theo
                    if (arr[j] > arr[j + 1])
                    {
                        // Hoán đổi
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;

                        swapCount++;
                    }
                }
            }

            Console.WriteLine($"Bubble Sort tốn {swapCount} lần hoán đổi.");
        }

        // Insertion Sort
        static void InsertionSort(int[] arr)
        {
            int swapCount = 0;
            int n = arr.Length;

            for (int i = 1; i < n; i++) // bắt đầu từ phần tử thứ 2
            {
                int key = arr[i];
                int j = i - 1;

                // Dịch chuyển các phần tử lớn hơn key sang phải
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j--;
                    swapCount++;
                }

                arr[j + 1] = key;
            }

            Console.WriteLine($"Insertion Sort tốn {swapCount} lần hoán đổi.");
        }
    }
}

