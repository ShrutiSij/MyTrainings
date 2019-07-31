using System.Collections.Generic;
using WPFMVVMPersonList.Models;
using WPFMVVMPersonList.MockData;
namespace WPFMVVMPersonList.ViewModels
{
    public class PersonViewModel
    {        
        public List<PersonModel> Persons { get; set; }

        public PersonViewModel()
        {
            SetData();
        }
        private void SetData()
        {
            Persons = MockPersonData.GetPersonData();
        }
    }
}
