using System.Text;

class Program
{

    public delegate int MyDelegate1(int x, int y);
    static int Cong(int x, int y)
    {
        return x + y;
    }
    static int tru (int x, int y)
        {
        return x -y;
    }
    public delegate int[] MyDelegate2(int n);
    static int[] Danhsachsochan(int n)
    {
        List<int> list = new List<int>();
        for (int i = 2; i <= n; i = i + 2)
            list.Add(i);  // Sửa từ add → Add

        return list.ToArray();
    }

    static int[] Danhsachsonguyento(int n)
    {
        List<int> list = new List<int>(); // Sửa List<int[]> thành List<int>

        for (int i = 2; i <= n; i++)
        {
            int count = 0;
            for (int j = 1; j <= i; j++)
            {
                if (i % j == 0)
                    count++;
            }

            if (count == 2)
                list.Add(i); // Sửa từ list.Add(i) cho List<int[]>
        }

        return list.ToArray(); // Sửa từ List<int[]> thành List<int>
    }

    public static void Main(string[] args)
    {

        Console.OutputEncoding = Encoding.UTF8;
        MyDelegate1 d1 = new MyDelegate1(Cong);
        
        d1 = new MyDelegate1(Cong);
        Console.WriteLine("tổng của 5 và 8= " + d1(5, 8));
        
        d1 = new MyDelegate1(tru);
        Console.WriteLine("hiệu của 5 và 8= " + d1(5, 8));
        MyDelegate2 d2 = new MyDelegate2(Danhsachsochan);
        int[] arr = d2(10);
        Console.WriteLine("danh sach số chẵn ");
       foreach (int i in arr) Console.WriteLine(i);
    }
}