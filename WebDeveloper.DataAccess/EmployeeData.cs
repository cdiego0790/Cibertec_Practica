﻿using WebDeveloper.Model;

namespace WebDeveloper.DataAccess
{
    public class EmployeeData : BaseDataAccess<Employees>
    {
        public Employees GetEmployeeById(int? id)
        {
            using (var dbContext = new WebContextDb())
            {
                return dbContext.Employees.Find(id);
            }
        }
    }
}
