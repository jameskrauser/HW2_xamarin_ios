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
                    Fullname = "apple",
                    
                    myurl = "https://www.apple.com/tw/"
                },
                new Employee
                {
                    Fullname = "HTC",
                     
                    myurl = "http://www.htc.com/tw/"
                },
                new Employee
                {
                    Fullname = "Nike",
                   
                    myurl = "https://www.nike.com/tw/zh_tw/"
                },
                new Employee
                {
                    Fullname = "adidas",
                    
                    myurl = "http://www.adidas.com.tw"
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
