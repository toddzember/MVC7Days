using Proj1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Proj1.DataAccessLayer;
namespace Proj1.Models
{
    public class EmployeeBusinessLayer
    {
        public List<employee> GetEmployees()
        {
            SalesERPDAL salesDal = new SalesERPDAL();
            return salesDal.Employees.ToList();
            //List<employee> employees = new List<employee>();
            //employee emp = new employee();
            //emp.FirstName = "johnson";
            //emp.LastName = " fernandes";
            //emp.Salary = 14000;
            //employees.Add(emp);

            //emp = new employee();
            //emp.FirstName = "michael";
            //emp.LastName = "jackson";
            //emp.Salary = 1600000;
            //employees.Add(emp);

            //emp = new employee();
            //emp.FirstName = "robert";
            //emp.LastName = " pattinson";
            //emp.Salary = 20000;
            //employees.Add(emp);

            //emp = new employee();
            //emp.FirstName = "jack";
            //emp.LastName = " sparrow";
            //emp.Salary = 2000;
            //employees.Add(emp);

            //return employees;
        }
    }
}