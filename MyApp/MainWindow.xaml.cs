using System.Collections.Generic;
using System.Windows;
namespace MyApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {      
        public string boyImg = "/boy.png";
        public string girlImg = "/girl.png";
        Person[] PersonArray = new Person[5];
        //List<Person> PersonList = new List<Person>();
        public MainWindow()
        {
            SetData();
            InitializeComponent();
            lstBox.ItemsSource = PersonArray;
            //lstBox.ItemsSource = PersonList;
        }

        public void SetData()
        {
            PersonArray[0] = new Person
            {
                FirstName = "Ashutosh",
                LastName = "Mor",
                Age = "23",
                Hobby = "Football",
                ImgSrc = boyImg,
                Address = new Address
                {
                    Country = "UK",
                    PinCode = "RH13 5RW",
                    Street = "2 chequers court",
                    City = "Horsham"
                }
            };

            PersonArray[1] = new Person
            {
                FirstName = "Amol",
                LastName = "Sijaria",
                Age = "23",
                Hobby = "Reading",
                ImgSrc = boyImg,
                Address = new Address
                {
                    Country = "UK",
                    PinCode = "RH14 5RW",
                    Street = "12 chequers court",
                    City = "London"
                }
            };
            PersonArray[2] = new Person
            {
                FirstName = "Shruti",
                LastName = "Sijaria",
                Age = "22",
                Hobby = "Cricket",
                ImgSrc = girlImg,
                Address = new Address
                {
                    Country = "UK",
                    PinCode = "RH15 5RW",
                    Street = "chequers court",
                    City = "Crawley"
                }
            };
            PersonArray[3] = new Person
            {
                FirstName = "Varsha",
                LastName = "Jain",
                Age = "45",
                Hobby = "Writing",
                ImgSrc = girlImg,
                Address = new Address
                {
                    Country = "UK",
                    PinCode = "RH18 5RW",
                    Street = "A Court",
                    City = "London"
                }
            };
            PersonArray[4] = new Person
            {
                FirstName = "Niti",
                LastName = "Jain",
                Age = "34",
                Hobby = "Tennis",
                ImgSrc = girlImg,
                Address = new Address
                {
                    Country = "UK",
                    PinCode = "AB13 5RW",
                    Street = "82 chequers",
                    City = "Horsham"
                }
            };

            //PersonList.Add(new Person
            //{
            //    FirstName = "Ashutosh",
            //    LastName = "Mor",
            //    Age = "23",
            //    Hobby = "Football",
            //    ImgSrc = boyImg,
            //    Address = new Address
            //    {
            //        Country = "UK",
            //        PinCode = "RH13 5RW",
            //        Street = "2 chequers court",
            //        City = "Horsham"
            //    }
            //});
            //PersonList.Add(new Person
            //{
            //    FirstName = "Amol",
            //    LastName = "Sijaria",
            //    Age = "23",
            //    Hobby = "Reading",
            //    ImgSrc = boyImg,
            //    Address = new Address
            //    {
            //        Country = "UK",
            //        PinCode = "RH14 5RW",
            //        Street = "12 chequers court",
            //        City = "London"
            //    }
            //});
            //PersonList.Add(new Person
            //{
            //    FirstName = "Shruti",
            //    LastName = "Sijaria",
            //    Age = "22",
            //    Hobby = "Cricket",
            //    ImgSrc = girlImg,
            //    Address = new Address
            //    {
            //        Country = "UK",
            //        PinCode = "RH15 5RW",
            //        Street = "chequers court",
            //        City = "Crawley"
            //    }
            //});
            //PersonList.Add(new Person
            //{
            //    FirstName = "Varsha",
            //    LastName = "Jain",
            //    Age = "45",
            //    Hobby = "Writing",
            //    ImgSrc = girlImg,
            //    Address = new Address
            //    {
            //        Country = "UK",
            //        PinCode = "RH18 5RW",
            //        Street = "A Court",
            //        City = "London"
            //    }
            //});
            //PersonList.Add(new Person
            //{
            //    FirstName = "Niti",
            //    LastName = "Jain",
            //    Age = "34",
            //    Hobby = "Tennis",
            //    ImgSrc = girlImg,
            //    Address = new Address
            //    {
            //        Country = "UK",
            //        PinCode = "AB13 5RW",
            //        Street = "82 chequers",
            //        City = "Horsham"
            //    }
            //});
            //PersonList.Add(new Person
            //{
            //    FirstName = "John",
            //    LastName = "De",
            //    Age = "34",
            //    Hobby = "Badminton",
            //    ImgSrc = boyImg,
            //    Address = new Address
            //    {
            //        Country = "UK",
            //        PinCode = "AH13 5TW",
            //        Street = "AB street",
            //        City = "Horsham"
            //    }
            //});
            //PersonList.Add(new Person
            //{
            //    FirstName = "Peter",
            //    LastName = "parker",
            //    Age = "23",
            //    Hobby = "Painting",
            //    ImgSrc = boyImg,
            //    Address = new Address
            //    {
            //        Country = "UK",
            //        PinCode = "RH13 5RW",
            //        Street = "2 chequers court",
            //        City = "Horsham"
            //    }
            //});
        }
    }
}
