using Microsoft.EntityFrameworkCore;
using notepad.Models;

namespace notepad.Data
{
    public class Databasecontext : DbContext
    {
        public Databasecontext(DbContextOptions<Databasecontext> options) : base(options) { }
        public DbSet<Note> Users { get; set; }
    }
}
