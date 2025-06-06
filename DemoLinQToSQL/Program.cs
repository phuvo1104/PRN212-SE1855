using DemoLinQToSQL;

Console.OutputEncoding = System.Text.Encoding.UTF8;
string connectionString = @"server=localhost;database=MyStore;uid=sa;pwd=12345";
MyStoreDataContext context = new MyStoreDataContext(connectionString);
// cau 1 truy van toan bo danh muc
var dsdm = context.Categories.ToList();


dsdm.ForEach(x => Console.WriteLine(x.CategoryID + "\t" + x.CategoryName));
// cau 2
// dung query syntax de loc ra toan bo san pham
//
var dsp =from p in context.Products
         select p;
Console.WriteLine("danh sach san pham");
foreach  (var p in dsp)
{
    Console.WriteLine(  p.ProductID + "\t" + p.ProductName +"\t"+p.UnitPrice);
}
//cau 3 tim danh muc khi biet ma danh muc
int dmd = 3;
Category cate = context.Categories.FirstOrDefault(x => x.CategoryID == dmd);
if (cate != null)
{

    Console.WriteLine("khong tim thay danh muc co ma " + dmd);

}
else
{
    Console.WriteLine("da tim thay danh muc co ma "+dmd);
    Console.WriteLine(cate.CategoryID + "\t" + cate.CategoryName);
}
//cau 4 loc ra top 3 san pham co gia lon nhat
var dsstop3 = context.Products

    .OrderByDescending(p => p.UnitPrice)
    .Take(3);
Console.WriteLine("danh sach 3 san pham dat nhat");
foreach (var p in dsstop3)
{
    Console.WriteLine(p.ProductID+"\t"+p.ProductName+"\t"+p.UnitPrice);
}
//cau 5 them moi mot danh muc
Category c1 = new Category();
c1.CategoryName = "jhgjfhdsrtrjgnfvdrgtrfddet";
context.Categories.InsertOnSubmit(c1);
context.SubmitChanges();
//cau6 sua ten danh muc
//1.tim danh muc
//2.tim thay danh muc thi sua
Category c13 = context.Categories.FirstOrDefault(c => c.CategoryID == 13);

if (c13 != null)
{
    c13.CategoryName = "23432";
    context.SubmitChanges();
}
//cau7 xoa danh muc khi biet ma danh muc
Category c14 = context.Categories.FirstOrDefault(c => c.CategoryID == 14);
if (c14 != null)
{
   context.Categories.DeleteOnSubmit(c13);
    context.SubmitChanges();
}
//cau 8 xoa tat ca danh muc chua co san pham nao
var dssp_emty_produce= context.Categories.Where(c => c.Products.Count() == 0).ToList();
context.Categories.DeleteAllOnSubmit(dssp_emty_produce);
context.SubmitChanges();
//cau 9 them nhieu danh muc cung mot luc
List<Category> dsdm_new = new List<Category>();

dsdm_new.Add(new Category() { CategoryName = "hang dien tu" });
dsdm_new.Add(new Category() { CategoryName = "hang hoa chat" });
dsdm_new.Add(new Category() { CategoryName = "hang gia dung" });
context.Categories.InsertAllOnSubmit(dsdm_new);
context.SubmitChanges();