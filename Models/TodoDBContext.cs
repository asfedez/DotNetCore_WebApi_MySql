using Microsoft.EntityFrameworkCore;


namespace MySqlApi.Models
{
    public class TodoDBContext : DbContext
    {
        public TodoDBContext(DbContextOptions<TodoDBContext> options)
            : base(options){}

        public DbSet<item> item {get; set;}
    }
}