using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WPFMVVMPersonList.ViewModels;

namespace WPFMVVMPersonList.Commands
{
    public class ADDCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        private PersonViewModel _personViewModel;

        public ADDCommand(PersonViewModel PersonViewModel)
        {
            _personViewModel = PersonViewModel;
        }
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _personViewModel.GetPersonData();
        }
    }
}
