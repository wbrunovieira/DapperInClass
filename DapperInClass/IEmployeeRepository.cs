using System;
using System.Collections.Generic;

namespace DapperInClass
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employees> GetAllEmployee();
    }
}
