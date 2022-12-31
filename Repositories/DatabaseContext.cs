using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using Web2Project.Entities;

namespace Web2Project.Repositories
{
    public class DatabaseContext : DbContext
    {
        public DbSet <GeneralUser> Users { get; set; }
        public DbSet<Skills> SkillSet { get; set; }
        public DbSet<Jobs> Job { get; set; }

        public DatabaseContext()
        {
            Users = this.Set<GeneralUser>();
            SkillSet = this.Set<Skills>();
            Job = this.Set<Jobs>();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlServer("Server=(LocalDb)\\LibraryOfAlexandria;Database=Web2Project;Trusted_Connection=True");
            }
    }
}
