using System.Text;

void swap(ref int a,ref int b)
{
    int temp = a;
    a = b;
    b = temp;

}
void sort_arr(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        for (int j = 0; j < arr.Length; j++)
        {
            if (arr[i] > arr[j])
            {
                swap(ref arr[i], ref arr[j]);
            }    
        }    
    }    
}

void create_array(int[] arr)
{
    Random rd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rd.Next(100);
    }
}
void print_array(int[] arr)
{
    foreach (int x in arr)
    {
        Console.Write($"{x}\t");
    }    
}
int[]arr = new int[10];
create_array(arr);
Console.OutputEncoding = Encoding.UTF8;
Console.WriteLine("mảng trc khi sắp xếp ");
print_array(arr);
Console.WriteLine("mảng sau khi sắp xếp ");
sort_arr(arr);
print_array(arr);

void WhileSort(int[] arr)
{
    int i = 0;
    int j = 0;
    while ( i < arr.Length) 
    {
        i++;
        while (j < arr.Length)
        {
            j++;
            if(arr[i] > arr[j])
               {
                swap(ref arr[i], ref arr[j]);
            }

        }

    }
}
create_array(arr);
Console.OutputEncoding = Encoding.UTF8;
Console.WriteLine("mảng trc khi sắp xếp ");
print_array(arr);
Console.WriteLine("mảng sau khi sắp xếp ");
WhileSort(arr); 
print_array(arr);

