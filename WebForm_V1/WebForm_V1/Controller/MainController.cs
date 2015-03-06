using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Practices.Unity;
using WebForm_V1.Interface;
namespace WebForm_V1.Controller
{
    public class MainController
    {
        private IEmployee employee;

       // [InjectionConstructor]
        public MainController(IEmployee Iemp)
        {
            employee = Iemp;
        }
       

        public void printEmployeeDetails()
        {
            employee.getEmp_id();
            employee.getName();
            Console.WriteLine(">>>>print main ");
        
        }
     // kiiii
    }
}