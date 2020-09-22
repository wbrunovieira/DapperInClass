using System;
using System.Collections.Generic;
using System.Data;
using Dapper;

namespace DapperInClass
{
    public class DapperEmployeesRepository : IEmployeeRepository
    {
        private readonly IDbConnection _connection;

        public DapperEmployeesRepository(IDbConnection connection)
        {
            _connection = connection;
        }

        public IEnumerable<Employees> GetAllEmployee()
        {
            return _connection.Query<Employees>("SELECT EmployeeID, FirstName, LastName, Title FROM employees");
        }

        
    }
}
