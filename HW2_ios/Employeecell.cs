using Foundation;
using System;
using UIKit;

namespace HW2_ios
{
    public partial class Employeecell : UITableViewCell
    {
        public Employeecell (IntPtr handle) : base (handle)
        {
        }

        internal void UpdateCell(Employee employee)
        {
            //throw new NotImplementedException();
            NameLabel.Text = employee.Fullname;
            DepartmentLabel.Text = employee.Department;
            DescriptionLabel.Text = employee.Description;
        }
    }
}