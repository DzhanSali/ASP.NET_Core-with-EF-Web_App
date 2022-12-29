using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web2Project.Entities
{
    public class Skills
    {
        [Key]
        public int SkillsId { get; set; }
        public string SkillName { get; set; }


        public GeneralUser UserId { get; set; }

    }
}
