using Microsoft.EntityFrameworkCore;


namespace EF_StudentCurd.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Student> Students{ get; set; }

    }
}
