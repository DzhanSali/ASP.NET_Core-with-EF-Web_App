using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;
using Web2Project.Entities;

namespace Web2Project.ViewModels.Users
{
    public class CreateVM
    {
        Skills skl = new Skills();

        [Required(ErrorMessage = "This Field Is Required!")]
        public string Username { get; set; }

        [Required(ErrorMessage = "This Field Is Required!")]
        public string Password { get; set; }

        [Required(ErrorMessage = "This Field Is Required!")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "This Field Is Required!")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "This Field Is Required!")]
        public string EmailAddress { get; set; }

        [Required(ErrorMessage = "This Field Is Required!")]
        public string PhoneNumber { get; set; }


        public string SkillName { get =>skl.SkillName; set =>this.SkillName = skl.SkillName; }

        public List<Skills> SkillList { get; set; }
    }
}
