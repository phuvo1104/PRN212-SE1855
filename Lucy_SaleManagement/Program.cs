using Lucy_SaleManagement;

Console.OutputEncoding = System.Text.Encoding.UTF8;
string connectionString = @"server=localhost;database=MyStore;uid=sa;pwd=12345";
Lucy_SalesDataDataContext context = new Lucy_SalesDataDataContext(connectionString);
//cau1 lay chi tiet thong tin khach hangn khi biet ma so 
int mkh = 1;
Customer cust = context.Customers.FirstOrDefault(c => c.CustomerID == mkh);
if (cust == null)
{
    Console.WriteLine(cust.CustomerID + "\t" + cust.ContactName);

}
//loc ra danh sach cac hoa don 
if(cust != null)
{
    Console.WriteLine( "danh sach hoa don cua khach hang");

    foreach(Order od in cust.Orders)
    {
        Console.WriteLine(od.OrderID + "\t" + od.OrderDate.ToString("dd/MM/yyyy"));
    }
}
//cau 3 nagn cap cau 23
//bo sung them mot cot hien thi gia tri cua don
if (cust != null)
{
    Console.WriteLine("Danh sách hóa đơn của khách hàng:");

    Console.WriteLine("Mã đơn\tNgày đặt\t\tTổng giá trị (VNĐ)");

    foreach (Order od in cust.Orders)
    {
        // Tính tổng giá trị đơn hàng
        decimal total = od.OrderDetails.Sum(d => d.UnitPrice * d.Quantity * (1 - (decimal)d.Discount));

        Console.WriteLine($"{od.OrderID}\t{od.OrderDate:dd/MM/yyyy}\t{total:N0}");
    }
}
