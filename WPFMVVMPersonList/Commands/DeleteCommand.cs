using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WPFMVVMPersonList.ViewModels;

namespace WPFMVVMPersonList.Commands
{
    public class DeleteCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        private PersonViewModel _personViewModel;
        private int selectedindex;
        private bool _isenemy;
        public DeleteCommand(PersonViewModel PersonViewModel, bool isEnemy)
        {
            _personViewModel = PersonViewModel;
            _isenemy = isEnemy;
        }
        public bool CanExecute(object parameter)
        {
            selectedindex = parameter != null ? (int)parameter : 0;
            return true;
        }

        public void Execute(object parameter)
        {
             if (_isenemy)
            _personViewModel.DeleteEnemy(selectedindex);
             else
            _personViewModel.DeleteFriend(selectedindex);
        }
    }
}