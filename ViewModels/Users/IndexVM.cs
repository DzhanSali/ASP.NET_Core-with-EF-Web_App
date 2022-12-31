using System.ComponentModel.DataAnnotations;
using Web2Project.Entities;

namespace Web2Project.ViewModels.Users
{
    public class IndexVM
    {
        public List<GeneralUser> Items { get; set; }
    }
}
