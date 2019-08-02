using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFMVVMPersonList.Models
{
    public class Person : BaseModel
    {
        private string _firstName;
        private string _lastName;
        private string _age;
        private string _hobby;
        private string _address;
        private string _gender;
        private bool _isEnemy;
        public List<string> GenderList { get; set; }
        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                _firstName = value;
                NotifyPropertyChanged("FirstName");
            }
        }

        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
                NotifyPropertyChanged("LastName");
            }
        }

        public string Age
        {
            get
            {
                return _age;
            }
            set
            {
                _age = value;
                NotifyPropertyChanged("Age");
            }
        }

        public string Hobby
        {
            get
            {
                return _hobby;
            }
            set
            {
                _hobby = value;
                NotifyPropertyChanged("Hobby");
            }
        }

        public string Address
        {
            get
            {
                return _address;
            }
            set
            {
                _address = value;
                NotifyPropertyChanged("Address");
            }
        }

        public string Gender
        {
            get
            {
                return _gender;
            }
            set
            {
                _gender = value;
                NotifyPropertyChanged("Gender");
            }
        }

        public bool IsEnemy
        {
            get
            {
                return _isEnemy;
            }
            set
            {
                _isEnemy = value;
                NotifyPropertyChanged("IsEnemy");
            }
        }

        public Person()
        {
            List<string> item = new List<string>();
            item.Add("Female");
            item.Add("Male");
            GenderList = item;
        }
    }
}