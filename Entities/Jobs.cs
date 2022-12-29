using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using System.ComponentModel.DataAnnotations;

namespace Web2Project.Entities
{
    public class Jobs
    {
        [Key]
        public int JobId { get; set; }
        public string JobName { get; set; }


        public ICollection<GeneralUser> Jobs_Users { get; set; }
    }
}
