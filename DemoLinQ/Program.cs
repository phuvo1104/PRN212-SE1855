using System.Net.WebSockets;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;
int[] arr =
{
    1,2,4,5,6,7,8,9,23,24,25,26,27,28,29,30,31,32
};
// cau 1 lọc ra các số chẵn 
//cách 1 dùng Extension method -method syntax
var ar_chan  = arr.Where(x=> x%2 ==0);
Console.WriteLine("các số chẵn dùng phần mềm method syntax");
ar_chan.ToList().ForEach(x => Console.WriteLine(x));
//cách 2 đùng query syntax

var var_chan2 = from x in ar_chan
                where x %2 ==0
                select x;
Console.WriteLine("các số chẵn dùng query syntax");
var_chan2.ToList().ForEach(x => Console.WriteLine(x));

// câu 2 tăng các phần tử lên 2 đơn vị 
var arr2 = arr.Where(x => x % 2 != 0)
                .Select(x => x + 2) ;

Console.WriteLine("dữ liệu gốc");
foreach(var x in arr)
    Console.WriteLine(x+"\t")
;
Console.WriteLine("\n dữ liệu sau khi tăng số lẽ");
foreach(var x in arr2)
    Console.WriteLine(x+"\t");
//câu 3 sắp xếp theo thứ tự tăng dần
var arr4 = arr.OrderBy(x => x);
var arr5 = from x in arr
           orderby x
           select x;
Console.WriteLine("\n Sau khi sắp xếp tăng dần");
foreach (var item in arr4)
    Console.WriteLine(item + "\t");
//caau4 sắp xếp giảm dần
var arr6 = arr.OrderByDescending(x => x);
var arr7 =from x in arr
          orderby x descending
          select x;
//caau5 đem các phần lẽ
Console.WriteLine("số lẽ là = " + arr.Where(x => x % 2 != 0).Count());
int sole= (from x in arr
           where x % 2 == 0
           select x).Count();
