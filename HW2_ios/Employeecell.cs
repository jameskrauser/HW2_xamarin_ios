using Foundation;
using System;
using UIKit;

namespace HW2_ios
{
    public partial class Employeecell : UITableViewCell
    {
        partial void UIButton1016_TouchUpInside(UIButton sender)
        {
            //throw new NotImplementedException();
            Console.WriteLine("[button] click  "  );
        }

        public Employeecell (IntPtr handle) : base (handle)
        {
        }

        internal void UpdateCell(Employee employee)
        {
            //throw new NotImplementedException();
            NameLabel.Text = employee.Fullname;
            //mybutton.SetTitle(  employee.myurl , UIControlState.Normal );

        }
    }
}