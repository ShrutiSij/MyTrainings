using System.ComponentModel;
using WPFMVVMPersonList.Enum;

namespace WPFMVVMPersonList.Models
{
    public class PersonModel 
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Age { get; set; }
        public string Hobby { get; set; }
        public Address Address { get; set; }
        public string Gender { get; set; }
    }
}
