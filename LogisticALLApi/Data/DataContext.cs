using LogisticALLApi.Models;
using Microsoft.EntityFrameworkCore;

namespace LogisticALLApi.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<Value> Values { get; set; }
    }
}