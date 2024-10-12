internal class Program
{
    static int[] XoaPhanTu(int[] arr, int x)
    {
        int n = arr.Length;
        int index_delete = -1; //khởi tạo index_delete = -1 nếu không tìm thấy

        for (int i = 0; i < n; i++)
        {
            if (arr[i] == x)
            {
                index_delete = i;
                break;
            }

        }

        if (index_delete == -1)
        {
            Console.WriteLine($"Không tìm thấy phần tử {x} để xóa.");
            return arr;
        }
        // Tạo mảng mới có kích thước giảm đi 1
        int[] newArr = new int[n - 1];
        int newIndex = 0;

        // Chép các phần tử không bị xóa vào mảng mới
        for (int i = 0; i < n; i++)
        {
            if (i != index_delete)
            {
                newArr[newIndex++] = arr[i];
            }
        }

        return newArr;
    }

    private static void Main(string[] args)
    {
        Console.WriteLine($"Nhập số lượng phần tử của mảng: ");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];

        Console.WriteLine($"Nhập các phân tử của mảng: ");
        for(int i = 0; i < n; i++){
            Console.Write($"Phần tử thứ {i+1}: ");
            arr[i] = int.Parse(Console.ReadLine());            
        }

        Console.Write($"Nhập phần tử cần xóa:");
        int x = int.Parse(Console.ReadLine());

        arr = XoaPhanTu(arr, x);
        Console.WriteLine("Mảng sau khi xóa phần tử:");
        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }
    }
}