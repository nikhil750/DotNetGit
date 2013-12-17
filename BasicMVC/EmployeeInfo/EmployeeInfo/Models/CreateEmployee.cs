using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeInfo.Models
{
    public class CreateEmployee
    {
        public EmployeeGit EmployeeInformation { get; set; }
        public List<EmployeeBranch> EmployeeBranch { get; set; }
    }
}