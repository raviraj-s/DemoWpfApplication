using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoWpfApplication.Models
{
    public class EmployeeDetailsModel
    {
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public bool HasFilledMBOs { get; set; }
        public DateTime DateOfJoining { get; set; }

        private string _StkFilledMBOs;
        public string StkFilledMBOs { get { return _StkFilledMBOs; } }

        private string  _ElgibleForIncResult;
        public string ElgibleForIncResult { get { return _ElgibleForIncResult; } }

        public void CalculateEligibility()
        {
            if (DateOfJoining > DateTime.Now.AddYears(-1))
            {
                _ElgibleForIncResult = "Not Eligible";
                _StkFilledMBOs = "Red";
            }
            else
            {
                _ElgibleForIncResult = "Eligible";
                _StkFilledMBOs = "Green";
            }
        }
        public bool IsValid()
        {
            return true;
        }
    }    
}
