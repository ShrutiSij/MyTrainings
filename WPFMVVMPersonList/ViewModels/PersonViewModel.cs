using WPFMVVMPersonList.Models;
using System.Collections.ObjectModel;
using System.ComponentModel;
using WPFMVVMPersonList.Commands;
using System.Windows;

namespace WPFMVVMPersonList.ViewModels
{
    public class PersonViewModel : BaseModel, INotifyPropertyChanged
    {
        private Person _person;
        private Person _selectedPerson;
        private ObservableCollection<Person> _friends;
        public ObservableCollection<Person> _enemies;

        public Person SelectedPerson
        {
            get
            {
                return _selectedPerson;
            }
            set
            {
                _selectedPerson = value;
                NotifyPropertyChanged("SelectedPerson");
            }
        }
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
        public AddCommand AddCommand { get; set; }

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
            SelectedPerson = new Person();
            Friends = new ObservableCollection<Person>();
            Enemies = new ObservableCollection<Person>();
            AddCommand = new AddCommand(this);

        }
        public void Add()
        {
            Person p = new Person();
            p.FirstName = NewPerson.FirstName;
            p.Age = NewPerson.Age;
            p.Gender = NewPerson.Gender;
            p.Address = NewPerson.Address;
            p.Hobby = NewPerson.Hobby;
            
            SelectedPerson = p;
            if (NewPerson.IsEnemy)
            {
                p.DeleteCommand = new DeleteCommand(this, true);
                p.ID = Enemies.Count + 1;
                Enemies.Add(p);
                MessageBox.Show("Enemy is added to list.", "Information");
            }
            else
            {
                p.DeleteFriendCommand = new DeleteCommand(this, false);
                p.ID = Friends.Count + 1;
                Friends.Add(p);
                MessageBox.Show("Friend is added to list.", "Information");
            }

            NewPerson = new Person();
        }
        public void DeleteEnemy(int PersonID)
        {
            string name = string.Empty;
            foreach (Person p in Enemies)
            {
                if (p.ID.Equals(PersonID))
                {
                    name = p.FirstName;
                    Enemies.Remove(p);
                    break;
                }
            }
            MessageBox.Show("Enemy is deleted to list.", "Information");
        }

        public void DeleteFriend(int PersonID)
        {
            string name = string.Empty;
            foreach (Person p in Friends)
            {
                if (p.ID.Equals(PersonID))
                {
                    name = p.FirstName;
                    Friends.Remove(p);
                    break;
                }
            }
            MessageBox.Show("Friend is deleted to list.", "Information");
        }
    }
}