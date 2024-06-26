using Microsoft.EntityFrameworkCore;
using WebAPIFinalProject.Models;

namespace WebAPIFinalProject.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }


        //Modelos

        public DbSet<Tag> Tags { get; set; }

    }
}
