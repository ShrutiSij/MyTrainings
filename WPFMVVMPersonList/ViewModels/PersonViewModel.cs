using System.Collections.Generic;
using WPFMVVMPersonList.Models;
using WPFMVVMPersonList.MockData;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace WPFMVVMPersonList.ViewModels
{
    public class PersonViewModel : BaseModel, INotifyPropertyChanged
    {
        private PersonModel _person;
        private ObservableCollection<PersonModel> _friends;
        public ObservableCollection<PersonModel> _enemies;

        public PersonModel Person
        {
            get
            {
                return _person;
            }
            set
            {
                _person = value;
                NotifyPropertyChanged("Person");
            }
        }

        public ObservableCollection<PersonModel> Friends
       {
            get
            {
                return _friends;
            }
            set
            {
                _friends = value;
                NotifyPropertyChanged("Friends");
            }
        }

        public ObservableCollection<PersonModel> Enemies
        {
            get
            {
                return _enemies;
            }
            set
            {
                _enemies = value;
                NotifyPropertyChanged("Enemies");
            }
        }
        public PersonViewModel()
        {
            SetData();
        }
        private void SetData()
        {
            Friends = MockPersonData.GetPersonData();
            Enemies = MockPersonData.GetPersonData();
        }
    }
}
