using DatingApp.API.Models;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.API.Data
{
    public class DataContext : DbContext // inheritence after DbContext // DataContexzt is class derived from DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options) {} // constructor
            
        public DbSet<Value> Values { get; set; }
    }
}