//author: Phí Văn Công
//Mục tiêu: Học cách sử dụng các thuật sắp xếp cơ chế cơ bản: Bubble Sort, Selection Sort.
class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        //Bài 1: Sắp xếp nổi bọt (Bubble Sort)
        Console.Write("Nhap n: ");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        Console.WriteLine("Nhap cac phan tu: ");
        for(int i = 0; i < n; i++)
        {
            Console.Write($"arr[{i}]: ");
            arr[i] = int.Parse(Console.ReadLine());
        }
        BubbleSort(arr);
        Console.WriteLine("Mang sau khi sap xep: ");
        PrintArray(arr);
        InsertionSort(arr);
        Console.WriteLine("Mang sau khi sap xep bang Insertion Sort: ");
    }
    static void BubbleSort(int[] arr)
    {
        int n = arr.Length;
        for(int i = 0; i < n - 1; i++)
        {
            for(int j = 0; j < n - 1; j++)
            {
                if(arr[j] > arr[j + 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
    }
    static void PrintArray(int[] arr)
    {
        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
    //Bài 2: Sắp xếp chèn
    static void InsertionSort(int[] arr)
    {
        int n = arr.Length;
        for(int i = 1; i < n; i++){
        int key = arr[i];
        int j = i -1;
        while( j >= 0 && arr[j] > key)
        {
            arr[j  + 1] =arr[j];
            j--;
        }
        arr[j + 1] = key;
    }
    }
}