using System;
using System.Text;
using OOP2;

Console.OutputEncoding = Encoding.UTF8;

FullTimeEmployees obama = new FullTimeEmployees
{
    Id = 1,
    IdCard = "123",
    Name = "Barrack",
    BirthDay = new DateTime(1960, 11, 25)
};

Console.WriteLine("------Thông tin Obama----------");
Console.WriteLine($"Id = {obama.Id}");
Console.WriteLine($"IdCard = {obama.IdCard}");
Console.WriteLine($"Name = {obama.Name}");
Console.WriteLine($"Birthday = {obama.BirthDay:dd/MM/yyyy}");
Console.WriteLine($"Mức lương nhận được = {obama.calSalary()}");


FullTimeEmployees trump = new FullTimeEmployees
{
    Id = 1,
    IdCard = "123",
    Name = "Barrack",
    BirthDay = new DateTime(1960, 11, 25)
};

Console.WriteLine("------Thông tin Obama----------");
Console.WriteLine($"Id = {trump.Id}");
Console.WriteLine($"IdCard = {trump.IdCard}");
Console.WriteLine($"Name = {trump.Name}");
Console.WriteLine($"Birthday = {trump.BirthDay:dd/MM/yyyy}");
Console.WriteLine($"Mức lương nhận được = {trump.calSalary()}");

Console.WriteLine("");
Console.WriteLine(obama);
Console.WriteLine(trump);
