using System.Collections.Generic;
using System.Collections.ObjectModel;
using WPFMVVMPersonList.Models;
namespace WPFMVVMPersonList.MockData
{
    public class MockPersonData
    {
        public static ObservableCollection<PersonModel> GetPersonData()
        {
            ObservableCollection<PersonModel> personList = new ObservableCollection<PersonModel>();
            personList.Add(new PersonModel
            {
                FirstName = "Ashutosh",
                LastName = "Mor",
                Age = "23",
                Hobby = "Football",
                Gender = "Male",
                Address = new Address
                {
                    Country = "UK",
                    PinCode = "RH13 5RW",
                    Street = "2 chequers court",
                    City = "Horsham"
                }
            });
            personList.Add(new PersonModel
            {
                FirstName = "Amol",
                LastName = "Sijaria",
                Age = "23",
                Hobby = "Reading",
                Gender = "Male",
                Address = new Address
                {
                    Country = "UK",
                    PinCode = "RH14 5RW",
                    Street = "12 chequers court",
                    City = "London"
                }
            });
            personList.Add(new PersonModel
            {
                FirstName = "Shruti",
                LastName = "Sijaria",
                Age = "22",
                Hobby = "Cricket",
                Gender = "Female",
                Address = new Address
                {
                    Country = "UK",
                    PinCode = "RH15 5RW",
                    Street = "chequers court",
                    City = "Crawley"
                }
            });
            personList.Add(new PersonModel
            {
                FirstName = "Varsha",
                LastName = "Jain",
                Age = "45",
                Hobby = "Writing",
                Gender = "Female",
                Address = new Address
                {
                    Country = "UK",
                    PinCode = "RH18 5RW",
                    Street = "A Court",
                    City = "London"
                }
            });
            personList.Add(new PersonModel
            {
                FirstName = "Niti",
                LastName = "Jain",
                Age = "34",
                Hobby = "Tennis",
                Gender = "Female",
                Address = new Address
                {
                    Country = "UK",
                    PinCode = "AB13 5RW",
                    Street = "82 chequers",
                    City = "Horsham"
                }
            });
            personList.Add(new PersonModel
            {
                FirstName = "John",
                LastName = "De",
                Age = "34",
                Hobby = "Badminton",
                Gender = "Male",
                Address = new Address
                {
                    Country = "UK",
                    PinCode = "AH13 5TW",
                    Street = "AB street",
                    City = "Horsham"
                }
            });
            personList.Add(new PersonModel
            {
                FirstName = "Peter",
                LastName = "parker",
                Age = "23",
                Hobby = "Painting",
                Gender = "Male",
                Address = new Address
                {
                    Country = "UK",
                    PinCode = "RH13 5RW",
                    Street = "2 chequers court",
                    City = "Horsham"
                }
            });
            return personList;
        }
    }
}
