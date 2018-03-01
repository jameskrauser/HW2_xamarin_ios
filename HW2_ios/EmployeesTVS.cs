using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using Foundation;
using UIKit;

namespace HW2_ios
{
    internal class EmployeesTVS : UITableViewSource
    {
        private List<Employee> employees;

        public EmployeesTVS(List<Employee> employees)
        {
            this.employees = employees;
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            Contract.Ensures(Contract.Result<UITableViewCell>() != null);
            // throw new NotImplementedException();
            var cell = (Employeecell) tableView.DequeueReusableCell("cell_id", indexPath);
            var employee = employees[indexPath.Row];
            cell.UpdateCell( employee );
            return cell;

        }

        public override nint RowsInSection(UITableView tableview, nint section)
        {
            //throw new NotImplementedException();
            return employees.Count;
        }
    }
}