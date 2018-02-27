using System;
using System.Collections.Generic;
using UIKit;

namespace HW2_ios
{
    public partial class ViewController : UIViewController
    {
        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
            var employees = new List<Employee>
            {
                new Employee
                {
                    Fullname = "james",
                    Department = "TP6",
                    Description = "iOS engineer"
                },
                new Employee
                {
                    Fullname = "aaa",
                    Department = "TP6",
                    Description = "iOS engineer"
                },
                new Employee
                {
                    Fullname = "bbb",
                    Department = "TP6",
                    Description = "iOS engineer"
                },
                new Employee
                {
                    Fullname = "ccc",
                    Department = "TP6",
                    Description = "iOS engineer"
                }
            };
            EmployeesTableView.Source = new EmployeesTVS(employees);
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}
