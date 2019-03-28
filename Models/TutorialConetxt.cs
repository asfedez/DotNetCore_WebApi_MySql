using Microsoft.EntityFrameworkCore;


namespace MySqlApi.Models
{
    public class TutorialContext : DbContext
    {
        public TutorialContext(DbContextOptions<TutorialContext> options)
            : base(options){}

        public DbSet<person> person {get; set;}
    }
}