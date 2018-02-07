using DemoWpfApplication.Commands;
using DemoWpfApplication.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DemoWpfApplication.ViewModels
{
    public class EmployeeViewModel : INotifyPropertyChanged
    {        
        private EmployeeDetailsModel objEmployee = new EmployeeDetailsModel();
        private ButtonCommand objCommand;

        public event PropertyChangedEventHandler PropertyChanged;

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
            get { return objEmployee.StkFilledMBOs; }
        }
        //public string StkFilledMBOs
        //{
        //    get
        //    {
        //        if(objEmployee.HasFilledMBOs == true)
        //        {
        //            return "Green";
        //        }
        //        else
        //        {
        //            return "Red";
        //        }
        //    }      
        //}
        public string LblElgibleForIncResult
        {
            get { return objEmployee.ElgibleForIncResult; }
            //set { objEmployee.ElgibleForIncResult = value; }
        }

        public void CalculateEligibility()
        {

            objEmployee.CalculateEligibility();
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("LblElgibleForIncResult"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("StkFilledMBOs"));

            //if (PropertyChanged != null) // Point 2
            //{
            //    PropertyChanged(this, new PropertyChangedEventArgs("ElgibleForIncResult"));
            //    // Point 3
            //}
        }

        public EmployeeViewModel()
        {
            //objCommand = new ButtonCommand(objEmployee.CalculateEligibility, objEmployee.IsValid);
            objCommand = new ButtonCommand(this);
        }

        public ICommand btnClick
        {
            get
            {
                return objCommand;
            }
        }

        //public string LblElgibleForIncResult
        //{
        //    get
        //    {
        //        if(objEmployee.DateOfJoining > DateTime.Now.AddYears(-1))
        //        {
        //            return "Not Eligible";
        //        }
        //        else
        //        {
        //            return "Eligible";                    
        //        }
        //    }            
        //}
    }
}
