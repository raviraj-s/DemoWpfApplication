using DemoWpfApplication.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DemoWpfApplication.Commands
{
    public class ButtonCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        //private Action WhatToExecute;
        //private Func<bool> WhenToExecute;

        private EmployeeViewModel objEmployee;

        public ButtonCommand(EmployeeViewModel _objEmployee)
        {
            objEmployee = _objEmployee;
            //WhatToExecute = What;
            //WhenToExecute = When;
        }

        public bool CanExecute(object parameter)
        {
            // When to execute
            // Validation logic goes here
            //return WhenToExecute();
            return true;
        }

        public void Execute(object parameter)
        {
            // What to Execute
            // Execution logic goes here
            //WhatToExecute();
            objEmployee.CalculateEligibility();
        }
    }
}
