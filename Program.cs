// See https://aka.ms/new-console-template for more information
using ConAppEmp;

Console.WriteLine("Hello, World!");

List<Employee> employees = new List<Employee>()
{
    new Employee() {Id= 1, Name="Sam",Designation="Manager",DOJ=new DateTime(day:12,month:11,year:2009)},
    new Employee() {Id= 2, Name="Vijay",Designation="Developer",DOJ=new DateTime(day:10,month:01,year:2015)},
    new Employee() {Id= 3, Name="Niraj",Designation="Manager",DOJ=new DateTime(day:14,month:12,year:2017)},
    new Employee() {Id= 4, Name="Vipul",Designation="Tester",DOJ=new DateTime(day:18,month:09,year:2021)},
    new Employee() {Id= 5, Name="Gagan",Designation="Manager",DOJ=new DateTime(day:21,month:09,year:2023)},
    new Employee() {Id= 6, Name="Simi",Designation="Developer",DOJ=new DateTime(day:28,month:10,year:2020)},
};
Console.WriteLine("ID\t Name \t Designation \t Date of Joining");
foreach (Employee emp in employees)
{
    Console.Write(emp.Id + "\t ");
    Console.Write(emp.Name + "\t \t");
    Console.Write(emp.Designation + "\t \t");
    Console.Write(emp.DOJ.ToLongDateString());
    Console.WriteLine("\n");
}
