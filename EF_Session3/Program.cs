using EF_Session3.Contexts;
using EF_Session3.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.Internal;

namespace EF_Session3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Inheritance Mapping(TPCC) 
            //Insert data

            //using CompanyDbContext db = new CompanyDbContext();
            //FullTimeEmployee employee = new FullTimeEmployee()
            //{
            //Name = "Aya",
            //Address = "Street City",
            //Age = 25, 
            //Salary = 1000,
            //StartDate = DateTime.Now
            //};

            ////Make connection with dbset
            //PartTimeEmployee partTimeEmployee = new PartTimeEmployee()
            //{
            //    Name = "Aly",
            //    Address = "Street_City",
            //    Age = 30,
            //    CountHours = 20,
            //    HourRate = 100
            //};
            ////db.fullTimeEmployees.Add(employee);
            //db.partTimeEmployees.Add(partTimeEmployee);

            //Add Localy
            //  db.SaveChanges();//Add Remotly

            //var FteEmployee = from FTE in db.fullTimeEmployees select FTE;
            //var PteEmployee = from PTE in db.partTimeEmployees select PTE;

            //foreach (var emp in FteEmployee)
            //{
            //    Console.WriteLine($"{emp.Name} ::{emp.Salary}");//to print all readings in table in DB
            //}

            //Console.WriteLine("====================================");
            //foreach (var part in PteEmployee)
            //    Console.WriteLine($"{part.Name} ::{part.HourRate}");//to print all readings in table in DB


            #endregion

            #region TPH 
            //var Employees = from FTE in db.Employees select FTE;


            //foreach (var emp in Employees.OfType<FullTimeEmployee>())
            //{
            //    Console.WriteLine($"{emp.Name} ::{emp.Salary}");//to print all readings in table in DB
            //}

            //Console.WriteLine("====================================");
            //foreach (var emp in Employees.OfType<PartTimeEmployee>())
            //    Console.WriteLine($"{emp.Name} ::{emp.HourRate}");//to print all readings in table in DB
            #endregion

            #region Without Loading 
            //var Employee = (from E in db.fullTimeEmployees
            //                where E.Name == "Aya"
            //                select E).FirstOrDefault();
            //Console.WriteLine($"Employee Name = {Employee?.Name ?? "Not Found"}"); 
            #endregion

            #region Explicit loading 

            //var Employee = ( from  E in db.Employees
            //                 where E.Name =="Aly"
            //                 select E ).FirstOrDefault();
            //db.Entry(Employee).Reference(E => E.Department).Load();
            #endregion

            #region Eager Loading  
            //var Employee = (from E in db.Employees.Include(E => E.Department)
            //                where E.Name == "Aly"
            //                select E).FirstOrDefault();
            //Console.WriteLine($"{Employee?.Name ?? "Not Found"} :: {Employee?.Department?.Name ?? "No Department"}");

            #endregion

            #region Lazy Loading 
            //first install its package
            //make the navigational properties virtual and the entities make public 
            //will get the req data and automatically get the related data if you needed it

            //var Employee = (from E in db.fullTimeEmployees
            //                where E.Name == "Aya"
            //                select E).FirstOrDefault();
            //Console.WriteLine($"{Employee?.Name ?? "Not Found"} :: {Employee?.Department?.Name ?? "No Department"}");
            #endregion

            //navigational property (one) ==> Eager Loading 
            //navigational property (Many) ==>Lazy Loading
            // and it depends on your Bussiness



        }
    }
}
