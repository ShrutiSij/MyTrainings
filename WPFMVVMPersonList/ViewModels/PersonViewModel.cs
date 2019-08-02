using WPFMVVMPersonList.Models;
using System.Collections.ObjectModel;
using System.ComponentModel;
using WPFMVVMPersonList.Commands;

namespace WPFMVVMPersonList.ViewModels
{
    public class PersonViewModel : BaseModel, INotifyPropertyChanged
    {
        private Person _person;
        private ObservableCollection<Person> _friends;
        public ObservableCollection<Person> _enemies;

        public Person NewPerson
        {
            get
            {
                return _person;
            }
            set
            {
                _person = value;
                NotifyPropertyChanged("NewPerson");
            }
        }
        public ADDCommand ADDCommand { get; set; }

        public ObservableCollection<Person> Friends
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

        public ObservableCollection<Person> Enemies
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
            NewPerson = new Person();
            Friends = new ObservableCollection<Person>();
            Enemies = new ObservableCollection<Person>();
            this.ADDCommand = new ADDCommand(this);
        }
        public void GetPersonData()
        {
            Person p = new Person();
            p.FirstName = NewPerson.FirstName;
            p.Age = NewPerson.Age;
            p.Gender = NewPerson.Gender;
            p.Address = NewPerson.Address;
            p.Hobby = NewPerson.Hobby;
            if (NewPerson.IsEnemy)
                Enemies.Add(p);
            else
                Friends.Add(p);
            NewPerson = new Person();
        }
    }
}