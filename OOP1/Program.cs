using OOP1;

class Program
{
    static void Main(string[] args)
    {
        Category c1 = new Category();
        c1.id = 1;
        c1.name = "nuoc mam";
        c1.PrintInfor();

        Employee e1 = new Employee();
        e1.id = 1;
        e1.idCard = "0123";
        e1.name = "teo";
        e1.email = "teo@gamil.com";
        e1.phone = "0912342423";
        e1.PrintInfor();



        Console.WriteLine("==================");
        Employee e3 = new Employee();
        e3.id = 1;
        e3.idCard = "0123";
        e3.name = "teo";
        e3.email = "teo@gamil.com";
        e3.phone = "0912342423";
        e3.PrintInfor();
        
        Console.WriteLine(e3);



        Customer cus1 = new Customer()
        {
            Id = "0324",
            Name = "Name",
            Email = "name@gmai.com",
            Phone = "9078543",
            Address = "ddsodswe ewwer werwerw"

        };
        cus1.PrintInfor();

    }
}
