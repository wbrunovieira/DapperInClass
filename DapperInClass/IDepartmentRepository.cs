using System;
using System.Collections.Generic;

namespace DapperInClass
{
    public interface IDepartmentRepository
    {
        IEnumerable<Department> GetAllDepartments();
    }
}
