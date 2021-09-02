using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemTwo_CompilationError
{
    class DirectReport : Employee
    {
        public Employee ReportsTo { get; set; }
        public string ProjectCode { get; set; }

        public DirectReport(int eID, string eName, int eLevel, DateTime eDoJEmployee, Employee managerEmpObj, string pCode)
        {
            this.EmpID = eID;
            this.EmpName = eName;
            this.EmpLevel = eLevel;
            this.DateOfJoining = eDoJEmployee;
            ReportsTo = managerEmpObj;
            ProjectCode = pCode;
        }
    }
}
