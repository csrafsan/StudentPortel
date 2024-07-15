using Microsoft.EntityFrameworkCore;
using StudentPortel.Web.Models.Entities;

namespace StudentPortel.Web.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
            
        }
        public DbSet<Student> Students { get; set; }
    }
}
