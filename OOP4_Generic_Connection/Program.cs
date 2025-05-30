using System.Text;
using OOP2;

Console.OutputEncoding = Encoding.UTF8;
/*
 *su dung genertic lst de quan ly nhan su
 *thuc hien tinh nang day du 
 *c-create -->them moi nhan su 
 *r-read /retriev -doc truy van tim kiem sap xep
 *u update
 *d delete
 *cau 1 create 
 */
List<Employees> employees = new List<Employees>();  
FullTimeEmployees e1=new FullTimeEmployees();
e1.Id = 1;
e1.Name = "te0";
e1.IdCard = "121";
e1.BirthDay = new DateTime(1116, 5, 2);
employees.Add(e1);

FullTimeEmployees e2 = new FullTimeEmployees();
e2.Id = 2;
e2.Name = "teeo";
e2.IdCard = "122";
e2.BirthDay = new DateTime(1116, 5, 2);
employees.Add(e2);


FullTimeEmployees e3 = new FullTimeEmployees();
e3.Id = 3;
e3.Name = "teeeo";
e3.IdCard = "123";
e3.BirthDay = new DateTime(1116, 5, 2);
employees.Add(e3);

FullTimeEmployees e4 = new FullTimeEmployees();
e4.Id = 4;
e4.Name = "teeeeo";
e4.IdCard = "124";
e4.BirthDay = new DateTime(1116, 5, 2);
employees.Add(e4);
PartTimeEmployees e5 = new PartTimeEmployees();
e5.Id = 5;
e5.Name = "teeeeeo";
e5.IdCard = "124";
e5.BirthDay = new DateTime(1116, 5, 2);
e5.WorkingHour = 4;
employees.Add(e5);
Console.WriteLine("danh sach nhan su cach 1");
employees.ForEach(e =>Console.WriteLine(e));
Console.WriteLine("danh sach nhan su cach 2");
foreach (var e in employees)
    Console.WriteLine(e);

//cau3
//cach 1 dung extension method cua he thong
List<FullTimeEmployees> fe_list = employees.OfType<FullTimeEmployees>().ToList();

Console.WriteLine("------danh sach nhan su cach 1---------");
fe_list.ForEach(e =>Console.WriteLine(e));

//cach 2 dung cach thong thuong
List<FullTimeEmployees> fe_list2= new List<FullTimeEmployees>();
foreach (var e in fe_list)
{
    if(e is FullTimeEmployees)
        fe_list2.Add(e as FullTimeEmployees);
}
Console.WriteLine("-----------danh sach nhan su cach 2----------");
fe_list.ForEach(e => Console.WriteLine(e));
//tong luong
double sum_salary = fe_list2.Sum(e => e.calSalary());
Console.WriteLine("tong luong"+sum_salary);
for (int i = 0; i < employees.Count - 1; i++)
{
    for (int j = i + 1; j < employees.Count; j++)
    {
        if (employees[i].BirthDay > employees[j].BirthDay)
        {
            // Hoán đổi vị trí
            Employees temp = employees[i];
            employees[i] = employees[j];
            employees[j] = temp;
        }
    }
}

