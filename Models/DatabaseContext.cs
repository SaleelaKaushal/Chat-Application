using Microsoft.EntityFrameworkCore;

namespace AppChat.Models
{
    public class DatabaseContext : DbContext
    {

        public DatabaseContext (DbContextOptions<DatabaseContext> options) : base (options)
        { 
        
           
        
        }

        public DbSet<Message> Message { get; set; }
       

    }
}
