using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Proj1.Models;
using Proj1.ViewModels;


namespace Proj1.Controllers
{
 
    public class Customer
    {
  

        public override string ToString()
        {
            return this.CustomerName + "|" + this.Address;
        }
        public string CustomerName { get; set; }
        public string Address { get; set; }
    }
    public class EmployeeController : Controller
    {

        public ActionResult SaveEmployee(employee e, string BtnSubmit)
        {
            switch (BtnSubmit)
            {
                case "Save Employee":
                    return Content(e.FirstName + "|" + e.LastName + "|" + e.Salary);
                case "Cancel":
                    return RedirectToAction("Index");
            }
            return new EmptyResult();
        }

        public ActionResult Index()
        {
            EmployeeListViewModel employeeListViewModel = new EmployeeListViewModel();

            EmployeeBusinessLayer empBal = new EmployeeBusinessLayer();
            List<employee> employees = empBal.GetEmployees();

            List<EmployeeViewModel> empViewModels = new List<EmployeeViewModel>();

            foreach (employee emp in employees)
            {
                EmployeeViewModel empViewModel = new EmployeeViewModel();
                empViewModel.EmployeeName = emp.FirstName + " " + emp.LastName;
                empViewModel.Salary = emp.Salary.ToString("C");
                if (emp.Salary > 15000)
                {
                    empViewModel.SalaryColor = "yellow";
                }
                else
                {
                    empViewModel.SalaryColor = "green";
                }
                empViewModels.Add(empViewModel);
            }
            employeeListViewModel.Employees = empViewModels;
            return View("Index", employeeListViewModel);
        }

        public ActionResult AddNew()
        {
            return View("CreateEmployee");
        }

    
        //[NonAction]
        //public string SimpleMethod()
        //{
        //    return "Hi, I am not action method";
        //}

        //public Customer GetCustomer()
        //{
        //    Customer c = new Customer();
        //    c.CustomerName = "Customer 1";
        //    c.Address = "Address1";
        //    return c;
        //}
    }
}