using System.ComponentModel.DataAnnotations;
using Web2Project.Entities;

namespace Web2Project.ViewModels.Users
{
    public class QuickApplicationVM
    {
        [Required(ErrorMessage = "This Field Is Required!")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "This Field Is Required!")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "This Field Is Required!")]
        public string EmailAddress { get; set; }

        [Required(ErrorMessage = "This Field Is Required!")]
        public string PhoneNumber { get; set; }
        
        [Required(ErrorMessage = "This Field Is Required!")]
        public string SkillName { get; set; }
        
        [Required(ErrorMessage = "This Field Is Required!")]
        public string JobName { get; set; }
        //list with skills. for each skill a new value is stored in the list
    }
}
