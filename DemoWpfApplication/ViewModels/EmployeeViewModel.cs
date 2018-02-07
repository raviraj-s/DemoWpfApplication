using DemoWpfApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoWpfApplication.ViewModels
{
    public class EmployeeViewModel
    {
        private EmployeeDetailsModel objEmployee = new EmployeeDetailsModel();

        public string TxtFirstName
        {
            get { return objEmployee.FirstName; }
            set { objEmployee.FirstName = value; }
        }
        public string TxtLastName
        {
            get { return objEmployee.LastName; }
            set { objEmployee.LastName = value; }
        }
        public Int32 SldAge
        {
            get { return objEmployee.Age; }
            set { objEmployee.Age = value; }
        }

        public bool ChkHasFilledMBOs
        {
            get { return objEmployee.HasFilledMBOs; }
            set { objEmployee.HasFilledMBOs = value; }
        }
        public DateTime DtDateOfJoining
        {
            get { return objEmployee.DateOfJoining; }
            set { objEmployee.DateOfJoining = value; }
        }
        public string StkFilledMBOs
        {
            get
            {
                if(objEmployee.HasFilledMBOs == true)
                {
                    return "Green";
                }
                else
                {
                    return "Red";
                }
            }      
        }
        public string LblElgibleForIncResult
        {
            get
            {
                if(objEmployee.DateOfJoining > DateTime.Now.AddYears(-1))
                {
                    return "Not Eligible";
                }
                else
                {
                    return "Eligible";                    
                }
            }            
        }
    }
}
