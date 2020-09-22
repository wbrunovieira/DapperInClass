using System;
using System.Data;
using System.IO;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;

namespace DapperInClass
{
    class Program
    {
        static void Main(string[] args)
        {
            var config = new ConfigurationBuilder()
                 .SetBasePath(Directory.GetCurrentDirectory())
                 .AddJsonFile("appsettings.json")
                 .Build();

            string connString = config.GetConnectionString("DefaultConnection");

            IDbConnection conn = new MySqlConnection(connString);

            var repoDepart = new DapperDepartmentRepository(conn);

            var departments = repoDepart.GetAllDepartments();

            foreach(var depart in departments)
            {
                Console.WriteLine($"{depart.DepartmentID} {depart.Name}");
            }

            var repoProd = new DapperProductsRepository(conn);
            var products = repoProd.GetAllProducts();

            foreach(var prod in products)
            {
                Console.WriteLine($"{prod.ProductID} {prod.Name} {prod.Price}");
            }

            var repoEmplo = new DapperEmployeesRepository(conn);
            var employees = repoEmplo.GetAllEmployee();

            foreach (var empl in employees)
            {
                Console.WriteLine($"{empl.EmployeeId} {empl.FirstName} {empl.LastName} {empl.Title}");
            }
        }

    }
}
