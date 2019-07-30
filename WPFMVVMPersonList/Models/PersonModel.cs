using System.ComponentModel;
using WPFMVVMPersonList.Enum;

namespace WPFMVVMPersonList.Models
{
    public class PersonModel : INotifyPropertyChanged
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Age { get; set; }
        public string Hobby { get; set; }
        public Address Address { get; set; }
        public Gender Gender { get; set; }
        public string ImgSrc { get; set; }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this,
                    new System.ComponentModel.PropertyChangedEventArgs(propertyName));
        }
    }
}
